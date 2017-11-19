<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LeftButton
        '
        Me.LeftButton.BackColor = System.Drawing.Color.Transparent
        Me.LeftButton.BackgroundImage = CType(resources.GetObject("LeftButton.BackgroundImage"), System.Drawing.Image)
        Me.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftButton.FlatAppearance.BorderSize = 0
        Me.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeftButton.ForeColor = System.Drawing.Color.Transparent
        Me.LeftButton.Location = New System.Drawing.Point(0, 391)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(37, 32)
        Me.LeftButton.TabIndex = 8
        Me.LeftButton.UseVisualStyleBackColor = False
        '
        'RightButton
        '
        Me.RightButton.BackColor = System.Drawing.Color.Transparent
        Me.RightButton.BackgroundImage = CType(resources.GetObject("RightButton.BackgroundImage"), System.Drawing.Image)
        Me.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightButton.FlatAppearance.BorderSize = 0
        Me.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RightButton.ForeColor = System.Drawing.Color.Transparent
        Me.RightButton.Location = New System.Drawing.Point(68, 391)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(37, 32)
        Me.RightButton.TabIndex = 7
        Me.RightButton.UseVisualStyleBackColor = False
        '
        'DownButton
        '
        Me.DownButton.BackColor = System.Drawing.Color.Transparent
        Me.DownButton.BackgroundImage = CType(resources.GetObject("DownButton.BackgroundImage"), System.Drawing.Image)
        Me.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DownButton.FlatAppearance.BorderSize = 0
        Me.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DownButton.ForeColor = System.Drawing.Color.Transparent
        Me.DownButton.Location = New System.Drawing.Point(37, 423)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(32, 37)
        Me.DownButton.TabIndex = 6
        Me.DownButton.UseVisualStyleBackColor = False
        '
        'UpButton
        '
        Me.UpButton.BackColor = System.Drawing.Color.Transparent
        Me.UpButton.BackgroundImage = CType(resources.GetObject("UpButton.BackgroundImage"), System.Drawing.Image)
        Me.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpButton.FlatAppearance.BorderSize = 0
        Me.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpButton.ForeColor = System.Drawing.Color.Transparent
        Me.UpButton.Location = New System.Drawing.Point(36, 355)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(32, 37)
        Me.UpButton.TabIndex = 5
        Me.UpButton.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.LeftButton)
        Me.Controls.Add(Me.RightButton)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Name = "Form4"
        Me.Text = "TourBot Feed"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents UpButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents RightButton As Button
    Friend WithEvents LeftButton As Button
End Class
