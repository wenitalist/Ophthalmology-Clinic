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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        public string[] FIOClient = new string[3];
        public string[] FIOWorker = new string[3];

        //public string[][] massWithClients; // Массив для клиентов
        //public string[][] massWithWorkers; // Массив для работников

        public void UpdateForm()
        {
            try
            {
                ToolTip t = new ToolTip();
                t.SetToolTip(button1, "Отмена поиска");

                dateTimePicker1.MinDate = DateTime.Today;

                //massWithClients = new string[WorkWithDB.CountRowsInTable("SELECT * FROM clients")][]; // Задаю размер массива 
                //massWithWorkers = new string[WorkWithDB.CountRowsInTable("SELECT * FROM employees")][]; // Задаю размер массива

                App.WorkingWithDataBase WorkWithDB = new App.WorkingWithDataBase();
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter;

                adapter = WorkWithDB.getAdapter("SELECT id," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM clients WHERE appointments.idClient = clients.id)," +
                                                "operation," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "date," +
                                                "time," +
                                                "price " +
                                                "FROM appointments;");
                adapter.Fill(table);

                DGVAppointments.DataSource = table;
                DGVAppointments.Columns[0].Visible = false;

                table.Columns[1].ColumnName = "Пациент";
                table.Columns[2].ColumnName = "Процедура";
                table.Columns[3].ColumnName = "Врач";
                table.Columns[4].ColumnName = "Дата";
                table.Columns[5].ColumnName = "Время";
                table.Columns[6].ColumnName = "Цена";

                DGVAppointments.Columns[2].Width = 300;

                CountRows.Text = "Количество записей: " + DGVAppointments.Rows.Count.ToString();

                this.DGVAppointments.Sort(this.DGVAppointments.Columns["Дата"], ListSortDirection.Ascending); // Сортировка по столбцу
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool CheckClientAppointment(string date, string firstName, string secondName, string lastName, string time) // Проверка записан ли клиент на этот день и на это время
        {
            App.WorkingWithDataBase GetTimes = new App.WorkingWithDataBase();
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter;

            adapter = GetTimes.getAdapter("SELECT * FROM appointments WHERE date='" + date + "' AND idClient=(SELECT id FROM clients WHERE firstName='" + firstName + "' AND secondName='" + secondName + "' AND lastName='" + lastName + "') AND time='" + time + "'");
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ButtonAddApointment_Click(object sender, EventArgs e) // Кнопка "Записать"
        {
            try
            {
                if (ComboBoxClient.Text != "" && ComboBoxEmployee.Text != "" && ComboBoxOperation.Text != "" && ComboBoxTime.Text != "" && TextBoxPrice.Text != "")
                {
                    string[] FIOClient = ComboBoxClient.Text.Split(' ');
                    string[] FIOWorker = ComboBoxEmployee.Text.Split(' ');

                    if (CheckClientAppointment(dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"), FIOClient[0], FIOClient[1], FIOClient[2], ComboBoxTime.Text) == true) // Если записан
                    {
                        MessageBox.Show("Этот клиент уже записан на эту дату и это время, выберите другое время или дату!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        App.WorkingWithDataBase AddAppointment = new App.WorkingWithDataBase();
                        DataTable table = new DataTable();
                        SQLiteDataAdapter adapter;

                        adapter = AddAppointment.getAdapter("SELECT id FROM clients WHERE firstName='" + FIOClient[0] + "' AND secondName='" + FIOClient[1] + "' AND lastName='" + FIOClient[2] + "'");
                        adapter.Fill(table);
                        string idClient = table.Rows[0].ItemArray[0].ToString();

                        table.Clear();

                        adapter = AddAppointment.getAdapter("SELECT id FROM employees WHERE firstName='" + FIOWorker[0] + "' AND secondName='" + FIOWorker[1] + "' AND lastName='" + FIOWorker[2] + "'");
                        adapter.Fill(table);
                        string idEmployee = table.Rows[0].ItemArray[0].ToString();

                        string query = "INSERT INTO appointments (date, time, idClient, idEmployee, operation, price)" +
                        " VALUES ('" + dateTimePicker1.Value.Date.ToString("dd/MM/yyyy") + "', '" + ComboBoxTime.Text + "', '" + idClient + "', '" + idEmployee + "', '" + ComboBoxOperation.Text + "', '" + TextBoxPrice.Text + "');";

                        AddAppointment.operationWithOneRowInDB(query);

                        MessageBox.Show("Запись успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateForm();

                        ComboBoxClient.SelectedIndex = -1;
                        ComboBoxEmployee.SelectedIndex = -1;
                        ComboBoxTime.SelectedIndex = -1;
                        ComboBoxOperation.SelectedIndex = -1;
                        TextBoxPrice.Text = "";
                    }
                }
                else if (ComboBoxTime.Text == "Всё время занято")
                {
                    MessageBox.Show("У врача нет свободных мест, выберите другого!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InComboBoxes() // Заполнение комбо боксов
        {
            try
            {
                App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter;

                adapter = GetAdapter.getAdapter("SELECT * FROM clients");
                adapter.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++) // Заполнение ComboBox c клиентами
                {
                    string row = table.Rows[i].ItemArray[1].ToString() + " " + table.Rows[i].ItemArray[2].ToString() + " " + table.Rows[i].ItemArray[3].ToString() + " " + table.Rows[i].ItemArray[4].ToString();
                    ComboBoxClient.Items.Add(row);

                    //massWithClients[i] = new string[4] { table.Rows[i].ItemArray[0].ToString(), table.Rows[i].ItemArray[1].ToString(), 
                    //table.Rows[i].ItemArray[2].ToString(), table.Rows[i].ItemArray[3].ToString() }; // Сохранение информации в массив (ФИО и айди)
                }

                table.Clear();

                adapter = GetAdapter.getAdapter("SELECT * FROM employees WHERE post LIKE '%Врач-офтальмолог%' OR post LIKE '%врач-офтальмолог%'");
                adapter.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++) // Заполнение ComboBox c врачами
                {
                    string row = table.Rows[i].ItemArray[1].ToString() + " " + table.Rows[i].ItemArray[2].ToString() + " " + table.Rows[i].ItemArray[3].ToString() + " " + table.Rows[i].ItemArray[8].ToString();
                    ComboBoxEmployee.Items.Add(row);

                    //massWithWorkers[i] = new string[5] { table.Rows[i].ItemArray[0].ToString(), table.Rows[i].ItemArray[1].ToString(), 
                    //table.Rows[i].ItemArray[2].ToString(), table.Rows[i].ItemArray[3].ToString() }; // Сохранение информации в массив (ФИО и айди)
                }

                table.Clear();

                adapter = GetAdapter.getAdapter("SELECT * FROM servicesAdults");
                adapter.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++) // Заполнение ComboBox c процедурами
                {
                    string row = table.Rows[i].ItemArray[9].ToString();
                    ComboBoxOperation.Items.Add(row);
                }

                table.Clear();

                adapter = GetAdapter.getAdapter("SELECT * FROM servicesChildrens");
                adapter.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++) // Заполнение ComboBox c процедурами
                {
                    string row = table.Rows[i].ItemArray[9].ToString();
                    ComboBoxOperation.Items.Add(row);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
            InComboBoxes();
        }

        private void ComboBoxOperation_SelectedValueChanged(object sender, EventArgs e) // При выборе процедуры
        {
            try
            {
                if (ComboBoxOperation.Text != "")
                {
                    string StrOperation = ComboBoxOperation.Text;

                    App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();
                    DataTable table = new DataTable();
                    SQLiteDataAdapter adapter;

                    adapter = GetAdapter.getAdapter("SELECT price FROM servicesAdults WHERE name='" + StrOperation + "'");
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        adapter = GetAdapter.getAdapter("SELECT price FROM servicesChildrens WHERE name='" + StrOperation + "'");
                        adapter.Fill(table);
                    }

                    TextBoxPrice.Text = table.Rows[0].ItemArray[0].ToString();

                    if (ComboBoxOperation.Text != "" && ComboBoxClient.Text != "" && ComboBoxEmployee.Text != "")
                    {
                        dateTimePicker1.Enabled = true;
                    }
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetTimesAppointments() // Тут я проверяю на свободное время выбранного дня для заполнения комбобокс с временем
        {
            try
            {
                //string[] FIOClient = ComboBoxClient.Text.Split(' '); // Имена и фамилии клиентов и сотрудников выбранных в комбобоксах
                string[] FIOWorker = ComboBoxEmployee.Text.Split(' ');

                string[] massWithTimes; // Массив для времени

                App.WorkingWithDataBase GetTimes = new App.WorkingWithDataBase();
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter;

                adapter = GetTimes.getAdapter("SELECT * FROM appointments WHERE date='" + dateTimePicker1.Value.Date.ToString("dd/MM/yyyy") + "' AND idEmployee=(SELECT id FROM employees WHERE firstName='" + FIOWorker[0] + "' AND secondName='" + FIOWorker[1] + "' AND lastName='" + FIOWorker[2] + "')");
                adapter.Fill(table);

                if (table.Rows.Count == 10) // Если записей 10, значит всё на этот день занято
                {
                    ComboBoxTime.Items.Clear();
                    ComboBoxTime.Items.Add("Всё время занято");
                    ComboBoxTime.SelectedIndex = 0;
                }
                else if (table.Rows.Count == 0) // Если записей ноль
                {
                    massWithTimes = new string[10] { "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00" };
                    ComboBoxTime.Items.Clear();

                    for (int i = 0; i < massWithTimes.Count(); i++)
                    {
                        ComboBoxTime.Items.Add(massWithTimes[i]);
                    }
                }
                else if (table.Rows.Count != 0 && table.Rows.Count != 10) // Если записи есть, но не 10, тут нужно составлять массив с временем, удаляя найденное время
                {
                    int clearPlaces = 10 - table.Rows.Count;
                    int hours = 8;
                    string[] massWithNoClearPlaces = new string[table.Rows.Count];
                    ComboBoxTime.Items.Clear();

                    for (int i = 0; i < massWithNoClearPlaces.Count(); i++)
                    {
                        massWithNoClearPlaces[i] = table.Rows[i].ItemArray[2].ToString();
                    }

                    for (int i = 0; i <= clearPlaces; i++)
                    {
                        if (Array.Exists(massWithNoClearPlaces, element => element == (hours + i).ToString() + ":00")) { } // Такое время занято 
                        else
                        {
                            ComboBoxTime.Items.Add((hours + i).ToString() + ":00");
                        }
                    }
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxClient_SelectedValueChanged(object sender, EventArgs e) // При выборе клиента
        {
            try
            {
                if (ComboBoxOperation.Text != "" && ComboBoxClient.Text != "" && ComboBoxEmployee.Text != "") // Если клиент, врач и процедура выбранны
                {
                    dateTimePicker1.Enabled = true;
                    ComboBoxTime.Enabled = true;
                    GetTimesAppointments();
                }
                else
                {
                    dateTimePicker1.Enabled = false;
                    ComboBoxTime.Enabled = false;
                    ComboBoxTime.Items.Clear();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxEmployee_SelectedValueChanged(object sender, EventArgs e) // При выборе сотрудника
        {
            try
            {
                if (ComboBoxOperation.Text != "" && ComboBoxClient.Text != "" && ComboBoxEmployee.Text != "") // Если клиент, врач и процедура выбранны
                {
                    dateTimePicker1.Enabled = true;
                    ComboBoxTime.Enabled = true;
                    GetTimesAppointments();
                }
                else
                {
                    dateTimePicker1.Enabled = false;
                    ComboBoxTime.Enabled = false;
                    ComboBoxTime.Items.Clear();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // При выборе даты
        {
            GetTimesAppointments();
        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e) // Отмена поиска
        {
            UpdateForm();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string day = dateTimePicker2.Value.Day.ToString(); if (day.Length == 1) { day = "0" + day; }
                string month = dateTimePicker2.Value.Month.ToString(); if (month.Length == 1) { month = "0" + month; }
                string year = dateTimePicker2.Value.Year.ToString();

                string date = day + '.' + month + '.' + year;

                App.WorkingWithDataBase WorkWithDB = new App.WorkingWithDataBase();
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter;

                adapter = WorkWithDB.getAdapter("SELECT id," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM clients WHERE appointments.idClient = clients.id)," +
                                                "operation," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "date," +
                                                "time," +
                                                "price " +
                                                "FROM appointments WHERE date='" + date + "';");
                adapter.Fill(table);

                DGVAppointments.DataSource = table;
                DGVAppointments.Columns[0].Visible = false;

                table.Columns[1].ColumnName = "Пациент";
                table.Columns[2].ColumnName = "Процедура";
                table.Columns[3].ColumnName = "Врач";
                table.Columns[4].ColumnName = "Дата";
                table.Columns[5].ColumnName = "Время";
                table.Columns[6].ColumnName = "Цена";

                DGVAppointments.Columns[2].Width = 300;

                if (DGVAppointments.Rows.Count == 0)
                {
                    CountRows.Text = "Количество записей: нет записей на эту дату";
                }
                else
                {
                    CountRows.Text = "Количество записей: " + DGVAppointments.Rows.Count.ToString();
                }

                this.DGVAppointments.Sort(this.DGVAppointments.Columns["Врач"], ListSortDirection.Ascending); // Сортировка по столбцу
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
