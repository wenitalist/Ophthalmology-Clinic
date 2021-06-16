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
using Word = Microsoft.Office.Interop.Word;

namespace OphthalmologyClinic
{
    public partial class FormationReportsForm : Form
    {
        public FormationReportsForm()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            this.Hide();
            MainForm.Show();
        }

        public static string SelectedRowID = "";
        string path = Application.StartupPath;

        public void UpdateForm()
        {
            try
            {
                App.WorkingWithDataBase WorkWithDB = new App.WorkingWithDataBase();
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter;

                //string date = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();

                adapter = WorkWithDB.getAdapter("SELECT id," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM clients WHERE appointments.idClient = clients.id)," +
                                                "operation," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "date," +
                                                "time," +
                                                "price," +
                                                "(SELECT placeOfResidence FROM clients WHERE appointments.idClient = clients.id)," + // Эти три не выводятся в ДГВ
                                                "(SELECT passportIssued FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT seriesAndNumberOfPassport FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT firstName FROM clients WHERE appointments.idClient = clients.id)," + // 6 строки с именами и отчествами для документов
                                                "(SELECT secondName FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT lastName FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT firstName FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "(SELECT secondName FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "(SELECT lastName FROM employees WHERE appointments.idEmployee = employees.id) " +
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

                DGVAppointments.Columns[7].Visible = false; // Место жительства клиента
                DGVAppointments.Columns[8].Visible = false; // Паспорт выдан
                DGVAppointments.Columns[9].Visible = false; // Серия и номер паспорта

                DGVAppointments.Columns[10].Visible = false; // Фамилия клиента
                DGVAppointments.Columns[11].Visible = false; // Имя клиента
                DGVAppointments.Columns[12].Visible = false; // Отчество сотрудника

                DGVAppointments.Columns[13].Visible = false; // Фамилия сотрудника
                DGVAppointments.Columns[14].Visible = false; // Имя сотрудника
                DGVAppointments.Columns[15].Visible = false; // Отчество сотрудника

                DGVAppointments.Columns[1].Width = 25;
                DGVAppointments.Columns[2].Width = 100;
                DGVAppointments.Columns[3].Width = 25;

                DGVAppointments.Columns[4].Width = 20;
                DGVAppointments.Columns[5].Width = 20;
                DGVAppointments.Columns[6].Width = 100;

                CountRows.Text = "Количество записей: " + DGVAppointments.Rows.Count.ToString();

                this.DGVAppointments.Sort(this.DGVAppointments.Columns["Дата"], ListSortDirection.Ascending); // Сортировка по столбцу
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateDogovor() // Функция создающая договор
        {
            try
            {
                App.GetMonth getMonth = new App.GetMonth();

                string day = DateTime.Today.Day.ToString();
                string month = getMonth.Month(DateTime.Today.Month.ToString());
                string year = (DateTime.Today.Year.ToString())[3].ToString();

                object start; object end;

                Word.Application Application = new Word.Application();
                object missing = System.Reflection.Missing.Value;
                Word.Document document = Application.Documents.Open(path + "\\dogovor.docx", ref missing, ref missing, ref missing, ref missing);

                start = 9084; end = 9084; // Диапазон для расшифровки росписи клиента
                Word.Range rospisclient = document.Range(ref start, ref end);
                rospisclient.Text = DGVAppointments.SelectedCells[1].Value.ToString();

                start = 9078; end = 9078; // Диапазон для расшифровки росписи сотрудника
                Word.Range rospisemployee = document.Range(ref start, ref end);
                rospisemployee.Text = DGVAppointments.SelectedCells[3].Value.ToString();

                start = 8985; end = 8985; // Диапазон для адреса
                Word.Range telephone = document.Range(ref start, ref end);
                telephone.Text = DGVAppointments.SelectedCells[7].Value.ToString();

                start = 8977; end = 8977; // Диапазон для кем выдан паспорт
                Word.Range passportIssued = document.Range(ref start, ref end);
                passportIssued.Text = DGVAppointments.SelectedCells[8].Value.ToString();

                start = 8969; end = 8969; // Диапазон для номера паспорта
                Word.Range NumberPassport = document.Range(ref start, ref end);
                NumberPassport.Text = DGVAppointments.SelectedCells[9].Value.ToString();

                start = 8949; end = 8949; // Диапазон для ФИО
                Word.Range FIO = document.Range(ref start, ref end);
                FIO.Text = DGVAppointments.SelectedCells[10].Value.ToString() + '.' + DGVAppointments.SelectedCells[11].Value.ToString() + '.' + DGVAppointments.SelectedCells[12].Value.ToString();

                start = 594; end = 594; // Диапазон для ФИО в начале документа
                Word.Range begin = document.Range(ref start, ref end);
                begin.Text = DGVAppointments.SelectedCells[10].Value.ToString() + '.' + DGVAppointments.SelectedCells[11].Value.ToString() + '.' + DGVAppointments.SelectedCells[12].Value.ToString();

                start = 73; end = 73; // Диапазон для года
                Word.Range yea = document.Range(ref start, ref end);
                yea.Text = year;

                start = 69; end = 69; // Диапазон для месяца
                Word.Range mesyac = document.Range(ref start, ref end);
                mesyac.Text = month;

                start = 68; end = 68; // Диапазон для числа
                Word.Range number = document.Range(ref start, ref end);
                number.Text = day;

                //document.Save();
                document.PrintOut(); // Печать документа

                document.Close(ref missing, ref missing, ref missing); // Закрытие приложения и процесса
                document = null;
                Application.Quit(ref missing, ref missing, ref missing);
                Application = null;

                CreateListWithOperations();
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateListWithOperations() // Функция создающая план-счет
        {
            try
            {
                object start = 0; object end = 0;

                Word.Application Application = new Word.Application();
                object missing = System.Reflection.Missing.Value;
                Word.Document document = Application.Documents.Open(path + "\\plan.docx", ref missing, ref missing, ref missing, ref missing);

                start = 66; end = 66; // Диапазон для времени
                Word.Range time = document.Range(ref start, ref end);
                time.Text = DGVAppointments.SelectedCells[5].Value.ToString();

                start = 58; end = 58; // Диапазон для даты
                Word.Range date = document.Range(ref start, ref end);
                date.Text = DGVAppointments.SelectedCells[4].Value.ToString();

                start = 50; end = 50; // Диапазон для правого столбца
                Word.Range rightColumn = document.Range(ref start, ref end);
                rightColumn.Text = DGVAppointments.SelectedCells[6].Value.ToString();

                start = 49; end = 49; // Диапазон для левого столбца
                Word.Range leftColumn = document.Range(ref start, ref end);
                leftColumn.Text = DGVAppointments.SelectedCells[2].Value.ToString();

                start = 26; end = 26; // Диапазон для пациента
                Word.Range patient = document.Range(ref start, ref end);
                patient.Text = DGVAppointments.SelectedCells[1].Value.ToString();

                start = 16; end = 16; // Диапазон для врача
                Word.Range doctor = document.Range(ref start, ref end);
                doctor.Text = DGVAppointments.SelectedCells[3].Value.ToString();

                //document.Save();
                document.PrintOut(); // Печать документа

                document.Close(ref missing, ref missing, ref missing); // Закрытие приложения и процесса
                document = null;
                Application.Quit(ref missing, ref missing, ref missing);
                Application = null;
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateDocuments_Click(object sender, EventArgs e) // Кнопка "Рассчпечатать документы"
        {
            try
            {
                if (SelectedRowID != "")
                {
                    CreateDogovor();

                    MessageBox.Show("Документы отправлены на печать", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormationReportsForm_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Отмена поиска");

            UpdateForm();
        }

        private void DGVAppointments_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectedRowID = DGVAppointments.SelectedCells[0].Value.ToString();
                LabelSelectedRow.Text = "Выбранная запись: " + DGVAppointments.SelectedCells[1].Value.ToString() + ' ' + DGVAppointments.SelectedCells[4].Value.ToString() + ' ' + DGVAppointments.SelectedCells[5].Value.ToString();
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormationReportsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                string day = dateTimePicker1.Value.Day.ToString(); if (day.Length == 1) { day = "0" + day; }
                string month = dateTimePicker1.Value.Month.ToString(); if (month.Length == 1) { month = "0" + month; }
                string year = dateTimePicker1.Value.Year.ToString();

                string date = day + '.' + month + '.' + year;

                App.WorkingWithDataBase WorkWithDB = new App.WorkingWithDataBase();
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter;

                //string date = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();

                adapter = WorkWithDB.getAdapter("SELECT id," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM clients WHERE appointments.idClient = clients.id)," +
                                                "operation," +
                                                "(SELECT firstName || ' ' || SUBSTR(secondName, 1, 1) || '.' || SUBSTR(lastName, 1, 1) || '.' FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "date," +
                                                "time," +
                                                "price," +
                                                "(SELECT placeOfResidence FROM clients WHERE appointments.idClient = clients.id)," + // Эти три не выводятся в ДГВ
                                                "(SELECT passportIssued FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT seriesAndNumberOfPassport FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT firstName FROM clients WHERE appointments.idClient = clients.id)," + // 6 строки с именами и отчествами для документов
                                                "(SELECT secondName FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT lastName FROM clients WHERE appointments.idClient = clients.id)," +
                                                "(SELECT firstName FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "(SELECT secondName FROM employees WHERE appointments.idEmployee = employees.id)," +
                                                "(SELECT lastName FROM employees WHERE appointments.idEmployee = employees.id) " +
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

                DGVAppointments.Columns[7].Visible = false; // Место жительства клиента
                DGVAppointments.Columns[8].Visible = false; // Паспорт выдан
                DGVAppointments.Columns[9].Visible = false; // Серия и номер паспорта

                DGVAppointments.Columns[10].Visible = false; // Фамилия клиента
                DGVAppointments.Columns[11].Visible = false; // Имя клиента
                DGVAppointments.Columns[12].Visible = false; // Отчество сотрудника

                DGVAppointments.Columns[13].Visible = false; // Фамилия сотрудника
                DGVAppointments.Columns[14].Visible = false; // Имя сотрудника
                DGVAppointments.Columns[15].Visible = false; // Отчество сотрудника

                DGVAppointments.Columns[1].Width = 25;
                DGVAppointments.Columns[2].Width = 100;
                DGVAppointments.Columns[3].Width = 25;

                DGVAppointments.Columns[4].Width = 20;
                DGVAppointments.Columns[5].Width = 20;
                DGVAppointments.Columns[6].Width = 100;

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

        private void button1_Click(object sender, EventArgs e) // Отмена поиска
        {
            UpdateForm();
        }
    }
}
