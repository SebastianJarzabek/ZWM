using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZWM.Classes
{
    class MainClass
    {
        private string fileZWMToAddPatch = "";

        public string FileZWMToAddPatchProperty
        {
            get { return fileZWMToAddPatch; }
            set { fileZWMToAddPatch = value; }
        }

        public String AddPatchToZWMFile()
        {
            OpenFileDialog openExcelFile = new OpenFileDialog();

            if (openExcelFile.ShowDialog() == DialogResult.OK)
            {
                FileZWMToAddPatchProperty = openExcelFile.FileName;
            }

            return fileZWMToAddPatch;
        }

        
        //public void OpenForm()
        //{

        //    //Otwarcie nowego okna, usunięcie obecnego.
        //    using (var okno = new Form())
        //    {
        //        this.Visible = false;
        //        okno.ShowInTaskbar = false;
        //        okno.ShowDialog();
        //        this.Visible = true;
        //    }

        //}
    }
}
