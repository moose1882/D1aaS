Public Class Form_Main

    Private Sub Button_RunCode_Click(sender As Object, e As EventArgs) Handles Button_RunCode.Click
        Dim fso, winShell, zipFolder, logFolder, file
        Dim WshNetwork, objFSO, objStartFolder, objFolder, SubF, colFiles, intAge
        Dim zipFileName,
        fso = CreateObject("Scripting.FileSystemObject")
        winShell = CreateObject("shell.application")
        WshNetwork = WScript.CreateObject("WScript.Network")
        objFSO = CreateObject("Scripting.FileSystemObject")
        objStartFolder = "D:\Logs\"
        objFolder = objFSO.GetFolder(objStartFolder)
        SubF = objFolder.SubFolders
        colFiles = objFolder.Files
        intAge = 7
        For Each objFolder In SubF
		zipFileName = "D:\BACKUP\archiveStaging\" & WshNetwork.ComputerName & "-" &  DatePart("YYYY",Date) &  DatePart("m",Date) & DatePart("d",Date)& "-" & objFolder.Name & "LogArchive.zip"
            file = fso.CreateTextFile(zipFileName, True)
		file.write("PK" & chr(5) & chr(6) & string(18,chr(0)))
            file.close()
            winShell.NameSpace(zipFileName).CopyHere winShell.NameSpace(objFolder.Path & "\")
            wscript.sleep 60000
            MoveAFile(zipFileName)
        Next
        Dim objFSO1, objFolder1,
        objFSO1 = CreateObject("Scripting.FileSystemObject")
        objFolder1 = objFSO1.GetFolder("D:\Logs\WindowsEventLogs\")
        colFiles1 = objFolder1.Files
        For Each objFile In colFiles1
            If Left(objFile.Name, 7) = "Archive" Then
                objFSO1.DeleteFile "D:\Logs\WindowsEventLogs\" & objFile.Name
            End If
        Next

Sub MoveAFile(Drivespec)
        Dim fso
        fso = CreateObject("Scripting.FileSystemObject")
        wscript.sleep 60000
        fso.MoveFile(Drivespec, "\\prod-ad-01\Software\AWSuploads\eventlogArchives\")
    End Sub
    End Sub
End Class
