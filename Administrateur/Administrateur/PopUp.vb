Imports System.Data.SqlClient
Public Class PopUp
    Dim con As New SqlConnection(pdo.ConString)
    Private Sub PopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("SELECT * FROM FILIER", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
        Dim co As New DataGridViewCheckBoxColumn
        co.HeaderText = "Branches"
        co.Name = "branche"
        GunaDataGridView1.Columns.Insert(0, co)
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmd As New SqlCommand("INSERT INTO MODULE(MODULE, COEFFICIENT) VALUES('" & Modules.courseName & "'," & Modules.coeffition & ");", con)
        If Modules.courseName <> "" And Modules.coeffition > 0 Then
            Try
                cmd.ExecuteScalar()
                MessageBox.Show("Course registred")
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Hide()
            End Try
        Else
            MsgBox("Please enter the course name or coefficient")
            Me.Hide()
        End If
        cmd = New SqlCommand("SELECT TOP 1 ID_MODULE FROM MODULE ORDER BY ID_MODULE DESC", con)
        Dim moduleId As Integer = cmd.ExecuteScalar

        Dim i As Integer
        For i = 0 To GunaDataGridView1.Rows.Count - 1
            If CBool(GunaDataGridView1.Rows(i).Cells(0).Value) Then

                cmd = New SqlCommand("INSERT INTO INTEGRATION (ID_FILIER, ID_MODULE) VALUES(" & GunaDataGridView1.Rows(i).Cells(1).Value & "," & GunaDataGridView1.Rows(i).Cells(1).Value & ");", con)
                Try
                    cmd.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next
        Modules.fill()
        MsgBox("Course saved")
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
    End Sub
End Class