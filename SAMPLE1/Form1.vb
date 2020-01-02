Imports System.Data.SqlClient



Public Class Form1


    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")
    Private Sub btnAdd_Click(ByVal sender As System.Object, e As EventArgs) Handles btnAdd.Click
        Dim insertquery As String = "insert into table_2(First_Name,Last_Name,Join_Date,Status,Mobile,Department) values(@First_Name,@Last_Name,@Join_Date,@Status,@Mobile,@Department)"
        If System.Text.RegularExpressions.Regex.IsMatch(fname.Text.ToString, "^[0-9 ]+$") And System.Text.RegularExpressions.Regex.IsMatch(fname.Text.ToString, "^[0-9 ]+$") Then
            MsgBox("Please Valid Name ")
        Else
            runQuery(insertquery)
        End If


        lbmsg.Text = "New Record"
        clear()
    End Sub

    Public Sub runQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", idBox.Text)
        cmd.Parameters.AddWithValue("@First_Name", fname.Text)
        cmd.Parameters.AddWithValue("@Last_Name", lname.Text)
        cmd.Parameters.AddWithValue("@Join_Date", jDate.Text)
        cmd.Parameters.AddWithValue("@Status", status.Text)
        cmd.Parameters.AddWithValue("@Mobile", mnum.Text)
        cmd.Parameters.AddWithValue("@Department", depart.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub clear()
        fname.Clear()
        lname.Clear()
        jDate.Clear()
        status.Clear()
        mnum.Clear()
        depart.Clear()


    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles lbmsg.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateRecord As String = "update table_2 set First_Name=@First_Name,Last_Name=@Last_Name,Join_Date=@Join_Date,Status=@Status,Mobile=@Mobile,Department = @Department WHERE id=@id"
        runQuery(updateRecord)
        lbmsg.Text = "Record Updated"
        clear()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If search.Text = String.Empty Then
            MsgBox("Please put a field to search ! ")
        Else
            Dim crt As New ReportView(search.Text)
            crt.Show()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles ID.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteRecord As String = " delete table_2 where id =@id"
        runQuery(deleteRecord)
        lbmsg.Text = " Deleted"
        clear()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        SearchTab("")
    End Sub
    Public Sub SearchTab(idToSearch As String)

        Dim searchRecord As String = "select * from table_2 where id = '" & idToSearch & " '"
        Dim cmd As New SqlCommand(searchRecord, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchTab(search.Text)
    End Sub
End Class
