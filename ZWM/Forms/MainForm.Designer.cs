namespace ZWM.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToFormManualAdditionZWM_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.AddExcelFileZWM__tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseProgram_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMe_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_tmsi = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Main_gb = new System.Windows.Forms.GroupBox();
            this.SaveDocuments_l = new System.Windows.Forms.Label();
            this.AddWZFormToBase_l = new System.Windows.Forms.Label();
            this.AddZWMToBase_l = new System.Windows.Forms.Label();
            this.ReadZWMForm_l = new System.Windows.Forms.Label();
            this.CheckFolders_l = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressAddingDocuments_pb = new System.Windows.Forms.ProgressBar();
            this.PrintLastAddedDocumentsZWMandWZ_btn = new System.Windows.Forms.Button();
            this.AddExcelFileZWM_btn = new System.Windows.Forms.Button();
            this.GoToFormManualAdditionZWM_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ZWM_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WZ_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ListZWM_dgv = new System.Windows.Forms.DataGridView();
            this.idZamowienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uwagi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminOdbioru = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CloseProgram_btn = new System.Windows.Forms.Button();
            this.zWMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowieniaTableAdapter = new ZWM.ZWMDataSetTableAdapters.ZamowieniaTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zWMDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zWMDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Main_gb.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZWM_dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WZ_dgv)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListZWM_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.Help_tmsi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoToFormManualAdditionZWM_tsmi,
            this.AddExcelFileZWM__tsmi,
            this.toolStripMenuItem1,
            this.CloseProgram_tsmi});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // GoToFormManualAdditionZWM_tsmi
            // 
            this.GoToFormManualAdditionZWM_tsmi.Name = "GoToFormManualAdditionZWM_tsmi";
            this.GoToFormManualAdditionZWM_tsmi.Size = new System.Drawing.Size(156, 26);
            this.GoToFormManualAdditionZWM_tsmi.Text = "Wprowadź";
            // 
            // AddExcelFileZWM__tsmi
            // 
            this.AddExcelFileZWM__tsmi.Name = "AddExcelFileZWM__tsmi";
            this.AddExcelFileZWM__tsmi.Size = new System.Drawing.Size(156, 26);
            this.AddExcelFileZWM__tsmi.Text = "Dodaj";
            this.AddExcelFileZWM__tsmi.Click += new System.EventHandler(this.doToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // CloseProgram_tsmi
            // 
            this.CloseProgram_tsmi.Name = "CloseProgram_tsmi";
            this.CloseProgram_tsmi.Size = new System.Drawing.Size(156, 26);
            this.CloseProgram_tsmi.Text = "Zamknij";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMe_tsmi});
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // AboutMe_tsmi
            // 
            this.AboutMe_tsmi.Name = "AboutMe_tsmi";
            this.AboutMe_tsmi.Size = new System.Drawing.Size(132, 26);
            this.AboutMe_tsmi.Text = "O mnie";
            // 
            // Help_tmsi
            // 
            this.Help_tmsi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem1});
            this.Help_tmsi.Name = "Help_tmsi";
            this.Help_tmsi.Size = new System.Drawing.Size(67, 24);
            this.Help_tmsi.Text = "Pomoc";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(130, 26);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Controls.Add(this.CloseProgram_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 505);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 374);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Main_gb);
            this.tabPage1.Controls.Add(this.PrintLastAddedDocumentsZWMandWZ_btn);
            this.tabPage1.Controls.Add(this.AddExcelFileZWM_btn);
            this.tabPage1.Controls.Add(this.GoToFormManualAdditionZWM_btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Główne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Main_gb
            // 
            this.Main_gb.Controls.Add(this.SaveDocuments_l);
            this.Main_gb.Controls.Add(this.AddWZFormToBase_l);
            this.Main_gb.Controls.Add(this.AddZWMToBase_l);
            this.Main_gb.Controls.Add(this.ReadZWMForm_l);
            this.Main_gb.Controls.Add(this.CheckFolders_l);
            this.Main_gb.Controls.Add(this.label5);
            this.Main_gb.Controls.Add(this.label4);
            this.Main_gb.Controls.Add(this.label3);
            this.Main_gb.Controls.Add(this.label2);
            this.Main_gb.Controls.Add(this.label1);
            this.Main_gb.Controls.Add(this.ProgressAddingDocuments_pb);
            this.Main_gb.Location = new System.Drawing.Point(111, 7);
            this.Main_gb.Name = "Main_gb";
            this.Main_gb.Size = new System.Drawing.Size(660, 332);
            this.Main_gb.TabIndex = 3;
            this.Main_gb.TabStop = false;
            this.Main_gb.Text = "Szczegóły";
            // 
            // SaveDocuments_l
            // 
            this.SaveDocuments_l.AutoSize = true;
            this.SaveDocuments_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveDocuments_l.Location = new System.Drawing.Point(189, 138);
            this.SaveDocuments_l.Name = "SaveDocuments_l";
            this.SaveDocuments_l.Size = new System.Drawing.Size(0, 20);
            this.SaveDocuments_l.TabIndex = 10;
            // 
            // AddWZFormToBase_l
            // 
            this.AddWZFormToBase_l.AutoSize = true;
            this.AddWZFormToBase_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddWZFormToBase_l.Location = new System.Drawing.Point(189, 109);
            this.AddWZFormToBase_l.Name = "AddWZFormToBase_l";
            this.AddWZFormToBase_l.Size = new System.Drawing.Size(0, 20);
            this.AddWZFormToBase_l.TabIndex = 9;
            // 
            // AddZWMToBase_l
            // 
            this.AddZWMToBase_l.AutoSize = true;
            this.AddZWMToBase_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddZWMToBase_l.Location = new System.Drawing.Point(189, 82);
            this.AddZWMToBase_l.Name = "AddZWMToBase_l";
            this.AddZWMToBase_l.Size = new System.Drawing.Size(0, 20);
            this.AddZWMToBase_l.TabIndex = 8;
            // 
            // ReadZWMForm_l
            // 
            this.ReadZWMForm_l.AutoSize = true;
            this.ReadZWMForm_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReadZWMForm_l.Location = new System.Drawing.Point(189, 52);
            this.ReadZWMForm_l.Name = "ReadZWMForm_l";
            this.ReadZWMForm_l.Size = new System.Drawing.Size(0, 20);
            this.ReadZWMForm_l.TabIndex = 7;
            // 
            // CheckFolders_l
            // 
            this.CheckFolders_l.AutoSize = true;
            this.CheckFolders_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckFolders_l.Location = new System.Drawing.Point(189, 23);
            this.CheckFolders_l.Name = "CheckFolders_l";
            this.CheckFolders_l.Size = new System.Drawing.Size(0, 20);
            this.CheckFolders_l.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zapis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dodanie WZ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dodanie ZWM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wczytanie formularza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprawdzenie folderów:";
            // 
            // ProgressAddingDocuments_pb
            // 
            this.ProgressAddingDocuments_pb.Location = new System.Drawing.Point(7, 161);
            this.ProgressAddingDocuments_pb.Name = "ProgressAddingDocuments_pb";
            this.ProgressAddingDocuments_pb.Size = new System.Drawing.Size(225, 23);
            this.ProgressAddingDocuments_pb.TabIndex = 0;
            // 
            // PrintLastAddedDocumentsZWMandWZ_btn
            // 
            this.PrintLastAddedDocumentsZWMandWZ_btn.Location = new System.Drawing.Point(5, 89);
            this.PrintLastAddedDocumentsZWMandWZ_btn.Name = "PrintLastAddedDocumentsZWMandWZ_btn";
            this.PrintLastAddedDocumentsZWMandWZ_btn.Size = new System.Drawing.Size(100, 25);
            this.PrintLastAddedDocumentsZWMandWZ_btn.TabIndex = 2;
            this.PrintLastAddedDocumentsZWMandWZ_btn.Text = "Drukuj";
            this.PrintLastAddedDocumentsZWMandWZ_btn.UseVisualStyleBackColor = true;
            this.PrintLastAddedDocumentsZWMandWZ_btn.Click += new System.EventHandler(this.PrintLastAddedDocumentsZWMandWZ_btn_Click);
            // 
            // AddExcelFileZWM_btn
            // 
            this.AddExcelFileZWM_btn.Location = new System.Drawing.Point(5, 59);
            this.AddExcelFileZWM_btn.Name = "AddExcelFileZWM_btn";
            this.AddExcelFileZWM_btn.Size = new System.Drawing.Size(100, 25);
            this.AddExcelFileZWM_btn.TabIndex = 1;
            this.AddExcelFileZWM_btn.Text = "Dodaj";
            this.AddExcelFileZWM_btn.UseVisualStyleBackColor = true;
            this.AddExcelFileZWM_btn.Click += new System.EventHandler(this.AddExcelFileZWM_btn_Click);
            // 
            // GoToFormManualAdditionZWM_btn
            // 
            this.GoToFormManualAdditionZWM_btn.Location = new System.Drawing.Point(5, 29);
            this.GoToFormManualAdditionZWM_btn.Name = "GoToFormManualAdditionZWM_btn";
            this.GoToFormManualAdditionZWM_btn.Size = new System.Drawing.Size(100, 25);
            this.GoToFormManualAdditionZWM_btn.TabIndex = 0;
            this.GoToFormManualAdditionZWM_btn.Text = "Wprowadź";
            this.GoToFormManualAdditionZWM_btn.UseVisualStyleBackColor = true;
            this.GoToFormManualAdditionZWM_btn.Click += new System.EventHandler(this.GoToFormManualAdditionZWM_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ZWM_dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ZWM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ZWM_dgv
            // 
            this.ZWM_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZWM_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZWM_dgv.Location = new System.Drawing.Point(3, 3);
            this.ZWM_dgv.Name = "ZWM_dgv";
            this.ZWM_dgv.RowTemplate.Height = 24;
            this.ZWM_dgv.Size = new System.Drawing.Size(771, 339);
            this.ZWM_dgv.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WZ_dgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(777, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "WZ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WZ_dgv
            // 
            this.WZ_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WZ_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WZ_dgv.Location = new System.Drawing.Point(0, 0);
            this.WZ_dgv.Name = "WZ_dgv";
            this.WZ_dgv.RowTemplate.Height = 24;
            this.WZ_dgv.Size = new System.Drawing.Size(777, 345);
            this.WZ_dgv.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ListZWM_dgv);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(777, 345);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lista";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ListZWM_dgv
            // 
            this.ListZWM_dgv.AllowUserToOrderColumns = true;
            this.ListZWM_dgv.AutoGenerateColumns = false;
            this.ListZWM_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListZWM_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZamowienia,
            this.name,
            this.Surname,
            this.Kontract,
            this.Kilometer,
            this.MaterialName,
            this.MaterialType,
            this.jm,
            this.ilosc,
            this.Uwagi,
            this.TerminOdbioru,
            this.idZamowieniaDataGridViewTextBoxColumn,
            this.idKierownikaDataGridViewTextBoxColumn,
            this.idkontraktuDataGridViewTextBoxColumn,
            this.idMaterialuDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.planowanyTerminOdbioruDataGridViewTextBoxColumn,
            this.idUwagiDataGridViewTextBoxColumn,
            this.odbiorZMagazynuDataGridViewTextBoxColumn});
            this.ListZWM_dgv.DataSource = this.zamowieniaBindingSource;
            this.ListZWM_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListZWM_dgv.Location = new System.Drawing.Point(0, 0);
            this.ListZWM_dgv.Name = "ListZWM_dgv";
            this.ListZWM_dgv.RowTemplate.Height = 24;
            this.ListZWM_dgv.Size = new System.Drawing.Size(777, 345);
            this.ListZWM_dgv.TabIndex = 0;
            // 
            // idZamowienia
            // 
            this.idZamowienia.DataPropertyName = "idZamowienia";
            this.idZamowienia.HeaderText = "idZamowienia";
            this.idZamowienia.Name = "idZamowienia";
            this.idZamowienia.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Imie";
            this.name.Name = "name";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Nazwisko";
            this.Surname.Name = "Surname";
            // 
            // Kontract
            // 
            this.Kontract.HeaderText = "Kontrakt";
            this.Kontract.Name = "Kontract";
            // 
            // Kilometer
            // 
            this.Kilometer.HeaderText = "Kilometr";
            this.Kilometer.Name = "Kilometer";
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "idZamowienia";
            this.MaterialName.HeaderText = "Nazwa Materiału";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // MaterialType
            // 
            this.MaterialType.DataPropertyName = "idZamowienia";
            this.MaterialType.HeaderText = "Typ Materiału";
            this.MaterialType.Name = "MaterialType";
            this.MaterialType.ReadOnly = true;
            // 
            // jm
            // 
            this.jm.DataPropertyName = "idZamowienia";
            this.jm.HeaderText = "J.M.";
            this.jm.Name = "jm";
            this.jm.ReadOnly = true;
            // 
            // ilosc
            // 
            this.ilosc.DataPropertyName = "idZamowienia";
            this.ilosc.HeaderText = "Ilość";
            this.ilosc.Name = "ilosc";
            this.ilosc.ReadOnly = true;
            // 
            // Uwagi
            // 
            this.Uwagi.DataPropertyName = "idZamowienia";
            this.Uwagi.HeaderText = "Uwagi do zamówienia";
            this.Uwagi.Name = "Uwagi";
            this.Uwagi.ReadOnly = true;
            // 
            // TerminOdbioru
            // 
            this.TerminOdbioru.DataPropertyName = "idZamowienia";
            this.TerminOdbioru.HeaderText = "Termin odbioru ";
            this.TerminOdbioru.Name = "TerminOdbioru";
            this.TerminOdbioru.ReadOnly = true;
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
            // CloseProgram_btn
            // 
            this.CloseProgram_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseProgram_btn.Location = new System.Drawing.Point(3, 383);
            this.CloseProgram_btn.Name = "CloseProgram_btn";
            this.CloseProgram_btn.Size = new System.Drawing.Size(100, 25);
            this.CloseProgram_btn.TabIndex = 0;
            this.CloseProgram_btn.Text = "Zamknij";
            this.CloseProgram_btn.UseVisualStyleBackColor = true;
            this.CloseProgram_btn.Click += new System.EventHandler(this.CloseProgram_btn_Click);
            // 
            // zWMDataSetBindingSource
            // 
            this.zWMDataSetBindingSource.DataSource = this.zWMDataSet;
            this.zWMDataSetBindingSource.Position = 0;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // zWMDataSetBindingSource1
            // 
            this.zWMDataSetBindingSource1.DataSource = this.zWMDataSet;
            this.zWMDataSetBindingSource1.Position = 0;
            // 
            // zWMDataSetBindingSource2
            // 
            this.zWMDataSetBindingSource2.DataSource = this.zWMDataSet;
            this.zWMDataSetBindingSource2.Position = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Zamówienie wydania materiałów";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Main_gb.ResumeLayout(false);
            this.Main_gb.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZWM_dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WZ_dgv)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListZWM_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zWMDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_tmsi;
        private System.Windows.Forms.ToolStripMenuItem GoToFormManualAdditionZWM_tsmi;
        private System.Windows.Forms.ToolStripMenuItem AboutMe_tsmi;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CloseProgram_btn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ZWMDataSet zWMDataSet;
        private System.Windows.Forms.BindingSource zWMDataSetBindingSource;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private ZWMDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.DataGridView ZWM_dgv;
        private System.Windows.Forms.DataGridView WZ_dgv;
        private System.Windows.Forms.DataGridView ListZWM_dgv;
        private System.Windows.Forms.GroupBox Main_gb;
        private System.Windows.Forms.Button PrintLastAddedDocumentsZWMandWZ_btn;
        private System.Windows.Forms.Button AddExcelFileZWM_btn;
        private System.Windows.Forms.Button GoToFormManualAdditionZWM_btn;
        private System.Windows.Forms.Label SaveDocuments_l;
        private System.Windows.Forms.Label AddWZFormToBase_l;
        private System.Windows.Forms.Label AddZWMToBase_l;
        private System.Windows.Forms.Label ReadZWMForm_l;
        private System.Windows.Forms.Label CheckFolders_l;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProgressAddingDocuments_pb;
        private System.Windows.Forms.ToolStripMenuItem AddExcelFileZWM__tsmi;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CloseProgram_tsmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamowienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontract;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn jm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uwagi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminOdbioru;
        private System.Windows.Forms.BindingSource zWMDataSetBindingSource1;
        private System.Windows.Forms.BindingSource zWMDataSetBindingSource2;
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