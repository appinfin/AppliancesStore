using ModelLibrary_Estore_1;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Enterprise_Store_beta_1._0
{
    public partial class AddProduct_Form : Form
    {
        public AddProduct_Form()
        {
            InitializeComponent();
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            using Db_Enterprise_Store_Context db = new();

            var allBrands = db.Brands.ToList();
            bindComBox_Brand.DataSource = allBrands;
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
                    db.Add(product);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Упс!!! Что-то пошло не так. Попробуйте ещё раз");
                }
                txtProductName.Text = "";
                comBoxBrand.Text = "- выбрать из списка -";
                comBoxProductGroup.Text = "- выбрать из списка -";
                comBoxUnit.Text = "- выбрать из списка -";
            }
        } 
        #endregion
    }
}
