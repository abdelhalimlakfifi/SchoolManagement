Imports System.Data.SqlClient
Imports System.IO
Public Module ipAdress
    Public ip As String
End Module
Public Class Login
    Dim MoveX, MoveY As Integer
    Dim newpoint As New Point
    Public ip As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.isPassword = True
        Try
            Using StreamReader As New StreamReader("Cookie.txt")
                pdo.ipServer = StreamReader.ReadLine()
                pdo.ConString = "Data Source=" & pdo.ipServer & ";Initial Catalog=miage;User ID=sa; Password=Miage@095006"
                Dim connection As New SqlConnection(pdo.ConString)
                connection.Open()

                connection.Close()
            End Using
        Catch ex As Exception

            IPServerForm.Show()

        End Try
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

    

    Private Sub GunaSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaSwitch1.CheckedChanged
        If GunaSwitch1.Checked Then
            PasswordTextBox.isPassword = False
        Else
            PasswordTextBox.isPassword = True
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim connection As New SqlConnection(pdo.ConString)
        connection.Open()
        If EmailTextBox.Text <> "" And PasswordTextBox.Text <> "" Then
            Dim cmd As New SqlCommand("SELECT count(*) FROM ADMINISTRATEUR WHERE SURNOM='" & EmailTextBox.Text & "' AND PASSWORD=HASHBYTES('SHA1','" & PasswordTextBox.Text & "')", connection)
            Dim count As Integer = Convert.ToInt16(cmd.ExecuteScalar())
            If count > 0 Then
                Dim cmd2 As New SqlCommand("SELECT ID_ADMIN FROM ADMINISTRATEUR WHERE SURNOM='" & EmailTextBox.Text & "' AND PASSWORD=HASHBYTES('SHA1','" & PasswordTextBox.Text & "')", connection)
                count = Convert.ToInt16(cmd2.ExecuteScalar())
                pdo.adminId = count
                Home.Show()
                Me.Hide()
            Else
                MessageBox.Show("Your information are incorrect")
            End If

        Else
            MessageBox.Show("Please fill the informrations")
        End If
    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click

    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click

    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub PasswordTextBox_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordTextBox_OnValueChanged_1(sender As Object, e As EventArgs) Handles PasswordTextBox.OnValueChanged
        PasswordTextBox.isPassword = True
        GunaSwitch1.Checked = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
