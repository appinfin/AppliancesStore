using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ModelLibrary_Estore_1;

namespace Enterprise_Store_beta_1._0
{
    internal class Manager
    {
        #region Получаем список док-тов "Покупка/комиссия"
        internal static BindingSource GetListDocumentBuy()
        {
            //DataGridView DGV = new();
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
                .Include(s => s.Product)
                .Select(s => new
                { //формирование представления
                    s.ProductId,
                    s.Product.ProductName,
                    s.PricePurchase,
                    s.Quantity,
                    Summa = s.PricePurchase * (decimal)s.Quantity
                })
                .ToList();

            //Привязка данных
            bind_DGV_CreateBuy.DataSource = _supPrQty;

            return bind_DGV_CreateBuy;
            #endregion
        }
        #endregion
    }
}
