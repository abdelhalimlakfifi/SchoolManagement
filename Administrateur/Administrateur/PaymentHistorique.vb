Imports System.Data.SqlClient
Public Class PaymentHistorique
    Dim con As New SqlConnection(pdo.ConString)
    Dim cmd As New SqlCommand
    Dim factureId As Integer
    Sub loadpayments()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("SELECT F.ID_FACTURE, E.NOM + ' ' + E.PRENOM as 'Nom etudianT', A.NOM + ' ' +A.PRENOM  as 'Nom admin', F.MONTANT, F.MOISPAYE, F.[DATE] FROM FACTURE as F, ETUDIANT as E, ADMINISTRATEUR as A WHERE F.ID_ETUDIANT = E.ID_ETUDIANT AND A.ID_ADMIN = F.ID_ADMIN", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub
    Sub loadAbcense()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand("SELECT A.ID_ABSENCE, E.NOM + ' ' + E.PRENOM as 'Nom d etudiant', [DATE], P.NOM + ' ' + P.PRENOM as 'Nom de professeur' FROM ABSENCE as A , ETUDIANT as E, PROF as P WHERE E.ID_ETUDIANT=A.ID_ETUDIANT AND P.ID_PROF = A.ID_PROF ;", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        GunaDataGridView1.DataSource = table
    End Sub
    Private Sub PaymentHistorique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaRadioButton1.Checked = True
        loadpayments()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If factureId <> Nothing Then
            If GunaRadioButton1.Checked = True Then
                cmd = New SqlCommand("DELETE FROM FACTURE WHERE ID_FACTURE=" & factureId, con)
                Try
                    cmd.ExecuteScalar()
                    MsgBox("Item deleted")
                    loadpayments()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                cmd = New SqlCommand("DELETE FROM ABSENCE WHERE ID_ABSENCE=" & factureId & ";", con)
                Try
                    cmd.ExecuteScalar()
                    MsgBox("Item deleted")
                    loadAbcense()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        factureId = GunaDataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton2.CheckedChanged
        factureId = Nothing
        If GunaRadioButton2.Checked = True Then
            loadAbcense()
        End If
    End Sub

    Private Sub GunaRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaRadioButton1.CheckedChanged
        factureId = Nothing
        If GunaRadioButton1.Checked = True Then
            loadpayments()
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If GunaRadioButton1.Checked = True Then
            loadpayments()
        Else
            loadAbcense()
        End If
    End Sub
End Class