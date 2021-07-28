using ModelLibrary_Estore_1;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class Test_Form : Form
    {
        private Product product;
        public Test_Form()
        {
            InitializeComponent();
            product = new();
        }



        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //var idx = comboBox1.SelectedIndex;
            //lblIndexItem.Text = idx.ToString();

            //var selItem = comboBox1.SelectedItem;
            //var sI = selItem.GetType().GetProperty("BrandId");
            //lblSelectedItem.Text = selItem.ToString();



            if (comBoxBrand.SelectedIndex >= 0)
            {
                int brandID = (int)comBoxBrand.SelectedValue;
                product.BrandsBrandId = brandID;
                //получаем BrandId
                //var selectedItem = comboBox1.Items[comboBox1.SelectedIndex];
                //var pO = selectedItem.GetValue(selectedItem);
                //var propItem = selectedItem.GetType().GetProperty("BrandName").GetValue(selectedItem);
                //var pO = propItem.GetValue(selectedItem);
                //var propertyArr = selectedItem.GetType().GetProperties();
                //var valueBrandId = propertyArr[0].GetValue(selectedItem);
                //label1.Text = propItem.ToString();
                //label2.Text = "pO - " + pO;
                //label4.Text = valueBrandId.ToString();

                //lblBrand.Text = selVal.ToString();
            }
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            Db_Enterprise_Store_Context db = new();

            var allBrands = db.Brands
                .Select(b => new
                {
                    b.BrandId,
                    b.BrandName
                })
                .ToList();
            bindingSource1.DataSource = allBrands;
            comBoxBrand.DataSource = bindingSource1;
            comBoxBrand.SelectedItem = null;
        }

        private void ComboBox1_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("comboBox1_Enter");
        }

        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("comboBox1_Leave");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var s = txtProductName.Text.Trim();
            //s.Trim();
            if (s == string.Empty)
            {
                MessageBox.Show(@"Поле ""Наименование"" пусто");
            }
            //Form f = new();
            MessageBox.Show(comBoxBrand.Text);
        }
    }
}
