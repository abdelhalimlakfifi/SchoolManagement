Imports System.Data.SqlClient
Public Class AbsencesForm
    Dim con As New SqlConnection(pdo.ConString)
    Dim stdId As Integer
    Dim IdProf As Integer
    Private Sub AbsencesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaComboBox2.DataSource = table
        GunaComboBox2.DisplayMember = "NOM"
        GunaComboBox2.ValueMember = "ID_FILIER"
        GunaComboBox2.SelectedIndex = -1
        Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT;", con)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        BunifuCustomDataGrid1.DataSource = table2

        cmd = New SqlCommand("SELECT * FROM PROF;", con)
        adapter = New SqlDataAdapter(cmd)
        Dim table3 As New DataTable()
        adapter.Fill(table3)
        GunaComboBox1.DataSource = table3
        GunaComboBox1.DisplayMember = "NOM"
        GunaComboBox1.ValueMember = "ID_PROF"
        'GunaComboBox1.SelectedIndex = -1
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        GunaTextBox1.Text = BunifuCustomDataGrid1.CurrentRow.Cells(0).Value
        GunaTextBox2.Text = BunifuCustomDataGrid1.CurrentRow.Cells(1).Value
        stdId = BunifuCustomDataGrid1.CurrentRow.Cells(7).Value
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT;", con)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        BunifuCustomDataGrid1.DataSource = table2
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Dim cmd As New SqlCommand("INSERT INTO ABSENCE(ID_ETUDIANT, [DATE], ID_PROF) VALUES(" & stdId & ", '" & BunifuDatepicker1.Value & "', " & IdProf & ");", con)
        Try
            cmd.ExecuteScalar()
            MessageBox.Show("Record saved successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged

    End Sub

    Private Sub GunaComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedValueChanged
        IdProf = Val(GunaComboBox1.SelectedValue.ToString)

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmd As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT WHERE NOM LIKE '%" & BunifuTextbox1.text & "%' OR PRENOM LIKE '%" & BunifuTextbox1.text & "%';", con)
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        BunifuCustomDataGrid1.DataSource = table2

    End Sub

    Private Sub GunaComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox2.SelectedIndexChanged
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT ID_FILIER FROM FILIER WHERE NOM='" & GunaComboBox2.Text & "'", con)
        Dim idFilier As Integer = cmd.ExecuteScalar
        cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, PHOTOS, SURNOM, ID_ETUDIANT, ID_ADMIN, ID_FILIER FROM ETUDIANT WHERE ID_FILIER=" & idFilier & ";", con)
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        BunifuCustomDataGrid1.DataSource = table2
    End Sub
End Class