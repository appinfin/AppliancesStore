using ModelLibrary_Estore_1;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class CreateBuy_Form : Form
    {
        #region //Форма док-та "Покупка/комиссия"
        public CreateBuy_Form(BuyForm buyForm)
        {
            InitializeComponent();
            this.buyForm = buyForm;
            splitContainer_CreateBuy.Panel2Collapsed = true;

        }
        #endregion

        public int SupplyID { get; set; } //id док-та "Покупка/комиссия"
        readonly BuyForm buyForm;

        #region //Панель "Каталог товаров" подобрать товар
        #region // Открытие панели "Каталог товаров" - КНОПКА <подобрать товар>
        private void ButDisplayDGVcatalog_CreateBuy_Click(object sender, EventArgs e)
        {
            #region //отобразить правую панель <выбор товара>
            splitContainer_CreateBuy.Panel2Collapsed = false;
            int _splitterDistance = 2 * this.splitContainer_CreateBuy.Size.Width / 3; //размер панели
            this.splitContainer_CreateBuy.SplitterDistance = _splitterDistance;
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
            bind_DGVcatalog_CreateBuy.DataSource = productGroupName;
            DGVcatalog_CreateBuy.DataSource = bind_DGVcatalog_CreateBuy;
            #endregion

            ViewDGVcatalogCreateBuy();
        }
        #endregion

        #region //Представление выборки в DGVcatalog_CreateBuy
        void ViewDGVcatalogCreateBuy()
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

        /// <summary>
        /// Добавляет товар в список док-та "Покупка/комиссия".
        /// Где (int SelectedId) - выбранный Id товара
        /// </summary>
        /// <param name="SelectedId"></param>
        internal void AddProductInListBuy(int SelectedId)
        {
            //получаем наименование выбранного товара для отображения в заголовке окна <Кол-во, цена>
            var productName = DGVcatalog_CreateBuy.CurrentRow.Cells["name"].Value.ToString();

            //создаём диалоговое окно <Кол-во, цена>
            var f = new SetPriceQty();
            f.Text += " " + productName;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //создаём экземпляр новой строки
                //для таблицы <Покупка товара / Цена / Кол-во>
                SupplyPriceQty newRow = new();
                newRow.SupplyId = SupplyID;
                newRow.ProductId = SelectedId;
                newRow.PricePurchase = f.PricePurchase;
                newRow.Quantity = (double)f.Quantity;

                try
                {
                    //сохраняем в БД
                    using Db_Enterprise_Store_Context db = new();
                    db.Add(newRow);
                    db.SaveChanges();

                    //привязка списка товаров к DGV и обновление отображения
                    DGV_CreateBuy.DataSource = Manager.GetListProductBuy(SupplyID);
                    //this.Refresh();

                    //получаем итоговую сумму товаров
                    this.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocumentBuy(this.DGV_CreateBuy)
                                            .ToString("C");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR !!!");
                }
            }
        }

        #region //Двойной клик по строке товара или группы товаров
        private void DGVcatalog_CreateBuy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //получаем данные из текущей выбраной строки Каталога товаров
            int SelectedId = (int)DGVcatalog_CreateBuy.CurrentRow.Cells["id"].Value;

            #region если "Группа" тогда получаем все связанные товары и отображаем их
            if ((string)DGVcatalog_CreateBuy.CurrentRow.Cells["category"].Value == "Группа")
            {
                using Db_Enterprise_Store_Context db = new();
                var productsWithGroupName = db.Products
                    .Where(p => p.ProductsGroupsProductGroupId == SelectedId)
                    .Select(p => new { category = "Товар", id = p.ProductId, name = p.ProductName, brand = p.BrandsBrand.BrandName })
                    .ToList();

                bind_DGVcatalog_CreateBuy.DataSource = productsWithGroupName;
                DGVcatalog_CreateBuy.DataSource = bind_DGVcatalog_CreateBuy;

            }
            #endregion

            #region если "Товар", проверяем его наличие в списке и добавляем
            //при условии, что список не пустой
            else
            {
                if (DGV_CreateBuy.Rows.Count > 0)
                {
                    var rowsCollection = DGV_CreateBuy.Rows; //получаем коллекцию строк DGV
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
                                AddProductInListBuy(SelectedId);
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
                    AddProductInListBuy(SelectedId);
                }
            }
            #endregion
        }
        #endregion
        #endregion

        #region //Очистка списка товаров в док-те <Покупка/комиссия>
        //нажатее кнопки <Очистить список>
        private void ButClearList_CreateBuy_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Вы уверены, что нужно очистить список?\n" +
                                                   "Список будет удалён безвозвратно!!!",
                                                   "Очистить список?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question))
            {
                using Db_Enterprise_Store_Context db = new();
                //выбираем строки 
                var res = db.SupplyPriceQtys.Where(s => s.SupplyId == SupplyID).AsEnumerable();
                int countFind = res.Count();
                db.RemoveRange(res);
                try
                {
                    db.SaveChanges();
                    DGV_CreateBuy.Rows.Clear(); //очистка DGV
                    lblSumma.Text = String.Format("Сумма {0:C2}", 0);
                }
                catch
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        }

        #endregion

        #region // Установка атрибутов док-та "Покупка/комиссия"
        #region //Календарь и кнопка для его отображения
        private void ButSelectDate_CreateBuy_Click(object sender, EventArgs e)
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
                var currentDoc = db.Supplies
                    .Where(s => s.SupplyId == SupplyID)
                    .FirstOrDefault();
                var currentDateDoc = currentDoc.Date;//старые значения даты для textBox при ошибке для отката
                currentDoc.Date = monthCalendar1.SelectionStart;
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    txtDate_CreateBuy.Text = currentDateDoc.ToString();
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }

            }
        }

        //изменение даты док-та "Покупка/комиссия"
        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.txtDate_CreateBuy.Text = "" + monthCalendar1.SelectionStart;
        }
        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        }
        #endregion

        #region// Выбор контрагентов.
        private void ButSelectCounterparty_CreateBuy_Click(object sender, EventArgs e)
        {
            CatalogCounterparty_Form catalogCounterparty = new();

            if (catalogCounterparty.ShowDialog() == DialogResult.OK)
            {
                using Db_Enterprise_Store_Context db = new();
                //получаем строку из БД по id текущего открытого док-та "Покупка/комиссия"
                Supply currentDocSupply = db.Supplies
                    .Where(s => s.SupplyId == SupplyID)
                    .FirstOrDefault();
                //изменяем данные в БД (меняем Id контрагента)
                currentDocSupply.CounterpartysCounterpartyId = catalogCounterparty.CurrentCounterparty.CounterpartyId;

                try
                {
                    db.SaveChanges(); //сохраняем изменения в БД
                    this.txtCounterparty_CreateBuy.Text = catalogCounterparty.CurrentCounterparty.CounterpartyName;
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
        private void ButSelectStorage_CreateBuy_Click(object sender, EventArgs e)
        {
            CatalogStorage_Form catalogStorage = new();

            if (catalogStorage.ShowDialog() == DialogResult.OK)
            {
                using Db_Enterprise_Store_Context db = new();
                //получаем строку из БД по id текущего открытого док-та "Покупка/комиссия"
                var currentDoc = db.Supplies
                    .Where(s => s.SupplyId == SupplyID)
                    .FirstOrDefault();
                currentDoc.StoragesStorageId = catalogStorage.StorageID;

                try
                {
                    db.SaveChanges();
                    Manager.SetAttributeDocumentBuy(db, this); //устанавливаем атрибуты док-та "Покупка/комиссия"
                }
                catch
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        }
        #endregion 
        #endregion

        #region // Кнопка "Провести". Обновление данных в форме список док-тов "Покупка/комиссия"
        private void ButOK_CreateBuy_Click(object sender, EventArgs e)
        {
            buyForm.TStrip_BuyForm_Refresh_Click(sender, e);
        }
        #endregion

        #region // Кнопка закрытия формы. Обновление данных в форме список док-тов "Покупка/комиссия"
        private void CreateBuy_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            buyForm.TStrip_BuyForm_Refresh_Click(sender, e);
        }
        #endregion

        #region // Кнопка "Добавить" на панели выбор товара из списка
        private void ButAddProduct_CreateBuy_Click(object sender, EventArgs e)
        {
            AddProduct_Form addProduct_Form = new();
            //addProduct_Form.Bind();
            addProduct_Form.ShowDialog();
            ButDisplayDGVcatalog_CreateBuy_Click(sender, e);
        }
        #endregion

        #region // Кнопка "Изменить" на панели выбор товара из списка
        private void ButCatalogProduct_Edit_Click(object sender, EventArgs e)
        {
            var productID = (int)DGVcatalog_CreateBuy.CurrentRow.Cells["id"].Value;
            AddProduct_Form addProduct_Form = new();
            addProduct_Form.PutAttrbuteProduct(productID);

            addProduct_Form.ShowDialog();

            ButDisplayDGVcatalog_CreateBuy_Click(sender, e);
        }
        #endregion

        #region //Кнопка "Удалить" товар.
        private void ButCatalogProduct_Delete_Click(object sender, EventArgs e)
        {

            if (DialogResult.OK == MessageBox.Show("Вы уверены, что нужно удалить товар?\n" +
                                                   "Товар будет удалён безвозвратно!!!",
                                                   "Удалить товар?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question))
            {
                var productID = (int)DGVcatalog_CreateBuy.CurrentRow.Cells["id"].Value;
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
                        ButDisplayDGVcatalog_CreateBuy_Click(sender, e);
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

        #region // Удаление товара из списка товаров в док-те "Покупка/комиссия"
        /// <summary>
        /// Нажатие кнопки "Х" в строке списка товаров док-та "Покупка/комиссия"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CreateBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            DGV_CreateBuy.Columns["Delete_row"].Index) return;

            if (DialogResult.OK == MessageBox.Show("Вы уверены, что нужно удалить товар из списка?",
                                                   "Удалить товар из списка?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question))
            {
                int selectedProductID = (int)DGV_CreateBuy.CurrentRow.Cells["ProductId"].Value;
                using Db_Enterprise_Store_Context db = new();
                var currentProductForRemove = db.SupplyPriceQtys.Where(s => s.SupplyId == SupplyID)
                                  .First(p => p.ProductId == selectedProductID);
                try
                {
                    db.Remove(currentProductForRemove);
                    db.SaveChanges();
                    DGV_CreateBuy.Rows.RemoveAt(e.RowIndex);
                    //получаем итоговую сумму товаров
                    this.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocumentBuy(this.DGV_CreateBuy)
                                            .ToString("C");
                    MessageBox.Show("Cell Click!!!");
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
        private void txtSearch_CreateBuy_TextChanged(object sender, EventArgs e)
        {
            while (txtSearch_CreateBuy.Text.Length < 3)
            {
                return;
            }
            MessageBox.Show("Text change", "ПОИСК", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Db_Enterprise_Store_Context db = new();
            var s = db.Products.Where(p => p.ProductName.StartsWith(txtSearch_CreateBuy.Text))
                .Select(p => new { category = "Товар", id = p.ProductId, name = p.ProductName, brand = p.BrandsBrand.BrandName })
                .ToList();

            bind_DGVcatalog_CreateBuy.DataSource = s;
            DGVcatalog_CreateBuy.DataSource = bind_DGVcatalog_CreateBuy;

            ViewDGVcatalogCreateBuy();
        } 
        #endregion
    }
}
