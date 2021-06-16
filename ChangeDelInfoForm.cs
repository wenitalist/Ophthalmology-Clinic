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
    public partial class ChangeDelInfoForm : Form
    {
        public ChangeDelInfoForm()
        {
            InitializeComponent();
        }

        public static string SelectedWorkerID; public static string SelectedClientID;

        public static int SelectedTableWorkers = 0; public static int SelectedTableClients = 0;

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        private void ButtonDeleteClientRow_Click(object sender, EventArgs e) // Удаление клиента
        {
            try
            {
                if (SelectedClientID != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Проверка
                    if (dialogResult == DialogResult.Yes)
                    {
                        App.WorkingWithDataBase DeleteRow = new App.WorkingWithDataBase();
                        string query = "DELETE FROM clients WHERE id =" + Convert.ToInt32(SelectedClientID) + ";";
                        DeleteRow.operationWithOneRowInDB(query);

                        SelectedClientID = "";
                        LabelSelectedClientID.Text = "Выбранная запись: -";
                        UpdateForm();
                    }
                    else
                    {
                        return; // отмена удаления
                    }
                }
                else
                {
                    MessageBox.Show("Сначала нужно выбрать запись", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDeleteWorkerRow_Click(object sender, EventArgs e) //  Удаление сотрудника
        {
            try
            {
                if (SelectedWorkerID != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Проверка
                    if (dialogResult == DialogResult.Yes)
                    {
                        App.WorkingWithDataBase DeleteRow = new App.WorkingWithDataBase();
                        string query = "DELETE FROM employees WHERE id =" + Convert.ToInt32(SelectedWorkerID) + ";";
                        DeleteRow.operationWithOneRowInDB(query);

                        SelectedWorkerID = "";
                        LabelSelectedWorkerID.Text = "Выбранная запись: -";
                        UpdateForm();
                    }
                    else
                    {
                        return; // Отмена удаления
                    }
                }
                else
                {
                    MessageBox.Show("Сначала нужно выбрать запись", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVClients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) // Для выбора записи на дгв с клиентами
        {
            try
            {
                SelectedClientID = DGVClients.SelectedCells[0].Value.ToString();
                LabelSelectedClientID.Text = "Выбранная запись: " + DGVClients.SelectedCells[1].Value.ToString() + " " + (DGVClients.SelectedCells[2].Value.ToString())[0] + '.' + (DGVClients.SelectedCells[3].Value.ToString())[0] + '.';
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVWorkers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) // Для выбора записи на дгв с сотрудниками
        {
            try
            {
                SelectedWorkerID = DGVWorkers.SelectedCells[0].Value.ToString();
                LabelSelectedWorkerID.Text = "Выбранная запись: " + DGVWorkers.SelectedCells[1].Value.ToString() + " " + (DGVWorkers.SelectedCells[2].Value.ToString())[0] + '.' + (DGVWorkers.SelectedCells[3].Value.ToString())[0] + '.';
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

                    table.Columns["firstName"].ColumnName = "Фамилия"; table.Columns["secondName"].ColumnName = "Имя";
                    table.Columns["lastName"].ColumnName = "Отчество"; table.Columns["seriesAndNumberOfPassport"].ColumnName = "Серия и номер паспорта";
                    table.Columns["placeOfResidence"].ColumnName = "Место жительства"; table.Columns["telephone"].ColumnName = "Телефон";
                    table.Columns["passportIssued"].ColumnName = "Паспорт выдан:";

                    this.DGVClients.Sort(this.DGVClients.Columns["Фамилия"], ListSortDirection.Ascending); // Сортировка по столбцу
                }

                this.Enabled = true; // Делает форму вновь активной

                SelectedWorkerID = "";
                SelectedClientID = "";

                TextBoxSearchClient.Text = "";
                TextBoxSearchEmployee.Text = "";

                LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeDelInfoForm_Load(object sender, EventArgs e) // Загрузка формы
        {
            UpdateForm();
            if (AuthorizationForm.type != "admin")
            {
                tabControl1.TabPages[1].Parent = null; // Убирает вкладку "Сотрудники"
            }
        }

        private void ChangeDelInfoForm_FormClosing(object sender, FormClosingEventArgs e) // Крестик
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) // При выборе других вкладок
        {
            try
            {
                int selectedTab = tabControl1.SelectedIndex; // Индекс выбранной вкладки
                if (selectedTab == 0)
                {
                    LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;
                }
                else if (selectedTab == 1)
                {
                    LabelCountRows.Text = "Количество записей: " + DGVWorkers.Rows.Count;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUpdateClientRow_Click(object sender, EventArgs e) // Кнопка редактирования записи о клиенте
        {
            try
            {
                if (SelectedClientID != "")
                {
                    this.Enabled = false; // Делает эту форму неактивной

                    SelectedTableWorkers = 0; SelectedTableClients = 1;

                    ChildrenFormForUpdate UpdateForm = new ChildrenFormForUpdate();
                    UpdateForm.Show();
                }
                else
                {
                    MessageBox.Show("Сначала нужно выбрать запись", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUpdateWorkerRow_Click(object sender, EventArgs e) // Кнопка редактирования записи о сотруднике
        {
            try
            {
                if (SelectedWorkerID != "")
                {
                    this.Enabled = false; // Делает эту форму неактивной

                    SelectedTableWorkers = 1; SelectedTableClients = 0;

                    ChildrenFormForUpdate UpdateForm = new ChildrenFormForUpdate();
                    UpdateForm.Show();
                }
                else
                {
                    MessageBox.Show("Сначала нужно выбрать запись", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxSearchClient_TextChanged(object sender, EventArgs e) // Поиск по фамилии клиента
        {
            try
            {
                if (TextBoxSearchClient.Text == "")
                {
                    UpdateForm();
                    LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;
                }
                else
                {
                    App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();
                    SQLiteDataAdapter adapter = GetAdapter.getAdapter("SELECT * FROM clients WHERE firstName LIKE '%" + TextBoxSearchClient.Text + "%'"); // Получить адаптер таблицы клиентов

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    DGVClients.DataSource = table;
                    DGVClients.Columns[0].Visible = false;

                    table.Columns["firstName"].ColumnName = "Фамилия"; table.Columns["secondName"].ColumnName = "Имя";
                    table.Columns["lastName"].ColumnName = "Отчество"; table.Columns["seriesAndNumberOfPassport"].ColumnName = "Серия и номер паспорта";
                    table.Columns["placeOfResidence"].ColumnName = "Место жительства"; table.Columns["telephone"].ColumnName = "Телефон";
                    table.Columns["passportIssued"].ColumnName = "Паспорт выдан:";

                    LabelCountRows.Text = "Количество записей: " + DGVClients.Rows.Count;

                    this.DGVClients.Sort(this.DGVClients.Columns["Фамилия"], ListSortDirection.Ascending); // Сортировка по столбцу
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxSearchEmployee_TextChanged(object sender, EventArgs e) // Поиск по фамилии сотрудника
        {
            try
            {
                if (TextBoxSearchEmployee.Text == "")
                {
                    UpdateForm();
                    LabelCountRows.Text = "Количество записей: " + DGVWorkers.Rows.Count;
                }
                else
                {
                    App.WorkingWithDataBase GetAdapter = new App.WorkingWithDataBase();
                    SQLiteDataAdapter adapterWorkers = GetAdapter.getAdapter("SELECT * FROM employees WHERE firstName LIKE '%" + TextBoxSearchEmployee.Text + "%'"); // Получить адаптер таблицы сотрудников

                    DataTable tableWorkers = new DataTable();
                    adapterWorkers.Fill(tableWorkers);

                    DGVWorkers.DataSource = tableWorkers;
                    DGVWorkers.Columns[0].Visible = false;

                    tableWorkers.Columns["firstName"].ColumnName = "Фамилия"; tableWorkers.Columns["secondName"].ColumnName = "Имя";
                    tableWorkers.Columns["lastName"].ColumnName = "Отчество"; tableWorkers.Columns["telephone"].ColumnName = "Телефон";
                    tableWorkers.Columns["placeOfResidence"].ColumnName = "Место жительства"; tableWorkers.Columns["post"].ColumnName = "Должность";

                    LabelCountRows.Text = "Количество записей: " + DGVWorkers.Rows.Count;

                    this.DGVWorkers.Sort(this.DGVWorkers.Columns["Фамилия"], ListSortDirection.Ascending); // Сортировка по столбцу
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxSearchEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back)) { }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBoxSearchClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar == (char)Keys.Back)) { }
            else
            {
                e.Handled = true;
            }
        }
    }
}
