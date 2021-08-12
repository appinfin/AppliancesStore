using ModelLibrary_Estore_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class CreateSell_Form : Form
    {
        #region //Форма док-та "Реализация/заказ"
        public CreateSell_Form(SellForm sellForm)
        {
            InitializeComponent();
            this.sellForm = sellForm;
            splitContainer_CreateSell.Panel2Collapsed = true;
        }
        #endregion
        public int RealizationID { get; set; } //id док-та "Реализация/заказ"
        readonly SellForm sellForm;

        private void ButDisplayDGVcatalog_CreateBuy_Click(object sender, EventArgs e)
        {
            #region //отобразить правую панель <выбор товара>
            splitContainer_CreateSell.Panel2Collapsed = false;
            int _splitterDistance = 2 * this.splitContainer_CreateSell.Size.Width / 3; //размер панели
            this.splitContainer_CreateSell.SplitterDistance = _splitterDistance;
            #endregion

            #region //Выборка из БД для каталога товаров
            using Db_Enterprise_Store_Context db = new();

            //выборка групп товаров
            var productGroupName = db.ProductsGroups
                .Select(n => new { category = "Группа", id = n.ProductGroupId, name = n.ProductGroupName, brand = "" })
                .OrderBy(n => n.category)
                .ToList();
            //выборка товаров без группы
            var productsWithoutGroupName = db.Products
                .Where(p => p.ProductsGroupsProductGroupId == null)
                .Select(p => new { category = "Товар", id = p.ProductId, name = p.ProductName, brand = p.BrandsBrand.BrandName })
                .OrderBy(n => n.name);

            //соединяем списки productGroupName и productsWithoutGroupName
            //вставляем список в список с указанного индекса
            productGroupName.InsertRange(productGroupName.Count, productsWithoutGroupName);

            //привязка списка товаров к DGV
            bind_DGVcatalog_CreateSell.DataSource = productGroupName;
            DGVcatalog_CreateBuy.DataSource = bind_DGVcatalog_CreateSell;
            #endregion

            ViewDGVcatalogCreateSell();
        }
        #region //Представление выборки в DGVcatalog_CreateSell
        void ViewDGVcatalogCreateSell()
        {
            DGVcatalog_CreateBuy.Columns["id"].Visible = false;
            //DGVcatalog_CreateBuy.Columns["category"].Visible = false;
            DGVcatalog_CreateBuy.Columns["category"].HeaderText = ""; //заголовок
            DGVcatalog_CreateBuy.Columns["category"].FillWeight = 20;
            DGVcatalog_CreateBuy.Columns["name"].HeaderText = "Номенклатура";
            DGVcatalog_CreateBuy.Columns["name"].FillWeight = 60;
            DGVcatalog_CreateBuy.Columns["brand"].HeaderText = "Производитель";
            DGVcatalog_CreateBuy.Columns["brand"].FillWeight = 20;
        }
        #endregion
    }
}
