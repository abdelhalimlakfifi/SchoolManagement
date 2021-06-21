Imports System.Data.SqlClient
Imports System.Text
Public Class AdminForms
    Dim con As New SqlConnection(pdo.ConString)
    Dim cmd As New SqlCommand
    Dim id As Integer
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
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        ' cmd = New SqlCommand("UPDATE ADMINISTRATEUR SET NOM='" & FirstNameTextBox.Text & "', PRENOM='" & LastNameTextBox.Text & "', NUM_TELEPHONE='""', EMAIL='', SURNOM='', PASSWORD='' WHERE ID_ADMIN=0;", con)
        If PasswordTextBox.Text <> "" Then
            Dim i As Integer = MsgBox("Vous etes sure de mise ajoure le mots de passe ?", vbYesNo)
            If i > 0 Then
                cmd = New SqlCommand("UPDATE ADMINISTRATEUR SET NOM='" & FirstNameTextBox.Text & "', PRENOM='" & LastNameTextBox.Text & "', NUM_TELEPHONE='" & PhoneTextBox.Text & "', EMAIL='" & EmailTextbox1.Text & "', SURNOM='" & UsernameTextbox.Text & "', PASSWORD=HASHBYTES('SHA1','" & PasswordTextBox.Text & "') WHERE ID_ADMIN=" & id & ";", con)
            Else
                cmd = New SqlCommand("UPDATE ADMINISTRATEUR SET NOM='" & FirstNameTextBox.Text & "', PRENOM='" & LastNameTextBox.Text & "', NUM_TELEPHONE='" & PhoneTextBox.Text & "', EMAIL='" & EmailTextbox1.Text & "', SURNOM='" & UsernameTextbox.Text & "' WHERE ID_ADMIN=" & id & ";", con)
            End If
            Try
                cmd.ExecuteScalar()
                MsgBox("Item updated")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, EMAIL, SURNOM, ID_ADMIN FROM ADMINISTRATEUR;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table

        id = Nothing
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        PhoneTextBox.Text = ""
        EmailTextbox1.Text = ""
        UsernameTextbox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or PhoneTextBox.Text = "" Or EmailTextbox1.Text = "" Or UsernameTextbox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please Fill the blanks")
        Else
            cmd = New SqlCommand("INSERT INTO ADMINISTRATEUR (NOM, PRENOM, NUM_TELEPHONE, EMAIL, SURNOM, PASSWORD) VALUES('" & FirstNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & PhoneTextBox.Text & "', '" & EmailTextbox1.Text & "','" & UsernameTextbox.Text & "', HASHBYTES('SHA1','" & PasswordTextBox.Text & "'));", con)
            Try
                cmd.ExecuteScalar()
                MsgBox("Admin Saved")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, EMAIL, SURNOM, ID_ADMIN FROM ADMINISTRATEUR;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table

        id = Nothing
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        PhoneTextBox.Text = ""
        EmailTextbox1.Text = ""
        UsernameTextbox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub AdminForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, EMAIL, SURNOM, ID_ADMIN FROM ADMINISTRATEUR;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        PasswordTextBox.Text = RandomString()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        Dim cmd As New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, EMAIL, SURNOM, ID_ADMIN FROM ADMINISTRATEUR WHERE NOM LIKE '%" & BunifuTextbox1.text & "%' OR PRENOM LIKE '%" & BunifuTextbox1.text & "%';", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        id = GunaDataGridView1.CurrentRow.Cells(5).Value
        FirstNameTextBox.Text = GunaDataGridView1.CurrentRow.Cells(0).Value
        LastNameTextBox.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        PhoneTextBox.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
        EmailTextbox1.Text = GunaDataGridView1.CurrentRow.Cells(3).Value
        UsernameTextbox.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        cmd = New SqlCommand("DELETE FROM ADMINISTRATEUR WHERE ID_ADMIN=" & id, con)
        Dim i As Integer = MsgBox("Are you sure want to delete this items ?", vbYesNo)
        If i > 0 Then
            Try
                cmd.ExecuteScalar()
                MsgBox("Item Deleted")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, EMAIL, SURNOM, ID_ADMIN FROM ADMINISTRATEUR;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table

        id = Nothing
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        PhoneTextBox.Text = ""
        EmailTextbox1.Text = ""
        UsernameTextbox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, EMAIL, SURNOM, ID_ADMIN FROM ADMINISTRATEUR;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub
End Class