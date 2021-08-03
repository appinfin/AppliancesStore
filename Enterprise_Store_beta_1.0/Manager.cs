using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    internal class Manager
    {
        #region //установка атрибутов док-та "Покупка/комиссия" по Id док-та
        public static void SetAttributeDocumentBuy(Db_Enterprise_Store_Context db, CreateBuy_Form createBuy_Form)
        {
            //получение даты, контрагента, склада
            var date = db.Supplies.Where(s => s.SupplyId == createBuy_Form.SupplyID)
                    .Select(r => new
                    {
                        r.Date,
                        r.CounterpartysCounterparty.CounterpartyName,
                        r.StoragesStorage.StorageName
                    })
                    .ToList();

            #region //формирование представления даты, контрагента и склада в DGV этой формы
            createBuy_Form.txtDate_CreateBuy.Text = date[0].Date.ToString();
            createBuy_Form.txtCounterparty_CreateBuy.Text = date[0].CounterpartyName.ToString();
            createBuy_Form.txtStorage_CreateBuy.Text = date[0].StorageName.ToString();
            #endregion

            #region //добавляем № док-та в шапке окна
            createBuy_Form.Text = "";
            createBuy_Form.Text = $"Поступление товаров: Покупка/Комиссия № {createBuy_Form.SupplyID}";
            #endregion

            //return createBuy_Form;
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
                .Skip(0) //пропускаем число строк от начала списка например 0
                .Take(30) //получаем нужное кол-во строк например 30
                .ToList(); //преобразуем полученные данные в список
            #endregion

            #region //создаём объект источник данных для привязки к DGV
            bind_DGV_BuyForm.DataSource = suppliesView;
            return bind_DGV_BuyForm;
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
        internal static decimal GetSummaDocumentBuy(DataGridView dataGridView)
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

    }
}
