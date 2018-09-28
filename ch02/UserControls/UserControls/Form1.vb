Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Person With {
            .FirstName = "Rob",
            .LastName = "Windsor",
            .Age = 49
            }

        PersonControl1.Person = p
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(PersonControl1.Person.LastName)
    End Sub
End Class
