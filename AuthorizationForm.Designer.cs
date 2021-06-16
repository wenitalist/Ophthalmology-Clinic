namespace OphthalmologyClinic
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonShowPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxLogin = new System.Windows.Forms.ComboBox();
            this.ButtonInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.ButtonShowPass);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ComboBoxLogin);
            this.panel1.Controls.Add(this.ButtonInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBoxPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 220);
            this.panel1.TabIndex = 0;
            // 
            // ButtonShowPass
            // 
            this.ButtonShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonShowPass.BackgroundImage")));
            this.ButtonShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowPass.Location = new System.Drawing.Point(270, 126);
            this.ButtonShowPass.Name = "ButtonShowPass";
            this.ButtonShowPass.Size = new System.Drawing.Size(33, 28);
            this.ButtonShowPass.TabIndex = 8;
            this.ButtonShowPass.UseVisualStyleBackColor = true;
            this.ButtonShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonShowPass_MouseDown);
            this.ButtonShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonShowPass_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 70);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // ComboBoxLogin
            // 
            this.ComboBoxLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLogin.FormattingEnabled = true;
            this.ComboBoxLogin.Location = new System.Drawing.Point(89, 84);
            this.ComboBoxLogin.Name = "ComboBoxLogin";
            this.ComboBoxLogin.Size = new System.Drawing.Size(214, 28);
            this.ComboBoxLogin.TabIndex = 6;
            // 
            // ButtonInput
            // 
            this.ButtonInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInput.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonInput.Location = new System.Drawing.Point(198, 171);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(105, 35);
            this.ButtonInput.TabIndex = 5;
            this.ButtonInput.Text = "Войти";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPassword.Location = new System.Drawing.Point(89, 127);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(181, 26);
            this.TextBoxPassword.TabIndex = 1;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 220);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(331, 259);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(331, 259);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Офтальмологическая клиника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.ComboBox ComboBoxLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonShowPass;
    }
}