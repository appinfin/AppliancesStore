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
    public partial class CreateSell_Form : Form
    {
        public CreateSell_Form()
        {
            InitializeComponent();
            var b = this.IsMdiChild;
            MessageBox.Show(b.ToString());
        }


    }
}
