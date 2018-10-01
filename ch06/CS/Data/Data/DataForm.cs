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
        private BindingSource categoryBindingSource = new BindingSource();
        private BindingSource productsBindingSource = new BindingSource();

        private void DataForm_Load(object sender, EventArgs e)
        {
            categoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName";
            categoryToolStripComboBox.ComboBox.ValueMember = "CategoryID";
            categoryToolStripComboBox.ComboBox.DataSource = source.GetCategories();

            categoryBindingSource.DataSource = source.GetCategories();

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
            var catId = Convert.ToInt32(categoryToolStripComboBox.ComboBox.SelectedValue);
            productsBindingSource.DataSource = source.GetProducts(catId);
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm((Category)categoryToolStripComboBox.ComboBox.SelectedItem);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                //source.AddProduct(form.Product);
                productsBindingSource.Add(form.Product);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            //source.DeleteProduct((Product)productsListBox.SelectedItem);
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
    }
}
