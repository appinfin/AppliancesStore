﻿using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class CreateBuy_Form : Form
    {
        public int SupplyID { get; set; } //id док-та "Покупка/комиссия"

        readonly BuyForm buyForm;

        #region //Форма док-та "Покупка/комиссия"
        public CreateBuy_Form(BuyForm buyForm)
        {
            InitializeComponent();
            this.buyForm = buyForm;
            splitContainer_CreateBuy.Panel2Collapsed = true;
        }
        #endregion

        #region //получение атрибутов док-та "Покупка/комиссия"
        public void GetAttributeDocumentBuy()
        {
            //получение даты, контрагента, склада
            using Db_Enterprise_Store_Context db = new();
            var date = db.Supplies.Where(s => s.SupplyId == SupplyID)
                    .Include(c => c.CounterpartysCounterparty)
                    .Include(st => st.StoragesStorage)
                    .Select(r => new
                    {
                        r.Date,
                        r.CounterpartysCounterparty.CounterpartyName,
                        r.StoragesStorage.StorageName
                    })
                    .ToList();

            #region //формирование представления даты, контрагента и склада в DGV этой формы
            txtDate_CreateBuy.Text = date[0].Date.ToString();
            txtCounterparty_CreateBuy.Text = date[0].CounterpartyName.ToString();
            txtStorage_CreateBuy.Text = date[0].StorageName.ToString();
            #endregion

            #region //добавляем № док-та в шапке окна
            Text = "";
            Text = $"Поступление товаров: Покупка/Комиссия № {SupplyID}";
            #endregion
        }
        #endregion

        #region ПОКА закоментировано
        //#region //получение списка товаров в док-те "Покупка/комиссия"
        /////<summary>
        /////Формирует представление списка товаров док-та "Покупка/комиссия"
        /////</summary>
        //public void GetListProductBuy()
        //{
        //    #region //Запрос к БД: отображение д-та "Покупка/комиссия"
        //    using Db_Enterprise_Store_Context db = new();
        //    //список товаров соответствующих коду док-та <Поступление товаров>
        //    //выбранного для редактирования
        //    var _supPrQty = db.SupplyPriceQtys.Where(s => s.SupplyId == this.SupplyID)
        //        .Include(s => s.Product)
        //        .Select(s => new
        //        { //формирование представления
        //            s.ProductId,
        //            s.Product.ProductName,
        //            s.PricePurchase,
        //            s.Quantity,
        //            Summa = s.PricePurchase * (decimal)s.Quantity
        //        })
        //        .ToList();

        //    //Привязка данных
        //    bind_DGV_CreateBuy.DataSource = _supPrQty;
        //    DGV_CreateBuy.DataSource = bind_DGV_CreateBuy;

        //    lblSumma.Text = "Сумма: " + db.SupplyPriceQtys
        //                            .Where(s => s.SupplyId == this.SupplyID)
        //                            .Select(p => p.PricePurchase * (decimal)p.Quantity)
        //                            .Sum()
        //                            .ToString("C");
        //    #endregion
        //}
        //#endregion 
        #endregion

        #region //Выбор из каталога и добавление строки в список док-та "Покупка/комиссия"
        /// <summary>
        /// Добавляет товар в список док-та "Покупка/комиссия"
        /// </summary>
        /// <param name="SelectedId"></param>
        internal void AddProductInListBuy(int SelectedId)
        {
            //получаем наименование выбранного товара для отображения в заголовке окна <Кол-во, цена>
            var ProductName = DGVcatalog_CreateBuy.CurrentRow.Cells["name"].Value.ToString();

            //создаём диалоговое окно <Кол-во, цена>
            var f = new SetPriceQty();
            f.Text += " " + ProductName;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //создаём экземпляр новой строки
                //для таблицы <Покупка товара / Цена / Кол-во>
                SupplyPriceQty newRow = new();
                newRow.SupplyId = SupplyID;
                newRow.ProductId = SelectedId;
                newRow.PricePurchase = f.PricePurchase;
                newRow.Quantity = (double)f.Quantity;
                //_ = f.PricePurchase * f.Quantity;

                try
                {
                    using Db_Enterprise_Store_Context db = new();
                    db.Add(newRow);
                    db.SaveChanges();
                    lblSumma.Text = "Сумма: " + db.SupplyPriceQtys
                                    .Where(s => s.SupplyId == SupplyID)
                                    .Select(p => p.PricePurchase * (decimal)p.Quantity)
                                    .Sum()
                                    .ToString("C");
                    DGV_CreateBuy.DataSource = Manager.GetListProductBuy(SupplyID);
                    this.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR !!!");
                }
            }
        }
        #endregion

        #region //Каталог товаров

        #region // Открытие панели "Каталог товаров" - КНОПКА <подобрать товар>
        private void ButDisplayDGVcatalog_CreateBuy_Click(object sender, EventArgs e)
        {
            using Db_Enterprise_Store_Context db = new();

            #region //Выборка для каталога товаров
            //выборка групп товаров
            var productGroupName = db.ProductsGroups
                .Select(n => new { category = "Группа", id = n.ProductGroupId, name = n.ProductGroupName })
                .ToList();
            //выборка товаров без группы
            var productsWithoutGroupName = db.Products
                .Where(p => p.ProductsGroupsProductGroupId == null)
                .Select(n => new { category = "Товар", id = n.ProductId, name = n.ProductName });

            //соединяем списки productGroupName и productsWithoutGroupName
            //вставляем список в список с указанного индекса
            productGroupName.InsertRange(productGroupName.Count - 1, productsWithoutGroupName);

            //привязка списка каталога товаров к DGV
            bind_DGVcatalog_CreateBuy.DataSource = productGroupName;
            DGVcatalog_CreateBuy.DataSource = bind_DGVcatalog_CreateBuy;
            #endregion

            #region //Представление выборки в DGVcatalog_CreateBuy
            DGVcatalog_CreateBuy.Columns["id"].Visible = false;
            //DGVcatalog_CreateBuy.Columns["category"].Visible = false;
            DGVcatalog_CreateBuy.Columns["category"].HeaderText = ""; //заголовок 
            DGVcatalog_CreateBuy.Columns["name"].HeaderText = "Номенклатура";
            #endregion

            #region //отобразить правую панель <выбор товара>
            splitContainer_CreateBuy.Panel2Collapsed = false;
            int _splitterDistance = 2 * this.splitContainer_CreateBuy.Size.Width / 3; //размер панели
            this.splitContainer_CreateBuy.SplitterDistance = _splitterDistance;
            #endregion
        }
        #endregion
        #endregion

        #region //Двойной клик по строке товара или группы товаров
        private void DGVcatalog_CreateBuy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //получаем данные из текущей выбраной строки Каталога товаров
            int SelectedId = (int)DGVcatalog_CreateBuy.CurrentRow.Cells["id"].Value;

            #region если "Группа" тогда получаем все связанные товары и отображаем их
            if ((string)DGVcatalog_CreateBuy.CurrentRow.Cells["category"].Value == "Группа")
            {
                using Db_Enterprise_Store_Context db = new();
                var product = db.Products
                    .Where(p => p.ProductsGroupsProductGroupId == SelectedId)
                    .Select(p => new { category = "Товар", id = p.ProductId, name = p.ProductName })
                    .ToList();

                bind_DGVcatalog_CreateBuy.DataSource = product;
                DGVcatalog_CreateBuy.DataSource = bind_DGVcatalog_CreateBuy;
                
            }
            #endregion

            #region если "Товар", проверяем его наличие в списке и добавляем
            //при условии, что список не пустой
            else
            {
                if (DGV_CreateBuy.Rows.Count > 0) //&& DGV_CreateBuy.Rows[0].DataBoundItem != null
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
                int countSave = db.SaveChanges();
                if (countFind.Equals(countSave))
                {
                    DGV_CreateBuy.Rows.Clear();
                    decimal O = 0;
                    lblSumma.Text = "Сумма: " + O.ToString("C");
                }
                else
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        }


        #endregion

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
                var curentDoc = db.Supplies
                    .Where(s => s.SupplyId == SupplyID)
                    .FirstOrDefault();
                var curentDateDoc = curentDoc.Date;//старые значения даты для textBox при ошибке для отката
                curentDoc.Date = monthCalendar1.SelectionStart;
                int resSave = db.SaveChanges();
                if (resSave != 1)
                {
                    if ( DialogResult.OK == MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз."))
                    {
                        this.txtDate_CreateBuy.Text = curentDateDoc.ToString();
                    }
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
            //this.txtDate_CreateBuy.Text = " соб2";
            //MessageBox.Show("СОБЫТИЕ MonthCalendar1_DateSelected");
        }
        #endregion

        private void ButOK_CreateBuy_Click(object sender, EventArgs e)
        {
            buyForm.DGV_BuyForm.DataSource = Manager.GetListDocumentBuy();
            buyForm.Refresh();
        }

        private void CreateBuy_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            buyForm.TStrip_BuyForm_Refresh_Click(sender, e);
        }
    }
}
