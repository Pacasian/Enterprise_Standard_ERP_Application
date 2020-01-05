<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Head_Of_Department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Head_Of_Department))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.viewall = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_update = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.did = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mnum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.personal1 = New System.Windows.Forms.Label()
        Me.p_out = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.viewall)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 348)
        Me.Panel1.TabIndex = 2
        '
        'viewall
        '
        Me.viewall.Location = New System.Drawing.Point(497, 38)
        Me.viewall.Name = "viewall"
        Me.viewall.Size = New System.Drawing.Size(75, 23)
        Me.viewall.TabIndex = 27
        Me.viewall.Text = "View All "
        Me.viewall.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(67, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Enter Employee ID"
        '
        'btn_find
        '
        Me.btn_find.Image = CType(resources.GetObject("btn_find.Image"), System.Drawing.Image)
        Me.btn_find.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_find.Location = New System.Drawing.Point(402, 38)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(75, 23)
        Me.btn_find.TabIndex = 25
        Me.btn_find.Text = "Find"
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(144, 40)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(239, 20)
        Me.search.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(760, 239)
        Me.DataGridView1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.lb_update)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.did)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.mnum)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.status)
        Me.Panel2.Controls.Add(Me.ID)
        Me.Panel2.Controls.Add(Me.idBox)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Location = New System.Drawing.Point(12, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 206)
        Me.Panel2.TabIndex = 3
        '
        'lb_update
        '
        Me.lb_update.AutoSize = True
        Me.lb_update.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lb_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_update.Location = New System.Drawing.Point(626, 38)
        Me.lb_update.Name = "lb_update"
        Me.lb_update.Size = New System.Drawing.Size(0, 13)
        Me.lb_update.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(37, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Depart_Status "
        Me.Label4.UseWaitCursor = True
        '
        'did
        '
        Me.did.Location = New System.Drawing.Point(129, 145)
        Me.did.MaxLength = 3
        Me.did.Name = "did"
        Me.did.Size = New System.Drawing.Size(300, 20)
        Me.did.TabIndex = 35
        Me.did.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(37, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Phone"
        Me.Label3.UseWaitCursor = True
        '
        'mnum
        '
        Me.mnum.Location = New System.Drawing.Point(129, 108)
        Me.mnum.Name = "mnum"
        Me.mnum.Size = New System.Drawing.Size(300, 20)
        Me.mnum.TabIndex = 33
        Me.mnum.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(33, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = " Status"
        Me.Label2.UseWaitCursor = True
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(129, 73)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(300, 20)
        Me.status.TabIndex = 31
        Me.status.UseWaitCursor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ID.Location = New System.Drawing.Point(33, 38)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(86, 13)
        Me.ID.TabIndex = 30
        Me.ID.Text = " Employee ID "
        Me.ID.UseWaitCursor = True
        '
        'idBox
        '
        Me.idBox.Location = New System.Drawing.Point(129, 34)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(62, 20)
        Me.idBox.TabIndex = 29
        Me.idBox.UseWaitCursor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(603, 127)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(137, 46)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.UseWaitCursor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.lbUpdate)
        Me.Panel3.Controls.Add(Me.dsV)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.passV)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.idV)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dptV)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.mnumV)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.stV)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.jdV)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lnV)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.fnV)
        Me.Panel3.Controls.Add(Me.personal1)
        Me.Panel3.Controls.Add(Me.p_out)
        Me.Panel3.Controls.Add(Me.updateBtn)
        Me.Panel3.Controls.Add(Me.logout)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(803, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 575)
        Me.Panel3.TabIndex = 4
        '
        'lbUpdate
        '
        Me.lbUpdate.AutoSize = True
        Me.lbUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbUpdate.Location = New System.Drawing.Point(154, 531)
        Me.lbUpdate.Name = "lbUpdate"
        Me.lbUpdate.Size = New System.Drawing.Size(0, 13)
        Me.lbUpdate.TabIndex = 47
        '
        'dsV
        '
        Me.dsV.Location = New System.Drawing.Point(191, 428)
        Me.dsV.Name = "dsV"
        Me.dsV.ReadOnly = True
        Me.dsV.Size = New System.Drawing.Size(100, 20)
        Me.dsV.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(20, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Dept Status"
        '
        'passV
        '
        Me.passV.Location = New System.Drawing.Point(191, 403)
        Me.passV.Name = "passV"
        Me.passV.Size = New System.Drawing.Size(100, 20)
        Me.passV.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(20, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Password"
        '
        'idV
        '
        Me.idV.Location = New System.Drawing.Point(191, 379)
        Me.idV.Name = "idV"
        Me.idV.ReadOnly = True
        Me.idV.Size = New System.Drawing.Size(100, 20)
        Me.idV.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(20, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "ID Number"
        '
        'dptV
        '
        Me.dptV.Location = New System.Drawing.Point(191, 353)
        Me.dptV.Name = "dptV"
        Me.dptV.ReadOnly = True
        Me.dptV.Size = New System.Drawing.Size(100, 20)
        Me.dptV.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(20, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Department"
        '
        'mnumV
        '
        Me.mnumV.Location = New System.Drawing.Point(191, 328)
        Me.mnumV.Name = "mnumV"
        Me.mnumV.Size = New System.Drawing.Size(100, 20)
        Me.mnumV.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(20, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Mobile"
        '
        'stV
        '
        Me.stV.Location = New System.Drawing.Point(191, 303)
        Me.stV.Name = "stV"
        Me.stV.ReadOnly = True
        Me.stV.Size = New System.Drawing.Size(100, 20)
        Me.stV.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(20, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Status "
        '
        'jdV
        '
        Me.jdV.Location = New System.Drawing.Point(191, 278)
        Me.jdV.Name = "jdV"
        Me.jdV.ReadOnly = True
        Me.jdV.Size = New System.Drawing.Size(100, 20)
        Me.jdV.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(20, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Joining Date"
        '
        'lnV
        '
        Me.lnV.Location = New System.Drawing.Point(191, 252)
        Me.lnV.Name = "lnV"
        Me.lnV.ReadOnly = True
        Me.lnV.Size = New System.Drawing.Size(100, 20)
        Me.lnV.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(20, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Last Name"
        '
        'fnV
        '
        Me.fnV.Location = New System.Drawing.Point(191, 226)
        Me.fnV.Name = "fnV"
        Me.fnV.ReadOnly = True
        Me.fnV.Size = New System.Drawing.Size(100, 20)
        Me.fnV.TabIndex = 30
        '
        'personal1
        '
        Me.personal1.AutoSize = True
        Me.personal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personal1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.personal1.Location = New System.Drawing.Point(20, 226)
        Me.personal1.Name = "personal1"
        Me.personal1.Size = New System.Drawing.Size(67, 13)
        Me.personal1.TabIndex = 29
        Me.personal1.Text = "First Name"
        '
        'p_out
        '
        Me.p_out.AutoSize = True
        Me.p_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_out.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.p_out.Location = New System.Drawing.Point(20, 163)
        Me.p_out.Name = "p_out"
        Me.p_out.Size = New System.Drawing.Size(109, 17)
        Me.p_out.TabIndex = 27
        Me.p_out.Text = "Personal Info."
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.updateBtn.Location = New System.Drawing.Point(154, 30)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(78, 33)
        Me.updateBtn.TabIndex = 26
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.logout.Location = New System.Drawing.Point(238, 30)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(78, 33)
        Me.logout.TabIndex = 25
        Me.logout.Text = "Log Out"
        Me.logout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Head_Of_Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1151, 622)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Head_Of_Department"
        Me.Text = "Head_Of_Department"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents viewall As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_find As Button
    Friend WithEvents search As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lb_update As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents did As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents status As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents idBox As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents personal1 As Label
    Friend WithEvents p_out As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents logout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
