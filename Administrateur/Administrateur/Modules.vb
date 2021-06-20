Imports System.Data.SqlClient
Imports System.Threading
Public Class Modules

    Dim con As New SqlConnection(pdo.ConString)
    Dim cmd As New SqlCommand
    Public courseId As Integer
    Public courseName As String
    Public coeffition As Integer
    Public Sub fill()
        cmd = New SqlCommand("SELECT * FROM Module", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub
    Private Sub Modules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("SELECT * FROM Module", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table

        ' PopUp.Show()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("SELECT * FROM Module", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        

        courseName = NameTextbox1.Text
        coeffition = GunaNumeric1.Value
        'MsgBox(GunaDataGridView1.Rows(GunaDataGridView1.RowCount - 1).Cells(0).Value)
        PopUp.Show()
    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        courseId = GunaDataGridView1.CurrentRow.Cells(0).Value
        NameTextbox1.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        GunaNumeric1.Value = GunaDataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If courseId <> Nothing Then
            cmd = New SqlCommand("DELETE FROM Module WHERE ID_MODULE=" & courseId, con)
            Try
                Dim i As Integer = MsgBox("Are you sure want to delete this course ?", vbYesNo)
                If i > 0 Then
                    cmd.ExecuteScalar()
                    MsgBox("Item deleted")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        cmd = New SqlCommand("SELECT * FROM Module", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class