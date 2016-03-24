Imports System.IO

Public Class ShortcutCreator

    Private Sub AppPathBrowse_Click(sender As Object, e As EventArgs) Handles AppPathBrowse.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            AppPathTextBox.Text = dialog.FileName
        End If
    End Sub

    Private Sub ImgPathBrowse_Click(sender As Object, e As EventArgs) Handles ImgPathBrowse.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            ImgPathTextBox.Text = dialog.FileName
        End If
    End Sub

    Private Sub BackImageBrowse_Click(sender As Object, e As EventArgs) Handles BackImageBrowse.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            BackimageTextBox.Text = dialog.FileName
        End If

    End Sub

    Private Sub BackgroundCheck_CheckedChanged(sender As Object, e As EventArgs) Handles BackgroundCheck.CheckedChanged
        BackimageTextBox.Enabled = BackgroundCheck.Checked
        BackImageBrowse.Enabled = BackgroundCheck.Checked

        If BackgroundCheck.Checked = False Then
            BackimageTextBox.Text = ""
        End If
    End Sub

    Private Sub MonitorCheck_CheckedChanged(sender As Object, e As EventArgs) Handles MonitorCheck.CheckedChanged
        ExitAbility.Enabled = MonitorCheck.Checked
        If MonitorCheck.Checked = False Then
            ExitAbility.Checked = MonitorCheck.Checked
        End If
    End Sub

    Private Sub Finished_Click(sender As Object, e As EventArgs) Handles Finished.Click
        If AppPathTextBox.Text = "" Or ImgPathTextBox.Text = "" Then
            MsgBox("Please fill in both the application path and the image path")
        Else
            If BackgroundCheck.Checked = True And BackimageTextBox.Text = "" Then
                MsgBox("Please fill in the background image path")
            Else
                CreateStartTask()
                CreateStopTask()
                BuildIniFile()
                Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    ' My subs (yummy)

    Private Function GetProcessName() As String
        Dim processName As String
        processName = AppPathTextBox.Text.Substring(AppPathTextBox.Text.LastIndexOf("\") + 1)
        processName = processName.Substring(0, processName.LastIndexOf("."))
        Return processName
    End Function

    Private Function GetProcessNameWExt() As String
        Dim processName As String
        processName = AppPathTextBox.Text.Substring(AppPathTextBox.Text.LastIndexOf("\") + 1)
        Return processName
    End Function

    Private Function GetIconName() As String
        Dim iconName As String
        iconName = ImgPathTextBox.Text.Substring(ImgPathTextBox.Text.LastIndexOf("\") + 1)
        Return iconName
    End Function

    Private Function GetBackgroundName() As String
        Dim backgroundName As String
        backgroundName = BackimageTextBox.Text.Substring(BackimageTextBox.Text.LastIndexOf("\") + 1)
        Return backgroundName
    End Function

    Private Sub CreateStartTask()
        Dim process As New Process()
        Dim taskString As String
        process.StartInfo.FileName = "C:\Windows\System32\schtasks.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        taskString = "/Create /RL HIGHEST /TN \Rainmeter\Start_" + GetProcessName() + " /TR " + """" + AppPathTextBox.Text + """" + " /SC ONCE /ST 00:01 /F"
        process.StartInfo.Arguments = taskString

        Console.WriteLine(taskString)
        process.Start()

        Dim reader As StreamReader = process.StandardOutput
        Dim errorStream As StreamReader = process.StandardError
        Dim output As String = reader.ReadToEnd()
        Dim errorStr As String = errorStream.ReadToEnd()
        Console.WriteLine("Output is " + output)
        Console.WriteLine("Error is " + errorStr)

        process.WaitForExit()
        process.Close()
    End Sub

    Private Sub CreateStopTask()
        Dim process As New Process()
        Dim taskString As String
        process.StartInfo.FileName = "C:\Windows\System32\schtasks.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        taskString = "/Create /RL HIGHEST /TN \Rainmeter\Stop_" + GetProcessName() + " /TR ""C:\Windows\System32\taskkill.exe /F /T /IM " + GetProcessNameWExt() + """ /SC ONCE /ST 00:01 /F"
        process.StartInfo.Arguments = taskString

        Console.WriteLine(taskString)
        process.Start()

        Dim reader As StreamReader = process.StandardOutput
        Dim errorStream As StreamReader = process.StandardError
        Dim output As String = reader.ReadToEnd()
        Dim errorStr As String = errorStream.ReadToEnd()
        Console.WriteLine("Output is " + output)
        Console.WriteLine("Error is " + errorStr)

        process.WaitForExit()
        process.Close()
    End Sub

    Private Sub BuildIniFile()
        Dim baseFileReader As String
        Dim finalFileText As String
        Dim RainmeterLocation As String
        Dim envRainmeter As String
        envRainmeter = Environment.GetEnvironmentVariable("RAINMETER_HOME")
        If envRainmeter Is Nothing Then
            RainmeterLocation = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Rainmeter"
        Else
            RainmeterLocation = envRainmeter
        End If

        Console.WriteLine("Output is " + RainmeterLocation)

        If MonitorCheck.Checked = True Then
            baseFileReader = My.Resources.baseMonitor
        Else
            baseFileReader = My.Resources.baseNoMonitor
        End If

        finalFileText = baseFileReader

        finalFileText = finalFileText.Replace("@ContextMenuAddOn@", "")

        If ExitAbility.Checked = True Then
            Dim exitFileReader As String
            exitFileReader = My.Resources.KillTask
            finalFileText = finalFileText.Replace("@KillTask@", exitFileReader)
        Else
            finalFileText = finalFileText.Replace("@KillTask@", "")
        End If

        If BackgroundCheck.Checked = True Then
            Dim backgroundFileReader As String
            backgroundFileReader = My.Resources.ShowBackground
            finalFileText = finalFileText.Replace("@ShowBackground@", backgroundFileReader)

            Dim backgroundTemplateReader As String
            backgroundTemplateReader = My.Resources.background1
            backgroundTemplateReader = backgroundTemplateReader.Replace("@Background@", GetBackgroundName())
            Dim newBackgroundFile As System.IO.StreamWriter
            My.Computer.FileSystem.CreateDirectory(RainmeterLocation + "\Skins\RSC\" + GetProcessName() + "\background")
            newBackgroundFile = My.Computer.FileSystem.OpenTextFileWriter(RainmeterLocation + "\Skins\RSC\" + GetProcessName() + "\background\background.ini", False)
            newBackgroundFile.WriteLine(backgroundTemplateReader)
            newBackgroundFile.Close()

            My.Computer.FileSystem.CopyFile(
                BackimageTextBox.Text,
                RainmeterLocation + "\Skins\RSC\" + GetProcessName() + "\background\" + GetBackgroundName(),
                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        Else
            finalFileText = finalFileText.Replace("@ShowBackground@", "")
        End If

        finalFileText = finalFileText.Replace("@ApplicationPath@", AppPathTextBox.Text.Substring(0, AppPathTextBox.Text.LastIndexOf("\")))
        finalFileText = finalFileText.Replace("@SkinPath@", "RSC\" + GetProcessName())
        finalFileText = finalFileText.Replace("@StopTaskName@", "\Rainmeter\Stop_" + GetProcessName())
        finalFileText = finalFileText.Replace("@StartTaskName@", "\Rainmeter\Start_" + GetProcessName())
        finalFileText = finalFileText.Replace("@ProcessName@", GetProcessName())
        finalFileText = finalFileText.Replace("@ProcessNameWExt@", GetProcessNameWExt())
        finalFileText = finalFileText.Replace("@Icon@", GetIconName())

        Dim newIniFile As System.IO.StreamWriter
        My.Computer.FileSystem.CreateDirectory(RainmeterLocation + "\Skins\RSC\" + GetProcessName())
        newIniFile = My.Computer.FileSystem.OpenTextFileWriter(RainmeterLocation + "\Skins\RSC\" + GetProcessName() + "\" + GetProcessName() + ".ini", False)
        newIniFile.WriteLine(finalFileText)
        newIniFile.Close()

        My.Computer.FileSystem.CopyFile(
            ImgPathTextBox.Text,
            RainmeterLocation + "\Skins\RSC\" + GetProcessName() + "\" + GetIconName(),
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

    End Sub

    Private Sub ShortcutCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each argument As String In My.Application.CommandLineArgs
            AppPathTextBox.Text = argument
        Next

    End Sub
End Class
