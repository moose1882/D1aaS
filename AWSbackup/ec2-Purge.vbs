'vb script to automate the creation of volume snapshots on the D1aaS Production Platform
'uses AWS CLI commands

'DECLARATIONS
Option Explicit
DIM ec2SnapID, strLine, x, ec2SnapDate, ec2SnapDateTemp, ec2SnapDate2,ec2SnapDate3, todayDate, temp
DIM objFSO, objFile, awsShell, objFileLog
DIM awsGetPurgeSnapID, awsPurgeSnaps
DIM PathMonitor , PathSession, PathHome, OlderThenSeven
Set awsShell = WScript.CreateObject ("WScript.Shell")
Set objFSO = CreateObject("Scripting.FileSystemObject")

'''''''''''''''''
'Change these settings 
'to match your folder structure
'''''''''''''''''
PathMonitor = "C:\c_repo\D1aaS\AWSbackup\monitor"
PathSession = "C:\c_repo\D1aaS\AWSbackup\Logs\"
PathHome = "C:\c_repo\D1aaS\AWSbackup\"
x = 0
' END DECLARATIONS

'''''''''''''''''
'Housekeeping
'''''''''''''''''
' Clear snapshotIDs to purge result file
	Set objFile = objFSO.OpenTextFile(PathHome + "ec2_SnapPurgeList.txt", 2)
		objFile.Write ""
	objFile.Close
	
' Delete the monitoring files
If objFSO.FileExists(PathMonitor + "completed.txt") Then
	objFSO.DeleteFile(PathMonitor + "completed.txt") 
Else
If objFSO.FileExists(PathMonitor + "failed.txt") Then
	objFSO.DeleteFile(PathMonitor + "failed.txt") 
	end If
End If

' Open the session log file for appending
	Set objFileLog = objFSO.OpenTextFile(PathSession + "session.log",8) 
	'''''''''''''''''
'End Housekeeping
'''''''''''''''''

			objFileLog.Write (Date) & " - Starting the daily purge of old snapshots " & VbCrLf  ' send2LOG
			objFileLog.write "************************" & VbCrLf ' send2LOG
'Get the snapshots owned by us that have a tag called PurgeDate and a value equal to today's date -7 calendar days
			objFileLog.Write (Date) & " - Getting the snapshots owned by us " & VbCrLf  ' send2LOG
' aws ec2 describe-snapshots --owner 022543930592 --query Snapshots[*].{ID:SnapshotId,Time:StartTime}
awsGetPurgeSnapID = "aws ec2 describe-snapshots --owner 022543930592 --query Snapshots[*].{ID:SnapshotId,Time:StartTime} >" & PathHome + "ec2_SnapPurgeList.txt" 
	awsShell.run "cmd.exe /C" & awsGetPurgeSnapID
WScript.Sleep 2000 ' wait 2 secs until write to file is completed otherwise the following read from file will fail.
			objFileLog.Write (Date) & " - Got the list. " & VbCrLf  ' send2LOG

			
			
Set objFile = objFSO.OpenTextFile(PathHome + "ec2_SnapPurgeList.txt")
	if objFSO.GetFile(PathHome + "ec2_SnapPurgeList.txt").size = 0 then   'Check if there is anything contained in the above output file, if not terminate the script.
			objFileLog.Write (Date) & " - No snapshots found with a date of " & Date & ". Terminating the script as there is nothing to process." & VbCrLf  ' send2LOG	
			objFileLog.write Date & " - Purge Session Closed" & VbCrLf ' send2LOG
			objFileLog.write "************************" & VbCrLf ' send2LOG
			objFileLog.Close 'close the log file			
			wscript.Quit
	End If
			objFileLog.Write (Date) & " - We have found some snapshots to delete." & VbCrLf  ' send2LOG
	
	todayDate = replace(Date,"/", "-")
	'wscript.echo todayDate
Do Until objFile.AtEndOfStream
strLine = objFile.ReadLine
		ec2SnapDateTemp = Split(strLine,vbTab) ' populate VolumeID into the array
		ec2SnapDate2 = Split(ec2SnapDateTemp(1),"T")
		'wscript.echo ec2SnapDate2(0)		
		ec2SnapDate3= (Replace(ec2SnapDate2(0),"-","/"))
		'wscript.echo ec2SnapDate3		
		ec2SnapDate = StrReverse(ec2SnapDate3)
		wscript.echo "final date from readline " & ec2SnapDate
If ec2SnapDate = Date then
wscript.echo	"IT works " & ec2SnapDate
end if
		'x=x+1
	Loop


wscript.quit

			objFileLog.Write (Date) & " - snapshots to be deleted have been added to the array " & VbCrLf  ' send2LOG
for x = 0 to uBound(ec2SnapID) ' Set loop to the upper limit of the above defined array
			objFileLog.Write (Date) & " - Starting the delete process now.." & VbCrLf  ' send2LOG
	awsPurgeSnaps = "aws ec2 delete-snapshot --snapshot-id " & ec2SnapID(x) ' Loop through each snapshotID identified above and added to the array and delete them
	awsShell.run "cmd.exe /C" & awsPurgeSnaps
Next
			objFileLog.Write (Date) & " - Finished deleting old snapshots. " & x & " snapshots were deleted. " & VbCrLf  ' send2LOG

			
objFileLog.write Date & " - Purge Session Closed" & VbCrLf ' send2LOG
objFileLog.write "************************" & VbCrLf ' send2LOG
objFileLog.Close 'close the log file