Imports System.IO.File
Imports System.IO.FileStream
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports System.Net.FtpWebRequest
Public Class Students
    Private Function FtpFolderCreate(folder_name As String, username As String, password As String) As Boolean
        Dim request As Net.FtpWebRequest = CType(FtpWebRequest.Create(folder_name), FtpWebRequest)
        request.Credentials = New NetworkCredential(username, password)
        request.Method = WebRequestMethods.Ftp.MakeDirectory
        Try
            Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
                ' Folder created
            End Using
        Catch ex As WebException
            Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
            ' an error occurred
            If response.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                Return False
            End If
        End Try
        Return True
    End Function
    Function RandomString()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Dim con As New SqlConnection(pdo.ConString)
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        OpenFileDialog1.ShowDialog()
        PicturePathTextbox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub BunifuMaterialTextbox11_OnValueChanged(sender As Object, e As EventArgs) Handles PicturePathTextbox.OnValueChanged
        If (System.IO.File.Exists(PicturePathTextbox.Text)) Then
            GunaPictureBox2.Image = Image.FromFile(PicturePathTextbox.Text)
        End If
        If PicturePathTextbox.Text = "" Then
            GunaPictureBox2.Hide()
        Else
            GunaPictureBox2.Show()
        End If
    End Sub

    Private Sub BunifuMaterialTextbox10_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel2.Paint

    End Sub


    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaComboBox1.DataSource = table
        GunaComboBox1.DisplayMember = "NOM"
        GunaComboBox1.ValueMember = "ID_FILIER"
        con.Close()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim foldername As String
        Dim cmd As New SqlCommand("SELECT ID_FILIER FROM FILIER WHERE NOM LIKE '" & GunaComboBox1.Text & "'", con)
        'MsgBox(cmd.ExecuteScalar)
        Try
            foldername = FirstNameTextBox.Text.Replace(" ", "_") & "_" & LastNameTextBox.Text.Replace(" ", "_") & "_" & Format(Now, "dd_MM_yyyy_hh_mm_ss")
            Dim cmd2 As New SqlCommand("INSERT INTO ETUDIANT(ID_ADMIN, ID_FILIER, NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, MOTS_DE_PASSE) VALUES(" & pdo.adminId & "," & cmd.ExecuteScalar & ",'" & LastNameTextBox.Text & "', '" & FirstNameTextBox.Text & "', '" & AdressTextBox.Text & "', '" & PhoneTextBoxt.Text & "', '" & OtherPhoneTextBox.Text & "', '" & foldername & ".jpg" & "', '" & UsernameTextBox.Text & "', HASHBYTES('SHA1','" & PasswordTextBox.Text & "'))", con)
            Dim i = cmd2.ExecuteScalar


            FtpFolderCreate("ftp://" & pdo.ipServer & "/students/" & foldername & "/", "miage", "miage")
            My.Computer.Network.UploadFile(PicturePathTextbox.Text, "ftp://" & pdo.ipServer & "/" & "Administration/Student_Pictures/" & foldername & ".jpg", "miage", "miage", True, 500)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Username already exist")
        End Try
        
        'MessageBox.Show(i)
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        PasswordTextBox.Text = RandomString()
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click

    End Sub
End Class