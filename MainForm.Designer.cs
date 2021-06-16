namespace OphthalmologyClinic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelTypeAcc = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonExportAndImport = new System.Windows.Forms.Button();
            this.ButtonChangeDelete = new System.Windows.Forms.Button();
            this.ButtonReports = new System.Windows.Forms.Button();
            this.ButtonAppointment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.ButtonAdd);
            this.panel1.Controls.Add(this.ButtonExportAndImport);
            this.panel1.Controls.Add(this.ButtonChangeDelete);
            this.panel1.Controls.Add(this.ButtonReports);
            this.panel1.Controls.Add(this.ButtonAppointment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 477);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LabelTypeAcc);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 55);
            this.panel2.TabIndex = 14;
            // 
            // LabelTypeAcc
            // 
            this.LabelTypeAcc.AutoSize = true;
            this.LabelTypeAcc.Location = new System.Drawing.Point(21, 17);
            this.LabelTypeAcc.Name = "LabelTypeAcc";
            this.LabelTypeAcc.Size = new System.Drawing.Size(238, 20);
            this.LabelTypeAcc.TabIndex = 2;
            this.LabelTypeAcc.Text = "Вы авторизовались как Admin";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(13, 401);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(252, 56);
            this.ButtonBack.TabIndex = 13;
            this.ButtonBack.Text = "Авторизация";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(13, 71);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(252, 56);
            this.ButtonAdd.TabIndex = 8;
            this.ButtonAdd.Text = "Добавление информации";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonExportAndImport
            // 
            this.ButtonExportAndImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExportAndImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExportAndImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExportAndImport.Location = new System.Drawing.Point(13, 335);
            this.ButtonExportAndImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonExportAndImport.Name = "ButtonExportAndImport";
            this.ButtonExportAndImport.Size = new System.Drawing.Size(252, 56);
            this.ButtonExportAndImport.TabIndex = 12;
            this.ButtonExportAndImport.Text = "Экспорт\\восстановления данных БД";
            this.ButtonExportAndImport.UseVisualStyleBackColor = true;
            this.ButtonExportAndImport.Click += new System.EventHandler(this.ButtonExportAndImport_Click);
            // 
            // ButtonChangeDelete
            // 
            this.ButtonChangeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChangeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChangeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChangeDelete.Location = new System.Drawing.Point(13, 137);
            this.ButtonChangeDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonChangeDelete.Name = "ButtonChangeDelete";
            this.ButtonChangeDelete.Size = new System.Drawing.Size(252, 56);
            this.ButtonChangeDelete.TabIndex = 9;
            this.ButtonChangeDelete.Text = "Редактирование и удаление информации";
            this.ButtonChangeDelete.UseVisualStyleBackColor = true;
            this.ButtonChangeDelete.Click += new System.EventHandler(this.ButtonChangeDelete_Click);
            // 
            // ButtonReports
            // 
            this.ButtonReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReports.Location = new System.Drawing.Point(13, 269);
            this.ButtonReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonReports.Name = "ButtonReports";
            this.ButtonReports.Size = new System.Drawing.Size(252, 56);
            this.ButtonReports.TabIndex = 11;
            this.ButtonReports.Text = "Формирование отчетов";
            this.ButtonReports.UseVisualStyleBackColor = true;
            this.ButtonReports.Click += new System.EventHandler(this.ButtonReports_Click);
            // 
            // ButtonAppointment
            // 
            this.ButtonAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAppointment.Location = new System.Drawing.Point(13, 203);
            this.ButtonAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAppointment.Name = "ButtonAppointment";
            this.ButtonAppointment.Size = new System.Drawing.Size(252, 56);
            this.ButtonAppointment.TabIndex = 10;
            this.ButtonAppointment.Text = "Запись на приём";
            this.ButtonAppointment.UseVisualStyleBackColor = true;
            this.ButtonAppointment.Click += new System.EventHandler(this.ButtonAppointment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 477);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(294, 516);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(294, 516);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Офтальмологическая клиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTypeAcc;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonExportAndImport;
        private System.Windows.Forms.Button ButtonChangeDelete;
        private System.Windows.Forms.Button ButtonReports;
        private System.Windows.Forms.Button ButtonAppointment;

    }
}