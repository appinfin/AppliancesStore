using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;

namespace Enterprise_Store_beta_1._0
{
    public partial class CatalogPersonnels_Form : Form
    {
        public CatalogPersonnels_Form()
        {
            InitializeComponent();
        }

        BindingSource bind_DGV_CatalogPersonnels_Form = new();
        internal Personnel CurrentPersonnel { get; set; }

        // При отображении формы получаем список сотрудников
        private void CatalogPersonnels_Form_Load(object sender, EventArgs e)
        {
            // Получаем источник данных, привязываем его и настраиваем столбцы DGV
            bind_DGV_CatalogPersonnels_Form.DataSource = Manager.GetListPersonnels();
            DGV_CatalogPersonnels_Form.DataSource = bind_DGV_CatalogPersonnels_Form;
            DGV_CatalogPersonnels_Form.Columns["Realizations"].Visible = false;
            //DGV_CatalogPersonnels_Form.Columns["Supplies"].Visible = false;
        }

        #region // Двойной клик по строке для выбора и установки менеджера или редактирования
        private void DGV_CatalogPersonnels_Form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region //если окно в модальном режиме для выбора контрагента
            if (this.Modal)
            {
                CurrentPersonnel = (Personnel)bind_DGV_CatalogPersonnels_Form.Current;
                this.DialogResult = DialogResult.OK;
            }
            #endregion

            #region //иначе окно в независимом режиме для редактирования ячеек
            else
            {
                DGV_CatalogPersonnels_Form.BeginEdit(false);
            }
            #endregion
        }
        #endregion

        private void DGV_CatalogPersonnels_Form_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            #region // если новая строка или колонка PersonnelName пустая то return
            if (DGV_CatalogPersonnels_Form.Rows[e.RowIndex].IsNewRow ||
                DGV_CatalogPersonnels_Form.IsCurrentCellDirty == false ||
                DGV_CatalogPersonnels_Form["PersonnelName", e.RowIndex]
                    .EditedFormattedValue
                    .ToString()
                    .Trim() == string.Empty)
            {
                DGV_CatalogPersonnels_Form.CancelEdit();
                DGV_CatalogPersonnels_Form.EndEdit();
                return;
            }
            #endregion

            #region // Сохранить запись или отменить изменения
            if (DialogResult.Cancel == MessageBox.Show(
                    "Сохранить запись?",
                    "Сохранить сотрудника?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question))
            {
                DGV_CatalogPersonnels_Form.CancelEdit();
                DGV_CatalogPersonnels_Form.EndEdit();
            }
            else
            {
                #region // Получаем текущий эл-т списка и добавляем или обновляем в бд
                DGV_CatalogPersonnels_Form.EndEdit(); // конец редактирования
                Personnel currentItem = (Personnel)bind_DGV_CatalogPersonnels_Form.Current;

                try
                {
                    if (currentItem.PersonnelId <= 0) //если новая запись добавляем в бд
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
                    DGV_CatalogPersonnels_Form.CancelEdit();
                    DGV_CatalogPersonnels_Form.EndEdit();
                }
                #endregion
            }
            #endregion
        }

        private void TStripMenu_CatalogPersonnels_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Данные будут удалены безвозвратно.",
                                                   "Удалить сотрудника?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Exclamation))
            {
                Personnel currentItem = (Personnel)bind_DGV_CatalogPersonnels_Form.Current;

                try
                {
                    using Db_Enterprise_Store_Context db = new();
                    db.Remove(currentItem);
                    db.SaveChanges();
                    bind_DGV_CatalogPersonnels_Form.RemoveCurrent();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка обновления базы данных!!!");
                }
            }
        }

        private void CtxMenu_CatalogStorage_Delete_Click(object sender, EventArgs e)
        {
            TStripMenu_CatalogPersonnels_Delete_Click(sender, e);
        }
    }
}
