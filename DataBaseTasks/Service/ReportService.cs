using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTasks.Service
{
    public class ReportService
    {
        public void ExportExcel(DataGridView dataGrid)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridView";

            for (int i = 1; i < dataGrid.Columns.Count + 1; i++) worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;

            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs(@"C:\Users\Yrulewet\Desktop\Образование\2 курс\БД\LR11\Output.xls", 
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange);

            app.Quit();
        }

        public void ExportWord(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count == 0) return;

            int RowCount = dataGrid.Rows.Count;
            int ColumnCount = dataGrid.ColumnCount;

            var app = new Microsoft.Office.Interop.Word.Application();

            Microsoft.Office.Interop.Word.Document document = new Microsoft.Office.Interop.Word.Document();

            document.Application.Visible = true;
            document.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;

            Microsoft.Office.Interop.Word.Paragraph paragraph = document.Paragraphs.Add();
            Microsoft.Office.Interop.Word.Range range = paragraph.Range;
            Microsoft.Office.Interop.Word.Table table = document.Tables.Add(range, RowCount, ColumnCount);

            table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            table.Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

            for (int i = 1; i <= RowCount + 1; i++)
            {
                range = table.Cell(1, i).Range;
                range.Text = dataGrid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < RowCount - 1; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    range = table.Cell(i + 2, j + 1).Range;
                    range.Text = dataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            document.SaveAs2(@"C:\Users\Yrulewet\Desktop\Образование\2 курс\БД\LR12\Output.docx");
        }
    }


}

