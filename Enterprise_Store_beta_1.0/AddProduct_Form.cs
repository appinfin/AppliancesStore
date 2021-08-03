using ModelLibrary_Estore_1;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Enterprise_Store_beta_1._0
{
    public partial class AddProduct_Form : Form
    {
        Dictionary<string, object> dicBindLists = new();
        public AddProduct_Form()
        {
            InitializeComponent();
            Bind();
        }

        /// <summary>
        /// Привязка данных к полям формы "Карточка товара"
        /// </summary>
        internal void Bind()
        {
            
            using Db_Enterprise_Store_Context db = new();

            var allBrands = db.Brands.ToList();
            this.bindComBox_Brand.DataSource = allBrands;
            comBoxBrand.DataSource = bindComBox_Brand; //привязка бренд
            comBoxBrand.SelectedItem = null; //ставим пустой эл-т
            comBoxBrand.Text = "- выбрать из списка -";

            var allGroups = db.ProductsGroups.ToList();
            bindComBox_ProductGroup.DataSource = allGroups; //привязка групп товаров
            comBoxProductGroup.DataSource = bindComBox_ProductGroup;
            comBoxProductGroup.SelectedItem = null;
            comBoxProductGroup.Text = "- выбрать из списка -";
            
            var allUnits = db.Units.ToList();
            bindComBox_Unit.DataSource = allUnits; //привязка ед.изм
            comBoxUnit.DataSource = bindComBox_Unit;
            comBoxUnit.SelectedItem = null;
            comBoxUnit.Text = "- выбрать из списка -";

            dicBindLists.Add("brands", allBrands);
            dicBindLists.Add("groups", allGroups);
            dicBindLists.Add("units", allUnits);

            //object[] arrLists = { allBrands, allGroups, allUnits };
            //var v = (IList<object>)arrLists;
            //var idx = v.IndexOf(allBrands);
            //var idx2 = v.IndexOf(allGroups);
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

                    //если поле id не пусто, тогда редактируем товар
                    if (txtProductId.Text.Length != 0)
                    {
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
                            MessageBox.Show("1 Упс!!! Что-то пошло не так.\n" +
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
                    MessageBox.Show("2 Упс!!! Что-то пошло не так.\n" +
                                            "Попробуйте ещё раз");
                }

                txtProductName.Text = "";
                comBoxBrand.Text = "- выбрать из списка -";
                comBoxProductGroup.Text = "- выбрать из списка -";
                comBoxUnit.Text = "- выбрать из списка -";
            }
        }
        #endregion

        /// <summary>
        /// Находит товар по Id  и выводит атрибуты в поля формы. В режиме изменения товара.
        /// </summary>
        /// <param name="productID"></param>
        public void PutAttrbuteProduct(int productID)
        {
            //List<object> list = new(){ currentSelProd };
            //BindingSource bS = new(currentSelProd, "brand");

            //comBoxBrand.DataSource = bS;
            //comBoxProductGroup.DataSource = list;
            //comBoxUnit.DataSource = list;
            //comBoxBrand.DisplayMember = "brand";
            //comBoxProductGroup.DisplayMember = "groups";
            //comBoxUnit.DisplayMember = "brand";
            
            using Db_Enterprise_Store_Context db = new();
            var product = db.Products.Find(productID); // Находим товар по Id
            // Заполняем поля формы текущими значениями выбранного товара для редактирования
            txtProductId.Text = product.ProductId.ToString();
            txtProductName.Text = product.ProductName;

            if (product.BrandsBrandId != null)
            {
                comBoxBrand.SelectedValue = product.BrandsBrandId;

            }
            if (product.ProductsGroupsProductGroupId != null)
            {
                comBoxProductGroup.SelectedValue = product.ProductsGroupsProductGroupId;
            }
            if (product.UnitsIdUnit != null)
            {
                comBoxUnit.SelectedValue = product.UnitsIdUnit;
            }
            if (product.ProductSale == null)
            {
                numSale_AddProduct.Value = 0;
            }
            else
            {
                numSale_AddProduct.Value = (decimal)product.ProductSale;
            }
        }
    }
}
