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

    public partial class SetPriceQty : Form
    {
        public SetPriceQty()
        {
            InitializeComponent();
        }

        public decimal PricePurchase { get; set; }
        public decimal Quantity { get; set; }

        private void SetPriceQtyOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Decimal.TryParse(txtPrice.Text, out decimal _price);
            Decimal.TryParse(txtQty.Text, out decimal _qty);
            PricePurchase = _price;
            Quantity = _qty;
            this.Close();
        }
    }
}
