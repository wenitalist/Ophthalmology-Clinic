using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace OphthalmologyClinic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static public AuthorizationForm AuthorizationForm; // Статические методы каждой формы, чтобы их можно было использовать на других формах
        static public ChangeDelInfoForm ChangeDelInfoForm;
        static public AddInfoForm AddInfoForm;
        static public AppointmentForm AppointmentForm;
        static public FormationReportsForm FormationReportsForm;
        static public ExportAndImportDBForm ExportDBForm;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // Крестик
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

        public void CreateReserveCopyDataBase() // Резервная копия БД после авторизации
        {
            try
            {
                if (AuthorizationForm.Authzw == 1)
                {
                    AuthorizationForm.Authzw += 1; // Чтобы нельзя было дюпать копии под одним пользователем

                    string mainPath = System.IO.Directory.GetCurrentDirectory();
                    string fileName = mainPath + "\\db.sqlite";
                    string time = DateTime.Now.ToString().Replace(":", "-");
                    string newNameFile = "backupdb " + time + ".sqlite";

                    File.Copy(fileName, mainPath + "\\Backups\\" + newNameFile, true);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) // Загрузка формы
        {
            try
            {
                CreateReserveCopyDataBase();

                if (AuthorizationForm.type == "admin") { }
                else
                {
                    LabelTypeAcc.Text = "Вы авторизовались как User";

                    ButtonAdd.Text = "Добавить клиента";
                    ButtonReports.Text = "Распечатать документы";
                    ButtonAppointment.Text = "Записать на приём";
                    ButtonChangeDelete.Text = "Удалить клиента или изменить его данные";
                    ButtonExportAndImport.Enabled = false;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Ошибка в работе программы: " + m.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e) // Кнопка "Назад"
        {
            AuthorizationForm = new AuthorizationForm();
            this.Hide();
            AuthorizationForm.Show();
        }

        private void ButtonAdd_Click(object sender, EventArgs e) // Кнопка добавления информаци
        {
            AddInfoForm = new AddInfoForm();
            this.Hide();
            AddInfoForm.Show();
        }

        private void ButtonChangeDelete_Click(object sender, EventArgs e) // Кнопка удаления и редактирования информаци
        {
            ChangeDelInfoForm = new ChangeDelInfoForm();
            this.Hide();
            ChangeDelInfoForm.Show();
        }

        private void ButtonAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm = new AppointmentForm();
            this.Hide();
            AppointmentForm.Show();
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            FormationReportsForm = new FormationReportsForm();
            this.Hide();
            FormationReportsForm.Show();
        }

        private void ButtonExportAndImport_Click(object sender, EventArgs e)
        {
            ExportDBForm = new ExportAndImportDBForm();
            this.Hide();
            ExportDBForm.Show();
        }
    }
}
