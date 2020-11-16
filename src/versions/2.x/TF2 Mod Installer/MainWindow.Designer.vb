<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModInstaller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad_HudNone = New System.Windows.Forms.RadioButton()
        Me.rad_HudRayshud = New System.Windows.Forms.RadioButton()
        Me.rad_HudFlawHud = New System.Windows.Forms.RadioButton()
        Me.rad_HudAHud = New System.Windows.Forms.RadioButton()
        Me.rad_HudToonHud = New System.Windows.Forms.RadioButton()
        Me.rad_HudBudHud = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad_HudBudHud)
        Me.GroupBox1.Controls.Add(Me.rad_HudToonHud)
        Me.GroupBox1.Controls.Add(Me.rad_HudAHud)
        Me.GroupBox1.Controls.Add(Me.rad_HudFlawHud)
        Me.GroupBox1.Controls.Add(Me.rad_HudRayshud)
        Me.GroupBox1.Controls.Add(Me.rad_HudNone)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 414)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HUDs"
        '
        'rad_HudNone
        '
        Me.rad_HudNone.AutoSize = True
        Me.rad_HudNone.Checked = True
        Me.rad_HudNone.Location = New System.Drawing.Point(6, 19)
        Me.rad_HudNone.Name = "rad_HudNone"
        Me.rad_HudNone.Size = New System.Drawing.Size(62, 17)
        Me.rad_HudNone.TabIndex = 0
        Me.rad_HudNone.TabStop = True
        Me.rad_HudNone.Text = "No Hud"
        Me.rad_HudNone.UseVisualStyleBackColor = True
        '
        'rad_HudRayshud
        '
        Me.rad_HudRayshud.AutoSize = True
        Me.rad_HudRayshud.Location = New System.Drawing.Point(6, 42)
        Me.rad_HudRayshud.Name = "rad_HudRayshud"
        Me.rad_HudRayshud.Size = New System.Drawing.Size(62, 17)
        Me.rad_HudRayshud.TabIndex = 1
        Me.rad_HudRayshud.Text = "rayshud"
        Me.rad_HudRayshud.UseVisualStyleBackColor = True
        '
        'rad_HudFlawHud
        '
        Me.rad_HudFlawHud.AutoSize = True
        Me.rad_HudFlawHud.Location = New System.Drawing.Point(6, 65)
        Me.rad_HudFlawHud.Name = "rad_HudFlawHud"
        Me.rad_HudFlawHud.Size = New System.Drawing.Size(71, 17)
        Me.rad_HudFlawHud.TabIndex = 2
        Me.rad_HudFlawHud.Text = "FlawHUD"
        Me.rad_HudFlawHud.UseVisualStyleBackColor = True
        '
        'rad_HudAHud
        '
        Me.rad_HudAHud.AutoSize = True
        Me.rad_HudAHud.Location = New System.Drawing.Point(6, 88)
        Me.rad_HudAHud.Name = "rad_HudAHud"
        Me.rad_HudAHud.Size = New System.Drawing.Size(49, 17)
        Me.rad_HudAHud.TabIndex = 3
        Me.rad_HudAHud.Text = "ahud"
        Me.rad_HudAHud.UseVisualStyleBackColor = True
        '
        'rad_HudToonHud
        '
        Me.rad_HudToonHud.AutoSize = True
        Me.rad_HudToonHud.Location = New System.Drawing.Point(6, 111)
        Me.rad_HudToonHud.Name = "rad_HudToonHud"
        Me.rad_HudToonHud.Size = New System.Drawing.Size(74, 17)
        Me.rad_HudToonHud.TabIndex = 4
        Me.rad_HudToonHud.Text = "ToonHUD"
        Me.rad_HudToonHud.UseVisualStyleBackColor = True
        '
        'rad_HudBudHud
        '
        Me.rad_HudBudHud.AutoSize = True
        Me.rad_HudBudHud.Location = New System.Drawing.Point(6, 134)
        Me.rad_HudBudHud.Name = "rad_HudBudHud"
        Me.rad_HudBudHud.Size = New System.Drawing.Size(61, 17)
        Me.rad_HudBudHud.TabIndex = 5
        Me.rad_HudBudHud.Text = "budhud"
        Me.rad_HudBudHud.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(697, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Install Mods"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Uninstall Mods"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 432)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Settings"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ModInstaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 467)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ModInstaller"
        Me.Text = "TF2 Mod Installer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad_HudNone As RadioButton
    Friend WithEvents rad_HudRayshud As RadioButton
    Friend WithEvents rad_HudFlawHud As RadioButton
    Friend WithEvents rad_HudAHud As RadioButton
    Friend WithEvents rad_HudToonHud As RadioButton
    Friend WithEvents rad_HudBudHud As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
