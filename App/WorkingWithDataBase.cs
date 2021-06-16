using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SQLite;

namespace OphthalmologyClinic.App
{
    class WorkingWithDataBase
    {
        public int CountRowsInTable(string query) // Для подсчета количества строк в любой таблице
        {
            SQLiteConnection connect = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
            SQLiteCommand command = new SQLiteCommand(query, connect);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            int answer = table.Rows.Count;

            return answer;
        }
        public SQLiteDataAdapter getAdapter(string query) // Использую для вывода в datagridview и не только
        {
            SQLiteConnection connect = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
            SQLiteCommand command = new SQLiteCommand(query, connect);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            return adapter;
        }
        public void operationWithOneRowInDB(string query) // Для выполнения операций типа: удаление записи, обновление, добавления
        {
            SQLiteConnection connect = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
            connect.Open();
            SQLiteCommand command = new SQLiteCommand(query, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }
        public string[] coincidence(string login, string hash) // coincidence - совпадение
        {
            SQLiteConnection connect = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM users WHERE login='" + login + "' AND password='" + hash + "'", connect);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                string[] array = new string[1] { "false" };
                return array;
            }
            else
            {
                string[] array = new string[2] { "true", table.Rows[0].ItemArray.GetValue(3).ToString() };
                return array;
            }
        }
        public bool coincidencePriChangeAndAddRow(string query) // Для проверки совпадний при изменении или добавлении новой записи, чтобы нельзя было создать 2 одинаковых сотрудников или клиентов
        {
            SQLiteConnection connect = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
            SQLiteCommand command = new SQLiteCommand(query, connect);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0) // Если строк больше нуля
            {
                return true;
            }
            else // Если количество строк 0
            {
                return false;
            }
        }
    }
}
