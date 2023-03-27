using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTasks
{
    public partial class Form1 : Form
    {
        private string connection = default;
        private NpgsqlDataAdapter adapter = default;
        private NpgsqlCommand command = default;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDB_Click(object sender, EventArgs e) => NpgsqlLogic.CreateDB(NameDB.Text, this.connection);

        private void DeleteColumn_Click(object sender, EventArgs e) => NpgsqlLogic.DeleteColumn(NameTable.Text, NameColumn.Text, this.connection);

        private void AddColumn_Click(object sender, EventArgs e) => NpgsqlLogic.AddColumn
            (NameTable.Text,NameColumn.Text,TypeData.Text,this.connection);

        private void Form1_Load(object sender, EventArgs e) =>
            this.connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private void CreateTable_Click(object sender, EventArgs e) => NpgsqlLogic.CreateTable(NameTable.Text, this.connection);

        private void AddUser_Click(object sender, EventArgs e)
        {
            NpgsqlLogic.AddUser(nameUser.Text, nameSurname.Text, userSex.Text, userContact.Text, command, connection);
            dataGridView1.DataSource = NpgsqlLogic.DisplayUserData(this.connection, this.adapter);
        }
        private void UpdateUser_Click(object sender, EventArgs e)
        {
            NpgsqlLogic.UpdateUser(nameUser.Text, nameSurname.Text, userSex.Text, userContact.Text,idNumeric.Value.ToString(), command, connection);
            dataGridView1.DataSource = NpgsqlLogic.DisplayUserData(this.connection, this.adapter);
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            NpgsqlLogic.DeleteUser(idNumeric.Value.ToString(), this.connection, this.command);
            dataGridView1.DataSource = NpgsqlLogic.DisplayUserData(this.connection, this.adapter);
        }

        private void Truncate_Click(object sender, EventArgs e)
        {
            NpgsqlLogic.TruncateTable(this.connection, this.command);
            dataGridView1.DataSource = NpgsqlLogic.DisplayUserData(this.connection, this.adapter);
        }

        private void CleanData()
        {
            nameUser.Text = null;
            nameSurname.Text = null;
            userSex.Text = null;
            userContact.Text = null;
        }

        private void Clear_Click(object sender, EventArgs e) => CleanData();

        private void refresh_Click(object sender, EventArgs e) => dataGridView1.DataSource = NpgsqlLogic.DisplayUserData(this.connection, this.adapter);
    }
}
