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
            var idx = comboBox1.SelectedIndex;
            if (idx >= 0)
            {
                var selectedItem = comboBox1.Items[idx];
                var propertyArr = selectedItem.GetType().GetProperties();
                var valueBrandId = propertyArr[0].GetValue(selectedItem);
                label4.Text = valueBrandId.ToString();
            }
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            Db_Enterprise_Store_Context db = new();
            //var brands = db.Brands.Where(b => b.BrandName == "sumsung");
            //lblBrand.Text = brands;

            var allBrands = db.Brands
                .Select(b => new
                {
                    BrandId = b.BrandId,
                    BrandName = b.BrandName
                })
                //.AsEnumerable();
                .ToList();
            bindingSource1.DataSource = allBrands;
            comboBox1.DataSource = bindingSource1;
            //comboBox1.Items.AddRange(allBrands);
        }
    }
}
