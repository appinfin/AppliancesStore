using System;
using System.Globalization;
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

        internal decimal PricePurchase { get; set; }
        internal decimal Quantity { get; set; }

        private void SetPriceQtyOK_Click(object sender, EventArgs e)
        {
            
            if (Decimal.TryParse(txtPrice.Text, out decimal _price) && Decimal.TryParse(txtQty.Text, out decimal _qty))
            {
                PricePurchase = _price;
                Quantity = _qty;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Вы ввели недопустимый символ. Попробуйте ещё раз.\n" +
                                "Например дробные числа вводятся через запятую = 42,35",
                                "Неверный ввод символов!!!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }
    }
}
