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
            this.txtPrice.Text = "0.00";
            this.txtQty.Text = "0";
        }

        public decimal PricePurchase { get; set; }
        public decimal Quantity { get; set; }

        private void setPriceQtyOK_Click(object sender, EventArgs e)
        {
            decimal _price;
            decimal _qty;
            this.DialogResult = DialogResult.OK;
            var p = Decimal.TryParse(txtPrice.Text, out _price);
            var q = Decimal.TryParse(txtQty.Text, out _qty);
            PricePurchase = _price;
            Quantity = _qty;
            this.Close();
        }
    }
}
