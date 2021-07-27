using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary_Estore_1;

namespace Enterprise_Store_beta_1._0
{
    public partial class Test_Form : Form
    {
        public Test_Form()
        {
            InitializeComponent();
        }

        
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //var idx = comboBox1.SelectedIndex;
            //lblIndexItem.Text = idx.ToString();

            //var selItem = comboBox1.SelectedItem;
            //var sI = selItem.GetType().GetProperty("BrandId");
            //lblSelectedItem.Text = selItem.ToString();

            

            if (comboBox1.SelectedIndex >= 0)
            {
                //var selectedItem = comboBox1.Items[comboBox1.SelectedIndex];
                //var pO = selectedItem.GetValue(selectedItem);
                //var propItem = selectedItem.GetType().GetProperty("BrandName").GetValue(selectedItem);
                //var pO = propItem.GetValue(selectedItem);
                //var propertyArr = selectedItem.GetType().GetProperties();
                //var valueBrandId = propertyArr[0].GetValue(selectedItem);
                //label1.Text = propItem.ToString();
                //label2.Text = "pO - " + pO;
                //label4.Text = valueBrandId.ToString();
                var selVal = comboBox1.SelectedValue;
                lblBrand.Text = selVal.ToString();
            }
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            Db_Enterprise_Store_Context db = new();

            var allBrands = db.Brands
                .Select(b => new
                {
                    BrandId = b.BrandId,
                    BrandName = b.BrandName
                })
                .ToList();
            bindingSource1.DataSource = allBrands;
            comboBox1.DataSource = bindingSource1;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("comboBox1_Enter");
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("comboBox1_Leave");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new();
            //f.Controls(
               // );
        }
    }
}
