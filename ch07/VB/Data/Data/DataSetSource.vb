Imports System.Data.SqlClient
Imports Data

Public Class DataSetSource
    Implements ISource

    Private _dataSet As DataSet
    Private _nextId As Integer = Integer.MaxValue
    Private _productAdaptor As SqlDataAdapter

    Public Sub New()
        _dataSet = New DataSet

        Dim cn As New SqlConnection(My.Settings.NorthwindConnection)
        Dim cda As New SqlDataAdapter("Select CategoryID, CategoryName From Categories", cn)
        cda.Fill(_dataSet, "Categories")

        _productAdaptor = New SqlDataAdapter("Select * From Products", cn)
        Dim builder As New SqlCommandBuilder(_productAdaptor)
        _productAdaptor.Fill(_dataSet, "Products")

    End Sub

    Public Sub DeleteProduct(bindingSource As BindingSource, productId As Integer) Implements ISource.DeleteProduct
        Dim table = _dataSet.Tables("Products")
        Dim query = From p In table.AsEnumerable
                    Where p.RowState <> DataRowState.Deleted AndAlso p.Field(Of Integer)("ProductID") = productId
                    Select p

        Dim row = query.Single()
        row.Delete()
    End Sub

    Public Sub AddProduct(bindingSource As BindingSource, product As Product) Implements ISource.AddProduct
        Dim table = _dataSet.Tables("Products")
        _nextId -= 1

        Dim row = table.NewRow()
        row("ProductID") = _nextId
        row("ProductName") = product.ProductName
        row("SupplierID") = 1
        row("CategoryID") = product.CategoryID
        row("QuantityPerUnit") = product.QuantityPerUnit
        row("UnitPrice") = product.UnitPrice
        row("UnitsInStock") = product.UnitsInStock
        row("UnitsOnOrder") = product.UnitsOnOrder
        row("ReorderLevel") = 0
        row("Discontinued") = product.Discontinued
        table.Rows.Add(row)
    End Sub

    Public Sub Save() Implements ISource.Save
        Dim connection As SqlConnection = Nothing
        Try
            connection = New SqlConnection(My.Settings.NorthwindConnection)
            connection.Open()
            _productAdaptor.Update(_dataSet, "Products")
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        Finally
            If connection IsNot Nothing Then
                connection.Dispose()
            End If
        End Try
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
