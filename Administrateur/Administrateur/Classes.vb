Imports System.Data.SqlClient
Public Class Classes
    Dim con As New SqlConnection(pdo.ConString)
    Dim cmd As New SqlCommand
    Dim co As New DataGridViewCheckBoxColumn
    Dim i As Integer
    Dim idClass As Integer
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
        GunaComboBox1.SelectedIndex = -1
        Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE Id_class IS NULL;", con)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        GunaDataGridView1.DataSource = table2

        co.HeaderText = "Select"
        co.Name = "Select"
        GunaDataGridView1.Columns.Insert(0, co)
    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        cmd = New SqlCommand("SELECT if_filier FROM class WHERE Id_class=" & GunaComboBox1.Text, con)
        Try
            i = cmd.ExecuteScalar
            cmd = New SqlCommand("SELECT NOM FROM FILIER WHERE ID_FILIER=" & i, con)
            GunaLabel1.Text = cmd.ExecuteScalar
        Catch ex As Exception

        End Try
        If WithoutRadioButton.Checked = True Then
            cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE ID_FILIER=" & i & " AND Id_class IS NULL;", con)
            MsgBox(i)
        Else
            cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE ID_FILIER=" & i & " ;", con)

        End If
        Try
            cmd.ExecuteScalar()
            Dim adapter2 As New SqlDataAdapter(cmd)
            Dim table2 As New DataTable
            adapter2.Fill(table2)
            GunaDataGridView1.DataSource = table2
        Catch ex As Exception
            MsgBox(ex.Message)
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


        If WithoutRadioButton.Checked Then
            cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE ID_FILIER=" & i & " AND Id_class IS NULL;", con)
        Else
            cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE ID_FILIER=" & i & ";", con)

        End If
        Try
            cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        ' Here ghadi ndir loop 3la li chekcer then ghan update kola wahd f ndir lih class dialo
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim j As Integer
        For j = 0 To GunaDataGridView1.Rows.Count - 1
            If CBool(GunaDataGridView1.Rows(j).Cells(0).Value) Then
                cmd = New SqlCommand("UPDATE ETUDIANT SET Id_class=" & GunaComboBox1.Text & " WHERE ID_ETUDIANT=" & GunaDataGridView1.Rows(j).Cells(7).Value, con)
                Try
                    cmd.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next
        If WithoutRadioButton.Checked = True Then
            cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT ,Id_class FROM ETUDIANT WHERE ID_FILIER=" & i & " AND Id_class IS NULL;", con)
        Else
            cmd = New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE ID_FILIER=" & i & " ;", con)
        End If
        Dim adapter2 As New SqlDataAdapter(cmd)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        GunaDataGridView1.DataSource = table2
        MsgBox("Saved")

    End Sub

    Private Sub WithRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WithRadioButton.CheckedChanged
        If WithRadioButton.Checked Then
            Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE ID_FILIER=" & i & ";", con)
            Dim adapter2 As New SqlDataAdapter(cmd2)
            Dim table2 As New DataTable
            adapter2.Fill(table2)
            GunaDataGridView1.DataSource = table2
        End If
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub WithoutRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WithoutRadioButton.CheckedChanged
        If WithoutRadioButton.Checked = True Then
            Dim cmd2 As New SqlCommand("SELECT NOM, PRENOM, ADRESSE, TELEPHONE, AUTRE_PHONE, SURNOM, ID_ETUDIANT,Id_class FROM ETUDIANT WHERE Id_class IS NULL;", con)
            Dim adapter2 As New SqlDataAdapter(cmd2)
            Dim table2 As New DataTable
            adapter2.Fill(table2)
            GunaDataGridView1.DataSource = table2
        End If

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub
End Class