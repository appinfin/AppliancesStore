using ModelLibrary_Estore_1;
using System;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    /// <summary>
    /// Class:
    ///     Форма Покупка/Комиссия
    ///     Отображает данные списка поступлений товаров от контрагента на склад.
    ///     В форме возможно задать данные о поступлении товара, создав новый документ(форму).
    /// Вывод на экран:
    ///     дата, контрагент, склад
    /// </summary>
    public partial class BuyForm : Form
    {

        public BuyForm()
        {
            InitializeComponent();
            //привязываем данные к эл-ту управления DGV_BuyForm
            bind_DGV_BuyForm = Manager.GetListDocumentBuy();
            DGV_BuyForm.DataSource = bind_DGV_BuyForm;
        }

        #region //Отображение док-тов "Покупка/комиссия"
        private void BuyForm_Load(object sender, EventArgs e)
        {
            #region 
            //формат вывода даты год/мес./день час/мин./сек.
            DGV_BuyForm.Columns["Date"].DefaultCellStyle.Format = "G";
            //формат в валюте
            DGV_BuyForm.Columns["TotalPriceSupply"].DefaultCellStyle.Format = "C";
            //изменяем заголовок колонок представления
            DGV_BuyForm.Columns["SupplyId"].HeaderText = "Код";
            DGV_BuyForm.Columns["SupplyId"].Visible = true;
            DGV_BuyForm.Columns["Date"].HeaderText = "Дата";
            DGV_BuyForm.Columns["CounterpartyName"].HeaderText = "Контрагент";
            DGV_BuyForm.Columns["StorageName"].HeaderText = "Склад";
            DGV_BuyForm.Columns["TotalPriceSupply"].HeaderText = "Сумма";
            #endregion
        }
        #endregion

        #region //Создание док-та "Покупка/комиссия" - КНОПКА Действия → создать покупка/комиссия
        private void ToolStrip_BuyForm_Action_CreateBuy_Click(object sender, EventArgs e)
        {
            CreateBuy_Form createBuy_Form = new()
            {
                //присваиваем родителя для формы
                //родитель Form1 (MdiContainer)
                MdiParent = this.MdiParent
            };

            #region //Запрос к БД: создание док-та "Покупка/комиссия"
            using Db_Enterprise_Store_Context db = new();
            Supply supply = new();
            var tracking = db.Add(supply); //добавление и получение данных о док-те "Покупка/комиссия"

            db.SaveChanges();

            //получаем ID созданного док-та и передаём его в форму док-та
            createBuy_Form.SupplyID = tracking.Entity.SupplyId;
            createBuy_Form.Supply = tracking.Entity;
            Manager.SetAttributeDocumentBuy(db, createBuy_Form); //устанавливаем атрибуты док-та
            createBuy_Form.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocument(createBuy_Form.DGV_CreateBuy)
                                            .ToString("C");

            createBuy_Form.Show(); //отображаем форму

            #endregion
        }
        #endregion

        #region //Редактирование док-та <Поступление товаров> - двойной клик по строке док-та
        private void DGV_BuyForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //создаём экземпляр формы <Поступление товара>
            CreateBuy_Form createBuy_Form = new()
            {
                //получаем значение Id документа
                //из ячейки DGV, выбранной строки, в колонке "SupplyId"
                
                SupplyID = (int)DGV_BuyForm.CurrentRow.Cells["SupplyId"].Value,

                //присваиваем родителя для формы
                //родитель Form1 (MdiContainer)
                MdiParent = this.MdiParent
            };

            //устанавливаем атрибуты док-та
            using Db_Enterprise_Store_Context db = new();
            Manager.SetAttributeDocumentBuy(db, createBuy_Form); //устанавливаем атрибуты док-та
            createBuy_Form.DGV_CreateBuy.DataSource = Manager.GetListProductBuy(createBuy_Form.SupplyID);
            createBuy_Form.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocument(createBuy_Form.DGV_CreateBuy)
                                            .ToString("C");

            createBuy_Form.Show(); //отображаем форму
        }
        #endregion

        #region //Удаление док-та <Поступление товаров>
        private void ToolStrip_ctxtMenu_BuyForm_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Вы уверены, что нужно удалить документ?\n" +
                                                   "Документ будет удалён безвозвратно!!!",
                                                   "Удалить документ Покупка/комиссия?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question))
            {
                var idS = (int)DGV_BuyForm.CurrentRow.Cells["SupplyId"].Value;
                using Db_Enterprise_Store_Context db = new();

                Supply selectedSupply = new() { SupplyId = idS };
                db.Attach(selectedSupply);
                db.Remove(selectedSupply);
                try
                {
                    var countSave = db.SaveChanges();
                    this.DGV_BuyForm.DataSource = Manager.GetListDocumentBuy();
                    this.Refresh();
                }
                catch
                {
                    MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                }
            }
        }
        #endregion

        #region //Обновить список док-тов "Покупка/комиссия"
        internal void TStrip_BuyForm_Refresh_Click(object sender, EventArgs e)
        {
            this.DGV_BuyForm.DataSource = Manager.GetListDocumentBuy();
            this.Refresh();
        }
        #endregion

        private void tStrip_ctxMenu_BuyForm_Open_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs ev = new(0,0);
            DGV_BuyForm_CellDoubleClick(sender, ev);
        }
    }
}

