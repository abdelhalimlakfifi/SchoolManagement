Imports System.Data.SqlClient
Imports System.IO
Public Class Login
    Dim MoveX, MoveY As Integer
    Dim newpoint As New Point
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim connection As New SqlConnection(pdo.ConString)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If UsernameTextbox.Text <> "" And PasswordTextbox.Text <> "" Then
            Dim cmd As New SqlCommand("SELECT count(*) FROM ETUDIANT WHERE SURNOM='" & UsernameTextbox.Text & "' AND MOTS_DE_PASSE=HASHBYTES('SHA1','" & PasswordTextbox.Text & "')", connection)
            Dim count As Integer = Convert.ToInt16(cmd.ExecuteScalar)
            If count > 0 Then
                cmd = New SqlCommand("SELECT ID_ETUDIANT FROM ETUDIANT WHERE SURNOM='" & UsernameTextbox.Text & "' AND MOTS_DE_PASSE=HASHBYTES('SHA1','" & PasswordTextbox.Text & "')", connection)
                pdo.student_Id = Convert.ToInt16(cmd.ExecuteScalar)
                cmd = New SqlCommand("SELECT PHOTOS FROM ETUDIANT WHERE SURNOM='" & UsernameTextbox.Text & "' AND MOTS_DE_PASSE=HASHBYTES('SHA1','" & PasswordTextbox.Text & "')", connection)
                pdo.path = System.IO.Path.ChangeExtension(cmd.ExecuteScalar, Nothing)

                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Verifier votre information !")
            End If
        Else
            MessageBox.Show("SVP Saisir votre information !")
        End If
        'Form2.Show()
        'Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextbox.isPassword = True
        Try
            Using StreamReader As New StreamReader("Cookie.txt")
                pdo.ipServer = StreamReader.ReadLine()
                pdo.ConString = "Data Source=" & pdo.ipServer & ";Initial Catalog=miage;User ID=sa; Password=Miage@095006"
                Dim connection As New SqlConnection(pdo.ConString)
                connection.Open()

                connection.Close()
            End Using
        Catch ex As Exception
            Me.Hide()
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        If BunifuCheckbox1.Checked = True Then
            PasswordTextbox.isPassword = False
        Else
            PasswordTextbox.isPassword = True
        End If
    End Sub

    Private Sub PasswordTextbox_OnValueChanged(sender As Object, e As EventArgs) Handles PasswordTextbox.OnValueChanged
        PasswordTextbox.isPassword = True
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click
        If BunifuCheckbox1.Checked = True Then
            BunifuCheckbox1.Checked = False
            PasswordTextbox.isPassword = True
        Else
            BunifuCheckbox1.Checked = True
            PasswordTextbox.isPassword = False
        End If
    End Sub
End Class