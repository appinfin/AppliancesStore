using System;
using System.Drawing;
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
            #region MyRegion
            //    this.textBox1 = new System.Windows.Forms.TextBox
            //    {
            //        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
            //        Location = new System.Drawing.Point(48, 488),
            //        Multiline = true,
            //        ReadOnly = true,
            //        Size = new System.Drawing.Size(824, 32)
            //    };

            //    // Create the calendar.
            //    this.monthCalendar1 = new System.Windows.Forms.MonthCalendar
            //    {

            //        // Set the calendar location.
            //        Location = new System.Drawing.Point(47, 16),


            //        #region // Change the color.
            //        BackColor = System.Drawing.SystemColors.Info,
            //        ForeColor = System.Drawing.Color.FromArgb(
            //                             ((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(192))),
            //        TitleBackColor = System.Drawing.Color.Purple,
            //        TitleForeColor = System.Drawing.Color.Yellow,
            //        TrailingForeColor = System.Drawing.Color.FromArgb(
            //                             ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0))),
            //        #endregion

            //        // Add dates to the AnnuallyBoldedDates array.
            //        AnnuallyBoldedDates =
            //        new System.DateTime[] { new System.DateTime(2002, 4, 20, 0, 0, 0, 0),
            //                            new System.DateTime(2002, 4, 28, 0, 0, 0, 0),
            //                            new System.DateTime(2002, 5, 5, 0, 0, 0, 0),
            //                            new System.DateTime(2002, 7, 4, 0, 0, 0, 0),
            //                            new System.DateTime(2002, 12, 15, 0, 0, 0, 0),
            //                            new System.DateTime(2002, 12, 18, 0, 0, 0, 0)},

            //        // Add dates to BoldedDates array.
            //        BoldedDates = new System.DateTime[] { new System.DateTime(2002, 9, 26, 0, 0, 0, 0) },

            //        // Add dates to MonthlyBoldedDates array.
            //        MonthlyBoldedDates =
            //       new System.DateTime[] {new System.DateTime(2002, 1, 15, 0, 0, 0, 0),
            //                          new System.DateTime(2002, 1, 30, 0, 0, 0, 0)},

            //        // Configure the calendar to display 3 rows by 4 columns of months.
            //        CalendarDimensions = new System.Drawing.Size(1, 1),

            //        // Set week to begin on Monday.
            //        FirstDayOfWeek = System.Windows.Forms.Day.Monday,

            //        // Set the maximum visible date on the calendar to 12/31/2010.
            //        MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0),

            //        // Set the minimum visible date on calendar to 12/31/2010.
            //        MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0),

            //        // Only allow 21 days to be selected at the same time.
            //        MaxSelectionCount = 21,

            //        // Set the calendar to move one month at a time when navigating using the arrows.
            //        ScrollChange = 1,

            //        // Do not show the "Today" banner.
            //        ShowToday = false,

            //        // Do not circle today's date.
            //        ShowTodayCircle = false,

            //        // Show the week numbers to the left of each week.
            //        ShowWeekNumbers = true
            //    };

            //    // Add event handlers for the DateSelected and DateChanged events
            //    this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateSelected);
            //    this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);

            //    // Set up how the form should be displayed and add the controls to the form.
            //    this.ClientSize = new System.Drawing.Size(920, 566);
            //    this.Controls.AddRange(new System.Windows.Forms.Control[] { this.textBox1, this.monthCalendar1 });
            //    this.Text = "Month Calendar Example";
            //} 
            #endregion

            
        }
        private void MonthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            //this.textBox1.Text = "Date Changed: Start =  ";
            //// Show the start and end dates in the text box.
            //this.textBox1.Text = "Date Selected: Start = " +
            //    e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
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
            var r = monthCalendar1.HitTest(80,16).HitArea.ToString();
            this.textBox2.Text = r.ToString();
        }
    }
}