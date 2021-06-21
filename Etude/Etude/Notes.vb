Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Data.SqlClient

Public Class Notes
    Private cs As New SqlConnection("Data Source=192.168.1.101;Initial Catalog=miage;User ID=sa; Password=Miage@095006")
    Private da As New SqlDataAdapter("SELECT * FROM NOTES", cs)
    Private ds As New DataSet
    Private cmb As New SqlCommandBuilder(da)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MiageDataSet.NOTES' table. You can move, or remove it, as needed.
        'Me.NOTESTableAdapter.Fill(Me.MiageDataSet.NOTES)
        Try
            da.Fill(ds, "NOTES")
            TestlistBunifuCustomDataGrid1.DataSource = ds.Tables("NOTES")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Function getTestlist() As DataTable
        Dim dtTest As New DataTable

        Return dtTest


    End Function

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim cs As New SqlConnection("Data Source=192.168.1.101;Initial Catalog=miage;User ID=sa; Password=Miage@095006")
        Dim da As New SqlDataAdapter("SELECT * FROM NOTES", cs)
        Dim ds As New DataSet
        Dim cmb As New SqlCommandBuilder(da)
        da.Fill(ds, "NOTES")
        GunaComboBox1.DisplayMember = "NOTES"
        GunaComboBox1.ValueMember = "NOTES"


    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

    End Sub
End Class
