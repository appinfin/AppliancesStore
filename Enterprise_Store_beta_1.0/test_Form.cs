using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class test_Form : Form
    {
        public test_Form()
        {
            InitializeComponent();
            SupplyID = 164;
        }
        int SupplyID { get; set; }
        
        #region //получение списка товаров в док-те "Покупка/комиссия"
        ///<summary>
        ///Формирует представление списка товаров док-та "Покупка/комиссия"
        ///</summary>
        public void GetListProductBuy()
        {
            #region //Запрос к БД: отображение д-та "Покупка/комиссия"
            using Db_Enterprise_Store_Context db = new();
            //список товаров соответствующих коду док-та <Поступление товаров>
            //выбранного для редактирования
            var _supPrQty = db.SupplyPriceQtys.Where(s => s.SupplyId == this.SupplyID)
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
            bindingSource1.DataSource = _supPrQty;
            dataGridView1.DataSource = bindingSource1;

            #endregion
        }
        #endregion

        private void Test_Form_Load(object sender, EventArgs e)
        {
            GetListProductBuy();
        }
    }
}
