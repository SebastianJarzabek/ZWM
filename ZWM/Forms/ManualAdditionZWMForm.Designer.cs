namespace ZWM.Forms
{
    partial class ManualAdditionZWMForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateOfReceipt_dtp = new System.Windows.Forms.DateTimePicker();
            this.Kilometer_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContractNumber_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_cb = new System.Windows.Forms.ComboBox();
            this.Surname_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Materials_dgv = new System.Windows.Forms.DataGridView();
            this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKierownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkontraktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterialuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planowanyTerminOdbioruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUwagiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odbiorZMagazynuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zWMDataSet = new ZWM.ZWMDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Comments_tb = new System.Windows.Forms.TextBox();
            this.BackToTheFirstForm_btn = new System.Windows.Forms.Button();
            this.ManualAdditionZWM_btn = new System.Windows.Forms.Button();
            this.ClouseProgram_btn = new System.Windows.Forms.Button();
            this.zamowieniaTableAdapter = new ZWM.ZWMDataSetTableAdapters.ZamowieniaTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Materials_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DateOfReceipt_dtp);
            this.groupBox1.Controls.Add(this.Kilometer_cb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ContractNumber_cb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Name_cb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Surname_cb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Przewidywany termin odbioru:";
            // 
            // DateOfReceipt_dtp
            // 
            this.DateOfReceipt_dtp.Location = new System.Drawing.Point(244, 81);
            this.DateOfReceipt_dtp.Name = "DateOfReceipt_dtp";
            this.DateOfReceipt_dtp.Size = new System.Drawing.Size(382, 22);
            this.DateOfReceipt_dtp.TabIndex = 4;
            // 
            // Kilometer_cb
            // 
            this.Kilometer_cb.FormattingEnabled = true;
            this.Kilometer_cb.Location = new System.Drawing.Point(426, 47);
            this.Kilometer_cb.Name = "Kilometer_cb";
            this.Kilometer_cb.Size = new System.Drawing.Size(200, 24);
            this.Kilometer_cb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(334, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometr:";
            // 
            // ContractNumber_cb
            // 
            this.ContractNumber_cb.FormattingEnabled = true;
            this.ContractNumber_cb.Location = new System.Drawing.Point(128, 47);
            this.ContractNumber_cb.Name = "ContractNumber_cb";
            this.ContractNumber_cb.Size = new System.Drawing.Size(200, 24);
            this.ContractNumber_cb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nr. Kontraktu:";
            // 
            // Name_cb
            // 
            this.Name_cb.FormattingEnabled = true;
            this.Name_cb.Location = new System.Drawing.Point(128, 17);
            this.Name_cb.Name = "Name_cb";
            this.Name_cb.Size = new System.Drawing.Size(200, 24);
            this.Name_cb.TabIndex = 0;
            // 
            // Surname_cb
            // 
            this.Surname_cb.FormattingEnabled = true;
            this.Surname_cb.Location = new System.Drawing.Point(426, 17);
            this.Surname_cb.Name = "Surname_cb";
            this.Surname_cb.Size = new System.Drawing.Size(200, 24);
            this.Surname_cb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(334, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Materials_dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 357);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materiały";
            // 
            // Materials_dgv
            // 
            this.Materials_dgv.AllowUserToOrderColumns = true;
            this.Materials_dgv.AutoGenerateColumns = false;
            this.Materials_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Materials_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZamowieniaDataGridViewTextBoxColumn,
            this.idKierownikaDataGridViewTextBoxColumn,
            this.idkontraktuDataGridViewTextBoxColumn,
            this.idMaterialuDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.planowanyTerminOdbioruDataGridViewTextBoxColumn,
            this.idUwagiDataGridViewTextBoxColumn,
            this.odbiorZMagazynuDataGridViewTextBoxColumn});
            this.Materials_dgv.DataSource = this.zamowieniaBindingSource;
            this.Materials_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Materials_dgv.Location = new System.Drawing.Point(3, 18);
            this.Materials_dgv.Name = "Materials_dgv";
            this.Materials_dgv.RowTemplate.Height = 24;
            this.Materials_dgv.Size = new System.Drawing.Size(631, 336);
            this.Materials_dgv.TabIndex = 0;
            // 
            // idZamowieniaDataGridViewTextBoxColumn
            // 
            this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "idZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "idZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
            this.idZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idKierownikaDataGridViewTextBoxColumn
            // 
            this.idKierownikaDataGridViewTextBoxColumn.DataPropertyName = "idKierownika";
            this.idKierownikaDataGridViewTextBoxColumn.HeaderText = "idKierownika";
            this.idKierownikaDataGridViewTextBoxColumn.Name = "idKierownikaDataGridViewTextBoxColumn";
            // 
            // idkontraktuDataGridViewTextBoxColumn
            // 
            this.idkontraktuDataGridViewTextBoxColumn.DataPropertyName = "idkontraktu";
            this.idkontraktuDataGridViewTextBoxColumn.HeaderText = "idkontraktu";
            this.idkontraktuDataGridViewTextBoxColumn.Name = "idkontraktuDataGridViewTextBoxColumn";
            // 
            // idMaterialuDataGridViewTextBoxColumn
            // 
            this.idMaterialuDataGridViewTextBoxColumn.DataPropertyName = "idMaterialu";
            this.idMaterialuDataGridViewTextBoxColumn.HeaderText = "idMaterialu";
            this.idMaterialuDataGridViewTextBoxColumn.Name = "idMaterialuDataGridViewTextBoxColumn";
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            // 
            // planowanyTerminOdbioruDataGridViewTextBoxColumn
            // 
            this.planowanyTerminOdbioruDataGridViewTextBoxColumn.DataPropertyName = "planowanyTerminOdbioru";
            this.planowanyTerminOdbioruDataGridViewTextBoxColumn.HeaderText = "planowanyTerminOdbioru";
            this.planowanyTerminOdbioruDataGridViewTextBoxColumn.Name = "planowanyTerminOdbioruDataGridViewTextBoxColumn";
            // 
            // idUwagiDataGridViewTextBoxColumn
            // 
            this.idUwagiDataGridViewTextBoxColumn.DataPropertyName = "idUwagi";
            this.idUwagiDataGridViewTextBoxColumn.HeaderText = "idUwagi";
            this.idUwagiDataGridViewTextBoxColumn.Name = "idUwagiDataGridViewTextBoxColumn";
            // 
            // odbiorZMagazynuDataGridViewTextBoxColumn
            // 
            this.odbiorZMagazynuDataGridViewTextBoxColumn.DataPropertyName = "odbiorZMagazynu";
            this.odbiorZMagazynuDataGridViewTextBoxColumn.HeaderText = "odbiorZMagazynu";
            this.odbiorZMagazynuDataGridViewTextBoxColumn.Name = "odbiorZMagazynuDataGridViewTextBoxColumn";
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "Zamowienia";
            this.zamowieniaBindingSource.DataSource = this.zWMDataSet;
            // 
            // zWMDataSet
            // 
            this.zWMDataSet.DataSetName = "ZWMDataSet";
            this.zWMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Comments_tb);
            this.groupBox3.Location = new System.Drawing.Point(12, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uwagi";
            // 
            // Comments_tb
            // 
            this.Comments_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comments_tb.Location = new System.Drawing.Point(3, 18);
            this.Comments_tb.Multiline = true;
            this.Comments_tb.Name = "Comments_tb";
            this.Comments_tb.Size = new System.Drawing.Size(628, 101);
            this.Comments_tb.TabIndex = 0;
            // 
            // BackToTheFirstForm_btn
            // 
            this.BackToTheFirstForm_btn.Location = new System.Drawing.Point(12, 650);
            this.BackToTheFirstForm_btn.Name = "BackToTheFirstForm_btn";
            this.BackToTheFirstForm_btn.Size = new System.Drawing.Size(100, 25);
            this.BackToTheFirstForm_btn.TabIndex = 0;
            this.BackToTheFirstForm_btn.Text = "Cofnij";
            this.BackToTheFirstForm_btn.UseVisualStyleBackColor = true;
            // 
            // ManualAdditionZWM_btn
            // 
            this.ManualAdditionZWM_btn.Location = new System.Drawing.Point(438, 640);
            this.ManualAdditionZWM_btn.Name = "ManualAdditionZWM_btn";
            this.ManualAdditionZWM_btn.Size = new System.Drawing.Size(100, 25);
            this.ManualAdditionZWM_btn.TabIndex = 1;
            this.ManualAdditionZWM_btn.Text = "Dodaj";
            this.ManualAdditionZWM_btn.UseVisualStyleBackColor = true;
            // 
            // ClouseProgram_btn
            // 
            this.ClouseProgram_btn.Location = new System.Drawing.Point(543, 640);
            this.ClouseProgram_btn.Name = "ClouseProgram_btn";
            this.ClouseProgram_btn.Size = new System.Drawing.Size(100, 25);
            this.ClouseProgram_btn.TabIndex = 2;
            this.ClouseProgram_btn.Text = "Zamknij";
            this.ClouseProgram_btn.UseVisualStyleBackColor = true;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // ManualAdditionZWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 687);
            this.Controls.Add(this.ClouseProgram_btn);
            this.Controls.Add(this.ManualAdditionZWM_btn);
            this.Controls.Add(this.BackToTheFirstForm_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManualAdditionZWM";
            this.Text = "ManualAdditionZWM";
            this.Load += new System.EventHandler(this.ManualAdditionZWM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Materials_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateOfReceipt_dtp;
        private System.Windows.Forms.ComboBox Kilometer_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ContractNumber_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Name_cb;
        private System.Windows.Forms.ComboBox Surname_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Materials_dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Comments_tb;
        private System.Windows.Forms.Button BackToTheFirstForm_btn;
        private System.Windows.Forms.Button ManualAdditionZWM_btn;
        private System.Windows.Forms.Button ClouseProgram_btn;
        private ZWMDataSet zWMDataSet;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private ZWMDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKierownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkontraktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planowanyTerminOdbioruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUwagiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odbiorZMagazynuDataGridViewTextBoxColumn;
    }
}