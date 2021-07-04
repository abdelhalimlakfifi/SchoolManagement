Imports System.Data.SqlClient
Public Class New_Class
    Dim con As New SqlConnection(pdo.ConString)
    Private Sub New_Class_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("INSERT INTO class (ID_FILIER) VALUES(" & GunaComboBox1.SelectedValue & ")", con)
        Try
            cmd.ExecuteScalar()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Classes.refresh()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Me.Hide()
    End Sub
End Class