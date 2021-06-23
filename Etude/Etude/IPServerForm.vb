Imports System.IO
Imports System.Data.SqlClient
Public Class IPServerForm
    Dim MoveX, MoveY As Integer
    Dim newpoint As New Point
    Private Sub IPServerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Login.Enabled = False
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim connection As New SqlConnection("Data Source=" & BunifuTextbox1.text & ";Initial Catalog=miage;User ID=sa; Password=Miage@095006")
        If connection.State = ConnectionState.Closed Then
            Try
                connection.Open()
                Using StreamWriter As New StreamWriter("Cookie.txt")
                    StreamWriter.WriteLine(BunifuTextbox1.text)
                End Using
                BunifuSwitch1.Value = True
                MsgBox("SVP redemarrer l'application pour l'utiliser")
                Application.Restart()
            Catch ex As Exception
                MsgBox("Please check the IP adress")
            End Try
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If BunifuSwitch1.Value = True Then
            Login.Enabled = True
            Login.Show()
            Me.Hide()
            'Me.Close()

        Else
            Application.Exit()


        End If
    End Sub
End Class