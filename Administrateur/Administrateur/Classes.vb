Imports System.Data.SqlClient
Public Class Classes
    Dim con As New SqlConnection(pdo.ConString)
    Dim cmd As New SqlCommand
    Public Sub refresh()
        cmd = New SqlCommand("SELECT * FROM class", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaComboBox1.DataSource = table
        GunaComboBox1.DisplayMember = "Id_class"
        GunaComboBox1.ValueMember = "Id_class"
    End Sub
    Private Sub Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WithoutRadioButton.Checked = True
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("SELECT * FROM class", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaComboBox1.DataSource = table
        GunaComboBox1.DisplayMember = "Id_class"
        GunaComboBox1.ValueMember = "Id_class"

        Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM FROM ETUDIANT WHERE Id_class IS NULL;", con)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        GunaDataGridView1.DataSource = table2
        Dim co As New DataGridViewCheckBoxColumn
        co.HeaderText = "Select"
        co.Name = "Select"
        GunaDataGridView1.Columns.Insert(0, co)
    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged

        cmd = New SqlCommand("SELECT if_filier FROM class WHERE Id_class=" & GunaComboBox1.Text, con)
        Try
            Dim i As Integer = cmd.ExecuteScalar
            cmd = New SqlCommand("SELECT NOM FROM FILIER WHERE ID_FILIER=" & i, con)
            GunaLabel1.Text = cmd.ExecuteScalar
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        New_Class.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        cmd = New SqlCommand("SELECT * FROM class", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaComboBox1.DataSource = table
        GunaComboBox1.DisplayMember = "Id_class"
        GunaComboBox1.ValueMember = "Id_class"
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        ' Here ghadi ndir loop 3la li chekcer then ghan update kola wahd f ndir lih class dialo 
    End Sub

    Private Sub WithRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WithRadioButton.CheckedChanged
        If WithRadioButton.Checked Then
            Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM FROM ETUDIANT;", con)
            Dim adapter2 As New SqlDataAdapter(cmd2)
            Dim table2 As New DataTable
            adapter2.Fill(table2)
            GunaDataGridView1.DataSource = table2
            Dim co As New DataGridViewCheckBoxColumn
            co.HeaderText = "Select"
            co.Name = "Select"
            GunaDataGridView1.Columns.Insert(0, co)
        End If
    End Sub
End Class