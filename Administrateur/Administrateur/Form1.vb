Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using StreamReader As New StreamReader("Cookie.txt")
                Dim connection As New SqlConnection("Data Source=" & StreamReader.ReadLine() & ";Initial Catalog=miage;User ID=sa; Password=Miage@095006")
                connection.Open()
            End Using

        Catch ex As Exception
            IPServerForm.Show()

        End Try

    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
