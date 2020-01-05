Imports System.Data.SqlClient



Public Class Employee_Window


    Public searchVal As String
    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")




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

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim updateRecord As String = "update table_2 set Mobile= '" & mnumV.Text & "', Password = '" & passV.Text & "' WHERE ID = '" & searchVal & "'"
        Dim cmd As New SqlCommand(updateRecord, con)

        cmd.ExecuteNonQuery()
        con.Close()
        lbUpdate.Text = "Record Updated"
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        Dim SQL As String = " Select * from table_2 WHERE ID = '" & searchVal & "'"
        Dim cmd As New SqlCommand(SQL, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        con.Open()
        adapter = New SqlDataAdapter(SQL, con)
        adapter.Fill(dt)
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub
End Class