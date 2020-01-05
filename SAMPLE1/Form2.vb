Imports System.Data.SqlClient




Public Class Form2


    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Logn.Click
        If Not String.IsNullOrEmpty(empID.Text) And Not String.IsNullOrEmpty(passWord.Text) Then
            Dim SQL As String = " Select * from table_2 WHERE ID = '" & empID.Text & "' AND Password = '" & passWord.Text & "'"
            Dim cmd As New SqlCommand(SQL, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            con.Open()
            adapter = New SqlDataAdapter(SQL, con)
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Empl_Status").Substring(0, 1).ToString.ToUpper = "A" Then
                    Dim crt As New Form1()
                    crt.Show()
                ElseIf dt.Rows.Item(0).Item("Empl_Status").Substring(0, 1).ToString.ToUpper = "H" Then
                    Dim crt As New Head_Of_Department(dt.Rows.Item(0).Item("ID").ToString.ToUpper)
                    crt.Show()
                ElseIf dt.Rows.Item(0).Item("Empl_Status").Substring(0, 1).ToString.ToUpper = "E" Then
                    Dim crt As New Employee_Window(dt.Rows.Item(0).Item("ID").ToString.ToUpper)
                    crt.Show()
                Else
                    MsgBox("Unassigned Job title")
                End If
            Else
                    MsgBox("Invalid Employee Data")
            End If
            con.Close()
        Else
            MsgBox("Please fill the Employee ID and Password !")
        End If
    End Sub

End Class