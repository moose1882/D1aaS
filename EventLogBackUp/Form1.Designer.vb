<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.Button_RunCode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_RunCode
        '
        Me.Button_RunCode.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_RunCode.FlatAppearance.BorderSize = 5
        Me.Button_RunCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_RunCode.Location = New System.Drawing.Point(127, 48)
        Me.Button_RunCode.Name = "Button_RunCode"
        Me.Button_RunCode.Size = New System.Drawing.Size(180, 41)
        Me.Button_RunCode.TabIndex = 0
        Me.Button_RunCode.Text = "RUN THE CODE"
        Me.Button_RunCode.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 136)
        Me.Controls.Add(Me.Button_RunCode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Main"
        Me.Text = "Event Log Backup"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_RunCode As System.Windows.Forms.Button

End Class
