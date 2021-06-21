Imports System.Text
Imports System.Data.SqlClient
Public Class TechersForms
    Dim ProfId As Integer
    Dim con As New SqlConnection(pdo.ConString)
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
    Private Sub TechersForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, SALAIRE, CIN, SURNOM, ID_PROF, ID_ADMIN FROM PROF;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        PasswordTextBox.Text = RandomString()
    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        ProfId = GunaDataGridView1.CurrentRow.Cells(6).Value
        FirstNameTextBox.Text = GunaDataGridView1.CurrentRow.Cells(0).Value
        LastNameTextBox.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        PhoneTextBox.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
        SalaryNumeric.Text = GunaDataGridView1.CurrentRow.Cells(3).Value
        CIN_TextBox.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
        UsernameTextbox.Text = GunaDataGridView1.CurrentRow.Cells(5).Value

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Dim cmd As New SqlCommand
        Dim i As Integer = MsgBox("Are you sure want to delete this teacher ?", vbYes)
        If i > 0 Then
            cmd = New SqlCommand("DELETE FROM PROF WHERE ID_PROF=" & ProfId & ";", con)
            Try
                cmd.ExecuteScalar()
                MessageBox.Show("Item deleted")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, SALAIRE, CIN, SURNOM, ID_PROF, ID_ADMIN FROM PROF;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand
        If PasswordTextBox.Text <> "" Then
            cmd = New SqlCommand("UPDATE PROF SET NOM='" & FirstNameTextBox.Text & "', PRENOM='" & LastNameTextBox.Text & "', NUM_TELEPHONE='" & PhoneTextBox.Text & "', SALAIRE=" & SalaryNumeric.Text & ", CIN='" & CIN_TextBox.Text & "', SURNOM='" & UsernameTextbox.Text & "', PASSWORD=HASHBYTES('SHA1','" & PasswordTextBox.Text & "') WHERE ID_PROF=" & ProfId & ";", con)
            Dim i As Integer = MsgBox("Are You sure want to update the password ?", vbYesNo)
            If i > 0 Then
                cmd.ExecuteScalar()
            End If
        Else
            cmd = New SqlCommand("UPDATE PROF SET NOM='" & FirstNameTextBox.Text & "', PRENOM='" & LastNameTextBox.Text & "', NUM_TELEPHONE='" & PhoneTextBox.Text & "', SALAIRE=" & SalaryNumeric.Text & ", CIN='" & CIN_TextBox.Text & "', SURNOM='" & UsernameTextbox.Text & "' WHERE ID_PROF=" & ProfId & ";", con)
            cmd.ExecuteScalar()
        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, SALAIRE, CIN, SURNOM, ID_PROF, ID_ADMIN FROM PROF;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
        MessageBox.Show("Item Updated")
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand
        If FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or PhoneTextBox.Text = "" Or CIN_TextBox.Text = "" Or UsernameTextbox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please fill the fields")
        Else
            cmd = New SqlCommand("INSERT INTO PROF (ID_ADMIN, NOM, PRENOM, NUM_TELEPHONE, SALAIRE, CIN, SURNOM, PASSWORD) VALUES(" & pdo.adminId & ", '" & FirstNameTextBox.Text & "', '" & LastNameTextBox.Text & "', '" & PhoneTextBox.Text & "'," & Val(SalaryNumeric.Text) & ", '" & CIN_TextBox.Text & "', '" & UsernameTextbox.Text & "', HASHBYTES('SHA1','" & PasswordTextBox.Text & "'));", con)
            cmd.ExecuteScalar()
            MessageBox.Show("Teacher Added.")
        End If
        cmd = New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, SALAIRE, CIN, SURNOM, ID_PROF, ID_ADMIN FROM PROF;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Dim cmd As New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, SALAIRE, CIN, SURNOM, ID_PROF, ID_ADMIN FROM PROF;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        Dim cmd As New SqlCommand("SELECT NOM, PRENOM, NUM_TELEPHONE, SALAIRE, CIN, SURNOM, ID_PROF, ID_ADMIN FROM PROF WHERE NOM LIKE '%" & BunifuTextbox1.text & "%' OR PRENOM LIKE '%" & BunifuTextbox1.text & "%';", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub
End Class