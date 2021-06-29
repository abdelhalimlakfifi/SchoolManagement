Public Class Home
    Dim MoveX, MoveY As Integer
    Dim newpoint As New Point
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub clean()
        GunaButton13.BaseColor = System.Drawing.Color.FromArgb(2, 27, 92)
        GunaButton8.BaseColor = System.Drawing.Color.FromArgb(2, 27, 92)
        GunaButton3.BaseColor = System.Drawing.Color.FromArgb(2, 27, 92)
        GunaButton9.BaseColor = System.Drawing.Color.FromArgb(2, 27, 92)
        GunaButton6.BaseColor = System.Drawing.Color.FromArgb(2, 27, 92)
        GunaButton10.BaseColor = System.Drawing.Color.FromArgb(2, 27, 92)
    End Sub
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub GunaButton12_Click(sender As Object, e As EventArgs)

        switchPanel(Dashboard)
    End Sub



    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click

    End Sub






    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Size = Panel4.MinimumSize
        switchPanel(Dashboard)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            Panel4.Width += 60
            If Panel4.Size = Panel4.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
                'MsgBox(isCollapsed & "test 1")
            End If
        Else

            Panel4.Width -= 60
            If Panel4.Size = Panel4.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
                'MsgBox(isCollapsed & "test 2")
            End If
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        'isCollapsed = False
        Timer1.Start()
    End Sub

    Private Sub GunaButton2_MouseHover(sender As Object, e As EventArgs) Handles GunaButton2.MouseHover
        Timer1.Start()
    End Sub


    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        switchPanel(Students)
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        switchPanel(PaymentForm)
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        switchPanel(AbsencesForm)
    End Sub

    Private Sub GunaButton13_Click(sender As Object, e As EventArgs) Handles GunaButton13.Click
        clean()
        GunaButton13.BaseColor = Color.Gold
        switchPanel(TechersForms)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        MoveX = Control.MousePosition.X - Me.Location.X
        MoveY = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= MoveX
            newpoint.Y -= MoveY
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        clean()
        GunaButton9.BaseColor = Color.Gold
        switchPanel(Course_branches)
    End Sub
    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        clean()
        GunaButton8.BaseColor = Color.Gold
        switchPanel(PaymentHistorique)
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        clean()
        GunaButton3.BaseColor = Color.Gold
        switchPanel(Classes)
    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs) Handles GunaButton11.Click
        switchPanel(gradeForm)
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        clean()
        GunaButton6.BaseColor = Color.Gold
        switchPanel(AdminForms)
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        switchPanel(Dashboard)
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        clean()
        GunaButton10.BaseColor = Color.Gold
        switchPanel(AboutUS)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Application.Restart()
    End Sub
End Class