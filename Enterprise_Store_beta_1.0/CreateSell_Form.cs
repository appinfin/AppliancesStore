using ModelLibrary_Estore_1;
using Microsoft.EntityFrameworkCore;
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
        public CreateSell_Form()
        {
            InitializeComponent();
            splitContainer_CreateSell.Panel2Collapsed = true;
        }
        #endregion
        public int RealizationID { get; set; } //id док-та "Реализация/заказ"
        public Realization Realization { get; set; }

        #region //Панель "Каталог товаров" подобрать товар
        #region // Открытие панели "Каталог товаров" - КНОПКА <подобрать товар>
        private void ButDisplayDGVcatalog_CreateSell_Click(object sender, EventArgs e)
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
            DGVcatalog_CreateSell.DataSource = bind_DGVcatalog_CreateSell;
            #endregion

            ViewDGVcatalogCreateSell();
        }
        #endregion

        #region //Представление выборки в DGVcatalog_CreateSell
        void ViewDGVcatalogCreateSell()
        {
            DGVcatalog_CreateSell.Columns["id"].Visible = false;
            //DGVcatalog_CreateSell.Columns["category"].Visible = false;
            DGVcatalog_CreateSell.Columns["category"].HeaderText = ""; //заголовок
            DGVcatalog_CreateSell.Columns["category"].FillWeight = 20;
            DGVcatalog_CreateSell.Columns["name"].HeaderText = "Номенклатура";
            DGVcatalog_CreateSell.Columns["name"].FillWeight = 60;
            DGVcatalog_CreateSell.Columns["brand"].HeaderText = "Производитель";
            DGVcatalog_CreateSell.Columns["brand"].FillWeight = 20;
            DGVcatalog_CreateSell.Columns["availableInStock"].Visible = true;
            DGVcatalog_CreateSell.Columns["availableInStock"].HeaderText = "На складе";
            DGVcatalog_CreateSell.Columns["availableInStock"].FillWeight = 10;
            DGVcatalog_CreateSell.Columns["allAvailableInStock"].Visible = true;
            DGVcatalog_CreateSell.Columns["allAvailableInStock"].HeaderText = "На всех складах";
            DGVcatalog_CreateSell.Columns["allAvailableInStock"].FillWeight = 10;
        }
        #endregion

        /// <summary>
        /// Добавляет товар в список док-та "Реализация/заказ".
        /// Где (int SelectedId) - выбранный Id товара
        /// </summary>
        /// <param name="SelectedId"></param>
        internal void AddProductInListSell(int SelectedId)
        {
            //получаем наименование выбранного товара для отображения в заголовке окна <Кол-во, цена>
            var productName = DGVcatalog_CreateSell.CurrentRow.Cells["name"].Value.ToString();
            var priceSelling = Manager.GetPriceSell(SelectedId); //получаем цену покупки

            //создаём диалоговое окно <Кол-во, цена>
            var f = new SetPriceQty();
            f.Text += " " + productName;
            f.PriceSelling = priceSelling * (decimal)1.3;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //создаём экземпляр новой строки
                //для таблицы <Реализация товара / Цена / Кол-во>
                RealizationPriceQty newRow = new();
                newRow.RealizationId = RealizationID;
                newRow.ProductId = SelectedId;
                newRow.PriceSelling = f.PriceSelling;
                newRow.Quantity = (double)f.Quantity;

                try
                {
                    //сохраняем в БД
                    using Db_Enterprise_Store_Context db = new();
                    db.Add(newRow);
                    db.SaveChanges();

                    //привязка списка товаров к DGV и обновление отображения
                    DGV_CreateSell.DataSource = Manager.GetListProductBuy(RealizationID);
                    //this.Refresh();

                    //получаем итоговую сумму товаров
                    this.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocument(this.DGV_CreateSell)
                                            .ToString("C");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR !!!");
                }
            }
        }

        #region //Двойной клик по строке товара или группы товаров
        private void DGVcatalog_CreateSell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //получаем данные из текущей выбраной строки Каталога товаров
            int SelectedId = (int)DGVcatalog_CreateSell.CurrentRow.Cells["id"].Value;

            #region если "Группа" тогда получаем все связанные товары и отображаем их
            if ((string)DGVcatalog_CreateSell.CurrentRow.Cells["category"].Value == "Группа")
            {
                using Db_Enterprise_Store_Context db = new();
                //var productsWithGroupName = db.Products
                //    .Where(p => p.ProductsGroupsProductGroupId == SelectedId)
                //    .Select(p => new { category = "Товар", id = p.ProductId, name = p.ProductName, brand = p.BrandsBrand.BrandName })
                //    .ToList();

                //выборка товаров в группе
                var productsWithGroupName = db.Products
                    .Where(p => p.ProductsGroupsProductGroupId == SelectedId)
                    .Include(s => s.SupplyPriceQties)
                    .Select(p => new
                    {
                        category = "Товар",
                        id = p.ProductId,
                        name = p.ProductName,
                        brand = p.BrandsBrand.BrandName,

                        availableInStock = p.SupplyPriceQties
                                        .Where(s => s.Supply.StoragesStorage.StorageId == this.Realization.StoragesStorageId)
                                        .Select(q => new { q.Quantity }).Select(q => q.Quantity).Sum().ToString(),

                        allAvailableInStock = p.SupplyPriceQties.Select(q => new { q.Quantity }).Select(q => q.Quantity).Sum().ToString()
                    })
                    .OrderBy(n => n.name).ToList();


                bind_DGVcatalog_CreateSell.DataSource = productsWithGroupName;
                DGVcatalog_CreateSell.DataSource = bind_DGVcatalog_CreateSell;
                ViewDGVcatalogCreateSell();
            }
            #endregion

            #region если "Товар", проверяем его наличие в списке и добавляем
            //при условии, что список не пустой
            else
            {
                if (DGV_CreateSell.Rows.Count > 0)
                {
                    var rowsCollection = DGV_CreateSell.Rows; //получаем коллекцию строк DGV
                    //поиск товара в списке <Поступление товара>
                    //по текущему выбранному Id из Каталога товаров
                    foreach (DataGridViewRow row in rowsCollection)
                    {
                        //сравниваем Id выбранного товара с
                        //имеющимися в списке <Поступление товара>
                        bool b = SelectedId.Equals(row.Cells[0].Value);
                        if (b == false)
                        {
                            //если Id не совпадают, тогда продолжаем перебор списка и сравнение
                            if (rowsCollection.Count > row.Index + 1)
                            {
                                continue;
                            }
                            //по завершению списка добавляем строку с товаром
                            else
                            {
                                AddProductInListSell(SelectedId);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Товар уже находится в списке.\n" +
                                    "Если хотите добавить этот товар по другой цене\n" +
                                    "создайте новый документ <Поступление товара>.");
                            break;
                        }
                    }
                }
                else
                {
                    AddProductInListSell(SelectedId);
                }
            }
            #endregion
        }
        #endregion
#endregion
    }
}
