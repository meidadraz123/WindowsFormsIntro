using Data.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public class DataSetSource : ISource
    {
        private DataSet dataSet;

        public DataSetSource()
        {
            dataSet = new DataSet();

            var settings = new Settings();
            var connection = new SqlConnection(settings.NorthwindConnection);
            var categoriesDataAdaper = new SqlDataAdapter("Select CategoryID, CategoryName From Categories", connection);
            categoriesDataAdaper.Fill(dataSet, "Categories");

            var productsDataAdaper = new SqlDataAdapter("Select * From Products", connection);
            productsDataAdaper.Fill(dataSet, "Products");
            
        }

        public void AddProduct(BindingSource bindingSource, Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(BindingSource bindingSource, Product product)
        {
            throw new NotImplementedException();
        }

        public object GetCategories()
        {
            var table = dataSet.Tables["Categories"];
            return table;
            
        }

        public object GetProducts(int catId)
        {
            var table = dataSet.Tables["Products"];
            table.DefaultView.RowFilter = "CategoryID = " + catId.ToString();
            return table;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
