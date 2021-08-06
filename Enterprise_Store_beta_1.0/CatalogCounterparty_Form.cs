using System;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;
using ModelLibrary_Estore_1;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Enterprise_Store_beta_1._0
{
    public partial class CatalogCounterparty_Form : Form
    {
        public CatalogCounterparty_Form()
        {
            InitializeComponent();
        }

        BindingSource bind_DGV_CatalogCounterparty_Form;
        internal int CounterpartyID { get; set; }

        private void CatalogCounterparty_Load(object sender, EventArgs e)
        {
            // Получаем источник данных, привязываем его и настраиваем столбцы DGV
            DGV_CatalogCounterparty_Form.DataSource = Manager.GetListCouterparty();
            DGV_CatalogCounterparty_Form.Columns["Realizations"].Visible = false;
            DGV_CatalogCounterparty_Form.Columns["Supplies"].Visible = false;
        }

        #region // Двойной клик по строке для выбора и установки контрагента
        /// <summary>
        /// Метод устанавливает св-во CounterpartyID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CatalogCounterparty_Form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_CatalogCounterparty_Form.BeginEdit(true);
            CounterpartyID = (int)DGV_CatalogCounterparty_Form.CurrentRow.Cells["CounterpartyId"].Value;
            var counterpartyName = DGV_CatalogCounterparty_Form.CurrentRow.Cells["CounterpartyName"].Value.ToString();
            //DialogResult = DialogResult.OK;
            //Close();
        }

        #endregion

        private void DGV_CatalogCounterparty_Form_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //DGV_CatalogCounterparty_Form.Rows[e.RowIndex].ErrorText = "Ошибка";
            //var ds = DGV_CatalogCounterparty_Form.DataSource;
            //MessageBox.Show("Cell Validating\n" + e.ColumnIndex.ToString() + e.RowIndex.ToString());
            //DGV_CatalogCounterparty_Form.Rows[e.RowIndex].ErrorText = "";
            var cc = DGV_CatalogCounterparty_Form.Columns;
            var eq = e.FormattedValue.ToString().Equals(e.FormattedValue.ToString().Trim());

            long newInteger;
            //if (DGV_CatalogCounterparty_Form.SelectedColumns) { };
            if (DGV_CatalogCounterparty_Form.Rows[e.RowIndex].IsNewRow ||
                DGV_CatalogCounterparty_Form.IsCurrentCellDirty == false) { return; }
            if (DGV_CatalogCounterparty_Form.Columns["InnOgrnKpp"].Index == e.ColumnIndex && //and
                e.FormattedValue.ToString().Length != 0 && //and
                (!long.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0))
            {
                //e.Cancel = true;
                DGV_CatalogCounterparty_Form.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            }

        }

        private void DGV_CatalogCounterparty_Form_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            bind_DGV_CatalogCounterparty_Form = (BindingSource)DGV_CatalogCounterparty_Form.DataSource;
            Counterparty currentItem = (Counterparty)bind_DGV_CatalogCounterparty_Form.Current;

            var d = DGV_CatalogCounterparty_Form.IsCurrentCellDirty;
            DGV_CatalogCounterparty_Form.EndEdit();
            //if (currentItem.CounterpartyId <= 0)
            //{
            //    MessageBox.Show("Add");
            //    //AddEntyti();
            //}
            //else
            //{
            //    MessageBox.Show("Update");
            //    //UpdateEntyti();
            //}

            using Db_Enterprise_Store_Context db = new();
            //BindingSource ds = (BindingSource)DGV_CatalogCounterparty_Form.DataSource;

            bool isNewRow = DGV_CatalogCounterparty_Form.Rows[e.RowIndex].IsNewRow;
            
            var cellDirty = DGV_CatalogCounterparty_Form.IsCurrentCellDirty;

            void AddEntyti()
            {
                db.Add(currentItem);
                db.SaveChanges();
            }
            
            //var currentRow = (int)DGV_CatalogCounterparty_Form.CurrentRow.Cells["CounterpartyId"].Value;

            #region Reflection mysample
            //string ss ="";
            //var collection = ds.GetType().GetProperties();
            //foreach (var item in collection)
            //{
            //    var s = string.Format("Name: {0}\n", item.Name);
            //    ss += s;

            //}
            //MessageBox.Show(ss); 
            #endregion

            bool bo = bind_DGV_CatalogCounterparty_Form.Equals(DGV_CatalogCounterparty_Form.DataSource);
            
            //MessageBox.Show("Cell End edit");
        }

        #region // CellValueChanged
        //private void DGV_CatalogCounterparty_Form_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    //if (e.RowIndex < 0) { return; }
        //    //string msg = String.Format("Cell at row {0}, column {1} value changed",e.RowIndex, e.ColumnIndex);
        //    //MessageBox.Show(msg, "Cell Value Changed");
        //}
        #endregion

        private void DGV_CatalogCounterparty_Form_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            var enumContext = e.Context.ToString();
            MessageBox.Show("CellValue Changed\n" + enumContext);
        }

        #region // CellStateChanged
        //private void DGV_CatalogCounterparty_Form_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        //{
        //    //DataGridViewElementStates state = e.StateChanged;

        //    //string msg = String.Format("Row {0}, Column {1}, {2}",
        //    //    e.Cell.RowIndex, e.Cell.ColumnIndex, e.StateChanged);
        //    //MessageBox.Show(msg, "Cell State Changed");
        //} 
        #endregion
    }
}
