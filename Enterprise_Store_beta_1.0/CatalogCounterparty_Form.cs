using ModelLibrary_Estore_1;
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
    public partial class CatalogCounterparty_Form : Form
    {
        internal int CounterpartyID { get; set; }

        public CatalogCounterparty_Form()
        {
            InitializeComponent();
        }

        private void CatalogCounterparty_Load(object sender, EventArgs e)
        {
            DGV_CatalogCounterparty_Form.DataSource = Manager.GetListCouterparty();
            DGV_CatalogCounterparty_Form.Columns["Realizations"].Visible = false;
            DGV_CatalogCounterparty_Form.Columns["Supplies"].Visible = false;
        }

        private void DGV_CatalogCounterparty_Form_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CounterpartyID = (int)DGV_CatalogCounterparty_Form.CurrentRow.Cells["CounterpartyId"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
