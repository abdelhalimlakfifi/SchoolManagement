Imports System.Data.SqlClient

Public Class Branches
    Dim branchId As Integer
    Dim con As New SqlConnection(pdo.ConString)
    Private Sub Branches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("INSERT INTO FILIER (NOM, SPECIALITE) VALUES('" & NameTextbox1.Text & "', '" & SpecialityTextbox2.Text & "');", con)
        If NameTextbox1.Text = "" Or SpecialityTextbox2.Text = "" Then
            MessageBox.Show("Error: Brach name or speciality is Empty")
        Else
            Try
                cmd.ExecuteScalar()
                MessageBox.Show("Saved")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        cmd = New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
        NameTextbox1.Text = ""
        SpecialityTextbox2.Text = ""
    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        branchId = GunaDataGridView1.CurrentRow.Cells(0).Value
        NameTextbox1.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        SpecialityTextbox2.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand
        If branchId = Nothing Then
            MessageBox.Show("Please Select a branche before")
        Else
            cmd = New SqlCommand("DELETE FROM FILIER WHERE ID_FILIER=" & branchId & ";", con)
            Try

                Dim i As Integer = MsgBox("Are you sure want to delete this item ? ", vbYesNo)
                If i > 0 Then
                    cmd.ExecuteScalar()
                    MsgBox("Item deleted")
                End If
            Catch ex As Exception
                MsgBox("Can't Delete this item. Please verify the courses table... " & vbNewLine & ex.Message)
            End Try
        End If
        cmd = New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
        NameTextbox1.Text = ""
        SpecialityTextbox2.Text = ""
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim cmd As New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
        NameTextbox1.Text = ""
        SpecialityTextbox2.Text = ""
    End Sub
End Class