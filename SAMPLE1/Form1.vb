Imports System.Data.SqlClient



Public Class Form1


    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")
    Private Sub btnAdd_Click(ByVal sender As System.Object, e As EventArgs)
        Dim insertquery As String = "insert into table_2(First_Name,Last_Name,Join_Date,Status,Mobile,Department,Password,Empl_Status) values(@First_Name,@Last_Name,@Join_Date,@Status,@Mobile,@Department,@Password,@Empl_Status)"
        Dim fn As Boolean = False
        Dim ln As Boolean = False
        ln = False
        fn = False
        For i = 1 To Len(fname.Text.ToString)
            If IsNumeric(Mid(fname.Text.ToString, i, 1)) Then
                MsgBox("Please, Enter a valid First Name !")
                fn = False
                Exit For
            Else
                fn = True
            End If
        Next
        For i = 1 To Len(lname.Text.ToString)
            If IsNumeric(Mid(lname.Text.ToString, i, 1)) Then
                MsgBox("Please, Enter a valid Last Name !")
                ln = False
                Exit For
            Else
                ln = True
            End If
        Next
        lbmsg.Text = fn
        If Not fn Then
            MsgBox("Exopression Not valid (Error FNNUM)")
            ln = False
            fn = False

        ElseIf Not ln Then
            MsgBox("Exopression Not valid (Error LNNUM)")
            ln = False
            fn = False
        Else
            runQuery(insertquery)
            MsgBox("Successfully Added")
            ln = False
            fn = False
        End If

        'If System.Text.RegularExpressions.Regex.IsMatch(fname.Text.ToString, "^[0-9 ]+$") And System.Text.RegularExpressions.Regex.IsMatch(fname.Text.ToString, "^[0-9 ]+$") Then
        'MsgBox("please valid name ")
        'Else
        'runQuery(insertquery)
        'End If



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
        cmd.Parameters.AddWithValue("@Password", Password.Text)
        cmd.Parameters.AddWithValue("@Empl_Status", did.Text)
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
        Password.Clear()
        did.Clear()


    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles lbmsg.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim updateRecord As String = "update table_2 set First_Name=@First_Name,Last_Name=@Last_Name,Join_Date=@Join_Date,Status=@Status,Mobile=@Mobile,Department = @Department, Password= @Password, Empl_Status = @Empl_Status WHERE id=@id"
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

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim deleteRecord As String = " delete table_2 where id =@id"
        runQuery(deleteRecord)
        lbmsg.Text = " Deleted"
        clear()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        SearchTab(search.Text)
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim insertquery As String = "insert into table_2(First_Name,Last_Name,Join_Date,Status,Mobile,Department,Password,Empl_Status) values(@First_Name,@Last_Name,@Join_Date,@Status,@Mobile,@Department,@Password,@Empl_Status)"
        Dim fn As Boolean = False
        Dim ln As Boolean = False
        ln = False
        fn = False
        For i = 1 To Len(fname.Text.ToString)
            If IsNumeric(Mid(fname.Text.ToString, i, 1)) Then
                MsgBox("Please, Enter a valid First Name !")
                fn = False
                Exit For
            Else
                fn = True
            End If
        Next
        For i = 1 To Len(lname.Text.ToString)
            If IsNumeric(Mid(lname.Text.ToString, i, 1)) Then
                MsgBox("Please, Enter a valid Last Name !")
                ln = False
                Exit For
            Else
                ln = True
            End If
        Next
        lbmsg.Text = fn
        If Not fn Then
            MsgBox("Exopression Not valid (Error FNNUM)")
            ln = False
            fn = False

        ElseIf Not ln Then
            MsgBox("Exopression Not valid (Error LNNUM)")
            ln = False
            fn = False
        Else
            runQuery(insertquery)
            MsgBox("Successfully Added")
            ln = False
            fn = False
        End If

        'If System.Text.RegularExpressions.Regex.IsMatch(fname.Text.ToString, "^[0-9 ]+$") And System.Text.RegularExpressions.Regex.IsMatch(fname.Text.ToString, "^[0-9 ]+$") Then
        'MsgBox("please valid name ")
        'Else
        'runQuery(insertquery)
        'End If



        clear()
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateRecord As String = "update table_2 set First_Name=@First_Name,Last_Name=@Last_Name,Join_Date=@Join_Date,Status=@Status,Mobile=@Mobile,Department = @Department, Password= @Password, Empl_Status = @Empl_Status WHERE id=@id"
        runQuery(updateRecord)
        lbmsg.Text = "Record Updated"
        clear()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteRecord As String = " delete table_2 where id =@id"
        runQuery(deleteRecord)
        lbmsg.Text = " Deleted"
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        SearchTab("")
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchTab(search.Text)
    End Sub

    Private Sub btn_LogOut_Click(sender As Object, e As EventArgs) Handles btn_LogOut.Click
        Me.Close()
    End Sub
End Class
