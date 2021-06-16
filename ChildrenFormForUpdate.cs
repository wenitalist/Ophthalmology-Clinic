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

namespace OphthalmologyClinic
{
    public partial class ChildrenFormForUpdate : Form
    {
        public ChildrenFormForUpdate()
        {
            InitializeComponent();
        }

        private void ChildrenFormForUpdate_FormClosing(object sender, FormClosingEventArgs e) // При закрытии этой формы возвращать контроль родительской форме
        {
            MainForm.ChangeDelInfoForm.Enabled = true;
        }

        public string par1 = ""; public string par2 = ""; public string par3 = ""; public string par4 = ""; public string par5 = ""; public string par6 = ""; public string par7 = "";

        private void ButtonChangeRow_Click(object sender, EventArgs e) // Кнопка "Подтвердить"
        {
            try
            {
                if (TextBoxParametr1.Text != "" && TextBoxParametr2.Text != "" && TextBoxParametr3.Text != "" && TextBoxParametr4.Text != "" && TextBoxParametr5.Text != "" && TextBoxParametr6.Text != "")
                {
                    if (ChangeDelInfoForm.SelectedTableClients == 1 && ChangeDelInfoForm.SelectedTableWorkers == 0) // Если меняют запись о клиенте
                    {
                        App.WorkingWithDataBase checkRow = new App.WorkingWithDataBase();

                        if (checkRow.coincidencePriChangeAndAddRow("SELECT * FROM clients WHERE firstName='" + TextBoxParametr1.Text + "' AND secondName='" + TextBoxParametr2.Text + "' AND lastName='" + TextBoxParametr3.Text + "' AND seriesAndNumberOfPassport='" + TextBoxParametr4.Text + "' AND placeOfResidence='" + TextBoxParametr5.Text + "' AND telephone='" + TextBoxParametr6.Text + "' AND passportIssued='" + TextBoxParametr7.Text + "'") == false || (NameParametr1.Text == par1 && NameParametr2.Text == par2 && NameParametr3.Text == par3 && NameParametr4.Text == par4 && NameParametr5.Text == par5 && NameParametr6.Text == par6 && NameParametr7.Text == par7)) // Если такой же записи не обнаружено или изменений не произошло
                        {
                            App.WorkingWithDataBase UpdateRow = new App.WorkingWithDataBase();
                            string query = "UPDATE clients SET firstName='" + TextBoxParametr1.Text + "', secondName='" + TextBoxParametr2.Text + "', lastName='" + TextBoxParametr3.Text + "', seriesAndNumberOfPassport='" + TextBoxParametr4.Text + "', placeOfResidence='" + TextBoxParametr5.Text + "', telephone='" + TextBoxParametr6.Text + "', passportIssued='" + TextBoxParametr7.Text + "'  WHERE id=" + Convert.ToInt32(ChangeDelInfoForm.SelectedClientID) + ";";
                            UpdateRow.operationWithOneRowInDB(query);

                            MessageBox.Show("Запись успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm.ChangeDelInfoForm.UpdateForm();
                            this.Close();
                        }
                        else // Если такая запись уже есть
                        {
                            MessageBox.Show("Запись с точно такими же данными уже существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    if (ChangeDelInfoForm.SelectedTableClients == 0 && ChangeDelInfoForm.SelectedTableWorkers == 1) // Если меняют запись о сотруднике
                    {
                        App.WorkingWithDataBase checkRow = new App.WorkingWithDataBase();

                        if (checkRow.coincidencePriChangeAndAddRow("SELECT * FROM employees WHERE firstName='" + TextBoxParametr1.Text + "' AND secondName='" + TextBoxParametr2.Text + "' AND lastName='" + TextBoxParametr3.Text + "' AND telephone='" + TextBoxParametr4.Text + "' AND placeOfResidence='" + TextBoxParametr5.Text + "' AND post='" + TextBoxParametr6.Text + "'") == false || (NameParametr1.Text == par1 && NameParametr2.Text == par2 && NameParametr3.Text == par3 && NameParametr4.Text == par4 && NameParametr5.Text == par5 && NameParametr6.Text == par6)) // Если такой же записи не обнаружено или изменений не произошло
                        {
                            App.WorkingWithDataBase UpdateRow = new App.WorkingWithDataBase();
                            string query = "UPDATE employees SET firstName='" + TextBoxParametr1.Text + "', secondName='" + TextBoxParametr2.Text + "', lastName='" + TextBoxParametr3.Text + "', telephone='" + TextBoxParametr4.Text + "', placeOfResidence='" + TextBoxParametr5.Text + "', post='" + TextBoxParametr6.Text + "'  WHERE id=" + Convert.ToInt32(ChangeDelInfoForm.SelectedWorkerID) + ";";
                            UpdateRow.operationWithOneRowInDB(query);

                            MessageBox.Show("Запись успешно изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm.ChangeDelInfoForm.UpdateForm();
                            this.Close();
                        }
                        else // Если такая запись уже есть
                        {
                            MessageBox.Show("Запись с точно такими же данными уже существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateForm()
        {
            try
            {
                App.WorkingWithDataBase getRow = new App.WorkingWithDataBase();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();

                if (ChangeDelInfoForm.SelectedTableClients == 1 && ChangeDelInfoForm.SelectedTableWorkers == 0) // Если меняют запись о клиенте
                {
                    adapter = getRow.getAdapter("SELECT * FROM clients WHERE id='" + Convert.ToInt32(ChangeDelInfoForm.SelectedClientID) + "'");

                    NameParametr1.Text = "Фамилия:";
                    NameParametr2.Text = "Имя:";
                    NameParametr3.Text = "Отчество:";
                    NameParametr4.Text = "Серия и номер паспорта:";
                    NameParametr5.Text = "Место жительства:";
                    NameParametr6.Text = "Телефон:";
                    NameParametr7.Visible = true; TextBoxParametr7.Visible = true;
                    NameParametr7.Text = "Паспорт выдан:";
                }
                if (ChangeDelInfoForm.SelectedTableClients == 0 && ChangeDelInfoForm.SelectedTableWorkers == 1) // Если меняют запись о сотруднике
                {
                    adapter = getRow.getAdapter("SELECT * FROM employees WHERE id='" + Convert.ToInt32(ChangeDelInfoForm.SelectedWorkerID) + "'");

                    NameParametr1.Text = "Фамилия:";
                    NameParametr2.Text = "Имя:";
                    NameParametr3.Text = "Отчество:";
                    NameParametr4.Text = "Телефон:";
                    NameParametr5.Text = "Место жительства:";
                    NameParametr6.Text = "Должность:";
                    NameParametr7.Visible = false; TextBoxParametr7.Visible = false;
                }

                DataTable table = new DataTable();
                adapter.Fill(table);

                TextBoxParametr1.Text = table.Rows[0].ItemArray[1].ToString(); par1 = table.Rows[0].ItemArray[1].ToString();
                TextBoxParametr2.Text = table.Rows[0].ItemArray[2].ToString(); par2 = table.Rows[0].ItemArray[2].ToString();
                TextBoxParametr3.Text = table.Rows[0].ItemArray[3].ToString(); par3 = table.Rows[0].ItemArray[3].ToString();
                TextBoxParametr4.Text = table.Rows[0].ItemArray[4].ToString(); par4 = table.Rows[0].ItemArray[4].ToString();
                TextBoxParametr5.Text = table.Rows[0].ItemArray[5].ToString(); par5 = table.Rows[0].ItemArray[5].ToString();
                TextBoxParametr6.Text = table.Rows[0].ItemArray[6].ToString(); par6 = table.Rows[0].ItemArray[6].ToString();
                if (ChangeDelInfoForm.SelectedTableClients == 1)
                {
                    TextBoxParametr7.Text = table.Rows[0].ItemArray[7].ToString(); par7 = table.Rows[0].ItemArray[7].ToString();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChildrenFormForUpdate_Load(object sender, EventArgs e) // Загрузка формы
        {
            UpdateForm();
        }

        private void KeyPressFIO(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) { }
            else
            {
                e.Handled = true;
            }
        }

        private void KeyPressPar4(object sender, KeyPressEventArgs e)
        {
            if (ChangeDelInfoForm.SelectedTableClients == 1) // Если работают с таблицей клиентов
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) { }
                else
                {
                    e.Handled = true;
                }
            }
            else // Если работают с таблицей сотрудников
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '+')) { }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void KeyPressPar5(object sender, KeyPressEventArgs e)
        {
            if (ChangeDelInfoForm.SelectedTableClients == 1) // Если работают с таблицей клиентов
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '-') || (e.KeyChar == (char)Keys.Space)) { }
                else
                {
                    e.Handled = true;
                }
            }
            else // Если работают с таблицей сотрудников
            {
                if ((e.KeyChar == '-') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '.') || (e.KeyChar == ',')) { }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void KeyPressPar6(object sender, KeyPressEventArgs e)
        {
            if (ChangeDelInfoForm.SelectedTableClients == 1) // Если работают с таблицей клиентов
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) { }
                else
                {
                    e.Handled = true;
                }
            }
            else // Если работают с таблицей сотрудников
            {
                if ((e.KeyChar == ',') || (e.KeyChar == '.') || (e.KeyChar == '-') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) { }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void TextBoxParametr7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',') || (e.KeyChar == '.') || (e.KeyChar == '-') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) { }
            else
            {
                e.Handled = true;
            }
        }
    }
}
