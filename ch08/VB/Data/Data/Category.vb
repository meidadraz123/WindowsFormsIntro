Public Class Category
    Public Property CategoryID As Integer
    Public Property CategoryName As String

    Public Sub New(id As Integer, name As String)
        CategoryID = id
        CategoryName = name
    End Sub
End Class
