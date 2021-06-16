using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;

namespace OphthalmologyClinic
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        public static string type = ""; public static int Authzw = 0;

        private void ButtonInput_Click(object sender, EventArgs e) // Кнопка "Войти"
        {
            try
            {
                if (ComboBoxLogin.Text != "" && TextBoxPassword.Text != "")
                {
                    SHA256 algorithm = SHA256.Create();
                    App.HashPassword getHash = new App.HashPassword();
                    string hash = getHash.hashPassword(algorithm, TextBoxPassword.Text);

                    App.WorkingWithDataBase checkMatch = new App.WorkingWithDataBase();
                    var result = checkMatch.coincidence(ComboBoxLogin.Text, hash);

                    if (result[0] == "false")
                    {
                        MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (result[1] == "admin") // Открывает главную форму для администратора 
                    {
                        Authzw++;
                        type = "admin";
                        MainForm main = new MainForm();
                        this.Hide();
                        main.Show();
                        return;
                    }
                    else if (result[1] == "user") // Открывает главную форму для пользователя
                    {
                        Authzw++;
                        type = "user";
                        MainForm main = new MainForm();
                        this.Hide();
                        main.Show();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите логин и введите пароль!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonShowPass_MouseDown(object sender, MouseEventArgs e) // Нажатие и удерживание кнопки "Показать пароль"
        {
            TextBoxPassword.PasswordChar = '\0';
        }

        private void ButtonShowPass_MouseUp(object sender, MouseEventArgs e) // Остановка удерживания кнопки "Показать пароль"
        {
            TextBoxPassword.PasswordChar = '*';
        }

        private void AuthorizationForm_Load(object sender, EventArgs e) // Загрузка формы
        {
            try
            {
                Authzw = 0;

                App.WorkingWithDataBase WorkingDB = new App.WorkingWithDataBase();

                DataTable table = new DataTable();
                WorkingDB.getAdapter("SELECT * FROM users").Fill(table);

                int i = 0;
                while (i < table.Rows.Count)
                {
                    ComboBoxLogin.Items.Add(table.Rows[i].ItemArray.GetValue(1).ToString());
                    i++;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e) // Крестик
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
