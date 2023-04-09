using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTasks
{
    internal class NpgsqlLogic
    {
        private NpgsqlDataAdapter adapter = default;
        private NpgsqlCommand command = default;
        public static void AddColumn(string tableName, string columnName,string type,string connectionString)
        {
            
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string textCommand = "alter table " + tableName + " add " + columnName + " " + type;
                NpgsqlCommand command = new NpgsqlCommand(textCommand, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Команда выполнена успешно:\n" + textCommand + "\n");
            }
        }

        public static void DeleteColumn(string tableName, string columnName, string connectionString)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string textCommand = "alter table " + tableName + " drop column " + columnName;
                NpgsqlCommand command = new NpgsqlCommand(textCommand, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Команда выполнена успешно:\n" + textCommand + "\n");
            }
        }

        public static void CreateDB(string NameDB, string connectionString)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string textCommand = "create database " + NameDB;
                NpgsqlCommand command = new NpgsqlCommand(textCommand, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Команда выполнена успешно:\n" + textCommand + "\n");
            }
        }

        public static void CreateTable(string tableName, string connectionString)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string textCommand = "create table " + tableName + "()";
                NpgsqlCommand command = new NpgsqlCommand(textCommand, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Команда выполнена успешно:\n" + textCommand + "\n");
            }
        }


        //Task2

        public static DataTable DisplayUserData(string connectionString, NpgsqlDataAdapter adapter)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                
                adapter = new NpgsqlDataAdapter("select * from users", connection);
                adapter.Fill(dataTable);

                connection.Close();
            }
            return dataTable;
        }

        public static void AddUser(string userName,string userSurname, string sex, string contact, NpgsqlCommand command, string connectionString)
        {
            if (userName == "" || contact == "")
            {
                Console.WriteLine("Что-то пошло не так...");
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                command = new NpgsqlCommand("insert into users (Name, SurName, Sex, Contact) values (@userName, @userSurname, @sex, @contact)",connection);
                connection.Open();

                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@userSurname", userSurname);
                command.Parameters.AddWithValue("@sex", sex);
                command.Parameters.AddWithValue("@contact", contact);

                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Команда выполнена успешно");
            }
        }

        public static void TruncateTable(string connectionString, NpgsqlCommand command)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                command = new NpgsqlCommand("truncate users restart identity", connection);
                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Команда выполнена успешно");
            }
        }

        public static void DeleteUser(string id, string connectionString, NpgsqlCommand command)
        {
            if (id == null)
            {
                Console.WriteLine("Что-то пошло не так");
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                command = new NpgsqlCommand("delete from users where ID_U = @id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", int.Parse(id));
                command.ExecuteNonQuery();

                connection.Close();

                Console.WriteLine("Команда выполнена успешно");
            }
        }

        public static void UpdateUser(string userName, string userSurname, string sex, string contact, string id, NpgsqlCommand command, string connectionString)
        {
            if (userName == "" || contact == "")
            {
                Console.WriteLine("Что-то пошло не так...");
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                command = new NpgsqlCommand("update users set Name = @userName, SurName = @userSurname, Sex = @sex, Contact = @contact where @id = ID_U", connection);
                connection.Open();

                command.Parameters.AddWithValue("@id", int.Parse(id));
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@userSurname", userSurname);
                command.Parameters.AddWithValue("@sex", sex);
                command.Parameters.AddWithValue("@contact", contact);

                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Команда выполнена успешно");
            }
        }
    }
}
