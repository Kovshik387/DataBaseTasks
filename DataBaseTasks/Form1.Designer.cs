namespace DataBaseTasks
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddColumn = new System.Windows.Forms.Button();
            this.DeleteColumn = new System.Windows.Forms.Button();
            this.NameTable = new System.Windows.Forms.TextBox();
            this.TypeData = new System.Windows.Forms.TextBox();
            this.NameColumn = new System.Windows.Forms.TextBox();
            this.CreateDB = new System.Windows.Forms.Button();
            this.NameDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateTable = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refresh = new System.Windows.Forms.Button();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.Clear = new System.Windows.Forms.Button();
            this.Truncate = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.userSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userContact = new System.Windows.Forms.TextBox();
            this.nameSurname = new System.Windows.Forms.TextBox();
            this.nameUser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ExportToWord = new System.Windows.Forms.Button();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.ExecuteTask11 = new System.Windows.Forms.Button();
            this.dataGridTask11 = new System.Windows.Forms.DataGridView();
            this.ExecuteTask12 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask11)).BeginInit();
            this.SuspendLayout();
            // 
            // AddColumn
            // 
            this.AddColumn.Location = new System.Drawing.Point(6, 210);
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(151, 23);
            this.AddColumn.TabIndex = 0;
            this.AddColumn.Text = "AddColumn";
            this.AddColumn.UseVisualStyleBackColor = true;
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.Location = new System.Drawing.Point(6, 181);
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Size = new System.Drawing.Size(151, 23);
            this.DeleteColumn.TabIndex = 1;
            this.DeleteColumn.Text = "DeleteColumn";
            this.DeleteColumn.UseVisualStyleBackColor = true;
            this.DeleteColumn.Click += new System.EventHandler(this.DeleteColumn_Click);
            // 
            // NameTable
            // 
            this.NameTable.Location = new System.Drawing.Point(6, 6);
            this.NameTable.Name = "NameTable";
            this.NameTable.Size = new System.Drawing.Size(151, 20);
            this.NameTable.TabIndex = 2;
            // 
            // TypeData
            // 
            this.TypeData.Location = new System.Drawing.Point(6, 32);
            this.TypeData.Name = "TypeData";
            this.TypeData.Size = new System.Drawing.Size(151, 20);
            this.TypeData.TabIndex = 3;
            // 
            // NameColumn
            // 
            this.NameColumn.Location = new System.Drawing.Point(6, 58);
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Size = new System.Drawing.Size(151, 20);
            this.NameColumn.TabIndex = 4;
            // 
            // CreateDB
            // 
            this.CreateDB.Location = new System.Drawing.Point(6, 152);
            this.CreateDB.Name = "CreateDB";
            this.CreateDB.Size = new System.Drawing.Size(151, 23);
            this.CreateDB.TabIndex = 5;
            this.CreateDB.Text = "CreateDB";
            this.CreateDB.UseVisualStyleBackColor = true;
            this.CreateDB.Click += new System.EventHandler(this.CreateDB_Click);
            // 
            // NameDB
            // 
            this.NameDB.Location = new System.Drawing.Point(6, 84);
            this.NameDB.Name = "NameDB";
            this.NameDB.Size = new System.Drawing.Size(151, 20);
            this.NameDB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя Таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Атрибут";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "База данных";
            // 
            // CreateTable
            // 
            this.CreateTable.Location = new System.Drawing.Point(6, 123);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(151, 23);
            this.CreateTable.TabIndex = 11;
            this.CreateTable.Text = "CreateTable";
            this.CreateTable.UseVisualStyleBackColor = true;
            this.CreateTable.Click += new System.EventHandler(this.CreateTable_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 410);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NameTable);
            this.tabPage1.Controls.Add(this.CreateTable);
            this.tabPage1.Controls.Add(this.AddColumn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DeleteColumn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TypeData);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NameColumn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CreateDB);
            this.tabPage1.Controls.Add(this.NameDB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.refresh);
            this.tabPage2.Controls.Add(this.idNumeric);
            this.tabPage2.Controls.Add(this.Clear);
            this.tabPage2.Controls.Add(this.Truncate);
            this.tabPage2.Controls.Add(this.UpdateUser);
            this.tabPage2.Controls.Add(this.DeleteUser);
            this.tabPage2.Controls.Add(this.AddUser);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.userSex);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.userContact);
            this.tabPage2.Controls.Add(this.nameSurname);
            this.tabPage2.Controls.Add(this.nameUser);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(556, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Манипуляция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(302, 352);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 16;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // idNumeric
            // 
            this.idNumeric.Location = new System.Drawing.Point(464, 294);
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.Size = new System.Drawing.Size(75, 20);
            this.idNumeric.TabIndex = 15;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(383, 323);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Truncate
            // 
            this.Truncate.Location = new System.Drawing.Point(383, 352);
            this.Truncate.Name = "Truncate";
            this.Truncate.Size = new System.Drawing.Size(75, 23);
            this.Truncate.TabIndex = 13;
            this.Truncate.Text = "Trunc";
            this.Truncate.UseVisualStyleBackColor = true;
            this.Truncate.Click += new System.EventHandler(this.Truncate_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.Location = new System.Drawing.Point(464, 323);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(75, 23);
            this.UpdateUser.TabIndex = 12;
            this.UpdateUser.Text = "Update";
            this.UpdateUser.UseVisualStyleBackColor = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(464, 352);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.DeleteUser.TabIndex = 11;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(383, 291);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 10;
            this.AddUser.Text = "Add";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Пол";
            // 
            // userSex
            // 
            this.userSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userSex.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.userSex.Location = new System.Drawing.Point(219, 294);
            this.userSex.Name = "userSex";
            this.userSex.Size = new System.Drawing.Size(67, 21);
            this.userSex.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Контактные данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя";
            // 
            // userContact
            // 
            this.userContact.Location = new System.Drawing.Point(6, 347);
            this.userContact.Name = "userContact";
            this.userContact.Size = new System.Drawing.Size(129, 20);
            this.userContact.TabIndex = 3;
            // 
            // nameSurname
            // 
            this.nameSurname.Location = new System.Drawing.Point(6, 321);
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.Size = new System.Drawing.Size(129, 20);
            this.nameSurname.TabIndex = 2;
            // 
            // nameUser
            // 
            this.nameUser.Location = new System.Drawing.Point(6, 295);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(129, 20);
            this.nameUser.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ExecuteTask12);
            this.tabPage3.Controls.Add(this.ExportToWord);
            this.tabPage3.Controls.Add(this.ExportToExcel);
            this.tabPage3.Controls.Add(this.ExecuteTask11);
            this.tabPage3.Controls.Add(this.dataGridTask11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(556, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Group/Having";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ExportToWord
            // 
            this.ExportToWord.Location = new System.Drawing.Point(333, 358);
            this.ExportToWord.Name = "ExportToWord";
            this.ExportToWord.Size = new System.Drawing.Size(109, 23);
            this.ExportToWord.TabIndex = 3;
            this.ExportToWord.Text = "Сохранить Word";
            this.ExportToWord.UseVisualStyleBackColor = true;
            this.ExportToWord.Click += new System.EventHandler(this.ExportToWord_Click);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Location = new System.Drawing.Point(448, 358);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(100, 23);
            this.ExportToExcel.TabIndex = 2;
            this.ExportToExcel.Text = "Сохранить Excel";
            this.ExportToExcel.UseVisualStyleBackColor = true;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // ExecuteTask11
            // 
            this.ExecuteTask11.Location = new System.Drawing.Point(3, 358);
            this.ExecuteTask11.Name = "ExecuteTask11";
            this.ExecuteTask11.Size = new System.Drawing.Size(97, 23);
            this.ExecuteTask11.TabIndex = 1;
            this.ExecuteTask11.Text = "Запрос";
            this.ExecuteTask11.UseVisualStyleBackColor = true;
            this.ExecuteTask11.Click += new System.EventHandler(this.ExecuteTask11_Click);
            // 
            // dataGridTask11
            // 
            this.dataGridTask11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTask11.Location = new System.Drawing.Point(3, 3);
            this.dataGridTask11.Name = "dataGridTask11";
            this.dataGridTask11.Size = new System.Drawing.Size(545, 351);
            this.dataGridTask11.TabIndex = 0;
            // 
            // ExecuteTask12
            // 
            this.ExecuteTask12.Location = new System.Drawing.Point(106, 358);
            this.ExecuteTask12.Name = "ExecuteTask12";
            this.ExecuteTask12.Size = new System.Drawing.Size(97, 23);
            this.ExecuteTask12.TabIndex = 4;
            this.ExecuteTask12.Text = "Запрос Having";
            this.ExecuteTask12.UseVisualStyleBackColor = true;
            this.ExecuteTask12.Click += new System.EventHandler(this.ExecuteTask12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 423);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddColumn;
        private System.Windows.Forms.Button DeleteColumn;
        private System.Windows.Forms.TextBox NameTable;
        private System.Windows.Forms.TextBox TypeData;
        private System.Windows.Forms.TextBox NameColumn;
        private System.Windows.Forms.Button CreateDB;
        private System.Windows.Forms.TextBox NameDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox userSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userContact;
        private System.Windows.Forms.TextBox nameSurname;
        private System.Windows.Forms.TextBox nameUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Truncate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridTask11;
        private System.Windows.Forms.Button ExecuteTask11;
        private System.Windows.Forms.Button ExportToExcel;
        private System.Windows.Forms.Button ExportToWord;
        private System.Windows.Forms.Button ExecuteTask12;
    }
}

