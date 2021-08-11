using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System;
using System.Windows.Forms;
using System.Linq;


namespace Enterprise_Store_beta_1._0
{
    public partial class CatalogCounterparty_Form : Form
    {
        public CatalogCounterparty_Form()
        {
            InitializeComponent();
        }

        BindingSource bind_DGV_CatalogCounterparty_Form = new();
        internal Counterparty CurrentCounterparty { get; set; }

        private void CatalogCounterparty_Load(object sender, EventArgs e)
        {
            // Получаем источник данных, привязываем его и настраиваем столбцы DGV
            bind_DGV_CatalogCounterparty_Form.DataSource = Manager.GetListCouterparty();
            DGV_CatalogCounterparty_Form.DataSource = bind_DGV_CatalogCounterparty_Form;
            DGV_CatalogCounterparty_Form.Columns["Realizations"].Visible = false;
            DGV_CatalogCounterparty_Form.Columns["Supplies"].Visible = false;
        }

        #region // Двойной клик по строке для выбора и установки контрагента или редактирования
        private void DGV_CatalogCounterparty_Form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region //если окно в модальном режиме для выбора контрагента
            if (this.Modal)
            {
                CurrentCounterparty = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;
                this.DialogResult = DialogResult.OK;
            }
            #endregion

            #region //иначе окно в независимом режиме для редактирования ячеек
            else
            {
                DGV_CatalogCounterparty_Form.BeginEdit(false);
            }
            #endregion
        }
        #endregion

        #region // Проверка правильности введённого в поле значения
        /// <summary>
        /// Проверяет правильность ввода значений в поля dgv "CounterpartyName", "InnOgrnKpp"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CatalogCounterparty_Form_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            #region // если новая строка или колонка CounterpartyId пустая то return
            if (DGV_CatalogCounterparty_Form.Rows[e.RowIndex].IsNewRow ||
                DGV_CatalogCounterparty_Form.IsCurrentCellDirty == false ||
                DGV_CatalogCounterparty_Form["CounterpartyName", e.RowIndex]
                    .EditedFormattedValue
                    .ToString()
                    .Trim() == string.Empty)
            {
                DGV_CatalogCounterparty_Form.CancelEdit();
                DGV_CatalogCounterparty_Form.EndEdit();
                return;
            }
            #endregion

            #region // Проверка заполненности ячейки (строка из пробелов return;)
            var fv = DGV_CatalogCounterparty_Form.CurrentCell.FormattedValue.ToString(); //до форматирования
            var efv = DGV_CatalogCounterparty_Form.CurrentCell.EditedFormattedValue.ToString().Trim(); //форматируемое значение (текущее введённое)
            // если строка до форматирования и текущая форматируемая строка равны
            if (fv.Equals(efv))
            {
                DGV_CatalogCounterparty_Form.CancelEdit(); //сброс редактирования
                DGV_CatalogCounterparty_Form.EndEdit();    //конец редактирования
                return;
            }

            string efvInn = DGV_CatalogCounterparty_Form["InnOgrnKpp", e.RowIndex].EditedFormattedValue.ToString();
            if (string.IsNullOrWhiteSpace(efvInn) && efvInn != string.Empty) //
            {
                DGV_CatalogCounterparty_Form["InnOgrnKpp", e.RowIndex]
                    .ErrorText = "Неверный ввод значения!!!\n" +
                    "Введите последовательность целых чисел или\n" +
                    "оставьте поле пустым.";
                return;
            }
            #endregion

            #region // проверка ввода в колонку "InnOgrnKpp"
            if (DGV_CatalogCounterparty_Form["InnOgrnKpp", e.RowIndex]
                    .EditedFormattedValue
                    .ToString()
                    .Trim() != string.Empty &&
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
                DGV_CatalogCounterparty_Form.EndEdit(); // конец редактирования
                Counterparty currentItem = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;
                //если имя не пустое
                //if (!string.IsNullOrWhiteSpace(currentItem.CounterpartyName))
                //{
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
            #endregion
        }
        #endregion

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
            if (DialogResult.OK == MessageBox.Show("Данные будут удалены безвозвратно.",
                                                   "Удалить контрагента?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Exclamation))
            {
                Counterparty currentItem = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;

                try
                {
                    using Db_Enterprise_Store_Context db = new();
                    db.Remove(currentItem);
                    db.SaveChanges();
                    bind_DGV_CatalogCounterparty_Form.RemoveCurrent();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка обновления базы данных!!!");
                }
            }
        }

        private void tStrip_ctxMenu_CataloCounterparty_Delete_Click(object sender, EventArgs e)
        {
            TStrip_CatalogCounterparty_Delete_Click(sender, e);
        }
    }
}
