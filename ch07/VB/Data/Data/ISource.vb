Public Interface ISource
    Function GetCategories() As Object
    Function GetProducts(categoryId As Integer) As Object
    Sub DeleteProduct(bindingSource As BindingSource, product As Product)
    Sub AddProduct(bindingSource As BindingSource, product As Product)
    Sub Save()
End Interface
