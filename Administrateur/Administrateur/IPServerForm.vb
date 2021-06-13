Imports System.IO
Imports System.Data.SqlClient
Public Class IPServerForm
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim connection As New SqlConnection("Data Source=" & GunaLineTextBox1.Text & ";Initial Catalog=miage;User ID=sa; Password=Miage@095006")
        If connection.State = ConnectionState.Closed Then
            Try
                connection.Open()
                Using StreamWriter As New StreamWriter("Cookie.txt")
                    StreamWriter.WriteLine(GunaLineTextBox1.Text)
                End Using
                Label1.Text = "Activated"
                Label1.ForeColor = Color.Green

            Catch ex As Exception
                MsgBox("Please check the IP adress")
            End Try
        End If
    End Sub

    Private Sub IPServerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Form1.Enabled = False
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If Label1.Text = "Activated" Then
            Me.Close()
        Else
            Application.Exit()


        End If
    End Sub
End Class