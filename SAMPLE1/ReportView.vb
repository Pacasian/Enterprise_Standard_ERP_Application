Public Class ReportView
    Public searchVal As String
    Dim Price As Integer

    Public searchVal1 As String

    Public Sub New(ByVal vale As String)

        ' This call is required by the designer.
        InitializeComponent()
        searchVal = vale
        Int32.TryParse(searchVal, Price)

        CrystalReportViewer1.ReportSource = Application.StartupPath + "\CrystalReport5.rpt"
        CrystalReportViewer1.SelectionFormula = "{table_2.ID} = " & Price.ToString & ""
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub lb_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class