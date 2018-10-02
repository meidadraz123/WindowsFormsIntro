using System;
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
        private BindingSource categoriesBindingSource = new BindingSource();
        private BindingSource productsBindingSource = new BindingSource();

        private void DataForm_Load(object sender, EventArgs e)
        {
            sourceToolStripComboBox.ComboBox.SelectedIndex = 0;
            SetSource();
            BindCategories();

            categoriesBindingSource.DataSource = currentSource.GetCategories();

            categoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName";
            categoryToolStripComboBox.ComboBox.ValueMember = "CategoryID";
            categoryToolStripComboBox.ComboBox.DataSource = categoriesBindingSource;

            productDataGridView.DataSource = productsBindingSource;
            productsListBox.DataSource = productsBindingSource;
            productsListBox.DisplayMember = "ProductName";

            nameTextBox.DataBindings.Add("Text", productsBindingSource, "ProductName");
            quantityPerUnitTextBox.DataBindings.Add("Text", productsBindingSource, "QuantityPerUnit");
            priceTextBox.DataBindings.Add("Text", productsBindingSource, "UnitPrice");
            stockTextBox.DataBindings.Add("Text", productsBindingSource, "UnitsInStock");
            orderTextBox.DataBindings.Add("Text", productsBindingSource, "UnitsOnOrder");
            discontinuedCheckBox.DataBindings.Add("Checked", productsBindingSource, "Discontinued");
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
                default:
                    break;
            }
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm((Category)categoryToolStripComboBox.ComboBox.SelectedItem);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                productsBindingSource.Add(form.Product);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.Remove(productsListBox.SelectedItem);
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
    }
}
