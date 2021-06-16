namespace OphthalmologyClinic
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxTime = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBoxClient = new System.Windows.Forms.ComboBox();
            this.ComboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAddApointment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountRows = new System.Windows.Forms.Label();
            this.DGVAppointments = new System.Windows.Forms.DataGridView();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ComboBoxTime);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.TextBoxPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ComboBoxClient);
            this.panel1.Controls.Add(this.ComboBoxEmployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonAddApointment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ComboBoxOperation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CountRows);
            this.panel1.Controls.Add(this.DGVAppointments);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 523);
            this.panel1.TabIndex = 0;
            // 
            // ComboBoxTime
            // 
            this.ComboBoxTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTime.Enabled = false;
            this.ComboBoxTime.FormattingEnabled = true;
            this.ComboBoxTime.Items.AddRange(new object[] {
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.ComboBoxTime.Location = new System.Drawing.Point(931, 411);
            this.ComboBoxTime.Name = "ComboBoxTime";
            this.ComboBoxTime.Size = new System.Drawing.Size(170, 28);
            this.ComboBoxTime.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(931, 379);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextBoxPrice.Enabled = false;
            this.TextBoxPrice.Location = new System.Drawing.Point(931, 445);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.ReadOnly = true;
            this.TextBoxPrice.Size = new System.Drawing.Size(170, 26);
            this.TextBoxPrice.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(863, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Цена:";
            // 
            // ComboBoxClient
            // 
            this.ComboBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClient.FormattingEnabled = true;
            this.ComboBoxClient.Location = new System.Drawing.Point(115, 379);
            this.ComboBoxClient.Name = "ComboBoxClient";
            this.ComboBoxClient.Size = new System.Drawing.Size(742, 28);
            this.ComboBoxClient.TabIndex = 16;
            this.ComboBoxClient.SelectedValueChanged += new System.EventHandler(this.ComboBoxClient_SelectedValueChanged);
            // 
            // ComboBoxEmployee
            // 
            this.ComboBoxEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEmployee.FormattingEnabled = true;
            this.ComboBoxEmployee.Location = new System.Drawing.Point(116, 447);
            this.ComboBoxEmployee.Name = "ComboBoxEmployee";
            this.ComboBoxEmployee.Size = new System.Drawing.Size(741, 28);
            this.ComboBoxEmployee.TabIndex = 17;
            this.ComboBoxEmployee.SelectedValueChanged += new System.EventHandler(this.ComboBoxEmployee_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Клиент:";
            // 
            // ButtonAddApointment
            // 
            this.ButtonAddApointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddApointment.Location = new System.Drawing.Point(931, 479);
            this.ButtonAddApointment.Name = "ButtonAddApointment";
            this.ButtonAddApointment.Size = new System.Drawing.Size(170, 32);
            this.ButtonAddApointment.TabIndex = 26;
            this.ButtonAddApointment.Text = "Добавить запись";
            this.ButtonAddApointment.UseVisualStyleBackColor = true;
            this.ButtonAddApointment.Click += new System.EventHandler(this.ButtonAddApointment_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Врач:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Процедура:";
            // 
            // ComboBoxOperation
            // 
            this.ComboBoxOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOperation.FormattingEnabled = true;
            this.ComboBoxOperation.Location = new System.Drawing.Point(115, 413);
            this.ComboBoxOperation.Name = "ComboBoxOperation";
            this.ComboBoxOperation.Size = new System.Drawing.Size(742, 28);
            this.ComboBoxOperation.TabIndex = 24;
            this.ComboBoxOperation.SelectedValueChanged += new System.EventHandler(this.ComboBoxOperation_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Время:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(863, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата:";
            // 
            // CountRows
            // 
            this.CountRows.AutoSize = true;
            this.CountRows.Location = new System.Drawing.Point(118, 17);
            this.CountRows.Name = "CountRows";
            this.CountRows.Size = new System.Drawing.Size(0, 20);
            this.CountRows.TabIndex = 15;
            // 
            // DGVAppointments
            // 
            this.DGVAppointments.AllowUserToAddRows = false;
            this.DGVAppointments.AllowUserToDeleteRows = false;
            this.DGVAppointments.AllowUserToResizeColumns = false;
            this.DGVAppointments.AllowUserToResizeRows = false;
            this.DGVAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAppointments.Location = new System.Drawing.Point(12, 48);
            this.DGVAppointments.Name = "DGVAppointments";
            this.DGVAppointments.ReadOnly = true;
            this.DGVAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVAppointments.Size = new System.Drawing.Size(1089, 320);
            this.DGVAppointments.TabIndex = 12;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 30);
            this.ButtonBack.TabIndex = 11;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 34;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(948, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 26);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Поиск по дате:";
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 523);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1129, 562);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1129, 562);
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Офтальмологическая клиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppointmentForm_FormClosing);
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.DataGridView DGVAppointments;
        private System.Windows.Forms.Label CountRows;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxClient;
        private System.Windows.Forms.ComboBox ComboBoxEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAddApointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
    }
}