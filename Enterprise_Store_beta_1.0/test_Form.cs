using System;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class test_Form : Form
    {
        public test_Form()
        {
            InitializeComponent();
            SupplyID = 200;
        }
        int SupplyID { get; set; }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Manager.GetListProductBuy(SupplyID);
            label1.Text += GetSummaDocumentBuy(dataGridView1).ToString("C");
        }

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
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                summa += (decimal)dataGridView["Summa", i].Value;
            }

            return summa;
        } 
        #endregion

    }
}
