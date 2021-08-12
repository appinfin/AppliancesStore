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
    public partial class CatalogStorage_Form : Form
    {
        //internal int StorageID { get; set; }

        // Инициализация
        public CatalogStorage_Form()
        {
            InitializeComponent();
        }

        BindingSource bind_DGV_CatalogStorage_Form = new();
        internal Storage CurrentStorage { get; set; }

        // При отображении формы получаем список складов
        private void CatalogStorage_Form_Load(object sender, EventArgs e)
        {
            // Получаем источник данных, привязываем его и настраиваем столбцы DGV
            bind_DGV_CatalogStorage_Form.DataSource = Manager.GetListStorage();
            DGV_CatalogStorage_Form.DataSource = bind_DGV_CatalogStorage_Form;
            DGV_CatalogStorage_Form.Columns["Realizations"].Visible = false;
            DGV_CatalogStorage_Form.Columns["Supplies"].Visible = false;
        }

        #region // Двойной клик по строке для выбора и установки склада или редактирования
        private void DGV_CatalogStorage_Form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region //если окно в модальном режиме для выбора контрагента
            if (this.Modal)
            {
                CurrentStorage = (Storage)bind_DGV_CatalogStorage_Form.Current;
                this.DialogResult = DialogResult.OK;
            }
            #endregion

            #region //иначе окно в независимом режиме для редактирования ячеек
            else
            {
                DGV_CatalogStorage_Form.BeginEdit(false);
            }
            #endregion
        }

        #endregion

        private void DGV_CatalogStorage_Form_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            #region // если новая строка или колонка StorageName пустая то return
            if (DGV_CatalogStorage_Form.Rows[e.RowIndex].IsNewRow ||
                DGV_CatalogStorage_Form.IsCurrentCellDirty == false ||
                DGV_CatalogStorage_Form["StorageName", e.RowIndex]
                    .EditedFormattedValue
                    .ToString()
                    .Trim() == string.Empty)
            {
                DGV_CatalogStorage_Form.CancelEdit();
                DGV_CatalogStorage_Form.EndEdit();
                return;
            }
            #endregion

            #region // Сохранить запись или отменить изменения
            if (DialogResult.Cancel == MessageBox.Show(
                    "Сохранить запись?",
                    "Сохранить склад?",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question))
            {
                DGV_CatalogStorage_Form.CancelEdit();
                DGV_CatalogStorage_Form.EndEdit();
            }
            else
            {
                #region // Получаем текущий эл-т списка и добавляем или обновляем в бд
                DGV_CatalogStorage_Form.EndEdit(); // конец редактирования
                Storage currentItem = (Storage)bind_DGV_CatalogStorage_Form.Current;
                
                try
                {
                    if (currentItem.StorageId <= 0) //если новая запись добавляем в бд
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
                    DGV_CatalogStorage_Form.CancelEdit();
                    DGV_CatalogStorage_Form.EndEdit();
                }
                #endregion
            }
            #endregion
        }

        private void TStripMenu_CatalogStorage_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Данные будут удалены безвозвратно.",
                                                   "Удалить контрагента?",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Exclamation))
            {
                Storage currentItem = (Storage)bind_DGV_CatalogStorage_Form.Current;

                try
                {
                    using Db_Enterprise_Store_Context db = new();
                    db.Remove(currentItem);
                    db.SaveChanges();
                    bind_DGV_CatalogStorage_Form.RemoveCurrent();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка обновления базы данных!!!");
                }
            }
        }

        private void CtxMenu_CatalogStorage_Delete_Click(object sender, EventArgs e)
        {
            TStripMenu_CatalogStorage_Delete_Click(sender, e);
        }
    }
}
