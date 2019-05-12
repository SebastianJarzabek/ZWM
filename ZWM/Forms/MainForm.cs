using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
