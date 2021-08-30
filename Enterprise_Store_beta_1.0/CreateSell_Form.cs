using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System;
using System.Data;
using System.Linq;
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
                .Select(n => new
                {
                    category = "Группа",
                    id = n.ProductGroupId,
                    name = n.ProductGroupName,
                    brand = "",
                    availableInStock = new Double?(),
                    allAvailableInStock = new Double?()
                })
                .ToList();
            //выборка товаров без группы
            var productsWithoutGroupName = db.Products
                //.Include(s => s.SupplyPriceQties)
                .Where(p => p.ProductsGroupsProductGroupId == null)
                .Select(p => new
                {
                    category = "Товар",
                    id = p.ProductId,
                    name = p.ProductName,
                    brand = p.BrandsBrand.BrandName,

                    availableInStock = (double?)p.SupplyPriceQties //получаем  поступление - реализация = кол-во на складе
                        //когда склад == указанному складу в док-те "Реализация товара"
                        .Where(s => s.Supply.StoragesStorage.StorageId == this.Realization.StoragesStorageId)
                        .Select(spq => spq.Quantity).Sum()
                        - p.RealizationPriceQties // реализация с этого же склада
                        .Where(r => r.Realization.StoragesStorage.StorageId == this.Realization.StoragesStorageId)
                        .Select(rpq => rpq.Quantity).Sum(),

                    allAvailableInStock = (double?)p.SupplyPriceQties.Select(spq => spq.Quantity).Sum() // все поступления
                        - p.RealizationPriceQties.Select(rpq => rpq.Quantity).Sum() // все реализации
                })
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
        /// <summary>
        /// Формирует колонки в dgv их отображение и размер
        /// </summary>
        void ViewDGVcatalogCreateSell()
        {
            DGVcatalog_CreateSell.Columns["id"].Visible = false;
            //DGVcatalog_CreateSell.Columns["category"].Visible = false;
            DGVcatalog_CreateSell.Columns["category"].HeaderText = ""; //заголовок
            DGVcatalog_CreateSell.Columns["category"].FillWeight = 10;
            DGVcatalog_CreateSell.Columns["name"].HeaderText = "Номенклатура";
            DGVcatalog_CreateSell.Columns["name"].FillWeight = 40;
            DGVcatalog_CreateSell.Columns["brand"].HeaderText = "Производитель";
            DGVcatalog_CreateSell.Columns["brand"].FillWeight = 15;
            DGVcatalog_CreateSell.Columns["availableInStock"].Visible = true;
            DGVcatalog_CreateSell.Columns["availableInStock"].HeaderText = "На складе";
            DGVcatalog_CreateSell.Columns["availableInStock"].FillWeight = 15;
            DGVcatalog_CreateSell.Columns["allAvailableInStock"].Visible = true;
            DGVcatalog_CreateSell.Columns["allAvailableInStock"].HeaderText = "На всех складах";
            DGVcatalog_CreateSell.Columns["allAvailableInStock"].FillWeight = 15;
        }
        #endregion


        #region #region // метод AddProductInListSell - Добавляет товар в список док-та
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
            f.Text += " " + productName; //цена кол-во имя товара
            f.PriceSelling = priceSelling; //цена с наценкой и скидкой для отображения в форме
            if (f.ShowDialog() == DialogResult.OK)
            {
                //создаём экземпляр новой строки
                //для таблицы <Реализация товара / Цена / Кол-во>
                RealizationPriceQty newRow = new();
                newRow.RealizationId = RealizationID;
                newRow.ProductId = SelectedId;
                //if (f.PriceSelling == 0) //если товара нет в покупке, то цена =0 и 
                //{
                //    f.PriceSelling = f.PricePurchase; // равна введённому в textBox числу
                //}
                newRow.PriceSelling = f.PricePurchase;
                newRow.Quantity = (double)f.Quantity;

                try
                {
                    //сохраняем в БД
                    using Db_Enterprise_Store_Context db = new();
                    db.Add(newRow);
                    db.SaveChanges();

                    //привязка списка товаров к DGV и обновление отображения
                    DGV_CreateSell.DataSource = Manager.GetListProductSell(RealizationID);

                    //получаем итоговую сумму товаров
                    this.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocument(this.DGV_CreateSell)
                                            .ToString("C");
                }
                catch (Exception)
                {
                    MessageBox.Show("Товар уже находится в списке.\n" +
                                    "Если хотите добавить этот товар по другой цене\n" +
                                    "создайте новый документ <Поступление товара>.");
                }
            }
        } 
        #endregion

        #region //Двойной клик по строке товара или группы товаров
        private void DGVcatalog_CreateSell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //получаем данные из текущей выбраной строки Каталога товаров
            int SelectedId = (int)DGVcatalog_CreateSell.CurrentRow.Cells["id"].Value;

            #region если "Группа" тогда получаем все связанные товары и отображаем их
            if ((string)DGVcatalog_CreateSell.CurrentRow.Cells["category"].Value == "Группа")
            {
                using Db_Enterprise_Store_Context db = new();

                //выборка товаров в группе
                var productsWithGroupName = db.Products
                    .Where(p => p.ProductsGroupsProductGroupId == SelectedId)
                    //.Include(s => s.SupplyPriceQties)
                    .Select(p => new
                    {
                        category = "Товар",
                        id = p.ProductId,
                        name = p.ProductName,
                        brand = p.BrandsBrand.BrandName,

                        availableInStock = (double?)p.SupplyPriceQties //получаем  поступление - реализация = кол-во на складе
                        //когда склад == указанному складу в док-те "Реализация товара"
                        .Where(s => s.Supply.StoragesStorage.StorageId == this.Realization.StoragesStorageId)
                        .Select(spq => spq.Quantity).Sum()
                        - p.RealizationPriceQties // реализация с этого же склада
                        .Where(r => r.Realization.StoragesStorage.StorageId == this.Realization.StoragesStorageId)
                        .Select(rpq => rpq.Quantity).Sum(),

                        allAvailableInStock = (double?)p.SupplyPriceQties.Select(spq => spq.Quantity).Sum() // все поступления
                        - p.RealizationPriceQties.Select(rpq => rpq.Quantity).Sum() // все реализации
                    })
                    .OrderBy(n => n.name).ToList();


                bind_DGVcatalog_CreateSell.DataSource = productsWithGroupName;
                DGVcatalog_CreateSell.DataSource = bind_DGVcatalog_CreateSell;
                ViewDGVcatalogCreateSell();
            }
            #endregion

            #region // если "Товар", то добавляем в список
            else
            {
                AddProductInListSell(SelectedId);
            }
            #endregion
        }
        #endregion

        #endregion

        #region //Очистка списка товаров в док-те "Реализация/заказ"
        //нажатее кнопки <Очистить список>
        private void ButClearList_CreateSell_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Вы уверены, что нужно очистить список?\n" +
                                                   "Список будет удалён безвозвратно!!!",
                                                   "Очистить список?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question))
            {
                using Db_Enterprise_Store_Context db = new();
                //выбираем строки 
                var res = db.RealizationPriceQtys.Where(s => s.RealizationId == RealizationID).AsEnumerable();
                
                try
                {
                    db.RemoveRange(res);
                    db.SaveChanges();
                    DGV_CreateSell.Rows.Clear(); //очистка DGV
                    lblSumma.Text = String.Format("Сумма {0:C2}", 0);
                }
                catch
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        }
        #endregion

        #region // Установка атрибутов док-та "Реализация/заказ"
        #region //Календарь и кнопка для его отображения
        private void ButSelectDate_CreateSell_Click(object sender, EventArgs e)
        {
            //если не отображается, тогда отобразить
            if (!this.monthCalendar1.Visible)
            {
                this.monthCalendar1.Visible = true; //отобразить
                this.monthCalendar1.BringToFront(); //на передний план
            }
            //если отображается, тогда скрыть и сохранить дату
            else
            {
                this.monthCalendar1.Visible = false; //скрыть
                using Db_Enterprise_Store_Context db = new();
                var currentDoc = db.Realizations
                    .Where(s => s.RealizationId == RealizationID)
                    .FirstOrDefault();
                var currentDateDoc = currentDoc.Date;//старые значения даты для textBox при ошибке для отката
                currentDoc.Date = monthCalendar1.SelectionStart;
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    txtDate_CreateSell.Text = currentDateDoc.ToString();
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }

            }
        }
        //изменение даты док-та "Покупка/комиссия"
        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.txtDate_CreateSell.Text = "" + monthCalendar1.SelectionStart;
        }

        #endregion

        #region// Выбор контрагентов.
        private void ButSelectCounterparty_CreateSell_Form_Click(object sender, EventArgs e)
        {
            CatalogCounterparty_Form catalogCounterparty = new();

            if (catalogCounterparty.ShowDialog() == DialogResult.OK)
            {
                using Db_Enterprise_Store_Context db = new();
                //получаем строку из БД по id текущего открытого док-та "Покупка/комиссия"
                Realization currentDocRealization = db.Realizations
                    .Where(s => s.RealizationId == RealizationID)
                    .FirstOrDefault();
                //изменяем данные в БД (меняем Id контрагента)
                currentDocRealization.CounterpartysCounterpartyId = catalogCounterparty.CurrentCounterparty.CounterpartyId;

                try
                {
                    db.SaveChanges(); //сохраняем изменения в БД
                    this.txtCounterparty_CreateSell.Text = catalogCounterparty.CurrentCounterparty.CounterpartyName;
                    //Manager.SetAttributeDocumentBuy(db, this); //устанавливаем атрибуты док-та "Покупка/комиссия"
                }
                catch
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
                finally
                {
                    catalogCounterparty.Dispose();
                }
            }
        }
        #endregion

        #region // Выбор склада
        private void ButSelectStorage_CreateSell_Form_Click(object sender, EventArgs e)
        {
            CatalogStorage_Form catalogStorage = new();

            if (catalogStorage.ShowDialog() == DialogResult.OK)
            {
                using Db_Enterprise_Store_Context db = new();
                //получаем строку из БД по id текущего открытого док-та "Покупка/комиссия"
                var currentDoc = db.Realizations
                    .Where(s => s.RealizationId == RealizationID)
                    .FirstOrDefault();
                currentDoc.StoragesStorageId = catalogStorage.CurrentStorage.StorageId;
                this.Realization.StoragesStorageId = catalogStorage.CurrentStorage.StorageId;

                try
                {
                    db.SaveChanges();
                    Manager.SetAttributeDocumentSell(db, this); //устанавливаем атрибуты док-та "Покупка/комиссия"
                    ButDisplayDGVcatalog_CreateSell_Click(sender, e);

                }
                catch
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        }
        #endregion

        #region // Выбор персонала
        private void ButSelectPersonnel_CreateSell_Click(object sender, EventArgs e)
        {
            CatalogPersonnels_Form catalogPersonnels = new();

            if (catalogPersonnels.ShowDialog() == DialogResult.OK)
            {
                using Db_Enterprise_Store_Context db = new();
                //получаем строку из БД по id текущего открытого док-та "Реализация/заказы"
                var currentDoc = db.Realizations
                    .Where(s => s.RealizationId == RealizationID)
                    .FirstOrDefault();
                currentDoc.PersonnelsPersonnelId = catalogPersonnels.CurrentPersonnel.PersonnelId;
                this.Realization.PersonnelsPersonnelId = catalogPersonnels.CurrentPersonnel.PersonnelId;

                try
                {
                    db.SaveChanges();
                    Manager.SetAttributeDocumentSell(db, this); //устанавливаем атрибуты док-та "Покупка/комиссия"
                    ButDisplayDGVcatalog_CreateSell_Click(sender, e);

                }
                catch
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        } 
        #endregion
        #endregion

        #region // Кнопка "Провести", Кнопка закрытия формы - Обновление формы Buy_Form
        // Кнопка "Провести". Обновление данных в форме список док-тов "Покупка/комиссия"
        private void ButOK_CreateSell_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms;
            SellForm sellForm = (SellForm)openForms["SellForm"];
            sellForm.TStrip_SellForm_Refresh_Click(sender, e);
        }

        // Кнопка закрытия формы. Обновление данных в форме список док-тов "Покупка/комиссия"
        private void CreateSell_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.MdiFormClosing)
            {
                return;
            }
            ButOK_CreateSell_Click(sender, e);
            //buyForm.TStrip_BuyForm_Refresh_Click(sender, e);
        }
        #endregion

        #region // Кнопка "Добавить" на панели выбор товара из списка
        private void ButCatalogProduct_Add_Click(object sender, EventArgs e)
        {
            AddProduct_Form addProduct_Form = new();
            addProduct_Form.ShowDialog();
            ButDisplayDGVcatalog_CreateSell_Click(sender, e);
        }
        #endregion

        #region // Кнопка "Изменить" на панели выбор товара из списка
        private void ButCatalogProduct_Edit_Click(object sender, EventArgs e)
        {
            var productID = (int)DGVcatalog_CreateSell.CurrentRow.Cells["id"].Value;
            AddProduct_Form addProduct_Form = new();
            addProduct_Form.PutAttrbuteProduct(productID);

            addProduct_Form.ShowDialog();

            ButDisplayDGVcatalog_CreateSell_Click(sender, e);
        }
        #endregion

        #region //Кнопка "Удалить" товар.
        private void ButCatalogProduct_Delete_Click_1(object sender, EventArgs e)
        {

            if (DialogResult.OK == MessageBox.Show("Вы уверены, что нужно удалить товар?\n" +
                                                   "Товар будет удалён безвозвратно!!!",
                                                   "Удалить товар?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question))
            {
                var productID = (int)DGVcatalog_CreateSell.CurrentRow.Cells["id"].Value;
                using Db_Enterprise_Store_Context db = new();
                //кол-во ссылок на док-ты "Покупка/комиссия" где есть выбранный удаляемый товар
                var countRefOnDoc = db.SupplyPriceQtys.Where(s => s.ProductId == productID).Count();
                if (countRefOnDoc == 0)
                {
                    try
                    {
                        var selectedProduct = db.Products.First(p => p.ProductId == productID);
                        var rem = db.Remove(selectedProduct);
                        var countSave = db.SaveChanges();
                        ButDisplayDGVcatalog_CreateSell_Click(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно удалить.\n" +
                                    "Товар ссылается на док-ты Покупка/комиссия",
                                    "Удаление товара"
                                    , MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region // Удаление товара из списка товаров в док-те "Реализация/заказ"
        /// <summary>
        /// Нажатие кнопки "Х" в строке списка товаров док-та "Покупка/комиссия"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CreateSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            DGV_CreateSell.Columns["Delete_row"].Index) return;

            if (DialogResult.OK == MessageBox.Show("Вы уверены, что нужно удалить товар из списка?",
                                                   "Удалить товар из списка?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question))
            {
                int selectedProductID = (int)DGV_CreateSell.CurrentRow.Cells["ProductId"].Value;
                using Db_Enterprise_Store_Context db = new();
                var currentProductForRemove = db.RealizationPriceQtys.Where(r => r.RealizationId == RealizationID)
                                  .First(p => p.ProductId == selectedProductID);
                try
                {
                    db.Remove(currentProductForRemove);
                    db.SaveChanges();
                    DGV_CreateSell.Rows.RemoveAt(e.RowIndex);
                    //получаем итоговую сумму товаров
                    this.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocument(this.DGV_CreateSell)
                                            .ToString("C");
                }
                catch (Exception)
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        }
        #endregion

        #region //Поиск по названию после набора не менее 3-х символов в txtSearch_CreateBuy
        /// <summary>
        /// Поиск товара по названию в каталоге товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearch_CreateSell_TextChanged(object sender, EventArgs e)
        {
            while (txtSearch_CreateSell.Text.Length < 3)
            {
                return;
            }

            Db_Enterprise_Store_Context db = new();

            var foundProduct = db.Products
                    .Where(p => p.ProductName.StartsWith(txtSearch_CreateSell.Text))
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


            bind_DGVcatalog_CreateSell.DataSource = foundProduct;
            DGVcatalog_CreateSell.DataSource = bind_DGVcatalog_CreateSell;

            ViewDGVcatalogCreateSell();
        }









        #endregion


    }
}
