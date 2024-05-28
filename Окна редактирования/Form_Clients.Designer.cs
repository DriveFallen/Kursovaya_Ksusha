namespace SQLApp.Окна_редактирования
{
    partial class Form_Clients
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
            this.button_clients_delete = new System.Windows.Forms.Button();
            this.button_clients_change = new System.Windows.Forms.Button();
            this.button_clients_add = new System.Windows.Forms.Button();
            this.textBox_clients_fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_clients_id = new System.Windows.Forms.TextBox();
            this.dataGridView_DishesCategories = new System.Windows.Forms.DataGridView();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new SQLApp.RestoranDataSet();
            this.clientsTableAdapter = new SQLApp.RestoranDataSetTableAdapters.ClientsTableAdapter();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DishesCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_clients_delete
            // 
            this.button_clients_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_clients_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clients_delete.Location = new System.Drawing.Point(608, 293);
            this.button_clients_delete.Name = "button_clients_delete";
            this.button_clients_delete.Size = new System.Drawing.Size(106, 55);
            this.button_clients_delete.TabIndex = 24;
            this.button_clients_delete.Text = "Удалить";
            this.button_clients_delete.UseVisualStyleBackColor = false;
            this.button_clients_delete.Click += new System.EventHandler(this.button_clients_delete_Click);
            // 
            // button_clients_change
            // 
            this.button_clients_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_clients_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clients_change.Location = new System.Drawing.Point(667, 232);
            this.button_clients_change.Name = "button_clients_change";
            this.button_clients_change.Size = new System.Drawing.Size(106, 55);
            this.button_clients_change.TabIndex = 23;
            this.button_clients_change.Text = "Изменить";
            this.button_clients_change.UseVisualStyleBackColor = false;
            this.button_clients_change.Click += new System.EventHandler(this.button_clients_change_Click);
            // 
            // button_clients_add
            // 
            this.button_clients_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_clients_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clients_add.Location = new System.Drawing.Point(553, 232);
            this.button_clients_add.Name = "button_clients_add";
            this.button_clients_add.Size = new System.Drawing.Size(106, 55);
            this.button_clients_add.TabIndex = 22;
            this.button_clients_add.Text = "Добавить";
            this.button_clients_add.UseVisualStyleBackColor = false;
            this.button_clients_add.Click += new System.EventHandler(this.button_clients_add_Click);
            // 
            // textBox_clients_fullName
            // 
            this.textBox_clients_fullName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_clients_fullName.Location = new System.Drawing.Point(553, 171);
            this.textBox_clients_fullName.Name = "textBox_clients_fullName";
            this.textBox_clients_fullName.Size = new System.Drawing.Size(220, 32);
            this.textBox_clients_fullName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(549, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(549, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Клиента";
            // 
            // textBox_clients_id
            // 
            this.textBox_clients_id.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_clients_id.Location = new System.Drawing.Point(553, 92);
            this.textBox_clients_id.Name = "textBox_clients_id";
            this.textBox_clients_id.Size = new System.Drawing.Size(220, 32);
            this.textBox_clients_id.TabIndex = 17;
            // 
            // dataGridView_DishesCategories
            // 
            this.dataGridView_DishesCategories.AutoGenerateColumns = false;
            this.dataGridView_DishesCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DishesCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientsDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn});
            this.dataGridView_DishesCategories.DataSource = this.clientsBindingSource;
            this.dataGridView_DishesCategories.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_DishesCategories.Name = "dataGridView_DishesCategories";
            this.dataGridView_DishesCategories.Size = new System.Drawing.Size(507, 371);
            this.dataGridView_DishesCategories.TabIndex = 19;
            // 
            // idClientsDataGridViewTextBoxColumn
            // 
            this.idClientsDataGridViewTextBoxColumn.DataPropertyName = "IdClients";
            this.idClientsDataGridViewTextBoxColumn.HeaderText = "IdClients";
            this.idClientsDataGridViewTextBoxColumn.Name = "idClientsDataGridViewTextBoxColumn";
            this.idClientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(695, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(95, 35);
            this.button_back.TabIndex = 25;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(801, 397);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_clients_delete);
            this.Controls.Add(this.button_clients_change);
            this.Controls.Add(this.button_clients_add);
            this.Controls.Add(this.textBox_clients_fullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_clients_id);
            this.Controls.Add(this.dataGridView_DishesCategories);
            this.Name = "Form_Clients";
            this.Text = "Form_Clients";
            this.Load += new System.EventHandler(this.Form_Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DishesCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clients_delete;
        private System.Windows.Forms.Button button_clients_change;
        private System.Windows.Forms.Button button_clients_add;
        private System.Windows.Forms.TextBox textBox_clients_fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_clients_id;
        private System.Windows.Forms.DataGridView dataGridView_DishesCategories;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RestoranDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_back;
    }
}