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

        private ObjectSource source = new ObjectSource();

        private void DataForm_Load(object sender, EventArgs e)
        {
            categoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName";
            categoryToolStripComboBox.ComboBox.ValueMember = "CategoryID";
            categoryToolStripComboBox.ComboBox.DataSource = source.GetCategories();
        }

        private void categoryToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var catId = Convert.ToInt32(categoryToolStripComboBox.ComboBox.SelectedValue);
            var products = source.GetProducts(catId);
            productsListBox.DataSource = products;
            productsListBox.DisplayMember = "ProductName";

            nameTextBox.DataBindings.Clear();
            nameTextBox.DataBindings.Add("Text", products, "ProductName");
            quantityPerUnitTextBox.DataBindings.Clear();
            quantityPerUnitTextBox.DataBindings.Add("Text", products, "QuantityPerUnit");
            priceTextBox.DataBindings.Clear();
            priceTextBox.DataBindings.Add("Text", products, "UnitPrice");
            stockTextBox.DataBindings.Clear();
            stockTextBox.DataBindings.Add("Text", products, "UnitsInStock");
            orderTextBox.DataBindings.Clear();
            orderTextBox.DataBindings.Add("Text", products, "UnitsOnOrder");
            discontinuedCheckBox.DataBindings.Clear();
            discontinuedCheckBox.DataBindings.Add("Checked", products, "Discontinued");
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm((Category)categoryToolStripComboBox.ComboBox.SelectedItem);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                source.AddProduct(form.Product);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            source.DeleteProduct((Product)productsListBox.SelectedItem);
        }
    }
}
