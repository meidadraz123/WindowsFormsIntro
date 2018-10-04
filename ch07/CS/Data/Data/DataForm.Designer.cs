namespace Data
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DiscontinuedLabel = new System.Windows.Forms.Label();
            this.UnitsOnOrderLabel = new System.Windows.Forms.Label();
            this.UnitsInStockLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.QuantityPerUnitLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CategoryToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.categoryToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.SourceToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sourceToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 619);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DiscontinuedLabel);
            this.tabPage1.Controls.Add(this.UnitsOnOrderLabel);
            this.tabPage1.Controls.Add(this.UnitsInStockLabel);
            this.tabPage1.Controls.Add(this.UnitPriceLabel);
            this.tabPage1.Controls.Add(this.QuantityPerUnitLabel);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.discontinuedCheckBox);
            this.tabPage1.Controls.Add(this.orderTextBox);
            this.tabPage1.Controls.Add(this.quantityPerUnitTextBox);
            this.tabPage1.Controls.Add(this.stockTextBox);
            this.tabPage1.Controls.Add(this.priceTextBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.productsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DiscontinuedLabel
            // 
            this.DiscontinuedLabel.AutoSize = true;
            this.DiscontinuedLabel.Location = new System.Drawing.Point(314, 138);
            this.DiscontinuedLabel.Name = "DiscontinuedLabel";
            this.DiscontinuedLabel.Size = new System.Drawing.Size(69, 13);
            this.DiscontinuedLabel.TabIndex = 25;
            this.DiscontinuedLabel.Text = "Discontinued";
            // 
            // UnitsOnOrderLabel
            // 
            this.UnitsOnOrderLabel.AutoSize = true;
            this.UnitsOnOrderLabel.Location = new System.Drawing.Point(314, 113);
            this.UnitsOnOrderLabel.Name = "UnitsOnOrderLabel";
            this.UnitsOnOrderLabel.Size = new System.Drawing.Size(77, 13);
            this.UnitsOnOrderLabel.TabIndex = 24;
            this.UnitsOnOrderLabel.Text = "Units On Order";
            // 
            // UnitsInStockLabel
            // 
            this.UnitsInStockLabel.AutoSize = true;
            this.UnitsInStockLabel.Location = new System.Drawing.Point(314, 87);
            this.UnitsInStockLabel.Name = "UnitsInStockLabel";
            this.UnitsInStockLabel.Size = new System.Drawing.Size(74, 13);
            this.UnitsInStockLabel.TabIndex = 23;
            this.UnitsInStockLabel.Text = "Units In Stock";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(314, 61);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(53, 13);
            this.UnitPriceLabel.TabIndex = 22;
            this.UnitPriceLabel.Text = "Unit Price";
            // 
            // QuantityPerUnitLabel
            // 
            this.QuantityPerUnitLabel.AutoSize = true;
            this.QuantityPerUnitLabel.Location = new System.Drawing.Point(314, 35);
            this.QuantityPerUnitLabel.Name = "QuantityPerUnitLabel";
            this.QuantityPerUnitLabel.Size = new System.Drawing.Size(87, 13);
            this.QuantityPerUnitLabel.TabIndex = 21;
            this.QuantityPerUnitLabel.Text = "Quantity Per Unit";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(314, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "Name";
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.AutoSize = true;
            this.discontinuedCheckBox.Location = new System.Drawing.Point(412, 137);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.discontinuedCheckBox.TabIndex = 19;
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(412, 110);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(155, 20);
            this.orderTextBox.TabIndex = 18;
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(412, 32);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(155, 20);
            this.quantityPerUnitTextBox.TabIndex = 17;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(412, 84);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(155, 20);
            this.stockTextBox.TabIndex = 16;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(412, 58);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(155, 20);
            this.priceTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(412, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Location = new System.Drawing.Point(8, 6);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(290, 329);
            this.productsListBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.productDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataGridView.Location = new System.Drawing.Point(3, 3);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(863, 587);
            this.productDataGridView.TabIndex = 0;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryToolStripLabel,
            this.categoryToolStripComboBox,
            this.SourceToolStripLabel,
            this.sourceToolStripComboBox,
            this.BackToolStripButton,
            this.ForwardToolStripButton,
            this.ToolStripSeparator1,
            this.AddToolStripButton,
            this.DeleteToolStripButton,
            this.ToolStripSeparator2,
            this.SaveToolStripButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(877, 25);
            this.ToolStrip1.TabIndex = 3;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // CategoryToolStripLabel
            // 
            this.CategoryToolStripLabel.Name = "CategoryToolStripLabel";
            this.CategoryToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.CategoryToolStripLabel.Text = "Category:";
            // 
            // categoryToolStripComboBox
            // 
            this.categoryToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryToolStripComboBox.Name = "categoryToolStripComboBox";
            this.categoryToolStripComboBox.Size = new System.Drawing.Size(150, 25);
            this.categoryToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryToolStripComboBox_SelectedIndexChanged);
            // 
            // SourceToolStripLabel
            // 
            this.SourceToolStripLabel.Name = "SourceToolStripLabel";
            this.SourceToolStripLabel.Size = new System.Drawing.Size(46, 22);
            this.SourceToolStripLabel.Text = "Source:";
            // 
            // sourceToolStripComboBox
            // 
            this.sourceToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceToolStripComboBox.Items.AddRange(new object[] {
            "Object",
            "DataSet"});
            this.sourceToolStripComboBox.Name = "sourceToolStripComboBox";
            this.sourceToolStripComboBox.Size = new System.Drawing.Size(150, 25);
            this.sourceToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.sourceToolStripComboBox_SelectedIndexChanged);
            // 
            // BackToolStripButton
            // 
            this.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackToolStripButton.Image = global::Data.Properties.Resources.Backward_16x;
            this.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackToolStripButton.Name = "BackToolStripButton";
            this.BackToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BackToolStripButton.Text = "ToolStripButton1";
            this.BackToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // ForwardToolStripButton
            // 
            this.ForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardToolStripButton.Image = global::Data.Properties.Resources.Forward_16x;
            this.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardToolStripButton.Name = "ForwardToolStripButton";
            this.ForwardToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ForwardToolStripButton.Text = "ToolStripButton2";
            this.ForwardToolStripButton.Click += new System.EventHandler(this.ForwardToolStripButton_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolStripButton.Image = global::Data.Properties.Resources.Add_16x;
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddToolStripButton.Text = "ToolStripButton3";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = global::Data.Properties.Resources.DeleteStep_16x;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteToolStripButton.Text = "ToolStripButton4";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = global::Data.Properties.Resources.SaveStatusBar7_16x;
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "ToolStripButton5";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 644);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "DataForm";
            this.Text = "Data Binding";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.ListBox productsListBox;
        internal System.Windows.Forms.Label DiscontinuedLabel;
        internal System.Windows.Forms.Label UnitsOnOrderLabel;
        internal System.Windows.Forms.Label UnitsInStockLabel;
        internal System.Windows.Forms.Label UnitPriceLabel;
        internal System.Windows.Forms.Label QuantityPerUnitLabel;
        internal System.Windows.Forms.Label NameLabel;
        internal System.Windows.Forms.CheckBox discontinuedCheckBox;
        internal System.Windows.Forms.TextBox orderTextBox;
        internal System.Windows.Forms.TextBox quantityPerUnitTextBox;
        internal System.Windows.Forms.TextBox stockTextBox;
        internal System.Windows.Forms.TextBox priceTextBox;
        internal System.Windows.Forms.TextBox nameTextBox;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel CategoryToolStripLabel;
        internal System.Windows.Forms.ToolStripComboBox categoryToolStripComboBox;
        internal System.Windows.Forms.ToolStripLabel SourceToolStripLabel;
        internal System.Windows.Forms.ToolStripComboBox sourceToolStripComboBox;
        internal System.Windows.Forms.ToolStripButton BackToolStripButton;
        internal System.Windows.Forms.ToolStripButton ForwardToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton AddToolStripButton;
        internal System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton SaveToolStripButton;
    }
}

