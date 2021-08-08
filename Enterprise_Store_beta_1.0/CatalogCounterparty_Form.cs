using ModelLibrary_Estore_1;
using System;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class CatalogCounterparty_Form : Form
    {
        public CatalogCounterparty_Form()
        {
            InitializeComponent();
        }
        BindingSource bind_DGV_CatalogCounterparty_Form = new();
        //internal int CounterpartyID { get; set; }
        internal Counterparty CurrentCounterparty { get; set; }

        private void CatalogCounterparty_Load(object sender, EventArgs e)
        {
            // Получаем источник данных, привязываем его и настраиваем столбцы DGV
            bind_DGV_CatalogCounterparty_Form.DataSource = Manager.GetListCouterparty();
            DGV_CatalogCounterparty_Form.DataSource = bind_DGV_CatalogCounterparty_Form;
            DGV_CatalogCounterparty_Form.Columns["Realizations"].Visible = false;
            DGV_CatalogCounterparty_Form.Columns["Supplies"].Visible = false;
        }

        #region // Двойной клик по строке для выбора и установки контрагента
        /// <summary>
        /// Метод устанавливает св-во CurrentCounterparty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CatalogCounterparty_Form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Modal) //окно в модальном режиме для выбора контрагента
            {

                CurrentCounterparty = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;
                this.DialogResult = DialogResult.OK;
            }
            else //окно в независимом режиме для редактирования ячеек
            {
                DGV_CatalogCounterparty_Form.BeginEdit(false);
            }
        }
        #endregion

        /// <summary>
        /// Проверка правильности введённого в поле (ячейку dgv) значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CatalogCounterparty_Form_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
       {
            if (DGV_CatalogCounterparty_Form.Rows[e.RowIndex].IsNewRow ||
                DGV_CatalogCounterparty_Form.IsCurrentCellDirty == false ||
                string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                DGV_CatalogCounterparty_Form.Rows[e.RowIndex].Cells["InnOgrnKpp"]
                    .ErrorText = "Значение состоит из одних пробелов\n" +
                    "Введите последовательность целых чисел или\n" +
                    "оставьте поле пустым.";
                return;
            }

            #region // проверка ввода в колонку "InnOgrnKpp"
            if (DGV_CatalogCounterparty_Form.Columns["InnOgrnKpp"].Index == e.ColumnIndex &&
                e.FormattedValue.ToString().Trim().Length != 0 &&
                (!long.TryParse(e.FormattedValue.ToString(), out long innOgrnKpp) || innOgrnKpp < 0))
            {
                DGV_CatalogCounterparty_Form.Rows[e.RowIndex].Cells["InnOgrnKpp"]
                    .ErrorText = "Неверный ввод значения!!!\n" +
                    "Введите последовательность целых чисел или\n" +
                    "оставьте поле пустым.";
            }
            #endregion
        }

        private void DGV_CatalogCounterparty_Form_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //bind_DGV_CatalogCounterparty_Form = (BindingSource)DGV_CatalogCounterparty_Form.DataSource;
            Counterparty currentItem = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;

            #region // UpdateEntyti()
            try
            {
                if (currentItem.CounterpartyId <= 0)
                {
                    using Db_Enterprise_Store_Context db = new();
                    db.Add(currentItem);
                    db.SaveChanges();
                }
                else
                {
                    using Db_Enterprise_Store_Context db = new();
                    db.Update(currentItem);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
            }
            #endregion
        }

        #region // Обработка ошибки ввода
        private void DGV_CatalogCounterparty_Form_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Сообщение об ошибке в текущей ячейке
            var currentCellErrorText = DGV_CatalogCounterparty_Form.CurrentRow.Cells[e.ColumnIndex].ErrorText;
            var enumContext = e.Context.ToString();
            if (MessageBox.Show(currentCellErrorText + "\n\n" +
                "Повтор - продолжить ввод значения,\n" +
                "Отмена - отменить ввод.\n" +
                enumContext,
                "Ошибка ввода!!!",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error) == DialogResult.Cancel)
            {
                DGV_CatalogCounterparty_Form.CancelEdit();
                //DGV_CatalogCounterparty_Form.EndEdit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
