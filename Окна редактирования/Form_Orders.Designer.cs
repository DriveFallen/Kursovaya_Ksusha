namespace SQLApp.Окна_редактирования
{
    partial class Form_Orders
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
            this.dataGridView_statusPreOrders = new System.Windows.Forms.DataGridView();
            this.idStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPreOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new SQLApp.RestoranDataSet();
            this.dataGridView_preOrders = new System.Windows.Forms.DataGridView();
            this.idOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDishesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.idOrdersDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTablesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusPreOrdersTableAdapter = new SQLApp.RestoranDataSetTableAdapters.StatusPreOrdersTableAdapter();
            this.preOrdersTableAdapter = new SQLApp.RestoranDataSetTableAdapters.PreOrdersTableAdapter();
            this.ordersTableAdapter = new SQLApp.RestoranDataSetTableAdapters.OrdersTableAdapter();
            this.button_back = new System.Windows.Forms.Button();
            this.button_statusPreOrders_delete = new System.Windows.Forms.Button();
            this.button_statusPreOrders_change = new System.Windows.Forms.Button();
            this.button_statusPreOrders_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_statusPreOrders_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_preOrders_idOrders = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_preOrders_delete = new System.Windows.Forms.Button();
            this.button_preOrders_change = new System.Windows.Forms.Button();
            this.button_preOrders_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_orders_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_orders_numberTable = new System.Windows.Forms.TextBox();
            this.button_orders_delete = new System.Windows.Forms.Button();
            this.button_orders_change = new System.Windows.Forms.Button();
            this.button_orders_add = new System.Windows.Forms.Button();
            this.numericUpDown_preOrders_quantity = new System.Windows.Forms.NumericUpDown();
            this.comboBox_preOrders_dishes = new System.Windows.Forms.ComboBox();
            this.comboBox_preOrders_status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_orders_dateTime = new System.Windows.Forms.DateTimePicker();
            this.comboBox_orders_employer = new System.Windows.Forms.ComboBox();
            this.comboBox_orders_client = new System.Windows.Forms.ComboBox();
            this.textBox_statusPreOrders_nameStatus = new System.Windows.Forms.TextBox();
            this.dataGridView_dishes = new System.Windows.Forms.DataGridView();
            this.idDishesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDishesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.DishesTableAdapter();
            this.dataGridView_employers = new System.Windows.Forms.DataGridView();
            this.idEmployeesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.EmployeesTableAdapter();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.idClientsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new SQLApp.RestoranDataSetTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_statusPreOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPreOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_preOrders_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_statusPreOrders
            // 
            this.dataGridView_statusPreOrders.AutoGenerateColumns = false;
            this.dataGridView_statusPreOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_statusPreOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStatusDataGridViewTextBoxColumn,
            this.nameStatusDataGridViewTextBoxColumn});
            this.dataGridView_statusPreOrders.DataSource = this.statusPreOrdersBindingSource;
            this.dataGridView_statusPreOrders.Location = new System.Drawing.Point(14, 355);
            this.dataGridView_statusPreOrders.Name = "dataGridView_statusPreOrders";
            this.dataGridView_statusPreOrders.Size = new System.Drawing.Size(256, 401);
            this.dataGridView_statusPreOrders.TabIndex = 9;
            // 
            // idStatusDataGridViewTextBoxColumn
            // 
            this.idStatusDataGridViewTextBoxColumn.DataPropertyName = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn.HeaderText = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn.Name = "idStatusDataGridViewTextBoxColumn";
            this.idStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameStatusDataGridViewTextBoxColumn
            // 
            this.nameStatusDataGridViewTextBoxColumn.DataPropertyName = "NameStatus";
            this.nameStatusDataGridViewTextBoxColumn.HeaderText = "NameStatus";
            this.nameStatusDataGridViewTextBoxColumn.Name = "nameStatusDataGridViewTextBoxColumn";
            // 
            // statusPreOrdersBindingSource
            // 
            this.statusPreOrdersBindingSource.DataMember = "StatusPreOrders";
            this.statusPreOrdersBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_preOrders
            // 
            this.dataGridView_preOrders.AutoGenerateColumns = false;
            this.dataGridView_preOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_preOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrdersDataGridViewTextBoxColumn,
            this.idDishesDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.idStatusDataGridViewTextBoxColumn1});
            this.dataGridView_preOrders.DataSource = this.preOrdersBindingSource;
            this.dataGridView_preOrders.Location = new System.Drawing.Point(276, 355);
            this.dataGridView_preOrders.Name = "dataGridView_preOrders";
            this.dataGridView_preOrders.Size = new System.Drawing.Size(471, 401);
            this.dataGridView_preOrders.TabIndex = 10;
            // 
            // idOrdersDataGridViewTextBoxColumn
            // 
            this.idOrdersDataGridViewTextBoxColumn.DataPropertyName = "IdOrders";
            this.idOrdersDataGridViewTextBoxColumn.HeaderText = "IdOrders";
            this.idOrdersDataGridViewTextBoxColumn.Name = "idOrdersDataGridViewTextBoxColumn";
            // 
            // idDishesDataGridViewTextBoxColumn
            // 
            this.idDishesDataGridViewTextBoxColumn.DataPropertyName = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn.HeaderText = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn.Name = "idDishesDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // idStatusDataGridViewTextBoxColumn1
            // 
            this.idStatusDataGridViewTextBoxColumn1.DataPropertyName = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn1.HeaderText = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn1.Name = "idStatusDataGridViewTextBoxColumn1";
            // 
            // preOrdersBindingSource
            // 
            this.preOrdersBindingSource.DataMember = "PreOrders";
            this.preOrdersBindingSource.DataSource = this.restoranDataSet;
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.AutoGenerateColumns = false;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrdersDataGridViewTextBoxColumn1,
            this.dateTimeOrdersDataGridViewTextBoxColumn,
            this.idEmployeesDataGridViewTextBoxColumn,
            this.idClientsDataGridViewTextBoxColumn,
            this.numberTablesDataGridViewTextBoxColumn,
            this.priceOrdersDataGridViewTextBoxColumn});
            this.dataGridView_orders.DataSource = this.ordersBindingSource;
            this.dataGridView_orders.Location = new System.Drawing.Point(753, 355);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.Size = new System.Drawing.Size(712, 401);
            this.dataGridView_orders.TabIndex = 11;
            // 
            // idOrdersDataGridViewTextBoxColumn1
            // 
            this.idOrdersDataGridViewTextBoxColumn1.DataPropertyName = "IdOrders";
            this.idOrdersDataGridViewTextBoxColumn1.HeaderText = "IdOrders";
            this.idOrdersDataGridViewTextBoxColumn1.Name = "idOrdersDataGridViewTextBoxColumn1";
            this.idOrdersDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateTimeOrdersDataGridViewTextBoxColumn
            // 
            this.dateTimeOrdersDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOrders";
            this.dateTimeOrdersDataGridViewTextBoxColumn.HeaderText = "DateTimeOrders";
            this.dateTimeOrdersDataGridViewTextBoxColumn.Name = "dateTimeOrdersDataGridViewTextBoxColumn";
            // 
            // idEmployeesDataGridViewTextBoxColumn
            // 
            this.idEmployeesDataGridViewTextBoxColumn.DataPropertyName = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn.HeaderText = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn.Name = "idEmployeesDataGridViewTextBoxColumn";
            // 
            // idClientsDataGridViewTextBoxColumn
            // 
            this.idClientsDataGridViewTextBoxColumn.DataPropertyName = "IdClients";
            this.idClientsDataGridViewTextBoxColumn.HeaderText = "IdClients";
            this.idClientsDataGridViewTextBoxColumn.Name = "idClientsDataGridViewTextBoxColumn";
            // 
            // numberTablesDataGridViewTextBoxColumn
            // 
            this.numberTablesDataGridViewTextBoxColumn.DataPropertyName = "NumberTables";
            this.numberTablesDataGridViewTextBoxColumn.HeaderText = "NumberTables";
            this.numberTablesDataGridViewTextBoxColumn.Name = "numberTablesDataGridViewTextBoxColumn";
            // 
            // priceOrdersDataGridViewTextBoxColumn
            // 
            this.priceOrdersDataGridViewTextBoxColumn.DataPropertyName = "PriceOrders";
            this.priceOrdersDataGridViewTextBoxColumn.HeaderText = "PriceOrders";
            this.priceOrdersDataGridViewTextBoxColumn.Name = "priceOrdersDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.restoranDataSet;
            // 
            // statusPreOrdersTableAdapter
            // 
            this.statusPreOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // preOrdersTableAdapter
            // 
            this.preOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(1371, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(95, 35);
            this.button_back.TabIndex = 33;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_statusPreOrders_delete
            // 
            this.button_statusPreOrders_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_statusPreOrders_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_statusPreOrders_delete.Location = new System.Drawing.Point(75, 206);
            this.button_statusPreOrders_delete.Name = "button_statusPreOrders_delete";
            this.button_statusPreOrders_delete.Size = new System.Drawing.Size(88, 32);
            this.button_statusPreOrders_delete.TabIndex = 32;
            this.button_statusPreOrders_delete.Text = "Удалить";
            this.button_statusPreOrders_delete.UseVisualStyleBackColor = false;
            this.button_statusPreOrders_delete.Click += new System.EventHandler(this.button_statusPreOrders_delete_Click);
            // 
            // button_statusPreOrders_change
            // 
            this.button_statusPreOrders_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_statusPreOrders_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_statusPreOrders_change.Location = new System.Drawing.Point(128, 158);
            this.button_statusPreOrders_change.Name = "button_statusPreOrders_change";
            this.button_statusPreOrders_change.Size = new System.Drawing.Size(88, 32);
            this.button_statusPreOrders_change.TabIndex = 31;
            this.button_statusPreOrders_change.Text = "Изменить";
            this.button_statusPreOrders_change.UseVisualStyleBackColor = false;
            this.button_statusPreOrders_change.Click += new System.EventHandler(this.button_statusPreOrders_change_Click);
            // 
            // button_statusPreOrders_add
            // 
            this.button_statusPreOrders_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_statusPreOrders_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_statusPreOrders_add.Location = new System.Drawing.Point(24, 158);
            this.button_statusPreOrders_add.Name = "button_statusPreOrders_add";
            this.button_statusPreOrders_add.Size = new System.Drawing.Size(88, 32);
            this.button_statusPreOrders_add.TabIndex = 30;
            this.button_statusPreOrders_add.Text = "Добавить";
            this.button_statusPreOrders_add.UseVisualStyleBackColor = false;
            this.button_statusPreOrders_add.Click += new System.EventHandler(this.button_statusPreOrders_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Название статуса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Статуса";
            // 
            // textBox_statusPreOrders_id
            // 
            this.textBox_statusPreOrders_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_statusPreOrders_id.Location = new System.Drawing.Point(13, 36);
            this.textBox_statusPreOrders_id.Name = "textBox_statusPreOrders_id";
            this.textBox_statusPreOrders_id.Size = new System.Drawing.Size(220, 29);
            this.textBox_statusPreOrders_id.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(272, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID Заказа";
            // 
            // textBox_preOrders_idOrders
            // 
            this.textBox_preOrders_idOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_preOrders_idOrders.Location = new System.Drawing.Point(277, 36);
            this.textBox_preOrders_idOrders.Name = "textBox_preOrders_idOrders";
            this.textBox_preOrders_idOrders.Size = new System.Drawing.Size(220, 29);
            this.textBox_preOrders_idOrders.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Блюдо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(273, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Статус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(272, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Количество";
            // 
            // button_preOrders_delete
            // 
            this.button_preOrders_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_preOrders_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_preOrders_delete.Location = new System.Drawing.Point(563, 220);
            this.button_preOrders_delete.Name = "button_preOrders_delete";
            this.button_preOrders_delete.Size = new System.Drawing.Size(88, 32);
            this.button_preOrders_delete.TabIndex = 44;
            this.button_preOrders_delete.Text = "Удалить";
            this.button_preOrders_delete.UseVisualStyleBackColor = false;
            this.button_preOrders_delete.Click += new System.EventHandler(this.button_preOrders_delete_Click);
            // 
            // button_preOrders_change
            // 
            this.button_preOrders_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_preOrders_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_preOrders_change.Location = new System.Drawing.Point(563, 138);
            this.button_preOrders_change.Name = "button_preOrders_change";
            this.button_preOrders_change.Size = new System.Drawing.Size(88, 32);
            this.button_preOrders_change.TabIndex = 43;
            this.button_preOrders_change.Text = "Изменить";
            this.button_preOrders_change.UseVisualStyleBackColor = false;
            this.button_preOrders_change.Click += new System.EventHandler(this.button_preOrders_change_Click);
            // 
            // button_preOrders_add
            // 
            this.button_preOrders_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_preOrders_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_preOrders_add.Location = new System.Drawing.Point(563, 60);
            this.button_preOrders_add.Name = "button_preOrders_add";
            this.button_preOrders_add.Size = new System.Drawing.Size(88, 32);
            this.button_preOrders_add.TabIndex = 42;
            this.button_preOrders_add.Text = "Добавить";
            this.button_preOrders_add.UseVisualStyleBackColor = false;
            this.button_preOrders_add.Click += new System.EventHandler(this.button_preOrders_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(764, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Клиент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(764, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Работник";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(765, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 48;
            this.label9.Text = "Дата и Время";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(764, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 21);
            this.label10.TabIndex = 46;
            this.label10.Text = "ID Заказа";
            // 
            // textBox_orders_id
            // 
            this.textBox_orders_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_orders_id.Location = new System.Drawing.Point(769, 36);
            this.textBox_orders_id.Name = "textBox_orders_id";
            this.textBox_orders_id.Size = new System.Drawing.Size(220, 29);
            this.textBox_orders_id.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1039, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 21);
            this.label12.TabIndex = 54;
            this.label12.Text = "Номер стола";
            // 
            // textBox_orders_numberTable
            // 
            this.textBox_orders_numberTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_orders_numberTable.Location = new System.Drawing.Point(1044, 36);
            this.textBox_orders_numberTable.Name = "textBox_orders_numberTable";
            this.textBox_orders_numberTable.Size = new System.Drawing.Size(220, 29);
            this.textBox_orders_numberTable.TabIndex = 53;
            // 
            // button_orders_delete
            // 
            this.button_orders_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_orders_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_orders_delete.Location = new System.Drawing.Point(1106, 223);
            this.button_orders_delete.Name = "button_orders_delete";
            this.button_orders_delete.Size = new System.Drawing.Size(88, 32);
            this.button_orders_delete.TabIndex = 59;
            this.button_orders_delete.Text = "Удалить";
            this.button_orders_delete.UseVisualStyleBackColor = false;
            this.button_orders_delete.Click += new System.EventHandler(this.button_orders_delete_Click);
            // 
            // button_orders_change
            // 
            this.button_orders_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_orders_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_orders_change.Location = new System.Drawing.Point(1159, 175);
            this.button_orders_change.Name = "button_orders_change";
            this.button_orders_change.Size = new System.Drawing.Size(88, 32);
            this.button_orders_change.TabIndex = 58;
            this.button_orders_change.Text = "Изменить";
            this.button_orders_change.UseVisualStyleBackColor = false;
            this.button_orders_change.Click += new System.EventHandler(this.button_orders_change_Click);
            // 
            // button_orders_add
            // 
            this.button_orders_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_orders_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_orders_add.Location = new System.Drawing.Point(1055, 175);
            this.button_orders_add.Name = "button_orders_add";
            this.button_orders_add.Size = new System.Drawing.Size(88, 32);
            this.button_orders_add.TabIndex = 57;
            this.button_orders_add.Text = "Добавить";
            this.button_orders_add.UseVisualStyleBackColor = false;
            this.button_orders_add.Click += new System.EventHandler(this.button_orders_add_Click);
            // 
            // numericUpDown_preOrders_quantity
            // 
            this.numericUpDown_preOrders_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_preOrders_quantity.Location = new System.Drawing.Point(276, 169);
            this.numericUpDown_preOrders_quantity.Name = "numericUpDown_preOrders_quantity";
            this.numericUpDown_preOrders_quantity.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_preOrders_quantity.TabIndex = 60;
            // 
            // comboBox_preOrders_dishes
            // 
            this.comboBox_preOrders_dishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_preOrders_dishes.FormattingEnabled = true;
            this.comboBox_preOrders_dishes.Location = new System.Drawing.Point(277, 102);
            this.comboBox_preOrders_dishes.Name = "comboBox_preOrders_dishes";
            this.comboBox_preOrders_dishes.Size = new System.Drawing.Size(220, 28);
            this.comboBox_preOrders_dishes.TabIndex = 61;
            // 
            // comboBox_preOrders_status
            // 
            this.comboBox_preOrders_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_preOrders_status.FormattingEnabled = true;
            this.comboBox_preOrders_status.Location = new System.Drawing.Point(276, 232);
            this.comboBox_preOrders_status.Name = "comboBox_preOrders_status";
            this.comboBox_preOrders_status.Size = new System.Drawing.Size(220, 28);
            this.comboBox_preOrders_status.TabIndex = 62;
            // 
            // dateTimePicker_orders_dateTime
            // 
            this.dateTimePicker_orders_dateTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dateTimePicker_orders_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_orders_dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_orders_dateTime.Location = new System.Drawing.Point(768, 101);
            this.dateTimePicker_orders_dateTime.Name = "dateTimePicker_orders_dateTime";
            this.dateTimePicker_orders_dateTime.Size = new System.Drawing.Size(221, 29);
            this.dateTimePicker_orders_dateTime.TabIndex = 63;
            // 
            // comboBox_orders_employer
            // 
            this.comboBox_orders_employer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_orders_employer.FormattingEnabled = true;
            this.comboBox_orders_employer.Location = new System.Drawing.Point(768, 168);
            this.comboBox_orders_employer.Name = "comboBox_orders_employer";
            this.comboBox_orders_employer.Size = new System.Drawing.Size(220, 28);
            this.comboBox_orders_employer.TabIndex = 64;
            // 
            // comboBox_orders_client
            // 
            this.comboBox_orders_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_orders_client.FormattingEnabled = true;
            this.comboBox_orders_client.Location = new System.Drawing.Point(769, 232);
            this.comboBox_orders_client.Name = "comboBox_orders_client";
            this.comboBox_orders_client.Size = new System.Drawing.Size(220, 28);
            this.comboBox_orders_client.TabIndex = 65;
            // 
            // textBox_statusPreOrders_nameStatus
            // 
            this.textBox_statusPreOrders_nameStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_statusPreOrders_nameStatus.Location = new System.Drawing.Point(13, 114);
            this.textBox_statusPreOrders_nameStatus.MaxLength = 10;
            this.textBox_statusPreOrders_nameStatus.Name = "textBox_statusPreOrders_nameStatus";
            this.textBox_statusPreOrders_nameStatus.Size = new System.Drawing.Size(220, 29);
            this.textBox_statusPreOrders_nameStatus.TabIndex = 29;
            // 
            // dataGridView_dishes
            // 
            this.dataGridView_dishes.AutoGenerateColumns = false;
            this.dataGridView_dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDishesDataGridViewTextBoxColumn1,
            this.nameDishesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idCategoriesDataGridViewTextBoxColumn});
            this.dataGridView_dishes.DataSource = this.dishesBindingSource;
            this.dataGridView_dishes.Location = new System.Drawing.Point(656, 266);
            this.dataGridView_dishes.Name = "dataGridView_dishes";
            this.dataGridView_dishes.Size = new System.Drawing.Size(91, 83);
            this.dataGridView_dishes.TabIndex = 66;
            this.dataGridView_dishes.Visible = false;
            // 
            // idDishesDataGridViewTextBoxColumn1
            // 
            this.idDishesDataGridViewTextBoxColumn1.DataPropertyName = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn1.HeaderText = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn1.Name = "idDishesDataGridViewTextBoxColumn1";
            this.idDishesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDishesDataGridViewTextBoxColumn
            // 
            this.nameDishesDataGridViewTextBoxColumn.DataPropertyName = "NameDishes";
            this.nameDishesDataGridViewTextBoxColumn.HeaderText = "NameDishes";
            this.nameDishesDataGridViewTextBoxColumn.Name = "nameDishesDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // idCategoriesDataGridViewTextBoxColumn
            // 
            this.idCategoriesDataGridViewTextBoxColumn.DataPropertyName = "IdCategories";
            this.idCategoriesDataGridViewTextBoxColumn.HeaderText = "IdCategories";
            this.idCategoriesDataGridViewTextBoxColumn.Name = "idCategoriesDataGridViewTextBoxColumn";
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.restoranDataSet;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_employers
            // 
            this.dataGridView_employers.AutoGenerateColumns = false;
            this.dataGridView_employers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmployeesDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView_employers.DataSource = this.employeesBindingSource;
            this.dataGridView_employers.Location = new System.Drawing.Point(753, 266);
            this.dataGridView_employers.Name = "dataGridView_employers";
            this.dataGridView_employers.Size = new System.Drawing.Size(91, 83);
            this.dataGridView_employers.TabIndex = 67;
            this.dataGridView_employers.Visible = false;
            // 
            // idEmployeesDataGridViewTextBoxColumn1
            // 
            this.idEmployeesDataGridViewTextBoxColumn1.DataPropertyName = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn1.HeaderText = "IdEmployees";
            this.idEmployeesDataGridViewTextBoxColumn1.Name = "idEmployeesDataGridViewTextBoxColumn1";
            this.idEmployeesDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AutoGenerateColumns = false;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientsDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1});
            this.dataGridView_clients.DataSource = this.clientsBindingSource;
            this.dataGridView_clients.Location = new System.Drawing.Point(850, 266);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(101, 83);
            this.dataGridView_clients.TabIndex = 68;
            this.dataGridView_clients.Visible = false;
            // 
            // idClientsDataGridViewTextBoxColumn1
            // 
            this.idClientsDataGridViewTextBoxColumn1.DataPropertyName = "IdClients";
            this.idClientsDataGridViewTextBoxColumn1.HeaderText = "IdClients";
            this.idClientsDataGridViewTextBoxColumn1.Name = "idClientsDataGridViewTextBoxColumn1";
            this.idClientsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.restoranDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1478, 768);
            this.Controls.Add(this.dataGridView_clients);
            this.Controls.Add(this.dataGridView_employers);
            this.Controls.Add(this.dataGridView_dishes);
            this.Controls.Add(this.comboBox_orders_client);
            this.Controls.Add(this.comboBox_orders_employer);
            this.Controls.Add(this.dateTimePicker_orders_dateTime);
            this.Controls.Add(this.comboBox_preOrders_status);
            this.Controls.Add(this.comboBox_preOrders_dishes);
            this.Controls.Add(this.numericUpDown_preOrders_quantity);
            this.Controls.Add(this.button_orders_delete);
            this.Controls.Add(this.button_orders_change);
            this.Controls.Add(this.button_orders_add);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_orders_numberTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_orders_id);
            this.Controls.Add(this.button_preOrders_delete);
            this.Controls.Add(this.button_preOrders_change);
            this.Controls.Add(this.button_preOrders_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_preOrders_idOrders);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_statusPreOrders_delete);
            this.Controls.Add(this.button_statusPreOrders_change);
            this.Controls.Add(this.button_statusPreOrders_add);
            this.Controls.Add(this.textBox_statusPreOrders_nameStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_statusPreOrders_id);
            this.Controls.Add(this.dataGridView_statusPreOrders);
            this.Controls.Add(this.dataGridView_preOrders);
            this.Controls.Add(this.dataGridView_orders);
            this.Name = "Form_Orders";
            this.Text = "Form_Orders";
            this.Load += new System.EventHandler(this.Form_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_statusPreOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPreOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_preOrders_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_statusPreOrders;
        private System.Windows.Forms.DataGridView dataGridView_preOrders;
        private System.Windows.Forms.DataGridView dataGridView_orders;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource statusPreOrdersBindingSource;
        private RestoranDataSetTableAdapters.StatusPreOrdersTableAdapter statusPreOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource preOrdersBindingSource;
        private RestoranDataSetTableAdapters.PreOrdersTableAdapter preOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDishesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RestoranDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdersDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTablesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_statusPreOrders_delete;
        private System.Windows.Forms.Button button_statusPreOrders_change;
        private System.Windows.Forms.Button button_statusPreOrders_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_statusPreOrders_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_preOrders_idOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_preOrders_delete;
        private System.Windows.Forms.Button button_preOrders_change;
        private System.Windows.Forms.Button button_preOrders_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_orders_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_orders_numberTable;
        private System.Windows.Forms.Button button_orders_delete;
        private System.Windows.Forms.Button button_orders_change;
        private System.Windows.Forms.Button button_orders_add;
        private System.Windows.Forms.NumericUpDown numericUpDown_preOrders_quantity;
        private System.Windows.Forms.ComboBox comboBox_preOrders_dishes;
        private System.Windows.Forms.ComboBox comboBox_preOrders_status;
        private System.Windows.Forms.DateTimePicker dateTimePicker_orders_dateTime;
        private System.Windows.Forms.ComboBox comboBox_orders_employer;
        private System.Windows.Forms.ComboBox comboBox_orders_client;
        private System.Windows.Forms.TextBox textBox_statusPreOrders_nameStatus;
        private System.Windows.Forms.DataGridView dataGridView_dishes;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestoranDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDishesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDishesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_employers;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RestoranDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RestoranDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
    }
}