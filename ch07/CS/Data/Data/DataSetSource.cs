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
        private int nextItem = int.MaxValue;
        private SqlDataAdapter productsDataAdaper;

        public DataSetSource()
        {
            dataSet = new DataSet();

            var settings = new Settings();
            var connection = new SqlConnection(settings.NorthwindConnection);
            var categoriesDataAdaper = new SqlDataAdapter("Select CategoryID, CategoryName From Categories", connection);
            categoriesDataAdaper.Fill(dataSet, "Categories");

            productsDataAdaper = new SqlDataAdapter("Select * From Products", connection);
            var builder = new SqlCommandBuilder(productsDataAdaper);
            productsDataAdaper.Fill(dataSet, "Products");
            
        }

        public void AddProduct(BindingSource bindingSource, Product product)
        {
            var table = dataSet.Tables["Products"];
            var row = table.NewRow();
            nextItem -= 1;
            row["ProductID"] = nextItem;
            row["ProductName"] = product.ProductName;
            row["SupplierID"] = 1;
            row["CategoryID"] = product.CategoryID;
            row["QuantityPerUnit"] = product.QuantityPerUnit;
            row["UnitPrice"] = product.UnitPrice;
            row["UnitsInStock"] = product.UnitsInStock;
            row["UnitsOnOrder"] = product.UnitsOnOrder;
            row["ReorderLevel"] = 0;
            row["Discontinued"] = product.Discontinued;
            table.Rows.Add(row);
        }

        public void DeleteProduct(BindingSource bindingSource, int productId)
        {
            var table = dataSet.Tables["Products"];
            var query = from p in table.AsEnumerable()
                        where p.RowState != DataRowState.Deleted && p.Field<int>("ProductID") == productId
                        select p;

            var row = query.Single();
            row.Delete();
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
            SqlConnection connection = null;
            try
            {
                var settings = new Settings();
                connection = new SqlConnection(settings.NorthwindConnection);
                connection.Open();
                productsDataAdaper.Update(dataSet, "Products");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
        }
    }
}
