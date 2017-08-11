using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    public class SaveAs
    {
        public static void SaveAsExcel()
        {

            var app = new Application { Visible = true };
            Workbook workbook = app.Workbooks.Add();
            Worksheet worksheet = app.ActiveSheet;
            int row = 2;
            foreach (var product in Product.GetSampleProducts().Where(p => p.Price != null))
            {
                worksheet.Cells[1, 1].Value = "Name";
                worksheet.Cells[1, 2].Value = "Price";

                worksheet.Cells[row, 1].Value = product.Name;
                worksheet.Cells[row, 2].Value = product.Price;
                row++;
            }
            workbook.SaveAs(Filename: @"D:\demo.xls", FileFormat: XlFileFormat.xlWorkbookNormal);
            app.Application.Quit();
        }
        public static void Python()
        {
            
        }
        
    }
    
}
