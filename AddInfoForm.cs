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
    public partial class AddInfoForm : Form
    {
        public AddInfoForm()
        {
            InitializeComponent();
        }

        public int selectFirstTable = 1; public int selectSecondTable = 0;

        private void ButtonAddClient_Click(object sender, EventArgs e) // Кнопка добавления нового клиента
        {
            try
            {
                App.WorkingWithDataBase checkRow = new App.WorkingWithDataBase();

                if (TextBoxClientFirstName.Text != "" && TextBoxClientSecondName.Text != "" && TextBoxClientLastName.Text != "" && TextBoxClientPassport.Text != "" && TextBoxClientPlaceResidence.Text != "" && TextBoxClientPhone.Text != "")
                {
                    if (checkRow.coincidencePriChangeAndAddRow("SELECT * FROM clients WHERE firstName='" + TextBoxClientFirstName.Text + "' AND secondName='" + TextBoxClientSecondName.Text + "' AND lastName='" + TextBoxClientLastName.Text + "' AND seriesAndNumberOfPassport='" + TextBoxClientPassport.Text + "' AND placeOfResidence='" + TextBoxClientPlaceResidence.Text + "' AND telephone='" + TextBoxClientPhone.Text + "' AND passportIssued='" + TextBoxPassportIssued.Text + "'") == false ) // Если такой же записи не обнаружено или изменений не произошло
                    {
                        string query = "INSERT INTO clients (firstName, secondName, lastName, seriesAndNumberOfPassport, placeOfResidence, telephone, passportIssued)" +
                        " VALUES ('" + TextBoxClientFirstName.Text + "', '" + TextBoxClientSecondName.Text + "', '" + TextBoxClientLastName.Text + "', '" + TextBoxClientPassport.Text + "', '" + TextBoxClientPlaceResidence.Text + "', '" + TextBoxClientPhone.Text + "', '" + TextBoxPassportIssued.Text + "');";

                        App.WorkingWithDataBase Execute = new App.WorkingWithDataBase();
                        Execute.operationWithOneRowInDB(query);

                        TextBoxClientFirstName.Text = "";
                        TextBoxClientSecondName.Text = "";
                        TextBoxClientLastName.Text = "";
                        TextBoxClientPassport.Text = "";
                        TextBoxClientPlaceResidence.Text = "";
                        TextBoxClientPhone.Text = "";
                        TextBoxPassportIssued.Text = "";

                        UpdateForm();

                        MessageBox.Show("Клиент успешно записан в БД", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Если запись была найдена
                    {
                        MessageBox.Show("Запись с точно такими же данными уже существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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

        private void ButtonAddWorker_Click(object sender, EventArgs e) // Кнопка добавления нового сотрудника
        {
            try
            {
                App.WorkingWithDataBase checkRow = new App.WorkingWithDataBase();

                if (TextBoxWorkerFirstName.Text != "" && TextBoxWorkerSecondName.Text != "" && TextBoxWorkerLastName.Text != "" && TextBoxWorkerPhone.Text != "" && TextBoxWorkerPlaceResidence.Text != "" && TextBoxWorkerPost.Text != "")
                {
                    if (checkRow.coincidencePriChangeAndAddRow("SELECT * FROM employees WHERE firstName='" + TextBoxWorkerFirstName.Text + "' AND secondName='" + TextBoxWorkerSecondName.Text + "' AND lastName='" + TextBoxWorkerLastName.Text + "' AND telephone='" + TextBoxWorkerPhone.Text + "' AND placeOfResidence='" + TextBoxWorkerPlaceResidence.Text + "' AND post='" + TextBoxWorkerPost.Text + "'") == false) // Если такой же записи не обнаружено или изменений не произошло
                    {
                        string query = "INSERT INTO employees (firstName, secondName, lastName, telephone, placeOfResidence, post)" +
                        " VALUES ('" + TextBoxWorkerFirstName.Text + "', '" + TextBoxWorkerSecondName.Text + "', '" + TextBoxWorkerLastName.Text + "', '" + TextBoxWorkerPhone.Text + "', '" + TextBoxWorkerPlaceResidence.Text + "', '" + TextBoxWorkerPost.Text + "');";

                        App.WorkingWithDataBase Execute = new App.WorkingWithDataBase();
                        Execute.operationWithOneRowInDB(query);

                        TextBoxWorkerFirstName.Text = "";
                        TextBoxWorkerSecondName.Text = "";
                        TextBoxWorkerLastName.Text = "";
                        TextBoxWorkerPhone.Text = "";
                        TextBoxWorkerPlaceResidence.Text = "";
                        TextBoxWorkerPost.Text = "";

                        UpdateForm();

                        MessageBox.Show("Работник успешно записан в БД", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Если запись была найдена
                    {
                        MessageBox.Show("Запись с точно такими же данными уже существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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
                if (AuthorizationForm.type == "admin")
                {
                    App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();

                    SQLiteDataAdapter adapterClients = GetAdapter.getAdapter("SELECT * FROM clients"); // Получить адаптер таблицы клиентов
                    DataTable tableClients = new DataTable();
                    adapterClients.Fill(tableClients);

                    DGVClients.DataSource = tableClients;
                    DGVClients.Columns[0].Visible = false;

                    tableClients.Columns["firstName"].ColumnName = "Фамилия"; tableClients.Columns["secondName"].ColumnName = "Имя";
                    tableClients.Columns["lastName"].ColumnName = "Отчество"; tableClients.Columns["seriesAndNumberOfPassport"].ColumnName = "Серия и номер паспорта";
                    tableClients.Columns["placeOfResidence"].ColumnName = "Место жительства"; tableClients.Columns["telephone"].ColumnName = "Телефон";
                    tableClients.Columns["passportIssued"].ColumnName = "Паспорт выдан:";

                    this.DGVClients.Sort(this.DGVClients.Columns["Фамилия"], ListSortDirection.Ascending); // Сортировка по столбцу

                    SQLiteDataAdapter adapterWorkers = GetAdapter.getAdapter("SELECT * FROM employees"); // Получить адаптер таблицы сотрудников
                    DataTable tableWorkers = new DataTable();
                    adapterWorkers.Fill(tableWorkers);

                    DGVWorkers.DataSource = tableWorkers;
                    DGVWorkers.Columns[0].Visible = false;

                    tableWorkers.Columns["firstName"].ColumnName = "Фамилия"; tableWorkers.Columns["secondName"].ColumnName = "Имя";
                    tableWorkers.Columns["lastName"].ColumnName = "Отчество"; tableWorkers.Columns["telephone"].ColumnName = "Телефон";
                    tableWorkers.Columns["placeOfResidence"].ColumnName = "Место жительства"; tableWorkers.Columns["post"].ColumnName = "Должность";

                    this.DGVWorkers.Sort(this.DGVWorkers.Columns["Фамилия"], ListSortDirection.Ascending); // Сортировка по столбцу
                }
                else
                {
                    App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();
                    SQLiteDataAdapter adapter = GetAdapter.getAdapter("SELECT * FROM clients"); // Получить адаптер таблицы клиентов

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    DGVClients.DataSource = table;
                    DGVClients.Columns[0].Visible = false;

                    table.Columns["firstName"].ColumnName = "Имя"; table.Columns["secondName"].ColumnName = "Фамилия";
                    table.Columns["lastName"].ColumnName = "Отчество"; table.Columns["seriesAndNumberOfPassport"].ColumnName = "Серия и номер паспорта";
                    table.Columns["placeOfResidence"].ColumnName = "Место жительства"; table.Columns["telephone"].ColumnName = "Телефон";
                    table.Columns["passportIssued"].ColumnName = "Паспорт выдан:";

                    this.DGVClients.Sort(this.DGVClients.Columns["Фамилия"], ListSortDirection.Ascending); // Сортировка по столбцу
                }

                LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddInfoForm_Load(object sender, EventArgs e) // Загрузка формы
        {
            UpdateForm();
            if (AuthorizationForm.type != "admin")
            {
                tabControl1.TabPages[1].Parent = null; // Убирает вкладку "Сотрудники"
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectFirstTable == 1 && selectSecondTable == 0) // Выбранна таблица клиенты
                {
                    if (TextBoxSearch.Text == "")
                    {
                        UpdateForm();
                        LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;
                    }
                    else
                    {
                        App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();

                        SQLiteDataAdapter adapterClients = GetAdapter.getAdapter("SELECT * FROM clients WHERE firstName LIKE '%" + TextBoxSearch.Text + "%'"); // Получить адаптер таблицы клиентов
                        DataTable tableClients = new DataTable();
                        adapterClients.Fill(tableClients);

                        DGVClients.DataSource = tableClients;
                        DGVClients.Columns[0].Visible = false;

                        tableClients.Columns["firstName"].ColumnName = "Фамилия"; tableClients.Columns["secondName"].ColumnName = "Имя";
                        tableClients.Columns["lastName"].ColumnName = "Отчество"; tableClients.Columns["seriesAndNumberOfPassport"].ColumnName = "Серия и номер паспорта";
                        tableClients.Columns["placeOfResidence"].ColumnName = "Место жительства"; tableClients.Columns["telephone"].ColumnName = "Телефон";
                        tableClients.Columns["passportIssued"].ColumnName = "Паспорт выдан:";

                        LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;
                    }
                }
                else if (selectFirstTable == 0 && selectSecondTable == 1) // Выбранна таблица сотрудники
                {
                    if (TextBoxSearch.Text == "")
                    {
                        UpdateForm();
                        LabelCountRows.Text = "Количество записей: " + DGVWorkers.Rows.Count;
                    }
                    else
                    {
                        App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();

                        SQLiteDataAdapter adapterWorkers = GetAdapter.getAdapter("SELECT * FROM employees WHERE firstName LIKE '%" + TextBoxSearch.Text + "%'"); // Получить адаптер таблицы сотрудников
                        DataTable tableWorkers = new DataTable();
                        adapterWorkers.Fill(tableWorkers);

                        DGVWorkers.DataSource = tableWorkers;
                        DGVWorkers.Columns[0].Visible = false;

                        tableWorkers.Columns["firstName"].ColumnName = "Фамилия"; tableWorkers.Columns["secondName"].ColumnName = "Имя";
                        tableWorkers.Columns["lastName"].ColumnName = "Отчество"; tableWorkers.Columns["telephone"].ColumnName = "Телефон";
                        tableWorkers.Columns["placeOfResidence"].ColumnName = "Место жительства"; tableWorkers.Columns["post"].ColumnName = "Должность";

                        LabelCountRows.Text = "Количество записей: " + DGVWorkers.Rows.Count;
                    }
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) // При выборе вкладок
        {
            try
            {
                int selectedTab = tabControl1.SelectedIndex; // Индекс выбранной вкладки
                if (selectedTab == 0)
                {
                    selectFirstTable = 1; selectSecondTable = 0;
                    TextBoxSearch.Text = "";

                    LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;
                }
                else if (selectedTab == 1)
                {
                    selectFirstTable = 0; selectSecondTable = 1;
                    TextBoxSearch.Text = "";

                    LabelCountRows.Text = "Количество записей: " + DGVWorkers.Rows.Count;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e) // Кнопка "Назад"
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        private void AddInfoForm_FormClosing(object sender, FormClosingEventArgs e) // Крестик
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

        private void KeyPressFIO(object sender, KeyPressEventArgs e) // Ограничение текстовых полей ФИО для сотрудников и клиентов
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) {    }
            else
            {
                e.Handled = true;
            }
        }

        private void KeyPressPhone(object sender, KeyPressEventArgs e) // Ограничение текстовых полей номера телефона для сотрудников и клиентов
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '+')) { }
            else
            {
                e.Handled = true;
            }
        }

        private void KeyPressLive(object sender, KeyPressEventArgs e) // Ограничение текстовых полей мест жительства для сотрудников и клиентов
        {
            if ((e.KeyChar == '-') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '.') || (e.KeyChar == ',')) { }
            else
            {
                e.Handled = true;
            }
        }

        private void KeyPressPassport(object sender, KeyPressEventArgs e) // Ограничение для поля серия и номер паспорта
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) { }
            else
            {
                e.Handled = true;
            }
        }

        private void KeyPressPost(object sender, KeyPressEventArgs e) // Ограничения для поля должность
        {
            if ((e.KeyChar == ',') || (e.KeyChar == '.') || (e.KeyChar == '-') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)) { }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBoxPassportIssued_KeyPress(object sender, KeyPressEventArgs e) // Для поля кем выдан паспорт
        {
            if ((e.KeyChar == '-') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '.') || (e.KeyChar == ',')) { }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back)) { }
            else
            {
                e.Handled = true;
            }
        } 
    }
}
