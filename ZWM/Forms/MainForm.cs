using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZWM.Classes;

namespace ZWM.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zWMDataSet.Zamowienia' . Możesz go przenieść lub usunąć.
            this.zamowieniaTableAdapter.Fill(this.zWMDataSet.Zamowienia);

        }

        private void doToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseProgram_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoToFormManualAdditionZWM_btn_Click(object sender, EventArgs e)
        {
            //Otwarcie nowego okna, usunięcie obecnego.
            using (var okno = new ManualAdditionZWMForm())
            {

                this.Visible = false;
                okno.ShowInTaskbar = false;
                okno.ShowDialog();
                this.Visible = true;
            }
        }

        private void AddExcelFileZWM_btn_Click(object sender, EventArgs e)
        {
            MainClass nowy = new MainClass();
            FolderOperactionClass folderOperaction = new FolderOperactionClass();
            

            if (folderOperaction.IsBaseFolderZWMExist())
            {
                ExcelClass excelClass = new ExcelClass(nowy.AddPatchToZWMFile().ToString());
                ZwmInstanceClass zwmInstanceClass = new ZwmInstanceClass();
               // zwmInstanceClass = excelClass.OpenExcelFile();
                FilleOperationClass filleOperation = new FilleOperationClass(zwmInstanceClass.orderIdProperty,zwmInstanceClass.contractNumberProperty,zwmInstanceClass.kilometerProperty,zwmInstanceClass.plannedDateOfReceiptProperty);
                filleOperation.CopyAndRenameZWMFile();
                filleOperation.CreateWZFile();

            }

            else folderOperaction.IfBaseFolderDontExistExtractIt();





        }

        private void PrintLastAddedDocumentsZWMandWZ_btn_Click(object sender, EventArgs e)
        {
            //Drukowanie zwm i wz (ostatnio dodanego)
        }

        private void ListZWM_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            zamowieniaTableAdapter.Adapter.Fill(this.zWMDataSet);
        }
    }
}
