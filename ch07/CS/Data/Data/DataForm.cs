﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private ISource currentSource;
        private ObjectSource objectSource;
        private DataSetSource dataSetSource;
        private BindingSource categoriesBindingSource = new BindingSource();
        private BindingSource productsBindingSource = new BindingSource();

        private void DataForm_Load(object sender, EventArgs e)
        {
            try
            {
                sourceToolStripComboBox.ComboBox.SelectedIndex = 0;
                SetSource();
                BindCategories();

                categoriesBindingSource.DataSource = currentSource.GetCategories();

                categoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName";
                categoryToolStripComboBox.ComboBox.ValueMember = "CategoryID";
                categoryToolStripComboBox.ComboBox.DataSource = categoriesBindingSource;

                productsListBox.DisplayMember = "ProductName";
                productsListBox.ValueMember = "ProductID";
                productsListBox.DataSource = productsBindingSource;
                productDataGridView.DataSource = productsBindingSource;

                nameTextBox.DataBindings.Add("Text", productsBindingSource, "ProductName");
                quantityPerUnitTextBox.DataBindings.Add("Text", productsBindingSource, "QuantityPerUnit");
                priceTextBox.DataBindings.Add("Text", productsBindingSource, "UnitPrice");
                stockTextBox.DataBindings.Add("Text", productsBindingSource, "UnitsInStock");
                orderTextBox.DataBindings.Add("Text", productsBindingSource, "UnitsOnOrder");
                discontinuedCheckBox.DataBindings.Add("Checked", productsBindingSource, "Discontinued");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
                throw;
            }
        }

        private void categoryToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProducts();
        }

        private void BindProducts()
        {
            var catId = Convert.ToInt32(categoryToolStripComboBox.ComboBox.SelectedValue);
            productsBindingSource.DataSource = currentSource.GetProducts(catId);
        }

        private void BindCategories()
        {
            categoriesBindingSource.DataSource = currentSource.GetCategories();
        }

        private void SetSource()
        {
            switch (sourceToolStripComboBox.ComboBox.SelectedIndex)
            {
                case 0:
                    if (objectSource == null)
                    {
                        objectSource = new ObjectSource();
                    }
                    currentSource = objectSource;
                    break;
                case 1:
                    if (dataSetSource == null)
                    {
                        dataSetSource = new DataSetSource();
                    }
                    currentSource = dataSetSource;
                    break;
                default:
                    break;
            }
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(categoryToolStripComboBox.ComboBox.SelectedValue);
            var name = categoryToolStripComboBox.ComboBox.Text;
            var category = new Category(id, name);
            var form = new AddProductForm(category);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentSource.AddProduct(productsBindingSource, form.Product);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedValue != null)
            {
                currentSource.DeleteProduct(productsBindingSource, (int)productsListBox.SelectedValue);
            }
        }

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void ForwardToolStripButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void sourceToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSource();
            BindCategories();
            BindProducts();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            currentSource.Save();
        }
    }
}
