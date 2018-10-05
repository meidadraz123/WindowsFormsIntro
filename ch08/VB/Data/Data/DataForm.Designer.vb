<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CategoryToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CategoryToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SourceToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SourceToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.ProductsListBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoryToolStripLabel, Me.CategoryToolStripComboBox, Me.SourceToolStripLabel, Me.SourceToolStripComboBox, Me.BackToolStripButton, Me.ForwardToolStripButton, Me.ToolStripSeparator1, Me.AddToolStripButton, Me.DeleteToolStripButton, Me.ToolStripSeparator2, Me.SaveToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(957, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CategoryToolStripLabel
        '
        Me.CategoryToolStripLabel.Name = "CategoryToolStripLabel"
        Me.CategoryToolStripLabel.Size = New System.Drawing.Size(58, 22)
        Me.CategoryToolStripLabel.Text = "Category:"
        '
        'CategoryToolStripComboBox
        '
        Me.CategoryToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryToolStripComboBox.Name = "CategoryToolStripComboBox"
        Me.CategoryToolStripComboBox.Size = New System.Drawing.Size(150, 25)
        '
        'SourceToolStripLabel
        '
        Me.SourceToolStripLabel.Name = "SourceToolStripLabel"
        Me.SourceToolStripLabel.Size = New System.Drawing.Size(46, 22)
        Me.SourceToolStripLabel.Text = "Source:"
        '
        'SourceToolStripComboBox
        '
        Me.SourceToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SourceToolStripComboBox.Items.AddRange(New Object() {"Objects", "DataSet", "LINQ to SQL"})
        Me.SourceToolStripComboBox.Name = "SourceToolStripComboBox"
        Me.SourceToolStripComboBox.Size = New System.Drawing.Size(150, 25)
        '
        'BackToolStripButton
        '
        Me.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolStripButton.Image = Global.Data.My.Resources.Resources.Backward_16x
        Me.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackToolStripButton.Name = "BackToolStripButton"
        Me.BackToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackToolStripButton.Text = "ToolStripButton1"
        '
        'ForwardToolStripButton
        '
        Me.ForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardToolStripButton.Image = Global.Data.My.Resources.Resources.Forward_16x
        Me.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardToolStripButton.Name = "ForwardToolStripButton"
        Me.ForwardToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ForwardToolStripButton.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = Global.Data.My.Resources.Resources.Add_16x
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AddToolStripButton.Text = "ToolStripButton3"
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteToolStripButton.Image = Global.Data.My.Resources.Resources.DeleteStep_16x
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteToolStripButton.Text = "ToolStripButton4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = Global.Data.My.Resources.Resources.SaveStatusBar7_16x
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "ToolStripButton5"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(957, 615)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DiscontinuedLabel)
        Me.TabPage1.Controls.Add(Me.UnitsOnOrderLabel)
        Me.TabPage1.Controls.Add(Me.UnitsInStockLabel)
        Me.TabPage1.Controls.Add(Me.UnitPriceLabel)
        Me.TabPage1.Controls.Add(Me.QuantityPerUnitLabel)
        Me.TabPage1.Controls.Add(Me.NameLabel)
        Me.TabPage1.Controls.Add(Me.DiscontinuedCheckBox)
        Me.TabPage1.Controls.Add(Me.UnitsOnOrderTextBox)
        Me.TabPage1.Controls.Add(Me.QuantityPerUnitTextBox)
        Me.TabPage1.Controls.Add(Me.StockTextBox)
        Me.TabPage1.Controls.Add(Me.PriceTextBox)
        Me.TabPage1.Controls.Add(Me.NameTextBox)
        Me.TabPage1.Controls.Add(Me.ProductsListBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(949, 589)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DiscontinuedLabel
        '
        Me.DiscontinuedLabel.AutoSize = True
        Me.DiscontinuedLabel.Location = New System.Drawing.Point(347, 140)
        Me.DiscontinuedLabel.Name = "DiscontinuedLabel"
        Me.DiscontinuedLabel.Size = New System.Drawing.Size(69, 13)
        Me.DiscontinuedLabel.TabIndex = 11
        Me.DiscontinuedLabel.Text = "Discontinued"
        '
        'UnitsOnOrderLabel
        '
        Me.UnitsOnOrderLabel.AutoSize = True
        Me.UnitsOnOrderLabel.Location = New System.Drawing.Point(347, 115)
        Me.UnitsOnOrderLabel.Name = "UnitsOnOrderLabel"
        Me.UnitsOnOrderLabel.Size = New System.Drawing.Size(77, 13)
        Me.UnitsOnOrderLabel.TabIndex = 9
        Me.UnitsOnOrderLabel.Text = "Units On Order"
        '
        'UnitsInStockLabel
        '
        Me.UnitsInStockLabel.AutoSize = True
        Me.UnitsInStockLabel.Location = New System.Drawing.Point(347, 89)
        Me.UnitsInStockLabel.Name = "UnitsInStockLabel"
        Me.UnitsInStockLabel.Size = New System.Drawing.Size(74, 13)
        Me.UnitsInStockLabel.TabIndex = 7
        Me.UnitsInStockLabel.Text = "Units In Stock"
        '
        'UnitPriceLabel
        '
        Me.UnitPriceLabel.AutoSize = True
        Me.UnitPriceLabel.Location = New System.Drawing.Point(347, 63)
        Me.UnitPriceLabel.Name = "UnitPriceLabel"
        Me.UnitPriceLabel.Size = New System.Drawing.Size(53, 13)
        Me.UnitPriceLabel.TabIndex = 5
        Me.UnitPriceLabel.Text = "Unit Price"
        '
        'QuantityPerUnitLabel
        '
        Me.QuantityPerUnitLabel.AutoSize = True
        Me.QuantityPerUnitLabel.Location = New System.Drawing.Point(347, 37)
        Me.QuantityPerUnitLabel.Name = "QuantityPerUnitLabel"
        Me.QuantityPerUnitLabel.Size = New System.Drawing.Size(87, 13)
        Me.QuantityPerUnitLabel.TabIndex = 3
        Me.QuantityPerUnitLabel.Text = "Quantity Per Unit"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(347, 11)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.AutoSize = True
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(445, 139)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DiscontinuedCheckBox.TabIndex = 12
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'UnitsOnOrderTextBox
        '
        Me.UnitsOnOrderTextBox.Location = New System.Drawing.Point(445, 112)
        Me.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox"
        Me.UnitsOnOrderTextBox.Size = New System.Drawing.Size(155, 20)
        Me.UnitsOnOrderTextBox.TabIndex = 10
        '
        'QuantityPerUnitTextBox
        '
        Me.QuantityPerUnitTextBox.Location = New System.Drawing.Point(445, 34)
        Me.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox"
        Me.QuantityPerUnitTextBox.Size = New System.Drawing.Size(155, 20)
        Me.QuantityPerUnitTextBox.TabIndex = 4
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(445, 86)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(155, 20)
        Me.StockTextBox.TabIndex = 8
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(445, 60)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(155, 20)
        Me.PriceTextBox.TabIndex = 6
        '
        'NameTextBox
        '
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(445, 8)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.NameTextBox.TabIndex = 2
        Me.NameTextBox.TabStop = False
        '
        'ProductsListBox
        '
        Me.ProductsListBox.FormattingEnabled = True
        Me.ProductsListBox.Location = New System.Drawing.Point(6, 6)
        Me.ProductsListBox.Name = "ProductsListBox"
        Me.ProductsListBox.Size = New System.Drawing.Size(302, 459)
        Me.ProductsListBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ProductsDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(949, 589)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Grid"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.Size = New System.Drawing.Size(943, 583)
        Me.ProductsDataGridView.TabIndex = 0
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 640)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DataForm"
        Me.Text = "DataBinding"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ProductsDataGridView As DataGridView
    Friend WithEvents ProductsListBox As ListBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CategoryToolStripLabel As ToolStripLabel
    Friend WithEvents CategoryToolStripComboBox As ToolStripComboBox
    Friend WithEvents SourceToolStripLabel As ToolStripLabel
    Friend WithEvents SourceToolStripComboBox As ToolStripComboBox
    Friend WithEvents DiscontinuedLabel As Label
    Friend WithEvents UnitsOnOrderLabel As Label
    Friend WithEvents UnitsInStockLabel As Label
    Friend WithEvents UnitPriceLabel As Label
    Friend WithEvents QuantityPerUnitLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents DiscontinuedCheckBox As CheckBox
    Friend WithEvents UnitsOnOrderTextBox As TextBox
    Friend WithEvents QuantityPerUnitTextBox As TextBox
    Friend WithEvents BackToolStripButton As ToolStripButton
    Friend WithEvents ForwardToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddToolStripButton As ToolStripButton
    Friend WithEvents DeleteToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SaveToolStripButton As ToolStripButton
End Class
