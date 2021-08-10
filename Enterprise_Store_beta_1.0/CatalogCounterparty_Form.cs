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
            var dirty = DGV_CatalogCounterparty_Form.IsCurrentCellDirty;

            if (DGV_CatalogCounterparty_Form.Rows[e.RowIndex].IsNewRow) // если новая строка
            {
                return;
            }
            //var currentColumnName = DGV_CatalogCounterparty_Form.Columns[e.ColumnIndex].Name;

            var fv = DGV_CatalogCounterparty_Form.CurrentCell.FormattedValue.ToString(); //до форматирования
            var efv = DGV_CatalogCounterparty_Form.CurrentCell.EditedFormattedValue.ToString().Trim(); //форматируемое значение (текущее введённое)
            // если равны или null или одни пробелы
            if (fv.Equals(efv) || string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                // Если колонка CounterpartyName неизменна или пустая
                if (DGV_CatalogCounterparty_Form.Columns["CounterpartyName"].Index == e.ColumnIndex)
                {
                    DGV_CatalogCounterparty_Form.CancelEdit();
                    DGV_CatalogCounterparty_Form.EndEdit();
                    return;
                }
                //текcт ошибки при IsNullOrWhiteSpace
                DGV_CatalogCounterparty_Form.Rows[e.RowIndex].Cells["InnOgrnKpp"]
                    .ErrorText = "Значение состоит из одних пробелов\n" +
                    "Введите последовательность целых чисел или\n" +
                    "оставьте поле пустым.";
                return;
            }
            
            #region // проверка ввода в колонку "InnOgrnKpp"
            if (DGV_CatalogCounterparty_Form.Columns["InnOgrnKpp"].Index == e.ColumnIndex &&
                //e.FormattedValue.ToString().Trim().Length != 0 &&
                (!long.TryParse(e.FormattedValue.ToString(), out long innOgrnKpp) || innOgrnKpp < 0))
            {
                DGV_CatalogCounterparty_Form.Rows[e.RowIndex].Cells["InnOgrnKpp"]
                    .ErrorText = "Неверный ввод значения!!!\n" +
                    "Введите последовательность целых чисел или\n" +
                    "оставьте поле пустым.";
                return;
            }
            #endregion

            #region // Сохранить запись или отменить изменения
            if (DialogResult.Cancel == MessageBox.Show(
                    "Сохранить запись?",
                    "Сохранить контрагента?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question))
            {
                DGV_CatalogCounterparty_Form.CancelEdit();
                DGV_CatalogCounterparty_Form.EndEdit();
                //e.Cancel = true;
            }
            else
            {
                DGV_CatalogCounterparty_Form.EndEdit();
                Counterparty currentItem = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;
                //если имя не пустое
                if (!string.IsNullOrWhiteSpace(currentItem.CounterpartyName))
                {
                    #region // Получаем текущий эл-т списка и добавляем или обновляем в бд
                    try
                    {
                        if (currentItem.CounterpartyId <= 0) //если новая запись добавляем в бд
                        {
                            using Db_Enterprise_Store_Context db = new();
                            db.Add(currentItem);
                            db.SaveChanges();
                        }
                        else
                        {
                            using Db_Enterprise_Store_Context db = new(); //иначе обновляем имеющуюся запись в бд
                            db.Update(currentItem);
                            db.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Упс! Что-то пошло не так. Попробуйте ещё раз.");
                        DGV_CatalogCounterparty_Form.CancelEdit();
                        DGV_CatalogCounterparty_Form.EndEdit();
                    }
                    #endregion
                }
                else
                {
                    #region // Отмена
                    DGV_CatalogCounterparty_Form.CancelEdit();
                    DGV_CatalogCounterparty_Form.EndEdit(); 
                    #endregion
                }
            } 
            #endregion
        }

        #region // Обработка ошибки ввода
        private void DGV_CatalogCounterparty_Form_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Получаем строку сообщения об ошибке из текущей ячейки
            var currentCellErrorText = DGV_CatalogCounterparty_Form.CurrentRow.Cells[e.ColumnIndex].ErrorText;

            #region // Сообщение об ошибке в текущей ячейке
            if (MessageBox.Show(currentCellErrorText + "\n\n" +
                    "Повтор - продолжить ввод значения,\n" +
                    "Отмена - отменить ввод.\n",
                    "Ошибка ввода!!!",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error) == DialogResult.Cancel)
            {
                DGV_CatalogCounterparty_Form.CancelEdit();
                DGV_CatalogCounterparty_Form.EndEdit();
            }
            else
            {
                e.Cancel = true;
            }
            #endregion
        }
        #endregion

        private void TStrip_CatalogCounterparty_Delete_Click(object sender, EventArgs e)
        {
            //var idC = (int)DGV_CatalogCounterparty_Form.CurrentRow.Cells["CounterpartyId"].Value;
            Counterparty currentItem = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;

            using Db_Enterprise_Store_Context db = new();
            db.Remove(currentItem);
            db.SaveChanges();
            bind_DGV_CatalogCounterparty_Form.RemoveCurrent();
        }

        private void TStripMenu_Delete_Click(object sender, EventArgs e)
        {
            TStrip_CatalogCounterparty_Delete_Click(sender, e);
        }
    }
}
