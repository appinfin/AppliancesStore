using Microsoft.EntityFrameworkCore;
using ModelLibrary_Estore_1;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;


namespace Enterprise_Store_beta_1._0
{
    public partial class Test_form : Form
    {
        public Test_form()
        {
            InitializeComponent();
        }

        private void Test_form_Load(object sender, EventArgs e)
        {
            
            var defaulPageSetting = printDocument1.DefaultPageSettings;
            var printerSetting = printDocument1.PrinterSettings;
            using Db_Enterprise_Store_Context db = new();

            //var sqq = db.RealizationPriceQtys

            //var sqq = db.Personnels
            //    .Include(p => p.Realizations)
            //    .ThenInclude(r => r.RealizationPriceQties)
            //    .Select(p => new 
            //    {
            //        p.PersonnelName,
                    //real = p.Realizations.Where(p => p.PersonnelsPersonnelId==p.PersonnelsPersonnel.PersonnelId),
                    //real = p.Realizations

                    //.Select(r => r.RealizationPriceQties.Select(p => new{ re = p.PriceSelling * (decimal)p.Quantity }).Select(r=>r.re).Sum())
                    //.Select(r => r.RealizationPriceQties.Select(p => p.PriceSelling * (decimal)p.Quantity).Sum())

                //})
                //.Select(p => new
                //{
                //    //TotalPriceRealizations = p.PriceSelling * (decimal)p.Quantity
                //    //TotalPriceRealizations = p.RealizationPriceQties.Select(p => p.PriceSelling * (decimal)p.Quantity).Sum()
                //})
                //.ToList();

            var sqq2 = db.Personnels.Select(
                per => new
                {
                    per.PersonnelName,
                    summa = per.Realizations.SelectMany(real => real.RealizationPriceQties).Sum(rpq => (decimal)rpq.Quantity * rpq.PriceSelling)
                })
                .ToList();

            bindingSource1.DataSource = sqq2;
            dataGridView1.DataSource = bindingSource1;
        }

        private void PreviewPrint_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.75;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDoc_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var font = this.Font;
            Pen pen = new (Color.Azure, 2F);
            var stringSizeF = e.Graphics.MeasureString("Hello, world!!!", this.Font);
            RectangleF rect = new() { Size = stringSizeF, X = 40F, Y = 40F };
            e.Graphics.DrawRectangle(pen, Rectangle.Truncate(rect));
            e.Graphics.DrawString("Hello, world!!!", this.Font, Brushes.Red, rect);
            var pageArea = e.PageBounds;
            var marginBounds = e.MarginBounds;
            //var area = Rectangle.Truncate(e.PageSettings.PrintableArea);
            e.Graphics.DrawRectangle(Pens.Red, marginBounds);
            var stringPrint = dataGridView1[0, 10].Value.ToString();
            //e.Graphics.DrawRectangle(Pens.Green, area);
            var rectangleCell = dataGridView1.GetCellDisplayRectangle(0, 10, true);
            var rectangleRow = dataGridView1.GetRowDisplayRectangle(0, true);
            var point = rectangleCell.Location;
            var rectangell = dataGridView1.GetCellDisplayRectangle(0, 0, true);
            e.Graphics.DrawRectangle(Pens.Black, rectangleCell);
            e.Graphics.DrawRectangle(Pens.Black, rectangleRow);
            e.Graphics.DrawString(stringPrint, this.Font, Brushes.Black, point);
            

            #region Print string format Example
            ///////
            Rectangle displayRectangle =
        new Rectangle(new Point(102, 45), new Size(80, 80));

            // Construct 2 new StringFormat objects
            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            StringFormat format2 = new StringFormat(format1);

            // Set the LineAlignment and Alignment properties for
            // both StringFormat objects to different values.
            format1.LineAlignment = StringAlignment.Near;
            format1.Alignment = StringAlignment.Center;
            format2.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Far;

            // Draw the bounding rectangle and a string for each
            // StringFormat object.
            e.Graphics.DrawRectangle(Pens.Black, displayRectangle);
            e.Graphics.DrawString("Showing Format1 Center", this.Font,
                Brushes.Red, (RectangleF)displayRectangle, format1);
            e.Graphics.DrawString("Showing Format2 Far", this.Font,
                Brushes.Red, (RectangleF)displayRectangle, format2);
            #endregion
            #region // Пример печати многостраничного док-та
            //Font printFont = new("Arial", 12);
            //var row = dataGridView1.Rows[0].ToString();
            //ev.Graphics.DrawString(row, printFont, Brushes.Black, 0, 0);

            //float linesPerPage = 0;
            //float yPos = 0;
            //int count = 0;
            //float leftMargin = ev.MarginBounds.Left;
            //float topMargin = ev.MarginBounds.Top;
            //String line = null;

            //// Calculate the number of lines per page.
            //linesPerPage = ev.MarginBounds.Height /
            //   printFont.GetHeight(ev.Graphics);

            //// Iterate over the file, printing each line.
            //while (count < linesPerPage &&
            //   ((line = streamToPrint.ReadLine()) != null))
            //{
            //    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            //    ev.Graphics.DrawString(line, printFont, Brushes.Black,
            //       leftMargin, yPos, new StringFormat());
            //    count++;
            //}

            //// If more lines exist, print another page.
            //if (line != null)
            //    ev.HasMorePages = true;
            //else
            //    ev.HasMorePages = false; 
            #endregion
        }

        private void PrintDialog_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();

        }

        private void PageSetupDialog_Click(object sender, EventArgs e)
        {
            var p = pageSetupDialog1;
            var psDialog = pageSetupDialog1.PageSettings;
            var psDoc = printDocument1.DefaultPageSettings;

            pageSetupDialog1.ShowDialog();

            psDialog = pageSetupDialog1.PageSettings;
            psDoc = printDocument1.DefaultPageSettings;

            PaperSize myPaperSize = new()
            {
                PaperName = "my_A4Rotade",
                RawKind = 77,
                Width = 1169,
                Height = 826
            };
            
            //printDocument1.DefaultPageSettings.PaperSize = myPaperSize;
        }

        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

            pageSetupDialog1.ShowDialog();
            
        }

        private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            //printDialog1.ShowDialog();
        }

        private void PrintDocument1_EndPrint(object sender, PrintEventArgs e)
        {

        }
    }
}
