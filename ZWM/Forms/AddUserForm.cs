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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes_btn_Click(object sender, EventArgs e)
        {
            Name_tb.Text = "";
            Surname_tb.Text = "";
            Login_tb.Text = "";
            Password_tb.Text = "";
            PasswordRepeat_tb.Text = "";
        }

        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            //TODO Sprawdz czy istnieje jesli nie Dodaj uzytkownika do bazy i cofnij do Login form w label wypisz informacje
        }

        private void BackToTheFirstForm_btn_Click(object sender, EventArgs e)
        {

            //Otwarcie nowego okna, usunięcie obecnego.
            using (var okno = new LogInForm())
            {
                this.Visible = false;
                okno.ShowInTaskbar = false;
                okno.ShowDialog();
                this.Visible = true;
            }
        }

        private void CloseProgram_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
