using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    internal class Manager
    {
        #region //установка атрибутов док-та "Покупка/комиссия" по Id док-та
        public static void SetAttributeDocumentBuy(Db_Enterprise_Store_Context db,
                                                   CreateBuy_Form createBuy_Form)
        {
            createBuy_Form.Supply = db.Supplies.Where(s => s.SupplyId == createBuy_Form.SupplyID).First();
            //получение даты, контрагента, склада
            var attributeDoc = db.Supplies.Where(s => s.SupplyId == createBuy_Form.SupplyID)
                    .Select(r => new
                    {
                        r.Date,
                        r.CounterpartysCounterparty.CounterpartyName,
                        r.StoragesStorage.StorageName,
                        StoragesStorageId = r.StoragesStorageId
                    })
                    .ToList();

            #region //формирование представления даты, контрагента и склада в DGV этой формы
            createBuy_Form.txtDate_CreateBuy.Text = attributeDoc[0].Date.ToString();
            createBuy_Form.txtCounterparty_CreateBuy.Text = attributeDoc[0].CounterpartyName.ToString();
            createBuy_Form.txtStorage_CreateBuy.Text = attributeDoc[0].StorageName.ToString();
            #endregion

            #region //добавляем № док-та в шапке окна Продажа товаров: Реализация/Заказ
            createBuy_Form.Text = "";
            createBuy_Form.Text = $"Поступление товаров: Покупка/Комиссия № {createBuy_Form.SupplyID}";
            #endregion
        }
        #endregion

        #region // Получаем список док-тов "Покупка/комиссия"
        internal static BindingSource GetListDocumentBuy()
        {
            BindingSource bind_DGV_BuyForm = new();
            //создание экземпляра контекста данных
            using Db_Enterprise_Store_Context db = new();

            #region Запрос к бд таблица Supplies, выборка всех док-тов "Покупка/комиссия"
            var suppliesView = db.Supplies
                .Include(c => c.CounterpartysCounterparty)
                .Include(s => s.StoragesStorage)
                .Include(spq => spq.SupplyPriceQties)
                .Select(b => new
                {
                    b.SupplyId,
                    b.Date,
                    b.CounterpartysCounterparty.CounterpartyName,
                    b.StoragesStorage.StorageName,
                    TotalPriceSupply = b.SupplyPriceQties.Select(p => p.PricePurchase * (decimal)p.Quantity).Sum()
                })
                .OrderByDescending(d => d.Date) //сортируем по убыванию даты
                //.Skip(0) //пропускаем число строк от начала списка например 0
                .Take(30) //получаем нужное кол-во строк например 30
                .ToList(); //преобразуем полученные данные в список
            #endregion

            #region //создаём объект источник данных для привязки к DGV
            bind_DGV_BuyForm.DataSource = suppliesView;
            return bind_DGV_BuyForm;
            #endregion
        }
        #endregion

        #region //получение списка товаров в док-те "Покупка/комиссия"
        ///<summary>
        ///Формирует представление списка товаров док-та "Покупка/комиссия"
        ///</summary>
        ///
        internal static BindingSource GetListProductBuy(int SupplyID)
        {
            BindingSource bind_DGV_CreateBuy = new();
            #region //Запрос к БД: отображение д-та "Покупка/комиссия"
            using Db_Enterprise_Store_Context db = new();
            //список товаров соответствующих коду док-та <Поступление товаров>
            //выбранного для редактирования
            var _supPrQty = db.SupplyPriceQtys.Where(s => s.SupplyId == SupplyID)
                //.Include(s => s.Product)
                .Select(s => new
                { //формирование представления
                    s.ProductId,
                    s.Product.ProductName,
                    s.PricePurchase,
                    s.Quantity,
                    Summa = s.PricePurchase * (decimal)s.Quantity,
                    textButton = ""
                })
                .ToList();

            //Привязка данных
            bind_DGV_CreateBuy.DataSource = _supPrQty;

            return bind_DGV_CreateBuy;
            #endregion
        }
        #endregion

        #region //Получаем итоговую сумму док-та "Покупка/комиссия"
        //GetSummaDocumentBuy(DataGridView dataGridView)
        /// <summary>
        /// Возвращает итоговую сумму списка товаров. В списке должна быть колонка с именем "Summa"
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns>decimal summa</returns>
        internal static decimal GetSummaDocument(DataGridView dataGridView)
        {
            decimal summa = 0;
            if (dataGridView.Rows.Count != 0 && dataGridView["Summa", 0].Value != null)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    summa += (decimal)dataGridView["Summa", i].Value;
                }
            }
            else
            {
                return 0;
            }

            return summa;
        }
        #endregion

        #region// Получаем список контрагентов
        internal static BindingSource GetListCouterparty()
        {
            BindingSource bind_DGV_Counterparty = new();
            //создание экземпляра контекста данных
            using Db_Enterprise_Store_Context db = new();

            //Запрос к бд таблица Counterpartys, выборка контрагентов
            var counterparty = db.Counterpartys.ToList();
            //.Include(c=> c.Supplies).Include(c=> c.Realizations)

            //создаём объект источник данных для привязки к DGV
            bind_DGV_Counterparty.DataSource = counterparty;
            return bind_DGV_Counterparty;
        }
        #endregion

        #region// Получаем список складов
        internal static BindingSource GetListStorage()
        {
            BindingSource bind_DGV_Storage = new();
            //создание экземпляра контекста данных
            using Db_Enterprise_Store_Context db = new();

            //Запрос к бд Storages, выборка складов
            var storages = db.Storages.ToList();

            //создаём объект источник данных для привязки к DGV
            bind_DGV_Storage.DataSource = storages;
            return bind_DGV_Storage;
        }
        #endregion


        #region //установка атрибутов док-та "Реализация/заказ" по Id док-та
        public static void SetAttributeDocumentSell(Db_Enterprise_Store_Context db,
                                                   CreateSell_Form createSell_Form)
        {
            createSell_Form.Realization = db.Realizations.Where(s => s.RealizationId == createSell_Form.RealizationID).First();
            //получение даты, контрагента, склада
            var attributeDoc = db.Realizations.Where(s => s.RealizationId == createSell_Form.RealizationID)
                    .Select(r => new
                    {
                        r.Date,
                        r.CounterpartysCounterparty.CounterpartyName,
                        r.StoragesStorage.StorageName,
                        r.PersonnelsPersonnel.PersonnelName
                    })
                    .ToList();

            #region //формирование представления даты, контрагента и склада в DGV этой формы
            createSell_Form.txtDate_CreateSell.Text = attributeDoc[0].Date.ToString();
            createSell_Form.txtCounterparty_CreateSell.Text = attributeDoc[0].CounterpartyName.ToString();
            createSell_Form.txtStorage_CreateSell.Text = attributeDoc[0].StorageName.ToString();
            createSell_Form.txtPersonnel_CreateSell.Text = attributeDoc[0].PersonnelName.ToString();
            #endregion

            #region //добавляем № док-та в шапке окна
            createSell_Form.Text = "";
            createSell_Form.Text = $"Продажа товаров: Реализация/Заказ № {createSell_Form.RealizationID}";
            #endregion
        }
        #endregion

        #region // Получаем список док-тов "Реализация/заказ"
        internal static BindingSource GetListDocumentSell()
        {
            BindingSource bind_DGV_SellForm = new();
            //создание экземпляра контекста данных
            using Db_Enterprise_Store_Context db = new();

            #region Запрос к бд таблица Realizations, выборка всех док-тов "Реализация/заказ"
            var realizationView = db.Realizations
                .Include(s => s.CounterpartysCounterparty)
                .Include(s => s.StoragesStorage)
                .Include(s => s.RealizationPriceQties)
                .Select(b => new
                {
                    b.RealizationId,
                    b.Date,
                    b.CounterpartysCounterparty.CounterpartyName,
                    b.StoragesStorage.StorageName,
                    TotalPriceRealization = b.RealizationPriceQties.Select(p => p.PriceSelling * (decimal)p.Quantity).Sum()
                })
                .OrderByDescending(d => d.Date) //сортируем по убыванию даты
                //.Skip(0) //пропускаем число строк от начала списка например 0
                .Take(30) //получаем нужное кол-во строк например 30
                .ToList(); //преобразуем полученные данные в список
            #endregion

            #region //создаём объект источник данных для привязки к DGV
            bind_DGV_SellForm.DataSource = realizationView;
            return bind_DGV_SellForm;
            #endregion
        }
        #endregion

        #region //получение списка товаров в док-те "Реализация/заказ"
        ///<summary>
        ///Формирует представление списка товаров док-та "Реализация/заказ"
        ///</summary>
        ///
        internal static BindingSource GetListProductSell(int RealizationID)
        {
            BindingSource bind_DGV_CreateSell = new();
            #region //Запрос к БД: отображение д-та "Реализация/заказ"
            using Db_Enterprise_Store_Context db = new();
            //список товаров соответствующих коду док-та <Поступление товаров>
            //выбранного для редактирования
            var _realPrQty = db.RealizationPriceQtys.Where(r => r.RealizationId == RealizationID)
                .Select(r => new
                { //формирование представления
                    r.ProductId,
                    r.Product.ProductName,
                    r.PriceSelling,
                    r.Quantity,
                    Summa = r.PriceSelling * (decimal)r.Quantity,
                    textButton = ""
                })
                .ToList();

            //Привязка данных
            bind_DGV_CreateSell.DataSource = _realPrQty;

            return bind_DGV_CreateSell;
            #endregion
        }
        #endregion

        public static decimal GetPriceSell(int SelectedId)
        {
            decimal priceSell = 0;

            Db_Enterprise_Store_Context db = new();
            var price = db.SupplyPriceQtys
                .Include(s => s.Supply)
                .Where(p => p.ProductId == SelectedId)
                .Select(p => new { p.PricePurchase, date = p.Supply.Date })
                .OrderBy(p => p.date).First();

            return priceSell = price.PricePurchase;//[0].PricePurchase;
        }
    }
}
