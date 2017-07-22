'vb script to automate the creation of volume snapshots on the D1aaS Production Platform
'uses AWS CLI commands

'DECLARATIONS
Option Explicit

DIM ec2VolumeID(28), ec2SnapID(28),ec2VolumeName(28)
DIM x, y, i, m, monitoringVols, monitoringSnaps, monitoringTag
DIM strLine, strLine2, strLine3, strLine4
DIM objFSO, objFile, objFileLog, fso, f1, f2
DIM strLastModified
Dim awsShell
DIM awsGetVols, awsCreateSnap, awsTagSnap 'AWS CLI commands
DIM Purgein7Days
DIM PathMonitor , PathSession, PathHome
Set fso = WScript.CreateObject("Scripting.Filesystemobject")
Set awsShell = WScript.CreateObject ("WScript.Shell")
Set objFSO = CreateObject("Scripting.FileSystemObject")

'''''''''''''''''
'Change these settings 
'to match your folder structure
'''''''''''''''''
PathMonitor = "D:\BACKUP\Logs\ServerbackupLogs\monitor\"
PathSession = "D:\BACKUP\Logs\ServerbackupLogs\Logs\"
PathHome = "D:\BACKUP\"

' END DECLARATIONS

'''''''''''''''''
'Housekeeping
'''''''''''''''''
	' Delete the monitoring files
	If objFSO.FileExists(PathMonitor + "completed.txt") Then
		objFSO.DeleteFile(PathMonitor + "completed.txt") 
	Else
		If objFSO.FileExists(PathMonitor + "failed.txt") Then
		objFSO.DeleteFile(PathMonitor + "failed.txt") 
		End If
	End If
	' Clear snapshotID result file
	Set objFile = objFSO.OpenTextFile(".\ec2CreateSnapResult.txt",2)
		objFile.Write ""
		objFile.Close
	' Open the session log file for appending
	Set objFileLog = objFSO.OpenTextFile(PathSession + "session.log",8) 
	' Zero out counters
	x = 0
	m = 0
	y = 0 
'''''''''''''''''
'End Housekeeping
'''''''''''''''''
			objFileLog.write "************************" & VbCrLf ' send2LOG
			objFileLog.write Date & " - Backup Session Started" & VbCrLf ' send2LOG
			objFileLog.write "************************" & VbCrLf ' send2LOG
	'First need to get the list of current ec2 
	'volumes in the production environment and save it to a file
	'This is done by filtering on the already defined Tags in 
	'EC2 - Environment with the value of Production
	'This command will return a txt list of the volumeID and the
	'volume name derived from the ec2 tag - Name

	awsGetVols ="aws ec2 describe-volumes --filters " & chr(34) & "Name=tag:Environment,Values=Production"& chr(34) &"  --query " & chr(34) & "Volumes[*].{ID:VolumeId,Tag:Tags[?Key=='Name']}"& chr(34) &" >" & PathHome & "ec2_VolumeList.txt"
	awsShell.run "cmd.exe /C " & awsGetVols
' wscript.Quit 'Debug


'''''''''''''''''
'get vol id and vol name into two arrays
'''''''''''''''''
			objFileLog.Write (Date) & " - Starting to get volIDs " & VbCrLf  ' send2LOG
	Set objFile = objFSO.OpenTextFile(PathHome + "ec2_VolumeList.txt")
	Do Until objFile.AtEndOfStream
		strLine = objFile.ReadLine
			If (InStr(strLine,"vol") = 1) Then 'Make sure that the text list is in the correct order i.e. volumeID is first.
				ec2VolumeID(x) = (strLine) ' populate VolumeID into the array
				strLine2 = objFile.ReadLine ' OK got the first line into the first array, now read in the second line
				strLine3 =(Replace(strLine2," ","_",9)) ' Remove spaces from volume name
				ec2VolumeName(x) = (strLine3) ' grab the Volume name from the string and populate the array
			End If
		x=x+1
		monitoringVols = x ' get the total number of volumes to compare with # of snapshots and # of tags
	Loop
			objFileLog.Write (Date) & " - We found: " & x & " Production Volumes." & VbCrLf  ' send2LOG
		objFile.Close
'wscript.Quit 'Debug


	'create snapshots with the Volume Name as the Description
			objFileLog.write Date & " - Creating Snapshots" & VbCrLf ' send2LOG
			objFileLog.write "************************" & VbCrLf ' send2LOG
			
	If ec2VolumeID(x) ="" then x=x-1 'look out for empty lines
			objFileLog.Write (Date) & " - Starting Snapshots " & VbCrLf  ' send2LOG
	For y =  x to 0 step -1
		awsCreateSnap = "aws ec2 create-snapshot --description " & ec2VolumeName(y) & " --volume-id " & ec2VolumeID(y) & " --output text --query SnapshotId >> ec2CreateSnapResult.txt"
		awsShell.run "cmd.exe /C " & awsCreateSnap 
		WScript.Sleep 3000 'wait for a few seconds for the command to run and for the output to be appended to the file before snapshot the next volume
		monitoringSnaps = monitoringSnaps + 1
	Next
			objFileLog.Write (Date) &  " - We created: " & x+1 & " snapshots." & VbCrLf  ' send2LOG
'wscript.Quit 'Debug


	'Now tag the new snapshots
			objFileLog.write Date & " - Tagging Snapshots" & VbCrLf ' send2LOG
			objFileLog.write "************************" & VbCrLf ' send2LOG
			
	Purgein7Days = DateAdd("d", 7, date) 'what is the date in 7 days
			objFileLog.Write (Date) & " - Starting to read in snapshotIDs created in the prior step. " & VbCrLf  ' send2LOG
	Set objFile = objFSO.OpenTextFile(PathHome + "ec2CreateSnapResult.txt") ' read in snapshotIDs that were created in the above step.
	Do Until objFile.AtEndOfStream
		strLine4 = objFile.ReadLine
		ec2SnapID(m) = (strLine4) ' populate SnaphotID into the array
		m=m+1
	 Loop
	objFile.Close
			objFileLog.Write (Date) & " - Finished getting SnapahotIDs. There was: " & m & VbCrLf  ' send2LOG
	'''''''''''''''''
	'Start tagging the new snapshots
	'we are tagging the snapshots with today's date + 7 calendar days
	'This will allow us to query on today MINUS 7 days to preform a purge
	'''''''''''''''''
	If ec2SnapID(m) = "" then m=m-1
			objFileLog.Write (Date) & " - Starting to tag the snapshots." & VbCrLf  ' send2LOG
	For i = m to 0 step -1
		awsTagSnap = "aws ec2 create-tags --resource " & ec2SnapID(i) & " --tags Key=PurgeDate,Value=" & Purgein7Days
		awsShell.run "cmd.exe /C " & awsTagSnap
	 	monitoringTag = monitoringTag + 1
	Next
			objFileLog.Write (Date) & " - We tagged: " & m+1 & " Production Volumes" & VbCrLf  ' send2LOG
			
			
'''''''''''''''''
'End of script Housekeeping
'''''''''''''''''
			objFileLog.write Date & " - Backup Session Closed" & VbCrLf ' send2LOG
			objFileLog.write "**************" & VbCrLf ' send2LOG
			objFileLog.Close 'close the log file
			
			
'''''''''''''''''
' Monitoring checksum
' If the number of volumes found equal the 
'number of snapshots taken and equals the number 
'of snapshots tagged, write a file out so that BB can pick it up. 
'''''''''''''''''
	if ((monitoringVols)* 2)  = monitoringSnaps + monitoringTag then 
		Set f1 = fso.CreateTextFile(PathMonitor + "completed.txt", 2)
			f1.write date & " - " & monitoringVols &" Volumes found and "& monitoringSnaps & "Snapshots taken and "& monitoringTag & " tags processed."
			f1.Close
	Else
		Set f2 = fso.CreateTextFile(PathMonitor + "failed.txt", 2)
			f2.write date & " - " & monitoringVols &" Volumes found with "& monitoringSnaps & " Snapshots taken and "& monitoringTag & " tags processed."
			f2.Close
	End If
