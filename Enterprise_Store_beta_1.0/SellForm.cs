using ModelLibrary_Estore_1;
using System;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
            //привязываем данные к эл-ту управления DGV_CreateSell
            bind_DGV_SellForm = Manager.GetListDocumentSell();
            DGV_SellForm.DataSource = bind_DGV_SellForm;
        }

        #region #region //Отображение док-тов "Реализация/заказ"
        private void SellForm_Load(object sender, EventArgs e)
        {
            #region 
            //формат вывода даты год/мес./день час/мин./сек.

            DGV_SellForm.Columns["Date"].DefaultCellStyle.Format = "G";
            //формат в валюте
            DGV_SellForm.Columns["TotalPriceRealization"].DefaultCellStyle.Format = "C";
            //изменяем заголовок колонок представления
            DGV_SellForm.Columns["RealizationId"].HeaderText = "Код";
            DGV_SellForm.Columns["RealizationId"].Visible = true;
            DGV_SellForm.Columns["Date"].HeaderText = "Дата";
            DGV_SellForm.Columns["CounterpartyName"].HeaderText = "Контрагент";
            DGV_SellForm.Columns["StorageName"].HeaderText = "Склад";
            DGV_SellForm.Columns["TotalPriceRealization"].HeaderText = "Сумма";
            #endregion
        } 
        #endregion

        #region //Создание док-та "Реализация/заказ" - КНОПКА Действия → создать продажа/заказ
        private void ToolStrip_SellForm_Action_CreateSell_Click(object sender, EventArgs e)
        {
            CreateSell_Form createSell_Form = new()
            {
                //присваиваем родителя для формы
                //родитель Form1 (MdiContainer)
                MdiParent = this.MdiParent
            };

            #region //Запрос к БД: создание док-та "Продажа/заказ"
            using Db_Enterprise_Store_Context db = new();
            Realization realization = new();
            var tracking = db.Add(realization); //добавление и получение данных о док-те "Продажа/заказ"

            db.SaveChanges();

            //получаем ID созданного док-та и передаём его в форму док-та
            createSell_Form.RealizationID = tracking.Entity.RealizationId;
            createSell_Form.Realization = tracking.Entity;
            Manager.SetAttributeDocumentSell(db, createSell_Form); //устанавливаем атрибуты док-та
            createSell_Form.lblSumma.Text = "Сумма: "
                                            + Manager.GetSummaDocument(createSell_Form.DGV_CreateSell)
                                            .ToString("C");

            createSell_Form.Show();
            #endregion
        }
        #endregion

        
    }
}
