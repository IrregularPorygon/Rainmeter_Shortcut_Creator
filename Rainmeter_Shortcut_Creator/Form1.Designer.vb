<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShortcutCreator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShortcutCreator))
        Me.PathLabel = New System.Windows.Forms.Label()
        Me.AppPathTextBox = New System.Windows.Forms.TextBox()
        Me.AppPathBrowse = New System.Windows.Forms.Button()
        Me.GenDescLabel = New System.Windows.Forms.Label()
        Me.ImgPathLabel = New System.Windows.Forms.Label()
        Me.ImgPathTextBox = New System.Windows.Forms.TextBox()
        Me.ImgPathBrowse = New System.Windows.Forms.Button()
        Me.BackgroundCheck = New System.Windows.Forms.CheckBox()
        Me.BackImageLabel = New System.Windows.Forms.Label()
        Me.BackimageTextBox = New System.Windows.Forms.TextBox()
        Me.BackImageBrowse = New System.Windows.Forms.Button()
        Me.MonitorCheck = New System.Windows.Forms.CheckBox()
        Me.ExitAbility = New System.Windows.Forms.CheckBox()
        Me.Finished = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PathLabel
        '
        Me.PathLabel.AutoSize = True
        Me.PathLabel.Location = New System.Drawing.Point(12, 36)
        Me.PathLabel.Name = "PathLabel"
        Me.PathLabel.Size = New System.Drawing.Size(87, 13)
        Me.PathLabel.TabIndex = 0
        Me.PathLabel.Text = "Application Path:"
        '
        'AppPathTextBox
        '
        Me.AppPathTextBox.Location = New System.Drawing.Point(105, 33)
        Me.AppPathTextBox.Name = "AppPathTextBox"
        Me.AppPathTextBox.Size = New System.Drawing.Size(206, 20)
        Me.AppPathTextBox.TabIndex = 1
        '
        'AppPathBrowse
        '
        Me.AppPathBrowse.Location = New System.Drawing.Point(317, 31)
        Me.AppPathBrowse.Name = "AppPathBrowse"
        Me.AppPathBrowse.Size = New System.Drawing.Size(75, 23)
        Me.AppPathBrowse.TabIndex = 2
        Me.AppPathBrowse.Text = "Browse"
        Me.AppPathBrowse.UseVisualStyleBackColor = True
        '
        'GenDescLabel
        '
        Me.GenDescLabel.AutoSize = True
        Me.GenDescLabel.Location = New System.Drawing.Point(5, 9)
        Me.GenDescLabel.Name = "GenDescLabel"
        Me.GenDescLabel.Size = New System.Drawing.Size(306, 13)
        Me.GenDescLabel.TabIndex = 3
        Me.GenDescLabel.Text = "Create a Rainmeter Launcher Skin with the following properties:"
        '
        'ImgPathLabel
        '
        Me.ImgPathLabel.AutoSize = True
        Me.ImgPathLabel.Location = New System.Drawing.Point(12, 65)
        Me.ImgPathLabel.Name = "ImgPathLabel"
        Me.ImgPathLabel.Size = New System.Drawing.Size(64, 13)
        Me.ImgPathLabel.TabIndex = 4
        Me.ImgPathLabel.Text = "Image Path:"
        '
        'ImgPathTextBox
        '
        Me.ImgPathTextBox.Location = New System.Drawing.Point(82, 62)
        Me.ImgPathTextBox.Name = "ImgPathTextBox"
        Me.ImgPathTextBox.Size = New System.Drawing.Size(229, 20)
        Me.ImgPathTextBox.TabIndex = 5
        '
        'ImgPathBrowse
        '
        Me.ImgPathBrowse.Location = New System.Drawing.Point(317, 60)
        Me.ImgPathBrowse.Name = "ImgPathBrowse"
        Me.ImgPathBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ImgPathBrowse.TabIndex = 6
        Me.ImgPathBrowse.Text = "Browse"
        Me.ImgPathBrowse.UseVisualStyleBackColor = True
        '
        'BackgroundCheck
        '
        Me.BackgroundCheck.AutoSize = True
        Me.BackgroundCheck.Location = New System.Drawing.Point(8, 93)
        Me.BackgroundCheck.Name = "BackgroundCheck"
        Me.BackgroundCheck.Size = New System.Drawing.Size(202, 17)
        Me.BackgroundCheck.TabIndex = 7
        Me.BackgroundCheck.Text = "Display Background Image On Hover"
        Me.BackgroundCheck.UseVisualStyleBackColor = True
        '
        'BackImageLabel
        '
        Me.BackImageLabel.AutoSize = True
        Me.BackImageLabel.Location = New System.Drawing.Point(12, 119)
        Me.BackImageLabel.Name = "BackImageLabel"
        Me.BackImageLabel.Size = New System.Drawing.Size(96, 13)
        Me.BackImageLabel.TabIndex = 8
        Me.BackImageLabel.Text = "Background Path: "
        '
        'BackimageTextBox
        '
        Me.BackimageTextBox.Enabled = False
        Me.BackimageTextBox.Location = New System.Drawing.Point(105, 116)
        Me.BackimageTextBox.Name = "BackimageTextBox"
        Me.BackimageTextBox.Size = New System.Drawing.Size(206, 20)
        Me.BackimageTextBox.TabIndex = 9
        '
        'BackImageBrowse
        '
        Me.BackImageBrowse.Enabled = False
        Me.BackImageBrowse.Location = New System.Drawing.Point(317, 114)
        Me.BackImageBrowse.Name = "BackImageBrowse"
        Me.BackImageBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BackImageBrowse.TabIndex = 10
        Me.BackImageBrowse.Text = "Browse"
        Me.BackImageBrowse.UseVisualStyleBackColor = True
        '
        'MonitorCheck
        '
        Me.MonitorCheck.AutoSize = True
        Me.MonitorCheck.Location = New System.Drawing.Point(7, 143)
        Me.MonitorCheck.Name = "MonitorCheck"
        Me.MonitorCheck.Size = New System.Drawing.Size(385, 17)
        Me.MonitorCheck.TabIndex = 11
        Me.MonitorCheck.Text = "Monitor Application Process (Greys out the icon if the program is not running)"
        Me.MonitorCheck.UseVisualStyleBackColor = True
        '
        'ExitAbility
        '
        Me.ExitAbility.AutoSize = True
        Me.ExitAbility.Enabled = False
        Me.ExitAbility.Location = New System.Drawing.Point(15, 166)
        Me.ExitAbility.Name = "ExitAbility"
        Me.ExitAbility.Size = New System.Drawing.Size(362, 17)
        Me.ExitAbility.TabIndex = 12
        Me.ExitAbility.Text = "Allow Application Exiting (Closes the application if clicked while running)"
        Me.ExitAbility.UseVisualStyleBackColor = True
        '
        'Finished
        '
        Me.Finished.Location = New System.Drawing.Point(259, 214)
        Me.Finished.Name = "Finished"
        Me.Finished.Size = New System.Drawing.Size(133, 23)
        Me.Finished.TabIndex = 14
        Me.Finished.Text = "Create the Shortcut!"
        Me.Finished.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(8, 214)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 15
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'ShortcutCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 249)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Finished)
        Me.Controls.Add(Me.ExitAbility)
        Me.Controls.Add(Me.MonitorCheck)
        Me.Controls.Add(Me.BackImageBrowse)
        Me.Controls.Add(Me.BackimageTextBox)
        Me.Controls.Add(Me.BackImageLabel)
        Me.Controls.Add(Me.BackgroundCheck)
        Me.Controls.Add(Me.ImgPathBrowse)
        Me.Controls.Add(Me.ImgPathTextBox)
        Me.Controls.Add(Me.ImgPathLabel)
        Me.Controls.Add(Me.GenDescLabel)
        Me.Controls.Add(Me.AppPathBrowse)
        Me.Controls.Add(Me.AppPathTextBox)
        Me.Controls.Add(Me.PathLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShortcutCreator"
        Me.Text = "Rainmeter Shortcut Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PathLabel As System.Windows.Forms.Label
    Friend WithEvents AppPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppPathBrowse As System.Windows.Forms.Button
    Friend WithEvents GenDescLabel As System.Windows.Forms.Label
    Friend WithEvents ImgPathLabel As System.Windows.Forms.Label
    Friend WithEvents ImgPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImgPathBrowse As System.Windows.Forms.Button
    Friend WithEvents BackgroundCheck As System.Windows.Forms.CheckBox
    Friend WithEvents BackImageLabel As System.Windows.Forms.Label
    Friend WithEvents BackimageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackImageBrowse As System.Windows.Forms.Button
    Friend WithEvents MonitorCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ExitAbility As System.Windows.Forms.CheckBox
    Friend WithEvents Finished As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

End Class
