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
        private string startPath;

        public string StartPathProperty
        {
            get { return startPath; }
            set { startPath = value; }
        }

        public ExcelClass(string startPath)
        {
            this.startPath = startPath;
            
        }


        public void OpenExcelFile()
        {
            MainClass main = new MainClass();
            string startpath = main.AddPatchToZWMFile();
            ZWM.Classes.ZwmInstanceClass zwmInstance = new ZwmInstanceClass();


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
                    string connectedNameAndSurname = (arkusz.Cells[4, 5].Value.ToString());
                    string connectedContractAndKilometer = arkusz.Cells[6, 5].Value.ToString();


                    //oddczytanie wartosci 
                    zwmInstance.nameProperty = connectedNameAndSurname.Substring(0, connectedNameAndSurname.Trim().IndexOf(" "));
                    zwmInstance.surnameProperty = connectedNameAndSurname.Substring(connectedNameAndSurname.Trim().IndexOf(" ") + 1);

                    zwmInstance.contractNumberProperty = connectedContractAndKilometer.Substring(0, connectedContractAndKilometer.Trim().IndexOf(" "));
                    zwmInstance.kilometerProperty = connectedContractAndKilometer.Substring(connectedContractAndKilometer.Trim().IndexOf(" ") + 1);
                    zwmInstance.plannedDateOfReceiptProperty = arkusz.Cells[8, 7].Value.ToString();

                    string[,] tab = new string[10, 6];
                    tab = arkusz.get_Range("B14", "G23").Value;

                    zwmInstance.attentionProperty = arkusz.Cells[27, 3].Value.ToString();
                    
                }
            }
            
        }
        public void StringGetDataFromDoc()
        {

        }

    }

}
