using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using ModelLibrary_Estore_1;

namespace Enterprise_Store_beta_1._0
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region Расположение окон в родительской форме
        private void HorizontallyTileMyWindows(object sender, EventArgs e)
        {
            // Tile all child forms horizontally.
            this.LayoutMdi(MdiLayout.TileHorizontal);
            
        }

        private void VerticallyTileMyWindows(object sender, EventArgs e)
        {
            // Tile all child forms vertically.
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void CascadeMyWindows(object sender, EventArgs e)
        {
            // Cascade all MDI child windows.
            this.LayoutMdi(MdiLayout.Cascade);
        }
        #endregion

        #region Создание дочерних окон (форм) "Покупка", "Продажа"
        #region Форма док-тов "Реализация товаров" Файл > Создать > Продажа
        private void toolStripMenuSell_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //получаем список окон
            foreach (Form f in Application.OpenForms)
                //ищем окно с указанным именем
                //если находим то не создаём новое
                if (f.Name == "SellForm")
                {
                    ok = false;
                }
            //если не находим то создаём новое окно
            if (ok)
            {
                var sellForm = new SellForm();
                sellForm.MdiParent = this;
                sellForm.Show();
            }
        }
        #endregion

        #region Форма док-тов "Покупка/комиссия" Файл > Создать > Покупка
        private void toolStripMenuBuy_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (Form f in Application.OpenForms)
                if (f.Name == "BuyForm")
                {
                    ok = false;
                }
            if (ok)
            {
                //var t = Task.Run(() => Manager.GetListDocumentBuy());
                var buyForm = new BuyForm();
                buyForm.MdiParent = this;
                //t.Wait();
                //buyForm.bind_DGV_BuyForm = t.Result;
                buyForm.bind_DGV_BuyForm = Manager.GetListDocumentBuy();
                buyForm.Show();
            }
        }
        #endregion

        #endregion

        private void tStrip_Form1_CatalogCounterperty_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (Form f in Application.OpenForms)
                if (f.Name == "CatalogCounterparty_Form")
                {
                    ok = false;
                }
            if (ok)
            {
                //var t = Task.Run(() => Manager.GetListDocumentBuy());
                CatalogCounterparty_Form сatalogCounterparty_Form = new();
                сatalogCounterparty_Form.MdiParent = this;
                //t.Wait();
                //buyForm.bind_DGV_BuyForm = t.Result;

                сatalogCounterparty_Form.Show();
            }
        }
    }
}
