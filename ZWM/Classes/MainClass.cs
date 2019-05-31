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
                return fileZWMToAddPatch;
            }

            return null;

            
        }
    }
}
