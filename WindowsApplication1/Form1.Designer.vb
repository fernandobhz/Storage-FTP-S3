<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.sync_url = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.sync_localfolder = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(841, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "e:\cliente.agoge.com.br.rar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(873, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(841, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "s3://xxxxx:xxxxxxxxx@s3-sa-east-1.amazonaws.com/cliente.agoge.com.br/cliente.agoge.com.br.rar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(873, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Download"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 289)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(841, 20)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "ftp://administrator:xxxxxx@leonidas.agoge.com.br/"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(859, 289)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 315)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(841, 20)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = "ftp://fernandobhz:xxxxxx@fernandobhz.com.br/"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(859, 315)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "List"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(12, 263)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(841, 20)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.Text = "s3://xxxx:xxxxxx@s3-sa-east-1.amazonaws.com/cliente.agoge.com.br/"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(859, 263)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "List"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(859, 138)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "MakeDir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(12, 138)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(841, 20)
        Me.TextBox6.TabIndex = 13
        Me.TextBox6.Text = "s3://xxx:xxx@s3-sa-east-1.amazonaws.com/cliente.agoge.com.br/NovoDir"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(859, 164)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "MakeDir"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(12, 164)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(841, 20)
        Me.TextBox7.TabIndex = 15
        Me.TextBox7.Text = "ftp://administrator:xxxxx@leonidas.agoge.com.br/NovoDir"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(940, 164)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 17
        Me.Button9.Text = "ForceDir"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(873, 427)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 21
        Me.Button10.Text = "DownSync"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'sync_url
        '
        Me.sync_url.Location = New System.Drawing.Point(12, 430)
        Me.sync_url.Name = "sync_url"
        Me.sync_url.Size = New System.Drawing.Size(841, 20)
        Me.sync_url.TabIndex = 20
        Me.sync_url.Text = "s3://xxxx:xxxx@s3-sa-east-1.amazonaws.com/cliente.agoge.com.br/Nova pasta"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(873, 391)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "UpSync"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'sync_localfolder
        '
        Me.sync_localfolder.Location = New System.Drawing.Point(12, 393)
        Me.sync_localfolder.Name = "sync_localfolder"
        Me.sync_localfolder.Size = New System.Drawing.Size(841, 20)
        Me.sync_localfolder.TabIndex = 18
        Me.sync_localfolder.Text = "E:\Nova pasta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 475)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.sync_url)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.sync_localfolder)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents sync_url As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents sync_localfolder As System.Windows.Forms.TextBox

End Class
