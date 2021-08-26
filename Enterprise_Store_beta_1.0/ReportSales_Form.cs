using ModelLibrary_Estore_1;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Enterprise_Store_beta_1._0
{
    public partial class ReportSales_Form : Form
    {
        PrintController printController;
        public ReportSales_Form()
        {
            InitializeComponent();
            
        }

        private void ReportSales_Form_Load(object sender, EventArgs e)
        {
            printController = printDocument1.PrintController;

            this.monthCalendar1.Visible = false; //скрыть календарь
            this.monthCalendar2.Visible = false; //скрыть календарь
            var pC = printDocument1.PrintController;
            var m = printDocument1.DefaultPageSettings.Margins;
            //printDocument1.DefaultPageSettings.Margins = new Margins { Left = 79, Right = 39, Top = 39, Bottom = 39 };
            var defaulPageSetting = printDocument1.DefaultPageSettings;
            var printerSetting = printDocument1.PrinterSettings;

            #region // Выборка для отчёта продаж

            #region nameAndSum
            //var nameAndSum = db.Personnels
            //        .Select(per => new
            //        {
            //            per.PersonnelName,

            //            realForEachProd = per.Realizations
            //            .Where(r => r.Date >= date && r.Date <= date2)
            //                .Select(real => new
            //                {
            //                    r = real.RealizationPriceQties.Select(p => p.Product.ProductName),
            //                    sum = real.RealizationPriceQties.Select(q => q.PriceSelling * (decimal)q.Quantity).Sum()
            //                }),

            //            sumForEachRealization = per.Realizations // сумма каждой реализации
            //            .Where(r => r.Date >= date && r.Date <= date2)
            //            .Select(real => real.RealizationPriceQties.Select(q => q.PriceSelling * (decimal)q.Quantity)
            //            .Sum()),

            //            sumAllRealization = per.Realizations // сумма всех реализаций
            //            .Where(r => r.Date >= date && r.Date <= date2)
            //            .SelectMany(real => real.RealizationPriceQties)
            //            .Sum(rpq => (decimal)rpq.Quantity * rpq.PriceSelling)
            //        })
            //        //.Skip(2)
            //        //.Take(2)
            //        .ToList();
            #endregion

            #region nameAndSum2 GroupBy //сумма всех продаж за период и з.п.
            //var sumAllRealizationAndSalary = db.RealizationPriceQtys
            //    .Where(r => r.Realization.Date >= date && r.Realization.Date <= date2)
            //    .GroupBy(el => el.Realization.PersonnelsPersonnel.PersonnelName)//группируем все проданные товары по PersonnelName

            //    .Select(g => new
            //    {
            //        persName = g.Key,
            //        sumRealization = g.Select(r => r.PriceSelling * (decimal)r.Quantity).Sum(),
            //        theSalary = g.Select(r => r.PriceSelling * (decimal)r.Quantity).Sum() * (decimal)0.05
            //    })
            //    .ToList();
            #endregion

            #region nameAndSum3 //отчёт о продаже каждого товара
            //var nameAndSum3 = db.Personnels
            //    .SelectMany(p => p.Realizations.SelectMany(r => r.RealizationPriceQties))
            //    .Select(rpq => new
            //    {
            //        rpq.Realization.PersonnelsPersonnel.PersonnelName,
            //        rpq.Product.ProductName,
            //        rpq.PriceSelling,
            //        rpq.Quantity,
            //        total = rpq.PriceSelling * (decimal)rpq.Quantity
            //    })
            //    .ToList();
            #endregion

            #region // Отчёт о продажах и начисление зп queryReportSalesForEachPersonnel

            ////var date = new DateTime(2021, 08, 11); // r.Date >= date  
            ////var date2 = new DateTime(2021, 08, 12) + new TimeSpan(23, 59, 59); // r.Date <= date2

            ////using Db_Enterprise_Store_Context db = new();
            //double percentPerSale = 0.05; //доля от суммы продаж
            //var queryReportSalesForEachPersonnel = db.Personnels
            //    .Select(per => new
            //    {
            //        per.PersonnelId, // id персонала
            //        per.PersonnelName, // имя персонала

            //        realizationForEachProduct = per.Realizations //реализация по каждому товару
            //            .Where(r => r.Date >= date && r.Date <= date2) // за период
            //            .SelectMany(r => r.RealizationPriceQties)
            //            .Select(rpq => new
            //            {
            //                rpq.Realization.PersonnelsPersonnel.PersonnelId,
            //                rpq.Realization.PersonnelsPersonnel.PersonnelName,

            //                Product_Name = rpq.Product.ProductName,
            //                rpq.PriceSelling,
            //                rpq.Quantity,
            //                totalForEachProduct = rpq.PriceSelling * (decimal)rpq.Quantity,

            //                sumAllRealizations = per.Realizations //сумма продаж 
            //                .Where(r => r.Date >= date && r.Date <= date2) // на период
            //                .SelectMany(r => r.RealizationPriceQties.Select(rpq => rpq.PriceSelling * (decimal)rpq.Quantity)).Sum(),

            //                theSalary = per.Realizations // процент от продаж з.п. сотрудника
            //                .Where(r => r.Date >= date && r.Date <= date2)
            //                .SelectMany(r => r.RealizationPriceQties
            //                    .Select(rpq => rpq.PriceSelling * (decimal)rpq.Quantity)).Sum() * (decimal)percentPerSale,

            //            }).ToList()
            //    }).ToList();

            //dataGridView1.ColumnCount = 4;
            //dataGridView1.Rows.Add("Дата:", "от " + date, "по " + date2);
            
            //dataGridView1.ReadOnly = true;
            //for (int i = 0; i < queryReportSalesForEachPersonnel.Count; i++)
            //{
            //    var item = queryReportSalesForEachPersonnel[i];
            //    if (item.realizationForEachProduct.Count() == 0)
            //    {
            //        continue;
            //    }
                
            //    var idAndNamePersonnel = string.Format("{0} {1}", item.PersonnelId, item.PersonnelName);
            //    var sumAllRealizations = string.Format("{0:C2}", item.realizationForEachProduct[0].sumAllRealizations);
            //    var theSalary = string.Format("{0:C2}", item.realizationForEachProduct[0].theSalary);

            //    int idx = dataGridView1.Rows.Add(idAndNamePersonnel); // вставка строки код и имя сотрудника
            //    dataGridView1.Rows[idx].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            //    foreach (var product in item.realizationForEachProduct)
            //    {
            //        dataGridView1.Rows.Insert(idx + 1, product.Product_Name,
            //                                         string.Format("{0:C2}", product.PriceSelling),
            //                                         product.Quantity,
            //                                         string.Format("{0:C2}", product.totalForEachProduct));
            //    }

            //    idx = dataGridView1.Rows.Add("Начислено 5% от продаж:", theSalary, "Сумма продаж:", sumAllRealizations); // вставка строки код и имя сотрудника
            //    dataGridView1.Rows[idx].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            //}
            #endregion

            #region nameAndSum5
            //double percentPerSale2 = 0.05; //доля от суммы продаж
            //var nameAndSum5 = db.Personnels
            //    .SelectMany(per => per.Realizations //реализация по каждому товару
            //        .Where(r => r.Date >= date && r.Date <= date2) // за период
            //        .SelectMany(r => r.RealizationPriceQties)
            //        .Select(rpq => new
            //        {
            //            rpq.Realization.PersonnelsPersonnel.PersonnelId,
            //            rpq.Realization.PersonnelsPersonnel.PersonnelName,

            //            Product_Name = rpq.Product.ProductName,
            //            rpq.PriceSelling,
            //            rpq.Quantity,
            //            totalForEachProduct = rpq.PriceSelling * (decimal)rpq.Quantity,

            //            sumAllRealizations = per.Realizations //сумма продаж 
            //            .Where(r => r.Date >= date && r.Date <= date2) // на период
            //            .SelectMany(r => r.RealizationPriceQties.Select(rpq => rpq.PriceSelling * (decimal)rpq.Quantity)).Sum(),

            //            theSalary = per.Realizations // процент от продаж з.п. сотрудника
            //            .Where(r => r.Date >= date && r.Date <= date2)
            //            .SelectMany(r => r.RealizationPriceQties
            //                .Select(rpq => rpq.PriceSelling * (decimal)rpq.Quantity)).Sum() * (decimal)percentPerSale2,

            //        })).ToList();
            #endregion

            #endregion

            //bindingSource1.DataSource = nameAndSum;
            //bindingSource1.DataSource = nameAndSum2;
            //bindingSource1.DataSource = nameAndSum3;
            //bindingSource1.DataSource = queryReportSalesForEachPersonnel;
            //dataGridView1.DataSource = bindingSource1;
        }

        private void PreviewPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            MenuStrip menuStrip = printPreviewDialog1.MainMenuStrip;
            
            printPreviewDialog1.ShowDialog();
            //printPreviewDialog1.Show();
        }

        private void PrintDoc_Click(object sender, EventArgs e)
        {
            
            printDocument1.Print();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var pageUnit = e.Graphics.PageUnit;
            Rectangle marginBounds = e.MarginBounds;
            Rectangle pageBounds = e.PageBounds;
            PageSettings pageSettings = e.PageSettings;
            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            StringFormat format2 = new StringFormat(format1);

            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Far;

            Rectangle rectangleCell;
            Font font = dataGridView1.Font;
            Pen pen = new(Color.LightGray);

            int rowsPerPage;
            int maximumPage;
            //int minimumPage = 0;
            float yPos = 0;
            int count = 0;
            string hederString;
            string stringPrint;

            hederString = lblHeaderString.Text;
            var hederStringSizeF = e.Graphics.MeasureString(hederString, lblHeaderString.Font);
            RectangleF hederStringRectangleF = new(e.MarginBounds.Location, hederStringSizeF);
            int marginBoundsHeightExceptHeder = (int)Math.Ceiling(e.MarginBounds.Height - hederStringSizeF.Height); //высота страницы без заголовка
            int rectangleRowHight = dataGridView1.GetRowDisplayRectangle(0, true).Height;

            var rowCountDGV = dataGridView1.RowCount;
            var columnCountDGV = dataGridView1.ColumnCount;
            rowsPerPage = e.MarginBounds.Height / rectangleRowHight; //кол-во строк на страницу
            maximumPage = rowCountDGV / rowsPerPage;
            e.PageSettings.PrinterSettings.MaximumPage = maximumPage;

            e.Graphics.DrawRectangle(Pens.Red, e.MarginBounds); //marginBounds
            e.Graphics.DrawRectangle(Pens.DarkGreen, e.PageBounds);
            e.Graphics.DrawRectangle(pen, Rectangle.Truncate(hederStringRectangleF)); //hederStringRectangleF
            e.Graphics.DrawString(hederString, lblHeaderString.Font, Brushes.Black, hederStringRectangleF); //hederString

            //e.HasMorePages = true;
            for (int rowIndex = 0; rowIndex < rowCountDGV; rowIndex++)
            {
                var rectangleRow = dataGridView1.GetRowDisplayRectangle(rowIndex, true);

                for (int columnIndex = 0; columnIndex < columnCountDGV; columnIndex++)
                {
                    rectangleCell = dataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);
                    //rectangleCell.X += 39;
                    stringPrint = (string)dataGridView1[columnIndex, rowIndex].FormattedValue;
                    e.Graphics.DrawRectangle(pen, rectangleCell);
                    e.Graphics.DrawString(stringPrint, font, Brushes.Black, (RectangleF)rectangleCell, format1);
                }
                
            }

            #region MyRegion
            //    //var stringSizeF = e.Graphics.MeasureString("Hello, world!!!", this.Font);
            //    //RectangleF rect = new() { Size = stringSizeF, X = 40F, Y = 40F };

            //    e.Graphics.DrawRectangle(pen, rectangleCell);
            //    e.Graphics.DrawString("Hello, world!!!", this.Font, Brushes.Red, rectangleCell);
            //var pageArea = e.PageBounds;
            //var marginBounds = e.MarginBounds;
            //    //var area = Rectangle.Truncate(e.PageSettings.PrintableArea);
            //e.Graphics.DrawRectangle(Pens.Red, marginBounds);

            //e.Graphics.DrawRectangle(Pens.Green, pageArea);

            //    var rectangleRow = dataGridView1.GetRowDisplayRectangle(0, true);
            //    var point = rectangleCell.Location;
            //    var rectangell = dataGridView1.GetCellDisplayRectangle(0, 0, true);
            //    e.Graphics.DrawRectangle(Pens.Black, rectangleCell);
            //    e.Graphics.DrawRectangle(Pens.Black, rectangleRow);
            //    e.Graphics.DrawString(stringPrint, this.Font, Brushes.Black, point);


            //    #region Print string format Example
            //    ///////
            //    Rectangle displayRectangle =
            //new Rectangle(new Point(102, 45), new Size(80, 80));

            //    // Construct 2 new StringFormat objects
            //    //StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            //    //StringFormat format2 = new StringFormat(format1);

            //    // Set the LineAlignment and Alignment properties for
            //    // both StringFormat objects to different values.
            //    format1.LineAlignment = StringAlignment.Near;
            //    format1.Alignment = StringAlignment.Center;
            //    format2.LineAlignment = StringAlignment.Center;
            //    format2.Alignment = StringAlignment.Far;

            //    // Draw the bounding rectangle and a string for each
            //    // StringFormat object.
            //    e.Graphics.DrawRectangle(Pens.Black, displayRectangle);
            //    e.Graphics.DrawString("Showing Format1 Center", this.Font,
            //        Brushes.Red, (RectangleF)displayRectangle, format1);
            //    e.Graphics.DrawString("Showing Format2 Far", this.Font,
            //        Brushes.Red, (RectangleF)displayRectangle, format2); 
            #endregion

            #region // Пример печати многостраничного док-та
            //Font printFont = new("Arial", 12);
            //var row = dataGridView1.Rows[0].ToString();
            //e.Graphics.DrawString(row, printFont, Brushes.Black, 0, 0);

            //float linesPerPage = 0;
            //float yPos = 0;
            //int count = 0;
            //float leftMargin = e.MarginBounds.Left;
            //float topMargin = e.MarginBounds.Top;
            //String line = null;

            // Calculate the number of lines per page.
            //linesPerPage = e.MarginBounds.Height /
            //   printFont.GetHeight(e.Graphics);

            // Iterate over the file, printing each line.
            //while (count < linesPerPage &&
            //   ((line = streamToPrint.ReadLine()) != null))
            //{
            //    yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            //    ev.Graphics.DrawString(line, printFont, Brushes.Black,
            //       leftMargin, yPos, new StringFormat());
            //    count++;
            //}

            // If more lines exist, print another page.
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
            var printController = printDocument1.PrintController;
            var pageSettings = pageSetupDialog1.PageSettings;
            var defaultPageSettings = printDocument1.DefaultPageSettings;

            pageSetupDialog1.ShowDialog();


            printController = printDocument1.PrintController;
            pageSettings = pageSetupDialog1.PageSettings;
            defaultPageSettings = printDocument1.DefaultPageSettings;
            
            //PaperSize myPaperSize = new()
            //{
            //    PaperName = "my_A4Rotade",
            //    RawKind = 77,
            //    Width = 1169,
            //    Height = 826
            //};

            //printDocument1.DefaultPageSettings.PaperSize = myPaperSize;
        }

        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            var ps = e.PageSettings;
            
            //printDialog1.ShowDialog();
        }

        private void PrintDocument1_EndPrint(object sender, PrintEventArgs e)
        {

        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            //если не отображается, тогда отобразить
            if (!this.monthCalendar1.Visible)
            {
                this.monthCalendar1.Visible = true; //отобразить
                this.monthCalendar1.BringToFront(); //на передний план
            }
            //если отображается, тогда скрыть и сохранить дату
            else
            {
                this.monthCalendar1.Visible = false; //скрыть
                //textBox1.Text = monthCalendar1.SelectionStart.ToString();
            }
        }
        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {

            //если не отображается, тогда отобразить
            if (!this.monthCalendar2.Visible)
            {
                this.monthCalendar2.Visible = true; //отобразить
                this.monthCalendar2.BringToFront(); //на передний план
            }
            //если отображается, тогда скрыть и сохранить дату
            else
            {
                this.monthCalendar2.Visible = false; //скрыть
                //textBox2.Text = monthCalendar1.SelectionStart.ToString();
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
            this.monthCalendar1.Visible = false; //скрыть
        }

        private void MonthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar2.SelectionStart.ToString();
            this.monthCalendar2.Visible = false; //скрыть
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(textBox1.Text, out DateTime date);
            DateTime.TryParse(textBox2.Text, out DateTime date2);
            
            //var date = new DateTime(2021, 07, 10); // r.Date >= date  
            //var date2 = new DateTime(2021, 10, 16) + new TimeSpan(23, 59, 59); // r.Date <= date2

            using Db_Enterprise_Store_Context db = new();

            #region // Отчёт о продажах и начисление зп queryReportSalesForEachPersonnel
            double percentPerSale = 0.05; //доля от суммы продаж
            var queryReportSalesForEachPersonnel = db.Personnels
                .Select(per => new
                {
                    per.PersonnelId, // id персонала
                    per.PersonnelName, // имя персонала

                    realizationForEachProduct = per.Realizations //реализация по каждому товару
                        .Where(r => r.Date >= date && r.Date <= date2) // за период
                        .SelectMany(r => r.RealizationPriceQties)
                        .Select(rpq => new
                        {
                            rpq.Realization.PersonnelsPersonnel.PersonnelId,
                            rpq.Realization.PersonnelsPersonnel.PersonnelName,

                            Product_Name = rpq.Product.ProductName,
                            rpq.PriceSelling,
                            rpq.Quantity,
                            totalForEachProduct = rpq.PriceSelling * (decimal)rpq.Quantity,

                            sumAllRealizations = per.Realizations //сумма продаж 
                            .Where(r => r.Date >= date && r.Date <= date2) // на период
                            .SelectMany(r => r.RealizationPriceQties.Select(rpq => rpq.PriceSelling * (decimal)rpq.Quantity)).Sum(),

                            theSalary = per.Realizations // процент от продаж з.п. сотрудника
                            .Where(r => r.Date >= date && r.Date <= date2)
                            .SelectMany(r => r.RealizationPriceQties
                                .Select(rpq => rpq.PriceSelling * (decimal)rpq.Quantity)).Sum() * (decimal)percentPerSale,

                        }).ToList()
                }).ToList();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Rows.Add("Дата:", "от " + date, "по " + date2);

            dataGridView1.ReadOnly = true;
            for (int i = 0; i < queryReportSalesForEachPersonnel.Count; i++)
            {
                var item = queryReportSalesForEachPersonnel[i];
                if (item.realizationForEachProduct.Count() == 0)
                {
                    continue;
                }

                var idAndNamePersonnel = string.Format("{0} {1}", item.PersonnelId, item.PersonnelName);
                var sumAllRealizations = string.Format("{0:C2}", item.realizationForEachProduct[0].sumAllRealizations);
                var theSalary = string.Format("{0:C2}", item.realizationForEachProduct[0].theSalary);

                int idx = dataGridView1.Rows.Add(idAndNamePersonnel); // вставка строки код и имя сотрудника
                dataGridView1.Rows[idx].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
                foreach (var product in item.realizationForEachProduct)
                {
                    dataGridView1.Rows.Insert(idx + 1, product.Product_Name,
                                                     string.Format("{0:C2}", product.PriceSelling),
                                                     product.Quantity,
                                                     string.Format("{0:C2}", product.totalForEachProduct));
                }

                idx = dataGridView1.Rows.Add("Начислено 5% от продаж:", theSalary, "Сумма продаж:", sumAllRealizations); // вставка строки код и имя сотрудника
                dataGridView1.Rows[idx].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            }
            #endregion
        }
    }
}
