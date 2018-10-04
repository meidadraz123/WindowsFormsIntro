Imports System.Data.SqlClient
Imports Data

Public Class DataSetSource
    Implements ISource

    Private _dataSet As DataSet

    Public Sub New()
        _dataSet = New DataSet

        Dim cn As New SqlConnection(My.Settings.NorthwindConnection)
        Dim cda As New SqlDataAdapter("Select CategoryID, CategoryName From Categories", cn)
        cda.Fill(_dataSet, "Categories")

        Dim pda As New SqlDataAdapter("Select * From Products", cn)
        pda.Fill(_dataSet, "Products")

    End Sub

    Public Sub DeleteProduct(bindingSource As BindingSource, product As Product) Implements ISource.DeleteProduct
        Throw New NotImplementedException()
    End Sub

    Public Sub AddProduct(bindingSource As BindingSource, product As Product) Implements ISource.AddProduct
        Throw New NotImplementedException()
    End Sub

    Public Sub Save() Implements ISource.Save
        Throw New NotImplementedException()
    End Sub

    Public Function GetCategories() As Object Implements ISource.GetCategories
        Dim table = _dataSet.Tables("Categories")
        Return table
    End Function

    Public Function GetProducts(categoryId As Integer) As Object Implements ISource.GetProducts
        Dim table = _dataSet.Tables("Products")
        table.DefaultView.RowFilter = "CategoryID = " & categoryId
        Return table
    End Function
End Class
