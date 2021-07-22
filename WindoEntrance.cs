using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliancesStore
{
    public partial class WindowEntrance : Form
    {
        public WindowEntrance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void entUser_Click(object sender, EventArgs e)
        {
            String Login = username.Text;
            String Pass = pass.Text;

            DBapplincesStore db = new DBapplincesStore();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("YES");
            else
                MessageBox.Show("NO");
        }

        private void WindowEntrance_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("DONE!");
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
