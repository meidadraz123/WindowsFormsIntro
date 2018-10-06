using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public class LinqSource : ISource
    {
        public object GetCategories()
        {
            object categories = null;
            using (var context = new NorthwindDataContext())
            {
                categories = context.LinqCategories.ToList();
            }
            return categories;
        }

        public object GetProducts(int catId)
        {
            object productsOfSelectedCategory = null;
            using (var context = new NorthwindDataContext())
            {
                var query = from p in context.LinqProducts
                            where p.CategoryID == catId
                            select p;
                productsOfSelectedCategory = query.ToList();
            }

            return productsOfSelectedCategory;
        }

        public bool AddProduct(Product product)
        {
            using (var context = new NorthwindDataContext())
            {
                var linqProduct = new LinqProduct();
                linqProduct.ProductName = product.ProductName;
                linqProduct.SupplierID = 1;
                linqProduct.CategoryID = product.CategoryID;
                linqProduct.QuantityPerUnit = product.QuantityPerUnit;
                linqProduct.UnitPrice = product.UnitPrice;
                linqProduct.UnitsInStock = (short)product.UnitsInStock;
                linqProduct.UnitsOnOrder = (short)product.UnitsOnOrder;
                linqProduct.ReorderLevel = 0;
                linqProduct.Discontinued = product.Discontinued;

                context.LinqProducts.InsertOnSubmit(linqProduct);
                Save(context);
            }

            return true;
        }

        public bool DeleteProduct(int productId)
        {
            using (var context = new NorthwindDataContext())
            {
                var query = from p in context.LinqProducts
                            where p.ProductID == productId
                            select p;
                var linqProduct = query.Single();
                context.LinqProducts.DeleteOnSubmit(linqProduct);
                Save(context);
            }

            return true;
        }

        public void Save()
        {
            using (var context = new NorthwindDataContext())
            {
                Save(context);
            }
        }

        public void Save(NorthwindDataContext context)
        {
            try
            {
                context.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
