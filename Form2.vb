Public Class Form2


    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Dim frm4 As New Form4
        frm4.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim frm4 As New Form4
        frm4.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim frm5 As New Form5
        frm5.Show()
        Me.Hide()

    End Sub
End Class