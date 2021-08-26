using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{

    public partial class Calendar_Form : System.Windows.Forms.Form
    {
        //private readonly System.Windows.Forms.MonthCalendar monthCalendar1;
        //private readonly System.Windows.Forms.TextBox textBox1;

        //[STAThread]
        //static void Main()
        //{
        //    Application.Run(new Calendar_Form());
        //}

        public Calendar_Form()
        {
            InitializeComponent();
        }

        private void MonthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            this.textBox1.Text = "Date Changed: Start =  ";
            // Show the start and end dates in the text box.
            this.textBox1.Text = "Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        }

        private void MonthCalendar1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            this.textBox1.Text = "Date Changed: Start =  " + monthCalendar1.SelectionStart;
            this.label1.Text = "Date Changed: Start =  " + monthCalendar1.SelectionStart;
            //e.Start.Date.ToLongTimeString();// + e.End.ToShortDateString();
        }

        private void MonthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            var r = monthCalendar1.HitTest(80, 16).HitArea.ToString();
            this.textBox2.Text = r.ToString();
        }
    }
}