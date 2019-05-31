namespace ZWM.Forms
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Surname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordRepeat_tb = new System.Windows.Forms.TextBox();
            this.AddUser_btn = new System.Windows.Forms.Button();
            this.ClearTextBoxes_btn = new System.Windows.Forms.Button();
            this.BackToTheFirstForm_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_tb
            // 
            this.Name_tb.Location = new System.Drawing.Point(156, 21);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(200, 22);
            this.Name_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj dane:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imie:";
            // 
            // Surname_tb
            // 
            this.Surname_tb.Location = new System.Drawing.Point(156, 49);
            this.Surname_tb.Name = "Surname_tb";
            this.Surname_tb.Size = new System.Drawing.Size(200, 22);
            this.Surname_tb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko:";
            // 
            // Login_tb
            // 
            this.Login_tb.Location = new System.Drawing.Point(156, 77);
            this.Login_tb.Name = "Login_tb";
            this.Login_tb.Size = new System.Drawing.Size(200, 22);
            this.Login_tb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasło:";
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(156, 105);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(200, 22);
            this.Password_tb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Powtórz hasło:";
            // 
            // PasswordRepeat_tb
            // 
            this.PasswordRepeat_tb.Location = new System.Drawing.Point(156, 133);
            this.PasswordRepeat_tb.Name = "PasswordRepeat_tb";
            this.PasswordRepeat_tb.Size = new System.Drawing.Size(200, 22);
            this.PasswordRepeat_tb.TabIndex = 4;
            // 
            // AddUser_btn
            // 
            this.AddUser_btn.Location = new System.Drawing.Point(218, 233);
            this.AddUser_btn.Name = "AddUser_btn";
            this.AddUser_btn.Size = new System.Drawing.Size(150, 25);
            this.AddUser_btn.TabIndex = 2;
            this.AddUser_btn.Text = "Dodaj użytkownika";
            this.AddUser_btn.UseVisualStyleBackColor = true;
            this.AddUser_btn.Click += new System.EventHandler(this.AddUser_btn_Click);
            // 
            // ClearTextBoxes_btn
            // 
            this.ClearTextBoxes_btn.Location = new System.Drawing.Point(9, 202);
            this.ClearTextBoxes_btn.Name = "ClearTextBoxes_btn";
            this.ClearTextBoxes_btn.Size = new System.Drawing.Size(150, 25);
            this.ClearTextBoxes_btn.TabIndex = 0;
            this.ClearTextBoxes_btn.Text = "Wyczyść";
            this.ClearTextBoxes_btn.UseVisualStyleBackColor = true;
            this.ClearTextBoxes_btn.Click += new System.EventHandler(this.ClearTextBoxes_btn_Click);
            // 
            // BackToTheFirstForm_btn
            // 
            this.BackToTheFirstForm_btn.Location = new System.Drawing.Point(9, 233);
            this.BackToTheFirstForm_btn.Name = "BackToTheFirstForm_btn";
            this.BackToTheFirstForm_btn.Size = new System.Drawing.Size(150, 25);
            this.BackToTheFirstForm_btn.TabIndex = 1;
            this.BackToTheFirstForm_btn.Text = "Cofnij";
            this.BackToTheFirstForm_btn.UseVisualStyleBackColor = true;
            this.BackToTheFirstForm_btn.Click += new System.EventHandler(this.BackToTheFirstForm_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Login:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Name_tb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Surname_tb);
            this.panel1.Controls.Add(this.Login_tb);
            this.panel1.Controls.Add(this.Password_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PasswordRepeat_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 161);
            this.panel1.TabIndex = 15;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 267);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackToTheFirstForm_btn);
            this.Controls.Add(this.ClearTextBoxes_btn);
            this.Controls.Add(this.AddUser_btn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj użytkownika";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Surname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordRepeat_tb;
        private System.Windows.Forms.Button AddUser_btn;
        private System.Windows.Forms.Button ClearTextBoxes_btn;
        private System.Windows.Forms.Button BackToTheFirstForm_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}