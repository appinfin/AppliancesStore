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
    class Manager
    {
        internal BindingSource GetListDocumentBuy()
        {
            DataGridView DGV = new();
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

            #region //привязываем данные к эл-ту управления DGV - DataGridView
            //для представления в форме

            bind_DGV_BuyForm.DataSource = suppliesView;
            
            #endregion
            return bind_DGV_BuyForm;
        }
    }
}
