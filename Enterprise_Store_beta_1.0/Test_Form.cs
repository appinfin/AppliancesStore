using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class Test_Form : Form
    {

        public Test_Form()
        {
            InitializeComponent();
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {

            using Db_Enterprise_Store_Context db = new();


            var sq = db.Products
                .Include(s => s.SupplyPriceQties)
                .ToQueryString();

            var sqq = db.Products
                .Include(s => s.SupplyPriceQties)
                .ThenInclude(s => s.Supply.StoragesStorage)
                .Select(ss => new
                {
                    ss.ProductId,
                    ss.ProductName,
                    supplyCount = ss.SupplyPriceQties.Count,
                    //supplyID = ss.SupplyPriceQties.Select(s => s.su),
                    qty = ss.SupplyPriceQties.Select(s => new {s.Quantity}).Select(s => s.Quantity).Sum()
                })
                .ToList();

            bindComBox_Brand.DataSource = sqq;
            dataGridView1.DataSource = bindComBox_Brand;
            textBox1.Text = sq;




            #region // Запрос атрибутов док-та  к БД
            //var allBrands = db.Brands.ToList();
            //bindComBox_Brand.DataSource = allBrands;
            //comBoxBrand.DataSource = bindComBox_Brand; //привязка бренд
            //comBoxBrand.SelectedItem = null; //ставим пустой эл-т
            //comBoxBrand.Text = "- выбрать из списка -";

            //var allGroups = db.ProductsGroups.ToList();
            //bindComBox_ProductGroup.DataSource = allGroups; //привязка групп товаров
            //comBoxProductGroup.DataSource = bindComBox_ProductGroup;
            //comBoxProductGroup.SelectedItem = null;
            //comBoxProductGroup.Text = "- выбрать из списка -";

            //var allUnits = db.Units.ToList();
            //bindComBox_Unit.DataSource = allUnits; //привязка ед.изм
            //comBoxUnit.DataSource = bindComBox_Unit;
            //comBoxUnit.SelectedItem = null;
            //comBoxUnit.Text = "- выбрать из списка -"; 
            #endregion

            #region Привязка к ДГВ построчно
            //    dataGridView1.ColumnCount = 4;
            //    string[] row1 = new string[] { "Meatloaf", "Main Dish", "ground beef",
            //"**" };
            //    string[] row2 = new string[] { "Key Lime Pie", "Dessert",
            //"lime juice, evaporated milk", "****" };
            //    string[] row3 = new string[] { "Orange-Salsa Pork Chops", "Main Dish",
            //"pork chops, salsa, orange juice", "****" };
            //    string[] row4 = new string[] { "Black Bean and Rice Salad", "Salad",
            //"black beans, brown rice", "****" };
            //    string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert",
            //"cream cheese", "***" };
            //    string[] row6 = new string[] { "Black Bean Dip", "Appetizer",
            //"black beans, sour cream", "***" };
            //    object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };

            //    foreach (string[] rowArray in rows)
            //    {
            //        dataGridView1.Rows.Add(rowArray);
            //    } 
            #endregion
        }

        #region //Добавить товар и сохранить в БД кнопка "Сохранить"
        private void Button1_Click(object sender, EventArgs e)
        {
            var sProductName = txtProductName.Text.Trim();//удаляем пробелы начала и конца строки
            if (sProductName == string.Empty) //если строка пустая то Message
            {
                MessageBox.Show(@"Поле ""Наименование"" пусто");
            }
            else
            {
                Product product = new();
                //var id = product.ProductId;
                product.ProductName = sProductName;
                product.BrandsBrandId = (int?)comBoxBrand.SelectedValue;
                product.ProductsGroupsProductGroupId = (int?)comBoxProductGroup.SelectedValue;
                product.UnitsIdUnit = (int?)comBoxUnit.SelectedValue;
                if (numSale_AddProduct.Value == 0) //если скидка 0%
                {
                    product.ProductSale = null; //тогда null
                }
                else
                {
                    product.ProductSale = (double)numSale_AddProduct.Value;
                }
                try
                {
                    using Db_Enterprise_Store_Context db = new();
                    if (product.ProductId == 0)
                    {
                        db.Add(product);
                        db.SaveChanges();
                        var b = Int32.TryParse(txtProductId.Text, out int productID);
                        if (b)
                        {

                            product.ProductId = productID;
                            db.Update(product);
                            db.SaveChanges();
                            txtProductId.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Упс!!! Что-то пошло не так.\n" +
                                            "Попробуйте ещё раз");
                        }
                    }
                    else
                    {
                        db.Add(product);
                        db.SaveChanges();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Упс!!! Что-то пошло не так.\n" +
                                            "Попробуйте ещё раз");
                }

                txtProductName.Text = "";
                comBoxBrand.Text = "- выбрать из списка -";
                comBoxProductGroup.Text = "- выбрать из списка -";
                comBoxUnit.Text = "- выбрать из списка -";
            }
        }
        #endregion

        public void ViewAttrbuteProduct(int productID)
        {
            using Db_Enterprise_Store_Context db = new();
            var productInfo = db.Products.Find(productID); // Находим товар по Id
            // Заполняем поля формы текущими значениями выбранного товара для редактирования
            txtProductId.Text = productInfo.ProductId.ToString();
            txtProductName.Text = productInfo.ProductName;
            if (productInfo.BrandsBrandId != null)
            {
                comBoxBrand.SelectedValue = productInfo.BrandsBrandId;
            }
            if (productInfo.ProductsGroupsProductGroupId != null)
            {
                comBoxProductGroup.SelectedValue = productInfo.ProductsGroupsProductGroupId;
            }
            if (productInfo.UnitsIdUnit != null)
            {
                comBoxUnit.SelectedValue = productInfo.UnitsIdUnit;
            }
            if (productInfo.ProductSale == null)
            {
                numSale_AddProduct.Value = 0;
            }
            else
            {
                numSale_AddProduct.Value = (decimal)productInfo.ProductSale;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var et = this.dataGridView1.SelectedCells[0].EditType;
            //bool b = this.dataGridView1.BeginEdit(true);
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            var idx = comBoxBrand.FindString(txtProductName.Text);
            comBoxBrand.SelectedIndex = idx;
        }

        #region // ПОИСК
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            while (txtProductName.Text.Length < 3)
            {
                return;
            }
            MessageBox.Show("Text change", "ПОИСК", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Db_Enterprise_Store_Context db = new();
            var s = db.Products.Where(p => p.ProductName.StartsWith(txtProductName.Text))
                .Select(p => new { category = "Товар", id = p.ProductId, name = p.ProductName, brand = p.BrandsBrand.BrandName })
                .ToList();

            bindDGV.DataSource = s;
            dataGridView1.DataSource = bindDGV;

            #region //Представление выборки в dataGridView1
            dataGridView1.Columns["id"].Visible = false;
            //dataGridView1.Columns["category"].Visible = false;
            dataGridView1.Columns["category"].HeaderText = ""; //заголовок
            dataGridView1.Columns["category"].FillWeight = 20;
            dataGridView1.Columns["name"].HeaderText = "Номенклатура";
            dataGridView1.Columns["name"].FillWeight = 60;
            dataGridView1.Columns["brand"].HeaderText = "Производитель";
            dataGridView1.Columns["brand"].FillWeight = 20;
            #endregion

        }
        #endregion
    }
}
