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
    public partial class ManualAdditionZWMForm : Form
    {
        public ManualAdditionZWMForm()
        {
            InitializeComponent();
        }

        private void ManualAdditionZWM_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zWMDataSet.Kontrakty' . Możesz go przenieść lub usunąć.
            this.kontraktyTableAdapter.Fill(this.zWMDataSet.Kontrakty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zWMDataSet.Kierownicy' . Możesz go przenieść lub usunąć.
            this.kierownicyTableAdapter.Fill(this.zWMDataSet.Kierownicy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zWMDataSet.Zamowienia' . Możesz go przenieść lub usunąć.
            this.zamowieniaTableAdapter.Fill(this.zWMDataSet.Zamowienia);

        }

        private void Materials_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kierownicyTableAdapter.FillBy(this.zWMDataSet.Kierownicy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManualAdditionZWM_btn_Click(object sender, EventArgs e)
        {
            //for ( int i=0; i< Materials_dgv.len; i++)
            //{
            //    object ZWMRow = i;
            //    ZwmInstanceClass ZWMRow = new ZwmInstanceClass();
            //    ZWMRow.nameProperty = Name_cb.Text;
            //    ZWMRow.surnameProperty = Surname_cb.Text;
            //    ZWMRow.contractNumberProperty = ContractNumber_cb.Text;
            //    ZWMRow.kilometerProperty = Kilometer_cb.Text;
            //    ZWMRow.plannedDateOfReceiptProperty = DateOfReceipt_dtp.Value;
            //}
            ZwmInstanceClass zwm = new ZwmInstanceClass();
            zwm.nameProperty = Name_cb.Text;
            zwm.surnameProperty = Surname_cb.Text;
            zwm.contractNumberProperty = ContractNumber_cb.Text;
            zwm.kilometerProperty = Kilometer_cb.Text;
            zwm.plannedDateOfReceiptProperty = DateOfReceipt_dtp.Value;

            // foreach (whatRow in )
        }

        private void BackToTheFirstForm_btn_Click(object sender, EventArgs e)
        {
            using (var okno = new MainForm())
            {

                this.Visible = false;
                okno.ShowInTaskbar = false;
                okno.ShowDialog();
                this.Visible = true;
            }
        }

        private void ClouseProgram_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
