namespace OphthalmologyClinic
{
    partial class FormationReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormationReportsForm));
            this.DGVAppointments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSelectedRow = new System.Windows.Forms.Label();
            this.CountRows = new System.Windows.Forms.Label();
            this.CreateDocuments = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVAppointments
            // 
            this.DGVAppointments.AllowUserToAddRows = false;
            this.DGVAppointments.AllowUserToDeleteRows = false;
            this.DGVAppointments.AllowUserToResizeColumns = false;
            this.DGVAppointments.AllowUserToResizeRows = false;
            this.DGVAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAppointments.Location = new System.Drawing.Point(13, 50);
            this.DGVAppointments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVAppointments.Name = "DGVAppointments";
            this.DGVAppointments.ReadOnly = true;
            this.DGVAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVAppointments.Size = new System.Drawing.Size(1389, 468);
            this.DGVAppointments.TabIndex = 0;
            this.DGVAppointments.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVAppointments_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelSelectedRow);
            this.panel1.Controls.Add(this.CountRows);
            this.panel1.Controls.Add(this.CreateDocuments);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.DGVAppointments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 574);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1013, 530);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск по дате:";
            // 
            // LabelSelectedRow
            // 
            this.LabelSelectedRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSelectedRow.AutoSize = true;
            this.LabelSelectedRow.Location = new System.Drawing.Point(12, 533);
            this.LabelSelectedRow.Name = "LabelSelectedRow";
            this.LabelSelectedRow.Size = new System.Drawing.Size(163, 20);
            this.LabelSelectedRow.TabIndex = 4;
            this.LabelSelectedRow.Text = "Выбранная запись: -";
            // 
            // CountRows
            // 
            this.CountRows.AutoSize = true;
            this.CountRows.Location = new System.Drawing.Point(118, 17);
            this.CountRows.Name = "CountRows";
            this.CountRows.Size = new System.Drawing.Size(0, 20);
            this.CountRows.TabIndex = 3;
            // 
            // CreateDocuments
            // 
            this.CreateDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDocuments.Location = new System.Drawing.Point(1172, 526);
            this.CreateDocuments.Name = "CreateDocuments";
            this.CreateDocuments.Size = new System.Drawing.Size(230, 34);
            this.CreateDocuments.TabIndex = 2;
            this.CreateDocuments.Text = "Распечатать документы";
            this.CreateDocuments.UseVisualStyleBackColor = true;
            this.CreateDocuments.Click += new System.EventHandler(this.CreateDocuments_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 30);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1139, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormationReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 574);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1428, 613);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1428, 613);
            this.Name = "FormationReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Офтальмологическая клиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormationReportsForm_FormClosing);
            this.Load += new System.EventHandler(this.FormationReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAppointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateDocuments;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelSelectedRow;
        private System.Windows.Forms.Label CountRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}