Imports System.Data.SqlClient
Imports System.Text
Imports System.Net.FtpWebRequest
Imports System.Net
Imports System.IO
Public Class PaymentForm


    Dim stdID As Integer
    Dim stdName As String
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
    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        GunaComboBox1.SelectedIndex = -1
        Dim cmd3 As New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter3 As New SqlDataAdapter(cmd3)
        Dim table3 As New DataTable()
        adapter3.Fill(table3)
        GunaComboBox3.DataSource = table3
        GunaComboBox3.DisplayMember = "NOM"
        GunaComboBox3.ValueMember = "ID_FILIER"
        GunaComboBox3.SelectedIndex = -1
        Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM,id_class , ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT;", con)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        StudentsPaymentsDataGrid.DataSource = table2
        Dim files() As String = Directory.GetFiles("Images/")
        If files.Length <> 0 Then
            For Each deletefile In Directory.GetFiles("Images/", "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deletefile)
            Next
        End If
    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT ID_FILIER FROM FILIER WHERE NOM='" & GunaComboBox1.Text & "'", con)
        Dim idFilier As Integer = cmd.ExecuteScalar
        cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM,id_class, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT WHERE ID_FILIER=" & idFilier & ";", con)
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        StudentsPaymentsDataGrid.DataSource = table2
    End Sub

    Private Sub StudentsPaymentsDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsPaymentsDataGrid.CellClick
        Dim arr(11) As String
        arr(0) = "1- January"
        arr(1) = "2- February"
        arr(2) = "3- March"
        arr(3) = "4- April"
        arr(4) = "5- May"
        arr(5) = "6- June"
        arr(6) = "7- July"
        arr(7) = "8- August"
        arr(8) = "9- Septembre"
        arr(9) = "10- October"
        arr(10) = "11- November"
        arr(11) = "12- December"
        stdID = StudentsPaymentsDataGrid.CurrentRow.Cells(8).Value
        If My.Computer.FileSystem.FileExists("Images/" & StudentsPaymentsDataGrid.CurrentRow.Cells(5).Value) Then
            GunaPictureBox2.Image = Image.FromFile("Images/" & StudentsPaymentsDataGrid.CurrentRow.Cells(5).Value)
        Else
            My.Computer.Network.DownloadFile("ftp://" & pdo.ipServer & "/Administration/Student_Pictures/" & StudentsPaymentsDataGrid.CurrentRow.Cells(5).Value, "Images/" & StudentsPaymentsDataGrid.CurrentRow.Cells(5).Value, "miage", "miage")
            GunaPictureBox2.Image = Image.FromFile("Images/" & StudentsPaymentsDataGrid.CurrentRow.Cells(5).Value)
        End If
        FirstNameTextBox.Text = StudentsPaymentsDataGrid.CurrentRow.Cells(0).Value
        LastNameTextBox.Text = StudentsPaymentsDataGrid.CurrentRow.Cells(1).Value
        stdName = FirstNameTextBox.Text & " " & LastNameTextBox.Text
        AdressTextBox.Text = StudentsPaymentsDataGrid.CurrentRow.Cells(2).Value
        PhoneTextBoxt.Text = StudentsPaymentsDataGrid.CurrentRow.Cells(3).Value
        OtherPhoneTextBox.Text = StudentsPaymentsDataGrid.CurrentRow.Cells(4).Value
        UsernameTextBox.Text = StudentsPaymentsDataGrid.CurrentRow.Cells(6).Value
        Dim cmd2 As New SqlCommand("SELECT NOM FROM FILIER WHERE ID_FILIER=" & StudentsPaymentsDataGrid.CurrentRow.Cells(9).Value, con)
        GunaComboBox3.Text = cmd2.ExecuteScalar
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT NOM FROM ADMINISTRATEUR WHERE ID_ADMIN=" & StudentsPaymentsDataGrid.CurrentRow.Cells(8).Value, con)
        GunaLabel2.Text = cmd.ExecuteScalar
        cmd = New SqlCommand("SELECT PRENOM FROM ADMINISTRATEUR WHERE ID_ADMIN=" & StudentsPaymentsDataGrid.CurrentRow.Cells(8).Value, con)
        GunaLabel2.Text &= " " & cmd.ExecuteScalar
        GunaComboBox2.Items.Clear()
        For Each Month As String In arr
            cmd = New SqlCommand("SELECT count(*) FROM FACTURE WHERE ID_ETUDIANT=" & stdID & " AND MOISPAYE='" & Month & "';", con)
            Dim x As Integer = cmd.ExecuteScalar
            If x = 0 Then
                GunaComboBox2.Items.Add(Month)
            End If
        Next
    End Sub




    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("UPDATE ETUDIANT SET NOM='" & LastNameTextBox.Text & "', PRENOM='" & FirstNameTextBox.Text & "', ADRESSE='" & AdressTextBox.Text & "', TELEPHONE='" & PhoneTextBoxt.Text & "', AUTRE_PHONE='" & OtherPhoneTextBox.Text & "', SURNOM='" & UsernameTextBox.Text & "', ID_FILIER=" & GunaComboBox3.SelectedValue & " WHERE ID_ETUDIANT=" & stdID & ";", con)
        Dim i As Integer = MsgBox("Are you sure you want to update ?", vbYesNo)
        If i > 0 Then
            Try
                cmd.ExecuteScalar()
                MsgBox("Item Updated")
                stdID = Nothing
                FirstNameTextBox.Text = ""
                LastNameTextBox.Text = ""
                AdressTextBox.Text = ""
                PhoneTextBoxt.Text = ""
                OtherPhoneTextBox.Text = ""
                UsernameTextBox.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        StudentsPaymentsDataGrid.DataSource = table
    End Sub

    Private Sub StudentsPaymentsDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsPaymentsDataGrid.CellContentClick

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("DELETE FROM ETUDIANT WHERE ID_ETUDIANT=" & stdID & ";", con)

        Dim i As Integer = MsgBox("Are you sure you wanna delete " & stdName & "?", vbYesNo)
        If i > 0 Then
            Try
                cmd.ExecuteScalar()
                MsgBox("Item Deleted")

                FirstNameTextBox.Text = ""
                LastNameTextBox.Text = ""
                AdressTextBox.Text = ""
                PhoneTextBoxt.Text = ""
                OtherPhoneTextBox.Text = ""
                UsernameTextBox.Text = ""
                stdID = Nothing
                GunaPictureBox2.Image.Dispose()
                GunaPictureBox2.Image = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT;", con)
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        StudentsPaymentsDataGrid.DataSource = table2
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT;", con)
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        StudentsPaymentsDataGrid.DataSource = table2
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
      
        Dim cmd As New SqlCommand("INSERT INTO FACTURE (ID_ETUDIANT, ID_ADMIN, MONTANT, MOISPAYE, [DATE]) VALUES(" & stdID & "," & pdo.adminId & ", " & amountTextBox.Text & ", '" & GunaComboBox2.Text & "', '" & Date.Today & "');", con)
        If amountTextBox.Text <> "" Then

            cmd.ExecuteScalar()
            MsgBox("Payment Done")


            stdID = Nothing
            FirstNameTextBox.Text = ""
            LastNameTextBox.Text = ""
            AdressTextBox.Text = ""
            PhoneTextBoxt.Text = ""
            OtherPhoneTextBox.Text = ""
            UsernameTextBox.Text = ""
            amountTextBox.Text = ""
        Else
            MessageBox.Show("Please fill the Amount Field")
        End If

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmd As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT WHERE NOM LIKE '%" & BunifuTextbox1.text & "%' OR PRENOM LIKE '%" & BunifuTextbox1.text & "%';", con)
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        StudentsPaymentsDataGrid.DataSource = table2
    End Sub

    Private Sub GunaComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox3.SelectedIndexChanged

    End Sub
End Class