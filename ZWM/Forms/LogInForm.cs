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
            bool isEntryOk = false;
            //TODO Pobierz dane, Sprawdz czy sa zgodne z danymi z baza
            if (!String.IsNullOrWhiteSpace(login_tb.Text) && !String.IsNullOrWhiteSpace(Password_tb.Text))
            {
                string myQuery = $"Select idKierownika From Kierownicy Where login='{login_tb.Text}' and haslo= '{Password_tb.Text}'";
                DbClass dbClass = new DbClass();
                dbClass.ConnectionToDataBaseZwm(myQuery: myQuery, whatToDo: 1, finished: out isEntryOk);
                if (isEntryOk)
                {
                    using (var okno = new MainForm())
                    {
                        this.Visible = false;
                        okno.ShowInTaskbar = false;
                        okno.ShowDialog();
                        this.Visible = true;
                    }
                    login_tb.Text = "";
                    Password_tb.Text = "";
                    label3.Text = "";

                }
                else
                {
                    MessageBox.Show("Wprowadzone dane są niepoprawne!");
                    login_tb.Text = "";
                    Password_tb.Text = "";
                }

            }
            else
            {
                label3.Text = "Wprowadź poprawnie dane logowania.";
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

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
