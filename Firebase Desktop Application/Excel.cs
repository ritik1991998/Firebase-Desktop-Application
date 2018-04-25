using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Firebase_Desktop_Application
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel(string path,int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
            
        }

        public object ReadCell(int i,int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value != null)
            {
                return ws.Cells[i, j].Value;


            }
            else return "";
        }
    }
}
