Imports System.Data.SqlClient
Public Class gradeForm
    Dim con As New SqlConnection(pdo.ConString)
    Dim cmd As New SqlCommand
    Dim studentId As Integer
    Private Sub gradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmd = New SqlCommand("SELECT ID_PROF, [NOM] + ' ' + [PRENOM] As Fullname FROM PROF", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("SELECT Id_class, if_filier FROM class", con)
        Dim ap As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()
        ap.Fill(tb)
        ClassComboBox1.DataSource = tb
        ClassComboBox1.DisplayMember = "Id_class"
        ClassComboBox1.ValueMember = "if_filier"
        ClassComboBox1.SelectedValue = -1
        cmd = New SqlCommand("SELECT  NOM, PRENOM, SURNOM, Id_class, ID_ETUDIANT, ID_FILIER FROM ETUDIANT;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        BunifuCustomDataGrid1.DataSource = table

        cmd = New SqlCommand("SELECT ID_MODULE, MODULE FROM MODULE", con)
        Dim ap2 As New SqlDataAdapter(cmd)
        Dim tb2 As New DataTable
        ap2.Fill(tb2)
        GunaComboBox2.DataSource = tb2
        GunaComboBox2.DisplayMember = "MODULE"
        GunaComboBox2.ValueMember = "ID_MODULE"
        GunaComboBox2.SelectedValue = -1
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        StudentTextbox.Text = BunifuCustomDataGrid1.CurrentRow.Cells(0).Value & " " & BunifuCustomDataGrid1.CurrentRow.Cells(1).Value
        studentId = BunifuCustomDataGrid1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClassComboBox1.SelectedIndexChanged
        Dim Idclass As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'MsgBox(ClassComboBox1.SelectedValue.ToString)
        'If ClassComboBox1.SelectedValue Then
        Try
            cmd = New SqlCommand("SELECT NOM FROM FILIER WHERE ID_FILIER=" & Val(ClassComboBox1.SelectedValue.ToString), con)
            GunaLabel3.Text = cmd.ExecuteScalar
            Idclass = ClassComboBox1.Text
        Catch ex As Exception

        End Try



        cmd = New SqlCommand("SELECT  NOM, PRENOM, SURNOM, Id_class, ID_ETUDIANT, ID_FILIER FROM ETUDIANT WHERE Id_class=" & Idclass & ";", con)
        Try
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            BunifuCustomDataGrid1.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If remarqueTextbox1.Text <> "" And gradesTextBox.Text <> "" Then
            cmd = New SqlCommand("INSERT INTO NOTES(ID_MODULE, ID_ETUDIANT, LA_NOTE, REMARQUE) VALUES(" & GunaComboBox2.SelectedValue & "," & studentId & "," & Val(gradesTextBox.Text) & ",'" & remarqueTextbox1.Text & "')", con)
            Try
                cmd.ExecuteScalar()
                MsgBox("Grade saved")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class