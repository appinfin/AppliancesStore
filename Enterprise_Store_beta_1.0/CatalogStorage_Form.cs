using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class CatalogStorage_Form : Form
    {
        internal int StorageID { get; set; }

        public CatalogStorage_Form()
        {
            InitializeComponent();
        }

        private void CatalogStorage_Form_Load(object sender, EventArgs e)
        {
            DGV_CatalogStorage_Form.DataSource = Manager.GetListStorage();
        }

        private void DGV_CatalogStorage_Form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StorageID = (int)DGV_CatalogStorage_Form.CurrentRow.Cells["StorageId"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
