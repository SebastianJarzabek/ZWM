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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            using (var okno = new AddUserForm())
            {
                this.Visible = false;
                okno.ShowInTaskbar = false;
                okno.ShowDialog();
                this.Visible = true;
            }
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            //TODO Pobierz dane, Sprawdz czy sa zgodne z danymi z baza
            if (!String.IsNullOrWhiteSpace(login_tb.Text) && !String.IsNullOrWhiteSpace(Password_tb.Text))
            {


                using (var okno = new MainForm())
                {
                    this.Visible = false;
                    okno.ShowInTaskbar = false;
                    okno.ShowDialog();
                    this.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Wprowadzone dane są niepoprawne!");
                login_tb.Text = "";
                Password_tb.Text = "";
                label3.Text = "Wprowadź poprawne dane logowania.";
            }
        }

        private void ClearTextBoxes_btn_Click(object sender, EventArgs e)
        {
            login_tb.Text = "";
            Password_tb.Text = "";
        }

        private void CloseProgram_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
