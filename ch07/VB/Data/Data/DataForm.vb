Public Class DataForm
    Private _categoriesBindingSource As New BindingSource()
    Private _productsBindingSource As New BindingSource()

    Private _currentSource As ISource
    Private _objectSource As ObjectSource
    Private _dataSetSource As DataSetSource

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SourceToolStripComboBox.SelectedIndex = 0
        SetSource()
        BindCategories()

        _categoriesBindingSource.DataSource = _currentSource.GetCategories()

        CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName"
        CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID"
        CategoryToolStripComboBox.ComboBox.DataSource = _categoriesBindingSource

        ProductsListBox.DataSource = _productsBindingSource
        ProductsListBox.DisplayMember = "ProductName"
        ProductsDataGridView.DataSource = _productsBindingSource

        NameTextBox.DataBindings.Add("Text", _productsBindingSource, "ProductName")
        QuantityPerUnitTextBox.DataBindings.Add("Text", _productsBindingSource, "QuantityPerUnit")
        PriceTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitPrice")
        StockTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsInStock")
        UnitsOnOrderTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsOnOrder")
        DiscontinuedCheckBox.DataBindings.Add("Checked", _productsBindingSource, "Discontinued")
    End Sub

    Private Sub CategoryToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryToolStripComboBox.SelectedIndexChanged
        BindProducts()
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        Dim category = CType(CategoryToolStripComboBox.SelectedItem, Category)
        Dim form As New AddProductForm(category)
        Dim result = form.ShowDialog()
        If result = DialogResult.OK Then
            _productsBindingSource.Add(form.Product)
        End If

    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Dim product = CType(ProductsListBox.SelectedItem, Product)
        _productsBindingSource.Remove(product)
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        _productsBindingSource.MovePrevious()
    End Sub

    Private Sub ForwardToolStripButton_Click(sender As Object, e As EventArgs) Handles ForwardToolStripButton.Click
        _productsBindingSource.MoveNext()
    End Sub

    Private Sub SourceToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SourceToolStripComboBox.SelectedIndexChanged
        SetSource()
        BindCategories()
        BindProducts()
    End Sub

    Private Sub BindCategories()
        _categoriesBindingSource.DataSource = _currentSource.GetCategories()
    End Sub

    Private Sub BindProducts()
        Dim catId = CategoryToolStripComboBox.ComboBox.SelectedValue
        _productsBindingSource.DataSource = _currentSource.GetProducts(catId)
    End Sub

    Private Sub SetSource()
        Select Case SourceToolStripComboBox.SelectedIndex
            Case 0
                If _objectSource Is Nothing Then
                    _objectSource = New ObjectSource()
                End If
                _currentSource = _objectSource
            Case 1
                If _dataSetSource Is Nothing Then
                    _dataSetSource = New DataSetSource()
                End If
                _currentSource = _dataSetSource
        End Select
    End Sub
End Class
