namespace OphthalmologyClinic
{
    partial class ExportAndImportDBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportAndImportDBForm));
            this.ComboBoxObject = new System.Windows.Forms.ComboBox();
            this.ComboBoxRazdelitel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonExporting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.buttonImporting = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxObject
            // 
            this.ComboBoxObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxObject.FormattingEnabled = true;
            this.ComboBoxObject.Items.AddRange(new object[] {
            "Таблица клиентов",
            "Таблица сотрудников",
            "Таблица записей на приём",
            "Таблица услуг для детей",
            "Таблица услуг для взрослых",
            "Вся БД"});
            this.ComboBoxObject.Location = new System.Drawing.Point(161, 9);
            this.ComboBoxObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxObject.Name = "ComboBoxObject";
            this.ComboBoxObject.Size = new System.Drawing.Size(258, 28);
            this.ComboBoxObject.TabIndex = 0;
            // 
            // ComboBoxRazdelitel
            // 
            this.ComboBoxRazdelitel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRazdelitel.FormattingEnabled = true;
            this.ComboBoxRazdelitel.Items.AddRange(new object[] {
            ":",
            ";",
            "|",
            "/"});
            this.ComboBoxRazdelitel.Location = new System.Drawing.Point(161, 47);
            this.ComboBoxRazdelitel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxRazdelitel.Name = "ComboBoxRazdelitel";
            this.ComboBoxRazdelitel.Size = new System.Drawing.Size(78, 28);
            this.ComboBoxRazdelitel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Объект экспорта:";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 30);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 181);
            this.panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 124);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonExporting);
            this.tabPage1.Controls.Add(this.ComboBoxRazdelitel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ComboBoxObject);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 91);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Экспорт";
            // 
            // buttonExporting
            // 
            this.buttonExporting.Location = new System.Drawing.Point(245, 45);
            this.buttonExporting.Name = "buttonExporting";
            this.buttonExporting.Size = new System.Drawing.Size(174, 35);
            this.buttonExporting.TabIndex = 5;
            this.buttonExporting.Text = "Экспортировать";
            this.buttonExporting.UseVisualStyleBackColor = true;
            this.buttonExporting.Click += new System.EventHandler(this.buttonExporting_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Разделитель:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonSelectFile);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TextBoxPath);
            this.tabPage2.Controls.Add(this.buttonImporting);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 91);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Восстановление БД";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(62, 43);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(135, 37);
            this.buttonSelectFile.TabIndex = 7;
            this.buttonSelectFile.Text = "Выбрать файл";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Путь:";
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Enabled = false;
            this.TextBoxPath.Location = new System.Drawing.Point(62, 8);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.ReadOnly = true;
            this.TextBoxPath.Size = new System.Drawing.Size(358, 26);
            this.TextBoxPath.TabIndex = 5;
            // 
            // buttonImporting
            // 
            this.buttonImporting.Location = new System.Drawing.Point(274, 43);
            this.buttonImporting.Name = "buttonImporting";
            this.buttonImporting.Size = new System.Drawing.Size(146, 37);
            this.buttonImporting.TabIndex = 4;
            this.buttonImporting.Text = "Восстановить";
            this.buttonImporting.UseVisualStyleBackColor = true;
            this.buttonImporting.Click += new System.EventHandler(this.buttonImporting_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "sqlite files (*.sqlite)|*.sqlite";
            // 
            // ExportAndImportDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 181);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 220);
            this.Name = "ExportAndImportDBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Офтальмологическая клиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportAndImportDBForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxObject;
        private System.Windows.Forms.ComboBox ComboBoxRazdelitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExporting;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.Button buttonImporting;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}