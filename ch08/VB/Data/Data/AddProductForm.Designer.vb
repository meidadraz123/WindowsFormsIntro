<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DiscontinuedLabel = New System.Windows.Forms.Label()
        Me.UnitsOnOrderLabel = New System.Windows.Forms.Label()
        Me.UnitsInStockLabel = New System.Windows.Forms.Label()
        Me.UnitPriceLabel = New System.Windows.Forms.Label()
        Me.QuantityPerUnitLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DiscontinuedCheckBox = New System.Windows.Forms.CheckBox()
        Me.UnitsOnOrderTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiscontinuedLabel
        '
        Me.DiscontinuedLabel.AutoSize = True
        Me.DiscontinuedLabel.Location = New System.Drawing.Point(16, 170)
        Me.DiscontinuedLabel.Name = "DiscontinuedLabel"
        Me.DiscontinuedLabel.Size = New System.Drawing.Size(69, 13)
        Me.DiscontinuedLabel.TabIndex = 12
        Me.DiscontinuedLabel.Text = "Discontinued"
        '
        'UnitsOnOrderLabel
        '
        Me.UnitsOnOrderLabel.AutoSize = True
        Me.UnitsOnOrderLabel.Location = New System.Drawing.Point(16, 145)
        Me.UnitsOnOrderLabel.Name = "UnitsOnOrderLabel"
        Me.UnitsOnOrderLabel.Size = New System.Drawing.Size(77, 13)
        Me.UnitsOnOrderLabel.TabIndex = 10
        Me.UnitsOnOrderLabel.Text = "Units On Order"
        '
        'UnitsInStockLabel
        '
        Me.UnitsInStockLabel.AutoSize = True
        Me.UnitsInStockLabel.Location = New System.Drawing.Point(16, 119)
        Me.UnitsInStockLabel.Name = "UnitsInStockLabel"
        Me.UnitsInStockLabel.Size = New System.Drawing.Size(74, 13)
        Me.UnitsInStockLabel.TabIndex = 8
        Me.UnitsInStockLabel.Text = "Units In Stock"
        '
        'UnitPriceLabel
        '
        Me.UnitPriceLabel.AutoSize = True
        Me.UnitPriceLabel.Location = New System.Drawing.Point(16, 93)
        Me.UnitPriceLabel.Name = "UnitPriceLabel"
        Me.UnitPriceLabel.Size = New System.Drawing.Size(53, 13)
        Me.UnitPriceLabel.TabIndex = 6
        Me.UnitPriceLabel.Text = "Unit Price"
        '
        'QuantityPerUnitLabel
        '
        Me.QuantityPerUnitLabel.AutoSize = True
        Me.QuantityPerUnitLabel.Location = New System.Drawing.Point(16, 67)
        Me.QuantityPerUnitLabel.Name = "QuantityPerUnitLabel"
        Me.QuantityPerUnitLabel.Size = New System.Drawing.Size(87, 13)
        Me.QuantityPerUnitLabel.TabIndex = 4
        Me.QuantityPerUnitLabel.Text = "Quantity Per Unit"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(16, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.AutoSize = True
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(114, 169)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DiscontinuedCheckBox.TabIndex = 13
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'UnitsOnOrderTextBox
        '
        Me.UnitsOnOrderTextBox.Location = New System.Drawing.Point(114, 142)
        Me.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox"
        Me.UnitsOnOrderTextBox.Size = New System.Drawing.Size(230, 20)
        Me.UnitsOnOrderTextBox.TabIndex = 11
        '
        'QuantityPerUnitTextBox
        '
        Me.QuantityPerUnitTextBox.Location = New System.Drawing.Point(114, 64)
        Me.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox"
        Me.QuantityPerUnitTextBox.Size = New System.Drawing.Size(230, 20)
        Me.QuantityPerUnitTextBox.TabIndex = 5
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(114, 116)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(230, 20)
        Me.StockTextBox.TabIndex = 9
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(114, 90)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(230, 20)
        Me.PriceTextBox.TabIndex = 7
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(114, 12)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(230, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Location = New System.Drawing.Point(16, 41)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(49, 13)
        Me.CategoryLabel.TabIndex = 2
        Me.CategoryLabel.Text = "Category"
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.Enabled = False
        Me.CategoryTextBox.Location = New System.Drawing.Point(114, 38)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(230, 20)
        Me.CategoryTextBox.TabIndex = 3
        Me.CategoryTextBox.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(269, 218)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 15
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkButton.Location = New System.Drawing.Point(188, 218)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 14
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'AddProductForm
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(363, 253)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.DiscontinuedLabel)
        Me.Controls.Add(Me.UnitsOnOrderLabel)
        Me.Controls.Add(Me.UnitsInStockLabel)
        Me.Controls.Add(Me.UnitPriceLabel)
        Me.Controls.Add(Me.QuantityPerUnitLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.DiscontinuedCheckBox)
        Me.Controls.Add(Me.UnitsOnOrderTextBox)
        Me.Controls.Add(Me.QuantityPerUnitTextBox)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "AddProductForm"
        Me.Text = "Add Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DiscontinuedLabel As Label
    Friend WithEvents UnitsOnOrderLabel As Label
    Friend WithEvents UnitsInStockLabel As Label
    Friend WithEvents UnitPriceLabel As Label
    Friend WithEvents QuantityPerUnitLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents DiscontinuedCheckBox As CheckBox
    Friend WithEvents UnitsOnOrderTextBox As TextBox
    Friend WithEvents QuantityPerUnitTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents OkButton As Button
End Class
