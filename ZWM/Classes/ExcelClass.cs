using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ZWM.Classes
{
    class ExcelClass
    {
        public int MyProperty { get; set; }

        public void OpenExcelFile()
        {
            MainClass main = new MainClass();
            string startpath = main.AddPatchToZWMFile();

            if (startpath != null)
            {
                Excel.Application app = new Excel.Application();
                //
                Excel.Workbook plik = app.Workbooks.Open(startpath);
                //
                Excel.Worksheet arkusz = null;
                //
                foreach (Excel.Worksheet shit in plik.Sheets)
                {
                    arkusz = shit;
                    break;
                }
                // jesli arkusz nie jest null
                if (arkusz != null)
                {
                    
                    ZWM.Classes.ZwmInstanceClass zwmInstance = new ZwmInstanceClass();
                    //oddczytanie wartosci 
                    zwmInstance.nameProperty = arkusz.Cells[4, 5].Value.ToString();
                    zwmInstance.surnameProperty = arkusz.Cells[6, 5].Value.ToString();
                    zwmInstance.contractNumberProperty = arkusz.Cells[8, 7].Value.ToString();
                    zwmInstance.kilometerProperty = "";

                    tab = arkusz.get_Range("B14", "G23").Value;
                    zwmInstance.attentionProperty = arkusz.Cells[27, 3].Value.ToString();

                }
            }

        }
    }
