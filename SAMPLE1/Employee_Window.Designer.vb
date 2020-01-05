<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Window
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Window))
        Me.lbUpdate = New System.Windows.Forms.Label()
        Me.dsV = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.passV = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.idV = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dptV = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mnumV = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jdV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lnV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fnV = New System.Windows.Forms.TextBox()
        Me.personal = New System.Windows.Forms.Label()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.p_out = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUpdate
        '
        Me.lbUpdate.AutoSize = True
        Me.lbUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbUpdate.Location = New System.Drawing.Point(657, 337)
        Me.lbUpdate.Name = "lbUpdate"
        Me.lbUpdate.Size = New System.Drawing.Size(0, 13)
        Me.lbUpdate.TabIndex = 47
        '
        'dsV
        '
        Me.dsV.Location = New System.Drawing.Point(403, 321)
        Me.dsV.Name = "dsV"
        Me.dsV.ReadOnly = True
        Me.dsV.Size = New System.Drawing.Size(106, 20)
        Me.dsV.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(238, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Dept Status"
        '
        'passV
        '
        Me.passV.Location = New System.Drawing.Point(403, 296)
        Me.passV.Name = "passV"
        Me.passV.Size = New System.Drawing.Size(106, 20)
        Me.passV.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(238, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Password"
        '
        'idV
        '
        Me.idV.Location = New System.Drawing.Point(403, 272)
        Me.idV.Name = "idV"
        Me.idV.ReadOnly = True
        Me.idV.Size = New System.Drawing.Size(106, 20)
        Me.idV.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(238, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "ID Number"
        '
        'dptV
        '
        Me.dptV.Location = New System.Drawing.Point(403, 246)
        Me.dptV.Name = "dptV"
        Me.dptV.ReadOnly = True
        Me.dptV.Size = New System.Drawing.Size(106, 20)
        Me.dptV.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(238, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Department"
        '
        'mnumV
        '
        Me.mnumV.Location = New System.Drawing.Point(403, 221)
        Me.mnumV.Name = "mnumV"
        Me.mnumV.Size = New System.Drawing.Size(106, 20)
        Me.mnumV.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(238, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Mobile"
        '
        'stV
        '
        Me.stV.Location = New System.Drawing.Point(403, 196)
        Me.stV.Name = "stV"
        Me.stV.ReadOnly = True
        Me.stV.Size = New System.Drawing.Size(106, 20)
        Me.stV.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(238, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Status "
        '
        'jdV
        '
        Me.jdV.Location = New System.Drawing.Point(403, 171)
        Me.jdV.Name = "jdV"
        Me.jdV.ReadOnly = True
        Me.jdV.Size = New System.Drawing.Size(106, 20)
        Me.jdV.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(238, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Joining Date"
        '
        'lnV
        '
        Me.lnV.Location = New System.Drawing.Point(403, 145)
        Me.lnV.Name = "lnV"
        Me.lnV.ReadOnly = True
        Me.lnV.Size = New System.Drawing.Size(106, 20)
        Me.lnV.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(238, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Last Name"
        '
        'fnV
        '
        Me.fnV.Location = New System.Drawing.Point(403, 119)
        Me.fnV.Name = "fnV"
        Me.fnV.ReadOnly = True
        Me.fnV.Size = New System.Drawing.Size(106, 20)
        Me.fnV.TabIndex = 30
        '
        'personal
        '
        Me.personal.AutoSize = True
        Me.personal.BackColor = System.Drawing.Color.Transparent
        Me.personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.personal.Location = New System.Drawing.Point(238, 119)
        Me.personal.Name = "personal"
        Me.personal.Size = New System.Drawing.Size(67, 13)
        Me.personal.TabIndex = 29
        Me.personal.Text = "First Name"
        '
        'btn_done
        '
        Me.btn_done.Location = New System.Drawing.Point(642, 364)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(75, 23)
        Me.btn_done.TabIndex = 28
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = True
        Me.btn_done.Visible = False
        '
        'p_out
        '
        Me.p_out.AutoSize = True
        Me.p_out.BackColor = System.Drawing.Color.Transparent
        Me.p_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_out.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.p_out.Location = New System.Drawing.Point(238, 56)
        Me.p_out.Name = "p_out"
        Me.p_out.Size = New System.Drawing.Size(121, 20)
        Me.p_out.TabIndex = 27
        Me.p_out.Text = "Personal Info."
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.updateBtn.ForeColor = System.Drawing.Color.Transparent
        Me.updateBtn.Location = New System.Drawing.Point(602, 48)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(78, 33)
        Me.updateBtn.TabIndex = 26
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logout.ForeColor = System.Drawing.Color.Transparent
        Me.logout.Location = New System.Drawing.Point(686, 48)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(78, 33)
        Me.logout.TabIndex = 25
        Me.logout.Text = "Log Out"
        Me.logout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(55, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Employee_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 448)
        Me.Controls.Add(Me.lbUpdate)
        Me.Controls.Add(Me.dsV)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.passV)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.idV)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dptV)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mnumV)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.stV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.jdV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lnV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fnV)
        Me.Controls.Add(Me.personal)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.p_out)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Employee_Window"
        Me.Text = "Employee_Window"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUpdate As Label
    Friend WithEvents dsV As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents passV As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents idV As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dptV As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mnumV As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents stV As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents jdV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lnV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fnV As TextBox
    Friend WithEvents personal As Label
    Friend WithEvents btn_done As Button
    Friend WithEvents p_out As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents logout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
