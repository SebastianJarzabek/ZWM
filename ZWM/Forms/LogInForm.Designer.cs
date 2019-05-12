namespace ZWM.Forms
{
    partial class LogInForm
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
            this.login_tb = new System.Windows.Forms.TextBox();
            this.AddUser_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.ClearTextBoxes_btn = new System.Windows.Forms.Button();
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.CloseProgram_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(100, 9);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(200, 22);
            this.login_tb.TabIndex = 0;
            // 
            // AddUser_btn
            // 
            this.AddUser_btn.Location = new System.Drawing.Point(16, 88);
            this.AddUser_btn.Name = "AddUser_btn";
            this.AddUser_btn.Size = new System.Drawing.Size(153, 25);
            this.AddUser_btn.TabIndex = 2;
            this.AddUser_btn.Text = "Dodaj użytkownika";
            this.AddUser_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło:";
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(100, 49);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(200, 22);
            this.Password_tb.TabIndex = 1;
            // 
            // ClearTextBoxes_btn
            // 
            this.ClearTextBoxes_btn.Location = new System.Drawing.Point(200, 88);
            this.ClearTextBoxes_btn.Name = "ClearTextBoxes_btn";
            this.ClearTextBoxes_btn.Size = new System.Drawing.Size(100, 25);
            this.ClearTextBoxes_btn.TabIndex = 3;
            this.ClearTextBoxes_btn.Text = "Wyczyść";
            this.ClearTextBoxes_btn.UseVisualStyleBackColor = true;
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.Location = new System.Drawing.Point(16, 119);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(153, 25);
            this.LogIn_btn.TabIndex = 4;
            this.LogIn_btn.Text = "Zaloguj";
            this.LogIn_btn.UseVisualStyleBackColor = true;
            // 
            // CloseProgram_btn
            // 
            this.CloseProgram_btn.Location = new System.Drawing.Point(200, 119);
            this.CloseProgram_btn.Name = "CloseProgram_btn";
            this.CloseProgram_btn.Size = new System.Drawing.Size(100, 25);
            this.CloseProgram_btn.TabIndex = 5;
            this.CloseProgram_btn.Text = "Zamknij";
            this.CloseProgram_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(312, 173);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CloseProgram_btn);
            this.Controls.Add(this.LogIn_btn);
            this.Controls.Add(this.ClearTextBoxes_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUser_btn);
            this.Controls.Add(this.login_tb);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaloguj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.Button AddUser_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Button ClearTextBoxes_btn;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.Button CloseProgram_btn;
        private System.Windows.Forms.Label label3;
    }
}