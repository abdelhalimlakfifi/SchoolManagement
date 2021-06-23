Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Data.SqlClient

Public Class Notes
    Private cs As New SqlConnection(pdo.ConString)
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim cmd As New SqlCommand("SELECT * FROM NOTES WHERE ID_ETUDIANT=" & pdo.student_Id, cs)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        TestlistBunifuCustomDataGrid1.DataSource = table

    End Sub
    Private Function getTestlist() As DataTable
        Dim dtTest As New DataTable

        Return dtTest


    End Function

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim cmd As New SqlCommand("SELECT * FROM NOTES WHERE ID_ETUDIANT=" & pdo.student_Id, cs)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        TestlistBunifuCustomDataGrid1.DataSource = table


    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
