﻿Public Class DataForm
    Private _categoriesBindingSource As New BindingSource()
    Private _productsBindingSource As New BindingSource()

    Private _currentSource As ISource
    Private _objectSource As ObjectSource
    Private _dataSetSource As DataSetSource
    Private _linqSource As LinqSource

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SourceToolStripComboBox.SelectedIndex = 0
        SetSource()
        BindCategories()

        _categoriesBindingSource.DataSource = _currentSource.GetCategories()

        CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName"
        CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID"
        CategoryToolStripComboBox.ComboBox.DataSource = _categoriesBindingSource

        ProductsListBox.DisplayMember = "ProductName"
        ProductsListBox.ValueMember = "ProductID"
        ProductsListBox.DataSource = _productsBindingSource
        ProductsDataGridView.DataSource = _productsBindingSource

        NameTextBox.DataBindings.Add("Text", _productsBindingSource, "ProductName", True)
        QuantityPerUnitTextBox.DataBindings.Add("Text", _productsBindingSource, "QuantityPerUnit", True)
        PriceTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitPrice", True)
        StockTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsInStock", True)
        UnitsOnOrderTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsOnOrder", True)
        DiscontinuedCheckBox.DataBindings.Add("Checked", _productsBindingSource, "Discontinued", True)
    End Sub

    Private Sub CategoryToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryToolStripComboBox.SelectedIndexChanged
        BindProducts()
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        Dim id = CategoryToolStripComboBox.ComboBox.SelectedValue
        Dim name = CategoryToolStripComboBox.ComboBox.Text
        Dim category = New Category(id, name)
        Dim form As New AddProductForm(category)
        Dim result = form.ShowDialog()
        If result = DialogResult.OK Then
            Dim rebind = _currentSource.AddProduct(form.Product)
            If rebind = True Then
                BindProducts()
            End If
        End If

    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Dim productId = ProductsListBox.SelectedValue
        Dim rebind = _currentSource.DeleteProduct(productId)
        If rebind = True Then
            BindProducts()
        End If
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
            Case 2
                If _linqSource Is Nothing Then
                    _linqSource = New LinqSource()
                End If
                _currentSource = _linqSource
        End Select
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        _currentSource.Save()
    End Sub
End Class
