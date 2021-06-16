namespace OphthalmologyClinic
{
    partial class ChangeDelInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDelInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelCountRows = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabClients = new System.Windows.Forms.TabPage();
            this.DGVClients = new System.Windows.Forms.DataGridView();
            this.LabelSelectedClientID = new System.Windows.Forms.Label();
            this.ButtonDeleteClientRow = new System.Windows.Forms.Button();
            this.ButtonUpdateClientRow = new System.Windows.Forms.Button();
            this.TabWorkers = new System.Windows.Forms.TabPage();
            this.LabelSelectedWorkerID = new System.Windows.Forms.Label();
            this.ButtonDeleteWorkerRow = new System.Windows.Forms.Button();
            this.ButtonUpdateWorkerRow = new System.Windows.Forms.Button();
            this.DGVWorkers = new System.Windows.Forms.DataGridView();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.TextBoxSearchClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSearchEmployee = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.LabelCountRows);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 511);
            this.panel1.TabIndex = 0;
            // 
            // LabelCountRows
            // 
            this.LabelCountRows.AutoSize = true;
            this.LabelCountRows.Location = new System.Drawing.Point(118, 17);
            this.LabelCountRows.Name = "LabelCountRows";
            this.LabelCountRows.Size = new System.Drawing.Size(173, 20);
            this.LabelCountRows.TabIndex = 4;
            this.LabelCountRows.Text = "Количество записей: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabClients);
            this.tabControl1.Controls.Add(this.TabWorkers);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 451);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabClients
            // 
            this.TabClients.BackColor = System.Drawing.SystemColors.Control;
            this.TabClients.Controls.Add(this.label1);
            this.TabClients.Controls.Add(this.DGVClients);
            this.TabClients.Controls.Add(this.TextBoxSearchClient);
            this.TabClients.Controls.Add(this.LabelSelectedClientID);
            this.TabClients.Controls.Add(this.ButtonDeleteClientRow);
            this.TabClients.Controls.Add(this.ButtonUpdateClientRow);
            this.TabClients.Location = new System.Drawing.Point(4, 29);
            this.TabClients.Name = "TabClients";
            this.TabClients.Padding = new System.Windows.Forms.Padding(3);
            this.TabClients.Size = new System.Drawing.Size(1244, 418);
            this.TabClients.TabIndex = 0;
            this.TabClients.Text = "Клиенты";
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
            this.DGVClients.Size = new System.Drawing.Size(1232, 356);
            this.DGVClients.TabIndex = 6;
            this.DGVClients.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVClients_RowHeaderMouseDoubleClick);
            // 
            // LabelSelectedClientID
            // 
            this.LabelSelectedClientID.AutoSize = true;
            this.LabelSelectedClientID.Location = new System.Drawing.Point(6, 381);
            this.LabelSelectedClientID.Name = "LabelSelectedClientID";
            this.LabelSelectedClientID.Size = new System.Drawing.Size(167, 20);
            this.LabelSelectedClientID.TabIndex = 5;
            this.LabelSelectedClientID.Text = "Выбранная запись:  -";
            // 
            // ButtonDeleteClientRow
            // 
            this.ButtonDeleteClientRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonDeleteClientRow.Location = new System.Drawing.Point(1091, 371);
            this.ButtonDeleteClientRow.Name = "ButtonDeleteClientRow";
            this.ButtonDeleteClientRow.Size = new System.Drawing.Size(147, 41);
            this.ButtonDeleteClientRow.TabIndex = 4;
            this.ButtonDeleteClientRow.Text = "Удалить запись";
            this.ButtonDeleteClientRow.UseVisualStyleBackColor = true;
            this.ButtonDeleteClientRow.Click += new System.EventHandler(this.ButtonDeleteClientRow_Click);
            // 
            // ButtonUpdateClientRow
            // 
            this.ButtonUpdateClientRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonUpdateClientRow.Location = new System.Drawing.Point(930, 371);
            this.ButtonUpdateClientRow.Name = "ButtonUpdateClientRow";
            this.ButtonUpdateClientRow.Size = new System.Drawing.Size(155, 41);
            this.ButtonUpdateClientRow.TabIndex = 3;
            this.ButtonUpdateClientRow.Text = "Изменить запись";
            this.ButtonUpdateClientRow.UseVisualStyleBackColor = true;
            this.ButtonUpdateClientRow.Click += new System.EventHandler(this.ButtonUpdateClientRow_Click);
            // 
            // TabWorkers
            // 
            this.TabWorkers.BackColor = System.Drawing.SystemColors.Control;
            this.TabWorkers.Controls.Add(this.label2);
            this.TabWorkers.Controls.Add(this.TextBoxSearchEmployee);
            this.TabWorkers.Controls.Add(this.LabelSelectedWorkerID);
            this.TabWorkers.Controls.Add(this.ButtonDeleteWorkerRow);
            this.TabWorkers.Controls.Add(this.ButtonUpdateWorkerRow);
            this.TabWorkers.Controls.Add(this.DGVWorkers);
            this.TabWorkers.Location = new System.Drawing.Point(4, 29);
            this.TabWorkers.Name = "TabWorkers";
            this.TabWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.TabWorkers.Size = new System.Drawing.Size(1244, 418);
            this.TabWorkers.TabIndex = 1;
            this.TabWorkers.Text = "Сотрудники";
            // 
            // LabelSelectedWorkerID
            // 
            this.LabelSelectedWorkerID.AutoSize = true;
            this.LabelSelectedWorkerID.Location = new System.Drawing.Point(6, 381);
            this.LabelSelectedWorkerID.Name = "LabelSelectedWorkerID";
            this.LabelSelectedWorkerID.Size = new System.Drawing.Size(167, 20);
            this.LabelSelectedWorkerID.TabIndex = 8;
            this.LabelSelectedWorkerID.Text = "Выбранная запись:  -";
            // 
            // ButtonDeleteWorkerRow
            // 
            this.ButtonDeleteWorkerRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonDeleteWorkerRow.Location = new System.Drawing.Point(1091, 371);
            this.ButtonDeleteWorkerRow.Name = "ButtonDeleteWorkerRow";
            this.ButtonDeleteWorkerRow.Size = new System.Drawing.Size(147, 41);
            this.ButtonDeleteWorkerRow.TabIndex = 7;
            this.ButtonDeleteWorkerRow.Text = "Удалить запись";
            this.ButtonDeleteWorkerRow.UseVisualStyleBackColor = true;
            this.ButtonDeleteWorkerRow.Click += new System.EventHandler(this.ButtonDeleteWorkerRow_Click);
            // 
            // ButtonUpdateWorkerRow
            // 
            this.ButtonUpdateWorkerRow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonUpdateWorkerRow.Location = new System.Drawing.Point(930, 371);
            this.ButtonUpdateWorkerRow.Name = "ButtonUpdateWorkerRow";
            this.ButtonUpdateWorkerRow.Size = new System.Drawing.Size(155, 41);
            this.ButtonUpdateWorkerRow.TabIndex = 6;
            this.ButtonUpdateWorkerRow.Text = "Изменить запись";
            this.ButtonUpdateWorkerRow.UseVisualStyleBackColor = true;
            this.ButtonUpdateWorkerRow.Click += new System.EventHandler(this.ButtonUpdateWorkerRow_Click);
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
            this.DGVWorkers.Size = new System.Drawing.Size(1232, 356);
            this.DGVWorkers.TabIndex = 1;
            this.DGVWorkers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVWorkers_RowHeaderMouseDoubleClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 30);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // TextBoxSearchClient
            // 
            this.TextBoxSearchClient.Location = new System.Drawing.Point(689, 378);
            this.TextBoxSearchClient.Name = "TextBoxSearchClient";
            this.TextBoxSearchClient.Size = new System.Drawing.Size(235, 26);
            this.TextBoxSearchClient.TabIndex = 5;
            this.TextBoxSearchClient.TextChanged += new System.EventHandler(this.TextBoxSearchClient_TextChanged);
            this.TextBoxSearchClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchClient_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск по фамилии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по фамилии:";
            // 
            // TextBoxSearchEmployee
            // 
            this.TextBoxSearchEmployee.Location = new System.Drawing.Point(689, 378);
            this.TextBoxSearchEmployee.Name = "TextBoxSearchEmployee";
            this.TextBoxSearchEmployee.Size = new System.Drawing.Size(235, 26);
            this.TextBoxSearchEmployee.TabIndex = 9;
            this.TextBoxSearchEmployee.TextChanged += new System.EventHandler(this.TextBoxSearchEmployee_TextChanged);
            this.TextBoxSearchEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchEmployee_KeyPress);
            // 
            // ChangeDelInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 511);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1292, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1292, 550);
            this.Name = "ChangeDelInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Офтальмологическая клиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeDelInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.ChangeDelInfoForm_Load);
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
        private System.Windows.Forms.Label LabelCountRows;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabClients;
        private System.Windows.Forms.Label LabelSelectedClientID;
        private System.Windows.Forms.Button ButtonDeleteClientRow;
        private System.Windows.Forms.Button ButtonUpdateClientRow;
        private System.Windows.Forms.TabPage TabWorkers;
        private System.Windows.Forms.DataGridView DGVWorkers;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.DataGridView DGVClients;
        private System.Windows.Forms.Label LabelSelectedWorkerID;
        private System.Windows.Forms.Button ButtonDeleteWorkerRow;
        private System.Windows.Forms.Button ButtonUpdateWorkerRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSearchClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSearchEmployee;

    }
}