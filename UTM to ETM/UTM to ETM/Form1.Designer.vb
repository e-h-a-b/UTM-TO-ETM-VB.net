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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lon = New System.Windows.Forms.RadioButton()
        Me.lat = New System.Windows.Forms.RadioButton()
        Me.dec = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.a35 = New System.Windows.Forms.RadioButton()
        Me.a31 = New System.Windows.Forms.RadioButton()
        Me.a27 = New System.Windows.Forms.RadioButton()
        Me.Eas = New System.Windows.Forms.Label()
        Me.No = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.S2 = New System.Windows.Forms.TextBox()
        Me.M2 = New System.Windows.Forms.TextBox()
        Me.D2 = New System.Windows.Forms.TextBox()
        Me.S1 = New System.Windows.Forms.TextBox()
        Me.M1 = New System.Windows.Forms.TextBox()
        Me.D1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(310, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Checking : -------------------------"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Checking : -------------------------"
        '
        'lon
        '
        Me.lon.AutoSize = True
        Me.lon.Location = New System.Drawing.Point(49, 7)
        Me.lon.Name = "lon"
        Me.lon.Size = New System.Drawing.Size(45, 17)
        Me.lon.TabIndex = 53
        Me.lon.TabStop = True
        Me.lon.Text = "long"
        Me.lon.UseVisualStyleBackColor = True
        '
        'lat
        '
        Me.lat.AutoSize = True
        Me.lat.Location = New System.Drawing.Point(6, 7)
        Me.lat.Name = "lat"
        Me.lat.Size = New System.Drawing.Size(36, 17)
        Me.lat.TabIndex = 52
        Me.lat.TabStop = True
        Me.lat.Text = "lat"
        Me.lat.UseVisualStyleBackColor = True
        '
        'dec
        '
        Me.dec.Location = New System.Drawing.Point(100, 4)
        Me.dec.Name = "dec"
        Me.dec.Size = New System.Drawing.Size(89, 20)
        Me.dec.TabIndex = 51
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(195, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Decmi to degree"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'a35
        '
        Me.a35.AutoSize = True
        Me.a35.BackColor = System.Drawing.Color.LightSkyBlue
        Me.a35.Location = New System.Drawing.Point(213, 30)
        Me.a35.Name = "a35"
        Me.a35.Size = New System.Drawing.Size(90, 56)
        Me.a35.TabIndex = 49
        Me.a35.Text = "long = 35  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lat    = 30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N = 1100000 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E = 300000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.a35.UseVisualStyleBackColor = False
        '
        'a31
        '
        Me.a31.AutoSize = True
        Me.a31.BackColor = System.Drawing.Color.MistyRose
        Me.a31.Checked = True
        Me.a31.Location = New System.Drawing.Point(117, 30)
        Me.a31.Name = "a31"
        Me.a31.Size = New System.Drawing.Size(84, 56)
        Me.a31.TabIndex = 48
        Me.a31.TabStop = True
        Me.a31.Text = "long = 31" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lat    = 30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N = 810000 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E  = 615000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.a31.UseVisualStyleBackColor = False
        '
        'a27
        '
        Me.a27.AutoSize = True
        Me.a27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.a27.Location = New System.Drawing.Point(5, 30)
        Me.a27.Name = "a27"
        Me.a27.Size = New System.Drawing.Size(95, 56)
        Me.a27.TabIndex = 47
        Me.a27.Text = "long = 27  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lat    = 30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N     = 200000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E      = 700000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.a27.UseVisualStyleBackColor = False
        '
        'Eas
        '
        Me.Eas.AutoSize = True
        Me.Eas.Location = New System.Drawing.Point(305, 149)
        Me.Eas.Name = "Eas"
        Me.Eas.Size = New System.Drawing.Size(14, 13)
        Me.Eas.TabIndex = 46
        Me.Eas.Text = "E"
        '
        'No
        '
        Me.No.AutoSize = True
        Me.No.Location = New System.Drawing.Point(307, 124)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(15, 13)
        Me.No.TabIndex = 45
        Me.No.Text = "N"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Easting :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(252, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "North    :"
        '
        'S2
        '
        Me.S2.Location = New System.Drawing.Point(178, 146)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(67, 20)
        Me.S2.TabIndex = 42
        Me.S2.Text = "0"
        '
        'M2
        '
        Me.M2.Location = New System.Drawing.Point(115, 146)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(57, 20)
        Me.M2.TabIndex = 41
        Me.M2.Text = "0"
        '
        'D2
        '
        Me.D2.Location = New System.Drawing.Point(70, 146)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(35, 20)
        Me.D2.TabIndex = 40
        Me.D2.Text = "29"
        '
        'S1
        '
        Me.S1.Location = New System.Drawing.Point(178, 121)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(67, 20)
        Me.S1.TabIndex = 39
        Me.S1.Text = "0"
        '
        'M1
        '
        Me.M1.Location = New System.Drawing.Point(115, 121)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(57, 20)
        Me.M1.TabIndex = 38
        Me.M1.Text = "0"
        '
        'D1
        '
        Me.D1.Location = New System.Drawing.Point(69, 121)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(36, 20)
        Me.D1.TabIndex = 37
        Me.D1.Text = "27"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Longtitude"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Latitude"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(70, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Geographic to ETM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 196)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lon)
        Me.Controls.Add(Me.lat)
        Me.Controls.Add(Me.dec)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.a35)
        Me.Controls.Add(Me.a31)
        Me.Controls.Add(Me.a27)
        Me.Controls.Add(Me.Eas)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.S2)
        Me.Controls.Add(Me.M2)
        Me.Controls.Add(Me.D2)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.M1)
        Me.Controls.Add(Me.D1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Egyption Coordinates"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lon As System.Windows.Forms.RadioButton
    Friend WithEvents lat As System.Windows.Forms.RadioButton
    Friend WithEvents dec As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents a35 As System.Windows.Forms.RadioButton
    Friend WithEvents a31 As System.Windows.Forms.RadioButton
    Friend WithEvents a27 As System.Windows.Forms.RadioButton
    Friend WithEvents Eas As System.Windows.Forms.Label
    Friend WithEvents No As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents S2 As System.Windows.Forms.TextBox
    Friend WithEvents M2 As System.Windows.Forms.TextBox
    Friend WithEvents D2 As System.Windows.Forms.TextBox
    Friend WithEvents S1 As System.Windows.Forms.TextBox
    Friend WithEvents M1 As System.Windows.Forms.TextBox
    Friend WithEvents D1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
