using System;
using System.Windows.Forms;

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

        #region // Создание дочерних окон (форм) "Покупка", "Продажа"

        #region //Форма док-тов "Реализация товаров" Файл > Создать > Продажа
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
                var buyForm = new BuyForm();
                buyForm.MdiParent = this;
                buyForm.Show();
            }
        }
        #endregion

        #endregion

        #region //Файл >>> Каталог контрагентов (открываем форму)
        private void tStrip_Form1_CatalogCounterperty_Click(object sender, EventArgs e)
        {
            CatalogCounterparty_Form сatalogCounterparty_Form = new();
            сatalogCounterparty_Form.Show();
        }
        #endregion

        #region //Файл >>> Каталог складов (открываем форму)
        private void tStrip_Form1_CatalogStorages_Click(object sender, EventArgs e)
        {
            CatalogStorage_Form catalogStorage_Form = new();
            //catalogStorage_Form.MdiParent = this;
            catalogStorage_Form.ShowDialog();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuBuy_Click(sender, e);
            toolStripMenuSell_Click(sender, e);
            VerticallyTileMyWindows(sender, e);
        }
    }
}
