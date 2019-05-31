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
            if (!String.IsNullOrWhiteSpace(Name_tb.Text) && !String.IsNullOrWhiteSpace(Surname_tb.Text) && !String.IsNullOrWhiteSpace(Login_tb.Text) && !String.IsNullOrWhiteSpace(Password_tb.Text) && !String.IsNullOrWhiteSpace(PasswordRepeat_tb.Text))
            {
                if (Password_tb.Text.Equals(PasswordRepeat_tb.Text))
                {
                    bool isUserExist = false;

                    string myQuery = $"Insert into Kierownicy (imie,nazwisko,login,haslo)values('{Name_tb.Text}','{Surname_tb.Text}','{Login_tb.Text}','{ Password_tb.Text}')";
                    DbClass dbClass = new DbClass();
                    dbClass.ConnectionToDataBaseZwm(myQuery: myQuery, whatToDo: 2, finished: out isUserExist);

                    if (isUserExist)
                    {
                        UserClass NewUser = new UserClass(Name_tb.Text, Surname_tb.Text, Login_tb.Text, Password_tb.Text);

                        Name_tb.Text = "";
                        Surname_tb.Text = "";
                        Login_tb.Text = "";
                        Password_tb.Text = "";
                        PasswordRepeat_tb.Text = "";

                        MessageBox.Show("Użytkownik został stworzony!");
                        using (var okno = new LogInForm())
                        {
                            this.Visible = false;
                            okno.ShowInTaskbar = false;
                            okno.ShowDialog();
                            this.Visible = true;
                        }
                    }

                    using (var okno = new LogInForm())
                    {
                        this.Visible = false;
                        okno.ShowInTaskbar = false;
                        okno.ShowDialog();
                        this.Visible = true;
                    }

                }
                else
                {
                    MessageBox.Show("Wprowadzone hasło musi być jednakowe!");
                }
            }
            else
            {
                MessageBox.Show("Wszystkie pola muszą zostać wprowadzone!");
            }
        }

        private void BackToTheFirstForm_btn_Click(object sender, EventArgs e)
        {
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
