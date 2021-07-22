using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;

namespace Enterprise_Store_beta_1._0
{
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        private void ToolStrip_SellForm_Action_CreateSell_Click(object sender, EventArgs e)
        {
            var createSell_Form = new CreateSell_Form
            {
                MdiParent = this.MdiParent
            };
            createSell_Form.Show();
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            using var db = new Db_Enterprise_Store_Context();

            bindingSource1.DataSource = db.Realizations.Local.ToBindingList();
            var dM = bindingSource1.DataMember;
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
