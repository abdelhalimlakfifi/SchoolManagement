Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Dim MoveX, MoveY As Integer
    Dim newpoint As New Point
    Sub methode()
        Dim frm As Loading = New Loading
        Application.Run(frm)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim thr As New Threading.Thread(AddressOf methode)
        thr.IsBackground = True
        thr.Start()
        Try
            Using StreamReader As New StreamReader("Cookie.txt")
                Dim connection As New SqlConnection("Data Source=" & StreamReader.ReadLine() & ";Initial Catalog=miage;User ID=sa; Password=Miage@095006")
                connection.Open()
            End Using

        Catch ex As Exception
            IPServerForm.Show()
            Loading.Hide()
        End Try

    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaVSeparator1_Click(sender As Object, e As EventArgs) Handles GunaVSeparator1.Click

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        MoveX = Control.MousePosition.X - Me.Location.X
        MoveY = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= MoveX
            newpoint.Y -= MoveY
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
