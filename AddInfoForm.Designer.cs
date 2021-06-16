namespace OphthalmologyClinic
{
    partial class AddInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelCountRows = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabClients = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPassportIssued = new System.Windows.Forms.TextBox();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.DGVClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxClientPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxClientPlaceResidence = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TextBoxClientPassport = new System.Windows.Forms.TextBox();
            this.TextBoxClientLastName = new System.Windows.Forms.TextBox();
            this.TextBoxClientSecondName = new System.Windows.Forms.TextBox();
            this.TextBoxClientFirstName = new System.Windows.Forms.TextBox();
            this.TabWorkers = new System.Windows.Forms.TabPage();
            this.DGVWorkers = new System.Windows.Forms.DataGridView();
            this.ButtonAddWorker = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxWorkerPost = new System.Windows.Forms.TextBox();
            this.TextBoxWorkerPlaceResidence = new System.Windows.Forms.TextBox();
            this.TextBoxWorkerPhone = new System.Windows.Forms.TextBox();
            this.TextBoxWorkerLastName = new System.Windows.Forms.TextBox();
            this.TextBoxWorkerSecondName = new System.Windows.Forms.TextBox();
            this.TextBoxWorkerFirstName = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClients)).BeginInit();
            this.TabWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TextBoxSearch);
            this.panel1.Controls.Add(this.LabelCountRows);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 619);
            this.panel1.TabIndex = 0;
            // 
            // LabelCountRows
            // 
            this.LabelCountRows.AutoSize = true;
            this.LabelCountRows.Location = new System.Drawing.Point(118, 17);
            this.LabelCountRows.Name = "LabelCountRows";
            this.LabelCountRows.Size = new System.Drawing.Size(0, 20);
            this.LabelCountRows.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabClients);
            this.tabControl1.Controls.Add(this.TabWorkers);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1373, 559);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabClients
            // 
            this.TabClients.BackColor = System.Drawing.SystemColors.Control;
            this.TabClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabClients.Controls.Add(this.label4);
            this.TabClients.Controls.Add(this.TextBoxPassportIssued);
            this.TabClients.Controls.Add(this.ButtonAddClient);
            this.TabClients.Controls.Add(this.DGVClients);
            this.TabClients.Controls.Add(this.label1);
            this.TabClients.Controls.Add(this.TextBoxClientPhone);
            this.TabClients.Controls.Add(this.label2);
            this.TabClients.Controls.Add(this.TextBoxClientPlaceResidence);
            this.TabClients.Controls.Add(this.label3);
            this.TabClients.Controls.Add(this.label6);
            this.TabClients.Controls.Add(this.label7);
            this.TabClients.Controls.Add(this.label16);
            this.TabClients.Controls.Add(this.TextBoxClientPassport);
            this.TabClients.Controls.Add(this.TextBoxClientLastName);
            this.TabClients.Controls.Add(this.TextBoxClientSecondName);
            this.TabClients.Controls.Add(this.TextBoxClientFirstName);
            this.TabClients.Location = new System.Drawing.Point(4, 29);
            this.TabClients.Name = "TabClients";
            this.TabClients.Padding = new System.Windows.Forms.Padding(3);
            this.TabClients.Size = new System.Drawing.Size(1365, 526);
            this.TabClients.TabIndex = 0;
            this.TabClients.Text = "Клиенты";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Кем паспорт выдан:";
            // 
            // TextBoxPassportIssued
            // 
            this.TextBoxPassportIssued.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPassportIssued.Location = new System.Drawing.Point(219, 481);
            this.TextBoxPassportIssued.Name = "TextBoxPassportIssued";
            this.TextBoxPassportIssued.Size = new System.Drawing.Size(752, 26);
            this.TextBoxPassportIssued.TabIndex = 41;
            this.TextBoxPassportIssued.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassportIssued_KeyPress);
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAddClient.Location = new System.Drawing.Point(1163, 481);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(191, 37);
            this.ButtonAddClient.TabIndex = 40;
            this.ButtonAddClient.Text = "Добавить клиента";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // DGVClients
            // 
            this.DGVClients.AllowUserToAddRows = false;
            this.DGVClients.AllowUserToDeleteRows = false;
            this.DGVClients.AllowUserToResizeColumns = false;
            this.DGVClients.AllowUserToResizeRows = false;
            this.DGVClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClients.Location = new System.Drawing.Point(6, 6);
            this.DGVClients.Name = "DGVClients";
            this.DGVClients.ReadOnly = true;
            this.DGVClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVClients.Size = new System.Drawing.Size(1348, 373);
            this.DGVClients.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Телефон:";
            // 
            // TextBoxClientPhone
            // 
            this.TextBoxClientPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxClientPhone.Location = new System.Drawing.Point(219, 449);
            this.TextBoxClientPhone.Name = "TextBoxClientPhone";
            this.TextBoxClientPhone.Size = new System.Drawing.Size(752, 26);
            this.TextBoxClientPhone.TabIndex = 34;
            this.TextBoxClientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressPhone);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Место жительства:";
            // 
            // TextBoxClientPlaceResidence
            // 
            this.TextBoxClientPlaceResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxClientPlaceResidence.Location = new System.Drawing.Point(219, 385);
            this.TextBoxClientPlaceResidence.Name = "TextBoxClientPlaceResidence";
            this.TextBoxClientPlaceResidence.Size = new System.Drawing.Size(752, 26);
            this.TextBoxClientPlaceResidence.TabIndex = 32;
            this.TextBoxClientPlaceResidence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressLive);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Серия и номер паспорта:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(977, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(977, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Отчество:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(977, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Фамилия:";
            // 
            // TextBoxClientPassport
            // 
            this.TextBoxClientPassport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxClientPassport.Location = new System.Drawing.Point(219, 417);
            this.TextBoxClientPassport.Name = "TextBoxClientPassport";
            this.TextBoxClientPassport.Size = new System.Drawing.Size(752, 26);
            this.TextBoxClientPassport.TabIndex = 25;
            this.TextBoxClientPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressPassport);
            // 
            // TextBoxClientLastName
            // 
            this.TextBoxClientLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxClientLastName.Location = new System.Drawing.Point(1072, 449);
            this.TextBoxClientLastName.Name = "TextBoxClientLastName";
            this.TextBoxClientLastName.Size = new System.Drawing.Size(282, 26);
            this.TextBoxClientLastName.TabIndex = 22;
            this.TextBoxClientLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFIO);
            // 
            // TextBoxClientSecondName
            // 
            this.TextBoxClientSecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxClientSecondName.Location = new System.Drawing.Point(1072, 417);
            this.TextBoxClientSecondName.Name = "TextBoxClientSecondName";
            this.TextBoxClientSecondName.Size = new System.Drawing.Size(282, 26);
            this.TextBoxClientSecondName.TabIndex = 21;
            this.TextBoxClientSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFIO);
            // 
            // TextBoxClientFirstName
            // 
            this.TextBoxClientFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxClientFirstName.Location = new System.Drawing.Point(1072, 385);
            this.TextBoxClientFirstName.Name = "TextBoxClientFirstName";
            this.TextBoxClientFirstName.Size = new System.Drawing.Size(282, 26);
            this.TextBoxClientFirstName.TabIndex = 20;
            this.TextBoxClientFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFIO);
            // 
            // TabWorkers
            // 
            this.TabWorkers.BackColor = System.Drawing.SystemColors.Control;
            this.TabWorkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabWorkers.Controls.Add(this.DGVWorkers);
            this.TabWorkers.Controls.Add(this.ButtonAddWorker);
            this.TabWorkers.Controls.Add(this.label14);
            this.TabWorkers.Controls.Add(this.label13);
            this.TabWorkers.Controls.Add(this.label12);
            this.TabWorkers.Controls.Add(this.label11);
            this.TabWorkers.Controls.Add(this.label10);
            this.TabWorkers.Controls.Add(this.label9);
            this.TabWorkers.Controls.Add(this.TextBoxWorkerPost);
            this.TabWorkers.Controls.Add(this.TextBoxWorkerPlaceResidence);
            this.TabWorkers.Controls.Add(this.TextBoxWorkerPhone);
            this.TabWorkers.Controls.Add(this.TextBoxWorkerLastName);
            this.TabWorkers.Controls.Add(this.TextBoxWorkerSecondName);
            this.TabWorkers.Controls.Add(this.TextBoxWorkerFirstName);
            this.TabWorkers.Location = new System.Drawing.Point(4, 29);
            this.TabWorkers.Name = "TabWorkers";
            this.TabWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.TabWorkers.Size = new System.Drawing.Size(1365, 526);
            this.TabWorkers.TabIndex = 1;
            this.TabWorkers.Text = "Сотрудники";
            // 
            // DGVWorkers
            // 
            this.DGVWorkers.AllowUserToAddRows = false;
            this.DGVWorkers.AllowUserToDeleteRows = false;
            this.DGVWorkers.AllowUserToResizeColumns = false;
            this.DGVWorkers.AllowUserToResizeRows = false;
            this.DGVWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVWorkers.Location = new System.Drawing.Point(6, 6);
            this.DGVWorkers.Name = "DGVWorkers";
            this.DGVWorkers.ReadOnly = true;
            this.DGVWorkers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVWorkers.Size = new System.Drawing.Size(1348, 373);
            this.DGVWorkers.TabIndex = 40;
            // 
            // ButtonAddWorker
            // 
            this.ButtonAddWorker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAddWorker.Location = new System.Drawing.Point(1163, 481);
            this.ButtonAddWorker.Name = "ButtonAddWorker";
            this.ButtonAddWorker.Size = new System.Drawing.Size(191, 37);
            this.ButtonAddWorker.TabIndex = 37;
            this.ButtonAddWorker.Text = "Добавить сотрудника";
            this.ButtonAddWorker.UseVisualStyleBackColor = true;
            this.ButtonAddWorker.Click += new System.EventHandler(this.ButtonAddWorker_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Должность:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Место жительства:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Телефон:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(935, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Имя:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(935, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Отчество:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(935, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Фамилия:";
            // 
            // TextBoxWorkerPost
            // 
            this.TextBoxWorkerPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxWorkerPost.Location = new System.Drawing.Point(177, 449);
            this.TextBoxWorkerPost.Name = "TextBoxWorkerPost";
            this.TextBoxWorkerPost.Size = new System.Drawing.Size(752, 26);
            this.TextBoxWorkerPost.TabIndex = 5;
            this.TextBoxWorkerPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressPost);
            // 
            // TextBoxWorkerPlaceResidence
            // 
            this.TextBoxWorkerPlaceResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxWorkerPlaceResidence.Location = new System.Drawing.Point(177, 385);
            this.TextBoxWorkerPlaceResidence.Name = "TextBoxWorkerPlaceResidence";
            this.TextBoxWorkerPlaceResidence.Size = new System.Drawing.Size(752, 26);
            this.TextBoxWorkerPlaceResidence.TabIndex = 4;
            this.TextBoxWorkerPlaceResidence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressLive);
            // 
            // TextBoxWorkerPhone
            // 
            this.TextBoxWorkerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxWorkerPhone.Location = new System.Drawing.Point(177, 417);
            this.TextBoxWorkerPhone.Name = "TextBoxWorkerPhone";
            this.TextBoxWorkerPhone.Size = new System.Drawing.Size(752, 26);
            this.TextBoxWorkerPhone.TabIndex = 3;
            this.TextBoxWorkerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressPhone);
            // 
            // TextBoxWorkerLastName
            // 
            this.TextBoxWorkerLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxWorkerLastName.Location = new System.Drawing.Point(1028, 449);
            this.TextBoxWorkerLastName.Name = "TextBoxWorkerLastName";
            this.TextBoxWorkerLastName.Size = new System.Drawing.Size(326, 26);
            this.TextBoxWorkerLastName.TabIndex = 2;
            this.TextBoxWorkerLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFIO);
            // 
            // TextBoxWorkerSecondName
            // 
            this.TextBoxWorkerSecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxWorkerSecondName.Location = new System.Drawing.Point(1028, 417);
            this.TextBoxWorkerSecondName.Name = "TextBoxWorkerSecondName";
            this.TextBoxWorkerSecondName.Size = new System.Drawing.Size(326, 26);
            this.TextBoxWorkerSecondName.TabIndex = 1;
            this.TextBoxWorkerSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFIO);
            // 
            // TextBoxWorkerFirstName
            // 
            this.TextBoxWorkerFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxWorkerFirstName.Location = new System.Drawing.Point(1028, 385);
            this.TextBoxWorkerFirstName.Name = "TextBoxWorkerFirstName";
            this.TextBoxWorkerFirstName.Size = new System.Drawing.Size(326, 26);
            this.TextBoxWorkerFirstName.TabIndex = 0;
            this.TextBoxWorkerFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFIO);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 30);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Поиск по фамилии в выбранной таблице:";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(1146, 14);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(235, 26);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.TextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            // 
            // AddInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 619);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1414, 658);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1414, 658);
            this.Name = "AddInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Офтальмологическая клиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.AddInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabClients.ResumeLayout(false);
            this.TabClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClients)).EndInit();
            this.TabWorkers.ResumeLayout(false);
            this.TabWorkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabClients;
        private System.Windows.Forms.TabPage TabWorkers;
        private System.Windows.Forms.TextBox TextBoxWorkerPost;
        private System.Windows.Forms.TextBox TextBoxWorkerPlaceResidence;
        private System.Windows.Forms.TextBox TextBoxWorkerPhone;
        private System.Windows.Forms.TextBox TextBoxWorkerLastName;
        private System.Windows.Forms.TextBox TextBoxWorkerSecondName;
        private System.Windows.Forms.TextBox TextBoxWorkerFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxClientPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxClientPlaceResidence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TextBoxClientPassport;
        private System.Windows.Forms.TextBox TextBoxClientLastName;
        private System.Windows.Forms.TextBox TextBoxClientSecondName;
        private System.Windows.Forms.TextBox TextBoxClientFirstName;
        private System.Windows.Forms.Button ButtonAddWorker;
        private System.Windows.Forms.DataGridView DGVClients;
        private System.Windows.Forms.Label LabelCountRows;
        private System.Windows.Forms.DataGridView DGVWorkers;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPassportIssued;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxSearch;
    }
}