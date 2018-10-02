Public Class AddProductForm
    Private _category As Category

    Public Sub New(category As Category)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _category = category
        CategoryTextBox.Text = _category.CategoryName
    End Sub

    Public ReadOnly Property Product As Product
        Get
            Dim result As New Product(0, NameTextBox.Text, _category.CategoryID, QuantityPerUnitTextBox.Text, PriceTextBox.Text, StockTextBox.Text, UnitsOnOrderTextBox.Text, DiscontinuedCheckBox.Checked)
            Return result
        End Get
    End Property

End Class