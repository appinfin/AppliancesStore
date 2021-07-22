//using ModelLibrary_Estore_1;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Enterprise_Store_beta_1._0
//{
//    public class ProductCatalog
//    {
//        DataGridView ViewCatalog()
//        {
//            using Db_Enterprise_Store_Context db = new Db_Enterprise_Store_Context();

//            #region //Выборка для каталога товаров
//            var productGroupName = db.ProductsGroups
//                .Select(n => new { category = "Группа", id = n.ProductGroupId, name = n.ProductGroupName })
//                .ToList();

//            var productsWithoutGroupName = db.Products
//                .Where(p => p.ProductsGroupsProductGroupId.Value == null)
//                .Select(n => new { category = "Товар", id = n.ProductId, name = n.ProductName });
//            //.ToList();

//            foreach (var item in productsWithoutGroupName)
//            {
//                productGroupName = productGroupName.Append(item).ToList();
//            }

//            bind_DGVcatalog_CreateBuy.DataSource = productGroupName;
//            DGVcatalog_CreateBuy.DataSource = bind_DGVcatalog_CreateBuy;
//            #endregion
//        }
//    }
//}