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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbmsg = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.did = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.Label()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.depart = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.mnum = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.jDate = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.TestclassDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestclassDataSet = New SAMPLE1.testclassDataSet()
        Me.TestclassDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestclassDataSet1 = New SAMPLE1.testclassDataSet1()
        Me.TestclassDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestclassDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_LogOut = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TestclassDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestclassDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestclassDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestclassDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestclassDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestclassDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnPrint.Location = New System.Drawing.Point(205, 465)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(523, 65)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lbmsg
        '
        Me.lbmsg.AutoSize = True
        Me.lbmsg.BackColor = System.Drawing.Color.Maroon
        Me.lbmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmsg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbmsg.Location = New System.Drawing.Point(308, 358)
        Me.lbmsg.Name = "lbmsg"
        Me.lbmsg.Size = New System.Drawing.Size(34, 17)
        Me.lbmsg.TabIndex = 0
        Me.lbmsg.Text = "Idle"
        Me.lbmsg.UseWaitCursor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.did)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbmsg)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.ID)
        Me.Panel1.Controls.Add(Me.idBox)
        Me.Panel1.Controls.Add(Me.depart)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.mnum)
        Me.Panel1.Controls.Add(Me.status)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.jDate)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.lname)
        Me.Panel1.Controls.Add(Me.fname)
        Me.Panel1.Location = New System.Drawing.Point(23, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 400)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(42, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Dep ID"
        Me.Label1.UseWaitCursor = True
        '
        'did
        '
        Me.did.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.did.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.did.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.did.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.did.Location = New System.Drawing.Point(149, 232)
        Me.did.MaxLength = 3
        Me.did.Name = "did"
        Me.did.Size = New System.Drawing.Size(60, 20)
        Me.did.TabIndex = 48
        '
        'Password
        '
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.Location = New System.Drawing.Point(149, 206)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(178, 20)
        Me.Password.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(42, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Department"
        Me.Label13.UseWaitCursor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(42, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Mobile Number"
        Me.Label12.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(41, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Joining Date"
        Me.Label11.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(42, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Status"
        Me.Label10.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(41, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Last Name"
        Me.Label9.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(41, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "First Name"
        Me.Label8.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(42, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Password"
        Me.Label7.UseWaitCursor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(65, 278)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 23)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.UseWaitCursor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ID.Location = New System.Drawing.Point(137, 338)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(20, 13)
        Me.ID.TabIndex = 39
        Me.ID.Text = "ID"
        Me.ID.UseWaitCursor = True
        '
        'idBox
        '
        Me.idBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idBox.Location = New System.Drawing.Point(163, 335)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(60, 20)
        Me.idBox.TabIndex = 38
        '
        'depart
        '
        Me.depart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.depart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.depart.Location = New System.Drawing.Point(149, 176)
        Me.depart.Name = "depart"
        Me.depart.Size = New System.Drawing.Size(178, 20)
        Me.depart.TabIndex = 33
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(245, 278)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 23)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.UseWaitCursor = True
        '
        'mnum
        '
        Me.mnum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mnum.Location = New System.Drawing.Point(149, 146)
        Me.mnum.Name = "mnum"
        Me.mnum.Size = New System.Drawing.Size(178, 20)
        Me.mnum.TabIndex = 32
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.status.Location = New System.Drawing.Point(149, 118)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(178, 20)
        Me.status.TabIndex = 31
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(38, 358)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.UseWaitCursor = True
        '
        'jDate
        '
        Me.jDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jDate.Location = New System.Drawing.Point(149, 87)
        Me.jDate.Name = "jDate"
        Me.jDate.Size = New System.Drawing.Size(178, 20)
        Me.jDate.TabIndex = 30
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(38, 318)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "Update "
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.UseWaitCursor = True
        '
        'lname
        '
        Me.lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lname.Location = New System.Drawing.Point(149, 54)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(178, 20)
        Me.lname.TabIndex = 29
        '
        'fname
        '
        Me.fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname.Location = New System.Drawing.Point(149, 20)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(178, 20)
        Me.fname.TabIndex = 28
        '
        'TestclassDataSetBindingSource2
        '
        Me.TestclassDataSetBindingSource2.DataSource = Me.TestclassDataSet
        Me.TestclassDataSetBindingSource2.Position = 0
        '
        'TestclassDataSet
        '
        Me.TestclassDataSet.DataSetName = "testclassDataSet"
        Me.TestclassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestclassDataSet1BindingSource
        '
        Me.TestclassDataSet1BindingSource.DataSource = Me.TestclassDataSet1
        Me.TestclassDataSet1BindingSource.Position = 0
        '
        'TestclassDataSet1
        '
        Me.TestclassDataSet1.DataSetName = "testclassDataSet1"
        Me.TestclassDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestclassDataSetBindingSource
        '
        Me.TestclassDataSetBindingSource.DataSource = Me.TestclassDataSet
        Me.TestclassDataSetBindingSource.Position = 0
        '
        'TestclassDataSetBindingSource1
        '
        Me.TestclassDataSetBindingSource1.DataSource = Me.TestclassDataSet
        Me.TestclassDataSetBindingSource1.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(521, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(386, 267)
        Me.DataGridView1.TabIndex = 25
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSearch.Location = New System.Drawing.Point(807, 116)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Find"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(549, 118)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(239, 20)
        Me.search.TabIndex = 23
        Me.search.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(518, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Employee ID "
        '
        'btn_LogOut
        '
        Me.btn_LogOut.BackColor = System.Drawing.Color.DarkRed
        Me.btn_LogOut.ForeColor = System.Drawing.Color.White
        Me.btn_LogOut.Location = New System.Drawing.Point(851, 52)
        Me.btn_LogOut.Name = "btn_LogOut"
        Me.btn_LogOut.Size = New System.Drawing.Size(76, 28)
        Me.btn_LogOut.TabIndex = 27
        Me.btn_LogOut.Text = "Log Out"
        Me.btn_LogOut.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(396, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 34)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Admin Window"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Modify "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(939, 555)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_LogOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TestclassDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestclassDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestclassDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestclassDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestclassDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestclassDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbmsg As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents did As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents ID As Label
    Friend WithEvents idBox As TextBox
    Friend WithEvents depart As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents mnum As TextBox
    Friend WithEvents status As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents jDate As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lname As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents TestclassDataSetBindingSource As BindingSource
    Friend WithEvents TestclassDataSet As testclassDataSet
    Friend WithEvents TestclassDataSetBindingSource1 As BindingSource
    Friend WithEvents TestclassDataSet1BindingSource As BindingSource
    Friend WithEvents TestclassDataSet1 As testclassDataSet1
    Friend WithEvents TestclassDataSetBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_LogOut As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
