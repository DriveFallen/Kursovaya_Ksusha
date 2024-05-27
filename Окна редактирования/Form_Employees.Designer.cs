namespace SQLApp.Окна_редактирования
{
    partial class Form_Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView_Employees = new System.Windows.Forms.DataGridView();
            this.idEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new SQLApp.RestoranDataSet();
            this.employeesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.EmployeesTableAdapter();
            this.button_employees_delete = new System.Windows.Forms.Button();
            this.button_employees_change = new System.Windows.Forms.Button();
            this.button_employees_add = new System.Windows.Forms.Button();
            this.textBox_employees_fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_employees_id = new System.Windows.Forms.TextBox();
            this.textBox_employees_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_employees_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_employees_login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_employees_post = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(823, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(95, 35);
            this.button_back.TabIndex = 18;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView_Employees
            // 
            this.dataGridView_Employees.AutoGenerateColumns = false;
            this.dataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmployeesDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView_Employees.DataSource = this.employeesBindingSource;
            this.dataGridView_Employees.Location = new System.Drawing.Point(12, 218);
            this.dataGridView_Employees.Name = "dataGridView_Employees";
            this.dataGridView_Employees.Size = new System.Drawing.Size(906, 315);
            this.dataGridView_Employees.TabIndex = 19;
            // 
            // idEmployeesDataGridViewTextBoxColumn
            // 
            this.idEmployeesDataGridViewTextBoxColumn.DataPropertyName = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn.HeaderText = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn.Name = "idEmployeesDataGridViewTextBoxColumn";
            this.idEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // button_employees_delete
            // 
            this.button_employees_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_employees_delete.Location = new System.Drawing.Point(666, 142);
            this.button_employees_delete.Name = "button_employees_delete";
            this.button_employees_delete.Size = new System.Drawing.Size(112, 51);
            this.button_employees_delete.TabIndex = 22;
            this.button_employees_delete.Text = "Удалить";
            this.button_employees_delete.UseVisualStyleBackColor = false;
            this.button_employees_delete.Click += new System.EventHandler(this.button_employees_delete_Click);
            // 
            // button_employees_change
            // 
            this.button_employees_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_employees_change.Location = new System.Drawing.Point(666, 75);
            this.button_employees_change.Name = "button_employees_change";
            this.button_employees_change.Size = new System.Drawing.Size(112, 51);
            this.button_employees_change.TabIndex = 21;
            this.button_employees_change.Text = "Изменить";
            this.button_employees_change.UseVisualStyleBackColor = false;
            this.button_employees_change.Click += new System.EventHandler(this.button_employees_change_Click);
            // 
            // button_employees_add
            // 
            this.button_employees_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_employees_add.Location = new System.Drawing.Point(666, 11);
            this.button_employees_add.Name = "button_employees_add";
            this.button_employees_add.Size = new System.Drawing.Size(112, 51);
            this.button_employees_add.TabIndex = 20;
            this.button_employees_add.Text = "Добавить";
            this.button_employees_add.UseVisualStyleBackColor = false;
            this.button_employees_add.Click += new System.EventHandler(this.button_employees_add_Click);
            // 
            // textBox_employees_fullName
            // 
            this.textBox_employees_fullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_employees_fullName.Location = new System.Drawing.Point(16, 97);
            this.textBox_employees_fullName.Name = "textBox_employees_fullName";
            this.textBox_employees_fullName.Size = new System.Drawing.Size(279, 29);
            this.textBox_employees_fullName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Полное ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID Работника";
            // 
            // textBox_employees_id
            // 
            this.textBox_employees_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_employees_id.Location = new System.Drawing.Point(16, 33);
            this.textBox_employees_id.Name = "textBox_employees_id";
            this.textBox_employees_id.Size = new System.Drawing.Size(279, 29);
            this.textBox_employees_id.TabIndex = 43;
            // 
            // textBox_employees_number
            // 
            this.textBox_employees_number.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_employees_number.Location = new System.Drawing.Point(16, 164);
            this.textBox_employees_number.Name = "textBox_employees_number";
            this.textBox_employees_number.Size = new System.Drawing.Size(279, 29);
            this.textBox_employees_number.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Телефон";
            // 
            // textBox_employees_password
            // 
            this.textBox_employees_password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_employees_password.Location = new System.Drawing.Point(312, 164);
            this.textBox_employees_password.Name = "textBox_employees_password";
            this.textBox_employees_password.Size = new System.Drawing.Size(279, 29);
            this.textBox_employees_password.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(308, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Пароль";
            // 
            // textBox_employees_login
            // 
            this.textBox_employees_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_employees_login.Location = new System.Drawing.Point(312, 97);
            this.textBox_employees_login.Name = "textBox_employees_login";
            this.textBox_employees_login.Size = new System.Drawing.Size(279, 29);
            this.textBox_employees_login.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(308, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(308, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Должность";
            // 
            // textBox_employees_post
            // 
            this.textBox_employees_post.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_employees_post.Location = new System.Drawing.Point(312, 33);
            this.textBox_employees_post.Name = "textBox_employees_post";
            this.textBox_employees_post.Size = new System.Drawing.Size(279, 29);
            this.textBox_employees_post.TabIndex = 57;
            // 
            // Form_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(930, 545);
            this.Controls.Add(this.textBox_employees_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_employees_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_employees_post);
            this.Controls.Add(this.textBox_employees_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_employees_fullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_employees_id);
            this.Controls.Add(this.button_employees_delete);
            this.Controls.Add(this.button_employees_change);
            this.Controls.Add(this.button_employees_add);
            this.Controls.Add(this.dataGridView_Employees);
            this.Controls.Add(this.button_back);
            this.Name = "Form_Employees";
            this.Text = "Работники";
            this.Load += new System.EventHandler(this.Form_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView_Employees;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RestoranDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_employees_delete;
        private System.Windows.Forms.Button button_employees_change;
        private System.Windows.Forms.Button button_employees_add;
        private System.Windows.Forms.TextBox textBox_employees_fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_employees_id;
        private System.Windows.Forms.TextBox textBox_employees_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_employees_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_employees_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_employees_post;
    }
}