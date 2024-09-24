<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start2
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
        Me.c_level = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Load = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.t_level = New System.Windows.Forms.TextBox
        Me.t_position = New System.Windows.Forms.TextBox
        Me.t_lvlname = New System.Windows.Forms.TextBox
        Me.t_pos1 = New System.Windows.Forms.TextBox
        Me.t_pos2 = New System.Windows.Forms.TextBox
        Me.t_hex = New System.Windows.Forms.TextBox
        Me.t_hex2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.t_position2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.t_lvlname2 = New System.Windows.Forms.TextBox
        Me.t_level2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.t_name = New System.Windows.Forms.TextBox
        Me.t_sgname = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.c_newlevel = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c_level
        '
        Me.c_level.FormattingEnabled = True
        Me.c_level.Items.AddRange(New Object() {"00  - Wood", "01 - Catacombs 1", "02 - Catacombs 2", "03 - Catacombs 3", "04 - Catacombs 4", "05 - Temple 1", "06 - Temple 2", "07 - Silver Tower 1", "08 - Silver Tower 2", "09 - Silver Tower 3", "10 - Azure Tower 1", "11 - Azure Tower 2", "12 - Azure Tower 3", "13 - Azure Tower 4", "14 - Frost Giants", "15 - Crimson Tower 1", "16 - Crimson Tower 2"})
        Me.c_level.Location = New System.Drawing.Point(399, 7)
        Me.c_level.Name = "c_level"
        Me.c_level.Size = New System.Drawing.Size(142, 21)
        Me.c_level.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Map:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folder:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 20)
        Me.TextBox1.TabIndex = 3
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.Text = "01 - EOBDATA0.SAV"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "02 - EOBDATA1.SAV"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(15, 58)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.Text = "03 - EOBDATA2.SAV"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(15, 81)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.Text = "04 - EOBDATA3.SAV"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(15, 104)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.Text = "05 - EOBDATA4.SAV"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(15, 127)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.Text = "06 - EOBDATA5.SAV"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton6)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Location = New System.Drawing.Point(82, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 158)
        Me.Panel1.TabIndex = 11
        '
        'Load
        '
        Me.Load.Location = New System.Drawing.Point(87, 327)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(68, 23)
        Me.Load.TabIndex = 12
        Me.Load.Text = "Load"
        Me.Load.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Level:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Position:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        't_level
        '
        Me.t_level.Enabled = False
        Me.t_level.Location = New System.Drawing.Point(84, 391)
        Me.t_level.Name = "t_level"
        Me.t_level.Size = New System.Drawing.Size(36, 20)
        Me.t_level.TabIndex = 15
        '
        't_position
        '
        Me.t_position.Enabled = False
        Me.t_position.Location = New System.Drawing.Point(84, 422)
        Me.t_position.Name = "t_position"
        Me.t_position.Size = New System.Drawing.Size(36, 20)
        Me.t_position.TabIndex = 16
        '
        't_lvlname
        '
        Me.t_lvlname.Enabled = False
        Me.t_lvlname.Location = New System.Drawing.Point(137, 391)
        Me.t_lvlname.Name = "t_lvlname"
        Me.t_lvlname.Size = New System.Drawing.Size(107, 20)
        Me.t_lvlname.TabIndex = 17
        '
        't_pos1
        '
        Me.t_pos1.Enabled = False
        Me.t_pos1.Location = New System.Drawing.Point(137, 422)
        Me.t_pos1.Name = "t_pos1"
        Me.t_pos1.Size = New System.Drawing.Size(32, 20)
        Me.t_pos1.TabIndex = 18
        '
        't_pos2
        '
        Me.t_pos2.Enabled = False
        Me.t_pos2.Location = New System.Drawing.Point(178, 422)
        Me.t_pos2.Name = "t_pos2"
        Me.t_pos2.Size = New System.Drawing.Size(33, 20)
        Me.t_pos2.TabIndex = 19
        '
        't_hex
        '
        Me.t_hex.Enabled = False
        Me.t_hex.Location = New System.Drawing.Point(217, 422)
        Me.t_hex.Name = "t_hex"
        Me.t_hex.Size = New System.Drawing.Size(32, 20)
        Me.t_hex.TabIndex = 20
        '
        't_hex2
        '
        Me.t_hex2.Enabled = False
        Me.t_hex2.Location = New System.Drawing.Point(258, 422)
        Me.t_hex2.Name = "t_hex2"
        Me.t_hex2.Size = New System.Drawing.Size(33, 20)
        Me.t_hex2.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 21)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Select Savegame:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(83, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "MAP:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        't_position2
        '
        Me.t_position2.Enabled = False
        Me.t_position2.Location = New System.Drawing.Point(84, 95)
        Me.t_position2.Name = "t_position2"
        Me.t_position2.Size = New System.Drawing.Size(36, 20)
        Me.t_position2.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Position:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        't_lvlname2
        '
        Me.t_lvlname2.Enabled = False
        Me.t_lvlname2.Location = New System.Drawing.Point(137, 68)
        Me.t_lvlname2.Name = "t_lvlname2"
        Me.t_lvlname2.Size = New System.Drawing.Size(107, 20)
        Me.t_lvlname2.TabIndex = 30
        '
        't_level2
        '
        Me.t_level2.Enabled = False
        Me.t_level2.Location = New System.Drawing.Point(84, 68)
        Me.t_level2.Name = "t_level2"
        Me.t_level2.Size = New System.Drawing.Size(36, 20)
        Me.t_level2.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Level:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Name:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        't_name
        '
        Me.t_name.Enabled = False
        Me.t_name.Location = New System.Drawing.Point(86, 365)
        Me.t_name.Name = "t_name"
        Me.t_name.Size = New System.Drawing.Size(158, 20)
        Me.t_name.TabIndex = 32
        '
        't_sgname
        '
        Me.t_sgname.Location = New System.Drawing.Point(84, 497)
        Me.t_sgname.Name = "t_sgname"
        Me.t_sgname.Size = New System.Drawing.Size(158, 20)
        Me.t_sgname.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 500)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Name:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 526)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Level:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c_newlevel
        '
        Me.c_newlevel.FormattingEnabled = True
        Me.c_newlevel.Items.AddRange(New Object() {"00  - Wood", "01 - Catacombs 1", "02 - Catacombs 2", "03 - Catacombs 3", "04 - Catacombs 4", "05 - Temple 1", "06 - Temple 2", "07 - Silver Tower 1", "08 - Silver Tower 2", "09 - Silver Tower 3", "10 - Azure Tower 1", "11 - Azure Tower 2", "12 - Azure Tower 3", "13 - Azure Tower 4", "14 - Frost Giants", "15 - Crimson Tower 1", "16 - Crimson Tower 2"})
        Me.c_newlevel.Location = New System.Drawing.Point(84, 523)
        Me.c_newlevel.Name = "c_newlevel"
        Me.c_newlevel.Size = New System.Drawing.Size(142, 21)
        Me.c_newlevel.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "MOVE TO NEW LEVEL:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(84, 555)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 21)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Move"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Start2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 588)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.c_newlevel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.t_sgname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.t_name)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.t_lvlname2)
        Me.Controls.Add(Me.t_level2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.t_position2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t_hex2)
        Me.Controls.Add(Me.t_hex)
        Me.Controls.Add(Me.t_pos2)
        Me.Controls.Add(Me.t_pos1)
        Me.Controls.Add(Me.t_lvlname)
        Me.Controls.Add(Me.t_position)
        Me.Controls.Add(Me.t_level)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c_level)
        Me.Name = "Start2"
        Me.Text = "Eye of the Beholder 2 Maps and Positions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Load As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents t_level As System.Windows.Forms.TextBox
    Friend WithEvents t_position As System.Windows.Forms.TextBox
    Friend WithEvents t_lvlname As System.Windows.Forms.TextBox
    Friend WithEvents t_pos1 As System.Windows.Forms.TextBox
    Friend WithEvents t_pos2 As System.Windows.Forms.TextBox
    Friend WithEvents t_hex As System.Windows.Forms.TextBox
    Friend WithEvents t_hex2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents t_position2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents t_lvlname2 As System.Windows.Forms.TextBox
    Friend WithEvents t_level2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents t_name As System.Windows.Forms.TextBox
    Friend WithEvents t_sgname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents c_newlevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
