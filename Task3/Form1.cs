using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, RoutedEventArgs e)
        {
            using (var package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Умножение");

                worksheet.Cells[1, 1].Value = "x";
                for (int i = 2; i <= 9; i++)
                {
                    worksheet.Cells[1, i].Value = i;
                    worksheet.Cells[i, 1].Value = i;
                }

                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 2; j <= 9; j++)
                    {
                        worksheet.Cells[i, j].Value = i * j;
                    }
                }

                var file = new FileInfo(@"C:\Temp\ispp21\PractWork2\Task3\bin\Debug\net8.0-windows\Умножение.xlsx");
                package.SaveAs(file);
            }
        }
    }
    /*

            private void CreateMultiplicationTable(object sender, RoutedEventArgs e)
            {
                using (var package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Умножение");

                    worksheet.Cells[1, 1].Value = "x";
                    for (int i = 2; i <= 9; i++)
                    {
                        worksheet.Cells[1, i].Value = i;
                        worksheet.Cells[i, 1].Value = i;
                    }

                    for (int i = 2; i <= 9; i++)
                    {
                        for (int j = 2; j <= 9; j++)
                        {
                            worksheet.Cells[i, j].Value = i * j;
                        }
                    }

                    var file = new FileInfo(@"C:\Temp\ispp21\PractWork2\Task3\bin\Debug\net8.0-windows\Умножение.xlsx");
                    package.SaveAs(file);
                }
            }
        }
    }*/
}
