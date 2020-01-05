Imports System.Data.SqlClient



Public Class Head_Of_Department

    Public searchVal As String
    Public searchVal1 As String
    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")


    ' start support functions

    Public Sub New(ByVal vale As String)

        ' This call is required by the designer.
        InitializeComponent()
        searchVal = vale


        Dim SQL As String = " Select * from table_2 WHERE ID = '" & searchVal & "'"
        Dim cmd As New SqlCommand(SQL, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        con.Open()
        adapter = New SqlDataAdapter(SQL, con)
        adapter.Fill(dt)
        fnV.Text = dt.Rows.Item(0).Item("First_Name").ToString
        lnV.Text = dt.Rows.Item(0).Item("Last_Name").ToString
        jdV.Text = dt.Rows.Item(0).Item("Join_Date").ToString
        stV.Text = dt.Rows.Item(0).Item("Status").ToString
        mnumV.Text = dt.Rows.Item(0).Item("Mobile").ToString
        dptV.Text = dt.Rows.Item(0).Item("Department").ToString
        idV.Text = dt.Rows.Item(0).Item("ID").ToString
        passV.Text = dt.Rows.Item(0).Item("Password").ToString
        dsV.Text = dt.Rows.Item(0).Item("Empl_Status").ToString
        searchVal1 = dt.Rows.Item(0).Item("Empl_Status").ToString
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub SearchTab(idToSearch As String)

        Dim searchRecord As String = "select * from table_2 where id = '" & idToSearch & " ' AND Empl_Status LIKE 'E" & searchVal1(1) & "'"
        Dim cmd As New SqlCommand(searchRecord, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub



    Public Sub runQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", idBox.Text)
        cmd.Parameters.AddWithValue("@Status", status.Text)
        cmd.Parameters.AddWithValue("@Mobile", mnum.Text)
        cmd.Parameters.AddWithValue("@Empl_Status", did.Text)

        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Sub clear()

        status.Clear()
        mnum.Clear()
        did.Clear()


    End Sub
    ' stop support function
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim SQL As String = " Select * from table_2 WHERE ID = '" & searchVal1 & "'"
        Dim cmd As New SqlCommand(SQL, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        con.Open()
        adapter = New SqlDataAdapter(SQL, con)
        adapter.Fill(dt)
    End Sub




    Private Sub btn_find_Click_1(sender As Object, e As EventArgs) Handles btn_find.Click
        SearchTab(search.Text)
    End Sub

    Private Sub viewall_Click(sender As Object, e As EventArgs) Handles viewall.Click
        Dim searchRecord As String = "select * from table_2  WHERE Empl_Status LIKE 'E" & searchVal1(1) & "'"
        Dim cmd As New SqlCommand(searchRecord, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateRecord As String = "update table_2 set Status=@Status,Mobile=@Mobile, Empl_Status = @Empl_Status WHERE id=@id AND Empl_Status LIKE 'E" & searchVal1(1) & "'"
        runQuery(updateRecord)
        lb_update.Text = "Record Updated"
        clear()
    End Sub

    Private Sub updateBtn_Click_1(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim updateRecord As String = "update table_2 set Mobile= '" & mnumV.Text & "', Password = '" & passV.Text & "' WHERE ID = '" & searchVal & "'"
        Dim cmd As New SqlCommand(updateRecord, con)

        cmd.ExecuteNonQuery()
        con.Close()
        lbUpdate.Text = "Record Updated"
    End Sub

    Private Sub logout_Click_1(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub
End Class