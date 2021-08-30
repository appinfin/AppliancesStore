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

        public ReportSales_Form()
        {
            InitializeComponent();
        }

        private void ReportSales_Form_Load(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = false; //скрыть календарь
            this.monthCalendar2.Visible = false; //скрыть календарь

            //поля страницы для печати (default)
            printDocument1.DefaultPageSettings.Margins = new Margins { Left = 79, Right = 39, Top = 39, Bottom = 39 };
        }

        #region // Открытие диалога предпросмотра печати
        private void PreviewPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; // документ для печати
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.75; // 
            printPreviewDialog1.PrintPreviewControl.Rows = 3;
            printPreviewDialog1.ShowDialog();
            rowIndex = 0; //индекс строки dgv для перебора всех строк в цикле печати
            paginationPage = 1;
        } 
        #endregion

        int rowIndex = 0; //индекс строки dgv для перебора всех строк в цикле печати
        int paginationPage = 1;
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle marginBounds = e.MarginBounds;

            // формат строки
            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Far;

            StringFormat paginationPageStringFormat = new StringFormat(format1);
            paginationPageStringFormat.LineAlignment = StringAlignment.Near;

            Font font = dataGridView1.Font;
            Pen pen = new(Color.LightGray);

            string printString;
            string hederString = lblHeaderString.Text; //строка заголовка
            string paginationPageString = string.Empty;

            var hederStringSizeF = e.Graphics.MeasureString(hederString, lblHeaderString.Font); //измеряем строку
            int marginBoundsHeightExceptHeder = (int)Math.Ceiling(e.MarginBounds.Height - hederStringSizeF.Height); //высота страницы без заголовка

            var rowCountDGV = dataGridView1.RowCount;
            var columnCountDGV = dataGridView1.ColumnCount;

            //подсчёт макс. кол-ва страниц исходя из кол-ва строк в таблице
            int rowHight = dataGridView1.GetRowDisplayRectangle(0, false).Height;
            int rowsPerPage = marginBoundsHeightExceptHeder / rowHight; //кол-во строк на страницу
            int maximumPage = (int)Math.Ceiling( (double)rowCountDGV / rowsPerPage);
            printDocument1.PrinterSettings.MaximumPage = maximumPage; // maximumPage;

            //строка загаловка отчёта
            e.Graphics.DrawString(hederString, lblHeaderString.Font, Brushes.Black, e.MarginBounds.Location);
            
            //строка нумерации страниц
            paginationPageString = paginationPage + " из " + maximumPage;
            e.Graphics.DrawString(paginationPageString, label1.Font, Brushes.Black, e.MarginBounds, paginationPageStringFormat);

            Rectangle rectangleCell = Rectangle.Empty; //прямоугольник ячейки dgv
            Point locatonRectangleCell = new Point // точка локации 0,0
            {
                // верхний левый угол пересечения границ отступов (верх. отступ и левый отступ)
                X = e.MarginBounds.Location.X, 
                Y = e.MarginBounds.Location.Y
            };
            
            rectangleCell.Y = locatonRectangleCell.Y + (int)hederStringSizeF.Height; // смещение по Y вниз на высоту заголовка

            //Size sizeCell; //размер ячейки

            #region // цикл печати
            // пока есть строки в таблице печатаем
            while (rowIndex < rowCountDGV)
            {
                rectangleCell.X = locatonRectangleCell.X; //начальная позиция печати 1-ой ячейки в строке
                //sizeCell = dataGridView1[0, rowIndex].Size;
                for (int columnIndex = 0; columnIndex < columnCountDGV; columnIndex++)
                {
                    rectangleCell.Size = dataGridView1[columnIndex, rowIndex].Size; //размер текущей ячейки
                    printString = (string)dataGridView1[columnIndex, rowIndex].FormattedValue; // значение текущей ячейки

                    e.Graphics.DrawRectangle(pen, rectangleCell);
                    e.Graphics.DrawString(printString, font, Brushes.Black, (RectangleF)rectangleCell, format1);

                    rectangleCell.X += rectangleCell.Width; //смещение на ширину ячейки для печати следующей
                }
                ++rowIndex;
                rectangleCell.Y += rectangleCell.Height; //смещение на высоту ячейки для печати следующей строки

                //если строки выходят за границу одной страницы
                if (rectangleCell.Y >= e.MarginBounds.Height)
                {
                    //тогда делаем документ многостраничным
                    e.HasMorePages = true;
                    rectangleCell.Y = 0;
                    paginationPage++;
                    return;
                }
                else //иначе больше страниц нет
                {
                    e.HasMorePages = false;
                }
            }
            pen.Dispose();

            #endregion
        }

        //диалог установки параметров печати
        private void PrintDialog_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        //диалог установки свойств страницы (поля, размер бумаги, ориентация)
        private void PageSetupDialog_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        //начало печати. диалог установки свойств страницы
        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        #region //Установка даты
        //клик в поле даты для ввода значения
        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //если не отображается, тогда отобразить календарь
            if (!this.monthCalendar1.Visible)
            {
                this.monthCalendar1.Visible = true; //отобразить
                this.monthCalendar1.BringToFront(); //на передний план
            }
            //если отображается, тогда скрыть и сохранить дату
            else
            {
                this.monthCalendar1.Visible = false; //скрыть
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

        //при выборе даты в календаре (клик по дате)
        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //дата дд/мм/гггг 00:00:00
            textBox1.Text = monthCalendar1.SelectionStart.Date.ToString();
            this.monthCalendar1.Visible = false; //скрыть
        }
        private void MonthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            //добавляем 23:59:59 для учёта всего календарного дня
            textBox2.Text = (monthCalendar2.SelectionStart.Date + new TimeSpan(23, 59, 59)).ToString();
            this.monthCalendar2.Visible = false; //скрыть
        } 
        #endregion

        // Формирование отчёта в DGV. Запрос к БД. 
        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //получаем даты из текстовых полей формы
            DateTime.TryParse(textBox1.Text, out DateTime date); //дата от
            DateTime.TryParse(textBox2.Text, out DateTime date2); // дата до

            using Db_Enterprise_Store_Context db = new();
            db.ChangeTracker.AutoDetectChangesEnabled = false;

            #region // Отчёт о продажах и начисление зп queryReportSalesForEachPersonnel
            double percentPerSale = 0.05; //доля от суммы продаж 5%
            var queryReportSalesForEachPersonnel = db.Personnels //запрос по каждому сотруднику
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

            //создаём DGV
            dataGridView1.ColumnCount = 4; //кол-во столбцов таблицы
            dataGridView1.Rows.Add("Дата:", "от " + date, "по " + date2); //добавляем первую строку
            dataGridView1.ReadOnly = true; // только для чтения без возможности редактировать ячейки

            //цикл вставки и заполнения строк таблицы данными из запроса
            for (int i = 0; i < queryReportSalesForEachPersonnel.Count; i++) //перебираем строки в результирующей таблице
            {
                var item = queryReportSalesForEachPersonnel[i];
                //если список реализаций у менеджера пуст, то переходим к следующему менеджеру
                if (item.realizationForEachProduct.Count() == 0)
                {
                    continue;
                }

                //формат строк
                var idAndNamePersonnel = string.Format("{0} {1}", item.PersonnelId, item.PersonnelName); //id и имя сотрудника
                var sumAllRealizations = string.Format("{0:C2}", item.realizationForEachProduct[0].sumAllRealizations); //сумма всех продаж
                var theSalary = string.Format("{0:C2}", item.realizationForEachProduct[0].theSalary); //зп

                // вставка строки код и имя сотрудника
                int idx = dataGridView1.Rows.Add(idAndNamePersonnel); //индекс добавленной строки
                dataGridView1.Rows[idx].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
                foreach (var product in item.realizationForEachProduct)
                {
                    //вставка строки Имя / Цена товара / Кол-во / Итого (сумма продажи товара)
                    dataGridView1.Rows.Insert(++idx, product.Product_Name,
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
