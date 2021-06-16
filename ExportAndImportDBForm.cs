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
using CsvHelper;

namespace OphthalmologyClinic
{
    public partial class ExportAndImportDBForm : Form
    {
        public ExportAndImportDBForm()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        public string mainPath = ""; public string fileName = "";

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        mainPath = System.IO.Directory.GetCurrentDirectory();
                        fileName = openFileDialog1.FileName;
                        myStream.Close();

                        TextBoxPath.Text = fileName;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImporting_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainPath != "" && fileName != "")
                {
                    if (File.Exists(mainPath + "\\db.sqlite"))
                    {
                        File.Delete(mainPath + "\\db.sqlite");
                    }
                    File.Copy(fileName, mainPath + "\\db.sqlite", true);

                    MessageBox.Show("База данных восстановлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сначала выберите файл!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportAllTables()
        {
            try
            {
                char razdelitel = Convert.ToChar(ComboBoxRazdelitel.Text);
                char s = '"';
                string[] tableNames = new string[5] { "appointments", "clients", "employees", "servicesAdults", "servicesChildrens" };

                using (var file = new StreamWriter(@"All Tables.csv", false, Encoding.Default))
                {
                    for (int q = 0; q < 5; q++) // Для таблиц
                    {
                        SQLiteConnection connect = new SQLiteConnection();
                        SQLiteCommand command = new SQLiteCommand();

                        connect = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
                        SQLiteCommand query = new SQLiteCommand("SELECT * FROM " + tableNames[q] + ";", connect);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        file.WriteLine("Table name: " + tableNames[q]);
                        for (int l = 0; l < table.Rows.Count; l++) // Для строк
                        {
                            for (int i = 0; i < table.Rows[l].ItemArray.Count(); i++) // Для данных в строках
                            {
                                string info = table.Rows[l].ItemArray.GetValue(i).ToString();
                                if ((i + 1) == table.Rows[l].ItemArray.Count())
                                {
                                    file.Write(s + info + s);
                                }
                                else
                                {
                                    file.Write(s + info + s + razdelitel);
                                }
                            }
                            file.WriteLine("");
                        }
                        file.WriteLine("");
                    }
                }
                MessageBox.Show("Таблицы успешно экспортированы", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExporting_Click(object sender, EventArgs e) // Кнопка экспорта инфы
        {
            try
            {
                if (ComboBoxRazdelitel.Text != "" && ComboBoxObject.Text != "")
                {
                    string tableName = "";

                    if (ComboBoxObject.Text == "Таблица записей на приём") { tableName = "appointments"; }
                    if (ComboBoxObject.Text == "Таблица клиентов") { tableName = "clients"; }
                    if (ComboBoxObject.Text == "Таблица сотрудников") { tableName = "employees"; }
                    if (ComboBoxObject.Text == "Таблица услуг для взрослых") { tableName = "servicesAdults"; }
                    if (ComboBoxObject.Text == "Таблица услуг для детей") { tableName = "servicesChildrens"; }
                    if (ComboBoxObject.Text == "Вся БД") { tableName = "allTables"; }

                    if (tableName == "allTables")
                    {
                        ExportAllTables();
                        return;
                    }
                    else
                    {
                        char razdelitel = Convert.ToChar(ComboBoxRazdelitel.Text);
                        char s = '"';

                        SQLiteConnection connect = new SQLiteConnection();
                        SQLiteCommand command = new SQLiteCommand();

                        connect = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
                        SQLiteCommand query = new SQLiteCommand("SELECT * FROM " + tableName + ";", connect);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        using (var file = new StreamWriter(@"" + tableName + ".csv", false, Encoding.Default))
                        {
                            for (int l = 0; l < table.Rows.Count; l++)
                            {
                                for (int i = 0; i < table.Rows[l].ItemArray.Count(); i++)
                                {
                                    string info = table.Rows[l].ItemArray.GetValue(i).ToString();
                                    if ((i + 1) == table.Rows[l].ItemArray.Count())
                                    {
                                        file.Write(s + info + s);
                                    }
                                    else
                                    {
                                        file.Write(s + info + s + razdelitel);
                                    }
                                }
                                file.WriteLine("");
                            }
                        }
                        MessageBox.Show("Таблица успешно экспортирована", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Сначала нужно выбрать разделить и название таблицы", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportAndImportDBForm_FormClosing(object sender, FormClosingEventArgs e)
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
