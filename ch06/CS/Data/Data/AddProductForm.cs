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
    public partial class AddProductForm : Form
    {
        private Category category;

        public AddProductForm(Category category)
        {
            InitializeComponent();

            this.category = category;
            categoryTextBox.Text = category.CategoryName;
        }

        private Product product;

        public Product Product
        {
            get
            {
                var result = new Product(0,
                    nameTextBox.Text,
                    category.CategoryID,
                    quantityPerUnitTextBox.Text,
                    Convert.ToDecimal(priceTextBox.Text),
                    Convert.ToInt32(stockTextBox.Text),
                     Convert.ToInt32(unitsOnOrderTextBox.Text),
                    discontinuedCheckBox.Checked);
                return result;
            }
        }

    }
}
