namespace SQLApp
{
    partial class Form_Admin
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
            this.button_close = new System.Windows.Forms.Button();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.dataGridView_compositionDishes = new System.Windows.Forms.DataGridView();
            this.dataGridView_dishes = new System.Windows.Forms.DataGridView();
            this.dataGridView_dishesCategories = new System.Windows.Forms.DataGridView();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.dataGridView_preOrders = new System.Windows.Forms.DataGridView();
            this.dataGridView_statusPreOrders = new System.Windows.Forms.DataGridView();
            this.button_tableProductsShow = new System.Windows.Forms.Button();
            this.button_tableDishesShow = new System.Windows.Forms.Button();
            this.button_tableOrderShow = new System.Windows.Forms.Button();
            this.button_tableClientShow = new System.Windows.Forms.Button();
            this.button_tableEmployerShow = new System.Windows.Forms.Button();
            this.button_tableProductsChange = new System.Windows.Forms.Button();
            this.button_tableDishesChange = new System.Windows.Forms.Button();
            this.button_tableOrderChange = new System.Windows.Forms.Button();
            this.button_tableEmployerChange = new System.Windows.Forms.Button();
            this.button_tableClientChange = new System.Windows.Forms.Button();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new SQLApp.RestoranDataSet();
            this.idOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDishesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPreOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCategoriesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDishesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDishesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDishesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProductsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new SQLApp.RestoranDataSetTableAdapters.ClientsTableAdapter();
            this.compositionDishesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.CompositionDishesTableAdapter();
            this.dishesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.DishesTableAdapter();
            this.dishesCategoriesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.DishesCategoriesTableAdapter();
            this.employeesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.EmployeesTableAdapter();
            this.ordersTableAdapter = new SQLApp.RestoranDataSetTableAdapters.OrdersTableAdapter();
            this.preOrdersTableAdapter = new SQLApp.RestoranDataSetTableAdapters.PreOrdersTableAdapter();
            this.statusPreOrdersTableAdapter = new SQLApp.RestoranDataSetTableAdapters.StatusPreOrdersTableAdapter();
            this.productsTableAdapter = new SQLApp.RestoranDataSetTableAdapters.ProductsTableAdapter();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_compositionDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dishesCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_statusPreOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPreOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionDishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Red;
            this.button_close.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(1125, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(45, 45);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AutoGenerateColumns = false;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductsDataGridViewTextBoxColumn1,
            this.nameProductsDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dataGridView_products.DataSource = this.productsBindingSource;
            this.dataGridView_products.Location = new System.Drawing.Point(12, 228);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.Size = new System.Drawing.Size(446, 401);
            this.dataGridView_products.TabIndex = 1;
            this.dataGridView_products.Visible = false;
            // 
            // dataGridView_compositionDishes
            // 
            this.dataGridView_compositionDishes.AutoGenerateColumns = false;
            this.dataGridView_compositionDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_compositionDishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDishesDataGridViewTextBoxColumn,
            this.idProductsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView_compositionDishes.DataSource = this.compositionDishesBindingSource;
            this.dataGridView_compositionDishes.Location = new System.Drawing.Point(343, 228);
            this.dataGridView_compositionDishes.Name = "dataGridView_compositionDishes";
            this.dataGridView_compositionDishes.Size = new System.Drawing.Size(363, 401);
            this.dataGridView_compositionDishes.TabIndex = 2;
            this.dataGridView_compositionDishes.Visible = false;
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
            this.dataGridView_dishes.Location = new System.Drawing.Point(712, 228);
            this.dataGridView_dishes.Name = "dataGridView_dishes";
            this.dataGridView_dishes.Size = new System.Drawing.Size(458, 401);
            this.dataGridView_dishes.TabIndex = 3;
            this.dataGridView_dishes.Visible = false;
            // 
            // dataGridView_dishesCategories
            // 
            this.dataGridView_dishesCategories.AutoGenerateColumns = false;
            this.dataGridView_dishesCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dishesCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriesDataGridViewTextBoxColumn1,
            this.nameCategoriesDataGridViewTextBoxColumn});
            this.dataGridView_dishesCategories.DataSource = this.dishesCategoriesBindingSource;
            this.dataGridView_dishesCategories.Location = new System.Drawing.Point(12, 228);
            this.dataGridView_dishesCategories.Name = "dataGridView_dishesCategories";
            this.dataGridView_dishesCategories.Size = new System.Drawing.Size(325, 401);
            this.dataGridView_dishesCategories.TabIndex = 4;
            this.dataGridView_dishesCategories.Visible = false;
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AutoGenerateColumns = false;
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_employees.DataSource = this.employeesBindingSource;
            this.dataGridView_employees.Location = new System.Drawing.Point(12, 228);
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.Size = new System.Drawing.Size(525, 401);
            this.dataGridView_employees.TabIndex = 5;
            this.dataGridView_employees.Visible = false;
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.AutoGenerateColumns = false;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrders,
            this.DateTimeOrders,
            this.IdEmployees,
            this.dataGridViewTextBoxColumn1,
            this.NumberTables,
            this.PriceOrders});
            this.dataGridView_orders.DataSource = this.ordersBindingSource;
            this.dataGridView_orders.Location = new System.Drawing.Point(724, 228);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.Size = new System.Drawing.Size(446, 401);
            this.dataGridView_orders.TabIndex = 6;
            this.dataGridView_orders.Visible = false;
            // 
            // dataGridView_preOrders
            // 
            this.dataGridView_preOrders.AutoGenerateColumns = false;
            this.dataGridView_preOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_preOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrdersDataGridViewTextBoxColumn,
            this.idDishesDataGridViewTextBoxColumn2,
            this.quantityDataGridViewTextBoxColumn1,
            this.idStatusDataGridViewTextBoxColumn});
            this.dataGridView_preOrders.DataSource = this.preOrdersBindingSource;
            this.dataGridView_preOrders.Location = new System.Drawing.Point(288, 228);
            this.dataGridView_preOrders.Name = "dataGridView_preOrders";
            this.dataGridView_preOrders.Size = new System.Drawing.Size(433, 401);
            this.dataGridView_preOrders.TabIndex = 7;
            this.dataGridView_preOrders.Visible = false;
            // 
            // dataGridView_statusPreOrders
            // 
            this.dataGridView_statusPreOrders.AutoGenerateColumns = false;
            this.dataGridView_statusPreOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_statusPreOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStatusDataGridViewTextBoxColumn1,
            this.nameStatusDataGridViewTextBoxColumn});
            this.dataGridView_statusPreOrders.DataSource = this.statusPreOrdersBindingSource;
            this.dataGridView_statusPreOrders.Location = new System.Drawing.Point(12, 228);
            this.dataGridView_statusPreOrders.Name = "dataGridView_statusPreOrders";
            this.dataGridView_statusPreOrders.Size = new System.Drawing.Size(270, 401);
            this.dataGridView_statusPreOrders.TabIndex = 8;
            this.dataGridView_statusPreOrders.Visible = false;
            // 
            // button_tableProductsShow
            // 
            this.button_tableProductsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableProductsShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableProductsShow.Location = new System.Drawing.Point(12, 12);
            this.button_tableProductsShow.Name = "button_tableProductsShow";
            this.button_tableProductsShow.Size = new System.Drawing.Size(137, 45);
            this.button_tableProductsShow.TabIndex = 9;
            this.button_tableProductsShow.Text = "Продукты";
            this.button_tableProductsShow.UseVisualStyleBackColor = false;
            this.button_tableProductsShow.Click += new System.EventHandler(this.button_tableProductsShow_Click);
            // 
            // button_tableDishesShow
            // 
            this.button_tableDishesShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableDishesShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableDishesShow.Location = new System.Drawing.Point(155, 12);
            this.button_tableDishesShow.Name = "button_tableDishesShow";
            this.button_tableDishesShow.Size = new System.Drawing.Size(137, 45);
            this.button_tableDishesShow.TabIndex = 10;
            this.button_tableDishesShow.Text = "Блюда";
            this.button_tableDishesShow.UseVisualStyleBackColor = false;
            this.button_tableDishesShow.Click += new System.EventHandler(this.button_tableDishesShow_Click);
            // 
            // button_tableOrderShow
            // 
            this.button_tableOrderShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableOrderShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableOrderShow.Location = new System.Drawing.Point(298, 12);
            this.button_tableOrderShow.Name = "button_tableOrderShow";
            this.button_tableOrderShow.Size = new System.Drawing.Size(137, 45);
            this.button_tableOrderShow.TabIndex = 11;
            this.button_tableOrderShow.Text = "Заказы";
            this.button_tableOrderShow.UseVisualStyleBackColor = false;
            this.button_tableOrderShow.Click += new System.EventHandler(this.button_tableOrderShow_Click);
            // 
            // button_tableClientShow
            // 
            this.button_tableClientShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableClientShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableClientShow.Location = new System.Drawing.Point(441, 12);
            this.button_tableClientShow.Name = "button_tableClientShow";
            this.button_tableClientShow.Size = new System.Drawing.Size(137, 45);
            this.button_tableClientShow.TabIndex = 12;
            this.button_tableClientShow.Text = "Клиенты";
            this.button_tableClientShow.UseVisualStyleBackColor = false;
            this.button_tableClientShow.Click += new System.EventHandler(this.button_tableClientShow_Click);
            // 
            // button_tableEmployerShow
            // 
            this.button_tableEmployerShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableEmployerShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableEmployerShow.Location = new System.Drawing.Point(584, 12);
            this.button_tableEmployerShow.Name = "button_tableEmployerShow";
            this.button_tableEmployerShow.Size = new System.Drawing.Size(137, 45);
            this.button_tableEmployerShow.TabIndex = 13;
            this.button_tableEmployerShow.Text = "Работники";
            this.button_tableEmployerShow.UseVisualStyleBackColor = false;
            this.button_tableEmployerShow.Click += new System.EventHandler(this.button_tableEmployerShow_Click);
            // 
            // button_tableProductsChange
            // 
            this.button_tableProductsChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableProductsChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableProductsChange.Location = new System.Drawing.Point(22, 63);
            this.button_tableProductsChange.Name = "button_tableProductsChange";
            this.button_tableProductsChange.Size = new System.Drawing.Size(118, 30);
            this.button_tableProductsChange.TabIndex = 14;
            this.button_tableProductsChange.Text = "Редактировать";
            this.button_tableProductsChange.UseVisualStyleBackColor = false;
            this.button_tableProductsChange.Click += new System.EventHandler(this.button_tableProductsChange_Click);
            // 
            // button_tableDishesChange
            // 
            this.button_tableDishesChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableDishesChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableDishesChange.Location = new System.Drawing.Point(164, 63);
            this.button_tableDishesChange.Name = "button_tableDishesChange";
            this.button_tableDishesChange.Size = new System.Drawing.Size(118, 30);
            this.button_tableDishesChange.TabIndex = 15;
            this.button_tableDishesChange.Text = "Редактировать";
            this.button_tableDishesChange.UseVisualStyleBackColor = false;
            this.button_tableDishesChange.Click += new System.EventHandler(this.button_tableDishesChange_Click);
            // 
            // button_tableOrderChange
            // 
            this.button_tableOrderChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableOrderChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableOrderChange.Location = new System.Drawing.Point(307, 63);
            this.button_tableOrderChange.Name = "button_tableOrderChange";
            this.button_tableOrderChange.Size = new System.Drawing.Size(118, 30);
            this.button_tableOrderChange.TabIndex = 16;
            this.button_tableOrderChange.Text = "Редактировать";
            this.button_tableOrderChange.UseVisualStyleBackColor = false;
            this.button_tableOrderChange.Click += new System.EventHandler(this.button_tableOrderChange_Click);
            // 
            // button_tableEmployerChange
            // 
            this.button_tableEmployerChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableEmployerChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableEmployerChange.Location = new System.Drawing.Point(593, 63);
            this.button_tableEmployerChange.Name = "button_tableEmployerChange";
            this.button_tableEmployerChange.Size = new System.Drawing.Size(118, 30);
            this.button_tableEmployerChange.TabIndex = 18;
            this.button_tableEmployerChange.Text = "Редактировать";
            this.button_tableEmployerChange.UseVisualStyleBackColor = false;
            this.button_tableEmployerChange.Click += new System.EventHandler(this.button_tableEmployerChange_Click);
            // 
            // button_tableClientChange
            // 
            this.button_tableClientChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_tableClientChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tableClientChange.Location = new System.Drawing.Point(450, 63);
            this.button_tableClientChange.Name = "button_tableClientChange";
            this.button_tableClientChange.Size = new System.Drawing.Size(118, 30);
            this.button_tableClientChange.TabIndex = 17;
            this.button_tableClientChange.Text = "Редактировать";
            this.button_tableClientChange.UseVisualStyleBackColor = false;
            this.button_tableClientChange.Click += new System.EventHandler(this.button_tableClientChange_Click);
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AutoGenerateColumns = false;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientsDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn});
            this.dataGridView_clients.DataSource = this.clientsBindingSource;
            this.dataGridView_clients.Location = new System.Drawing.Point(12, 228);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(465, 401);
            this.dataGridView_clients.TabIndex = 19;
            this.dataGridView_clients.Visible = false;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idOrdersDataGridViewTextBoxColumn
            // 
            this.idOrdersDataGridViewTextBoxColumn.DataPropertyName = "IdOrders";
            this.idOrdersDataGridViewTextBoxColumn.HeaderText = "IdOrders";
            this.idOrdersDataGridViewTextBoxColumn.Name = "idOrdersDataGridViewTextBoxColumn";
            // 
            // idDishesDataGridViewTextBoxColumn2
            // 
            this.idDishesDataGridViewTextBoxColumn2.DataPropertyName = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn2.HeaderText = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn2.Name = "idDishesDataGridViewTextBoxColumn2";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // idStatusDataGridViewTextBoxColumn
            // 
            this.idStatusDataGridViewTextBoxColumn.DataPropertyName = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn.HeaderText = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn.Name = "idStatusDataGridViewTextBoxColumn";
            // 
            // preOrdersBindingSource
            // 
            this.preOrdersBindingSource.DataMember = "PreOrders";
            this.preOrdersBindingSource.DataSource = this.restoranDataSet;
            // 
            // idStatusDataGridViewTextBoxColumn1
            // 
            this.idStatusDataGridViewTextBoxColumn1.DataPropertyName = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn1.HeaderText = "IdStatus";
            this.idStatusDataGridViewTextBoxColumn1.Name = "idStatusDataGridViewTextBoxColumn1";
            this.idStatusDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.restoranDataSet;
            // 
            // idCategoriesDataGridViewTextBoxColumn1
            // 
            this.idCategoriesDataGridViewTextBoxColumn1.DataPropertyName = "IdCategories";
            this.idCategoriesDataGridViewTextBoxColumn1.HeaderText = "IdCategories";
            this.idCategoriesDataGridViewTextBoxColumn1.Name = "idCategoriesDataGridViewTextBoxColumn1";
            this.idCategoriesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameCategoriesDataGridViewTextBoxColumn
            // 
            this.nameCategoriesDataGridViewTextBoxColumn.DataPropertyName = "NameCategories";
            this.nameCategoriesDataGridViewTextBoxColumn.HeaderText = "NameCategories";
            this.nameCategoriesDataGridViewTextBoxColumn.Name = "nameCategoriesDataGridViewTextBoxColumn";
            // 
            // dishesCategoriesBindingSource
            // 
            this.dishesCategoriesBindingSource.DataMember = "DishesCategories";
            this.dishesCategoriesBindingSource.DataSource = this.restoranDataSet;
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
            // idDishesDataGridViewTextBoxColumn
            // 
            this.idDishesDataGridViewTextBoxColumn.DataPropertyName = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn.HeaderText = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn.Name = "idDishesDataGridViewTextBoxColumn";
            // 
            // idProductsDataGridViewTextBoxColumn
            // 
            this.idProductsDataGridViewTextBoxColumn.DataPropertyName = "IdProducts";
            this.idProductsDataGridViewTextBoxColumn.HeaderText = "IdProducts";
            this.idProductsDataGridViewTextBoxColumn.Name = "idProductsDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // compositionDishesBindingSource
            // 
            this.compositionDishesBindingSource.DataMember = "CompositionDishes";
            this.compositionDishesBindingSource.DataSource = this.restoranDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.restoranDataSet;
            // 
            // idProductsDataGridViewTextBoxColumn1
            // 
            this.idProductsDataGridViewTextBoxColumn1.DataPropertyName = "IdProducts";
            this.idProductsDataGridViewTextBoxColumn1.HeaderText = "IdProducts";
            this.idProductsDataGridViewTextBoxColumn1.Name = "idProductsDataGridViewTextBoxColumn1";
            this.idProductsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameProductsDataGridViewTextBoxColumn
            // 
            this.nameProductsDataGridViewTextBoxColumn.DataPropertyName = "NameProducts";
            this.nameProductsDataGridViewTextBoxColumn.HeaderText = "NameProducts";
            this.nameProductsDataGridViewTextBoxColumn.Name = "nameProductsDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.restoranDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // compositionDishesTableAdapter
            // 
            this.compositionDishesTableAdapter.ClearBeforeFill = true;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // dishesCategoriesTableAdapter
            // 
            this.dishesCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // preOrdersTableAdapter
            // 
            this.preOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // statusPreOrdersTableAdapter
            // 
            this.statusPreOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // idClientsDataGridViewTextBoxColumn
            // 
            this.idClientsDataGridViewTextBoxColumn.DataPropertyName = "IdClients";
            this.idClientsDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.idClientsDataGridViewTextBoxColumn.Name = "idClientsDataGridViewTextBoxColumn";
            this.idClientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // IdOrders
            // 
            this.IdOrders.DataPropertyName = "IdOrders";
            this.IdOrders.HeaderText = "ID Заказа";
            this.IdOrders.Name = "IdOrders";
            this.IdOrders.ReadOnly = true;
            // 
            // DateTimeOrders
            // 
            this.DateTimeOrders.DataPropertyName = "DateTimeOrders";
            this.DateTimeOrders.HeaderText = "Время оформления";
            this.DateTimeOrders.Name = "DateTimeOrders";
            // 
            // IdEmployees
            // 
            this.IdEmployees.DataPropertyName = "IdEmployees";
            this.IdEmployees.HeaderText = "ID работника";
            this.IdEmployees.Name = "IdEmployees";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdClients";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // NumberTables
            // 
            this.NumberTables.DataPropertyName = "NumberTables";
            this.NumberTables.HeaderText = "Номер столика";
            this.NumberTables.Name = "NumberTables";
            // 
            // PriceOrders
            // 
            this.PriceOrders.DataPropertyName = "PriceOrders";
            this.PriceOrders.HeaderText = "Общий чек";
            this.PriceOrders.Name = "PriceOrders";
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1182, 641);
            this.Controls.Add(this.dataGridView_compositionDishes);
            this.Controls.Add(this.dataGridView_dishes);
            this.Controls.Add(this.dataGridView_dishesCategories);
            this.Controls.Add(this.button_tableEmployerChange);
            this.Controls.Add(this.button_tableClientChange);
            this.Controls.Add(this.button_tableOrderChange);
            this.Controls.Add(this.button_tableDishesChange);
            this.Controls.Add(this.button_tableProductsChange);
            this.Controls.Add(this.button_tableEmployerShow);
            this.Controls.Add(this.button_tableClientShow);
            this.Controls.Add(this.button_tableOrderShow);
            this.Controls.Add(this.button_tableDishesShow);
            this.Controls.Add(this.button_tableProductsShow);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dataGridView_orders);
            this.Controls.Add(this.dataGridView_preOrders);
            this.Controls.Add(this.dataGridView_statusPreOrders);
            this.Controls.Add(this.dataGridView_employees);
            this.Controls.Add(this.dataGridView_products);
            this.Controls.Add(this.dataGridView_clients);
            this.Name = "Form_Admin";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_compositionDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dishesCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_statusPreOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPreOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionDishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RestoranDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_compositionDishes;
        private System.Windows.Forms.BindingSource compositionDishesBindingSource;
        private RestoranDataSetTableAdapters.CompositionDishesTableAdapter compositionDishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDishesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_dishes;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestoranDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDishesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDishesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_dishesCategories;
        private System.Windows.Forms.BindingSource dishesCategoriesBindingSource;
        private RestoranDataSetTableAdapters.DishesCategoriesTableAdapter dishesCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RestoranDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RestoranDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_preOrders;
        private System.Windows.Forms.BindingSource preOrdersBindingSource;
        private RestoranDataSetTableAdapters.PreOrdersTableAdapter preOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDishesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_statusPreOrders;
        private System.Windows.Forms.BindingSource statusPreOrdersBindingSource;
        private RestoranDataSetTableAdapters.StatusPreOrdersTableAdapter statusPreOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_tableProductsShow;
        private System.Windows.Forms.Button button_tableDishesShow;
        private System.Windows.Forms.Button button_tableOrderShow;
        private System.Windows.Forms.Button button_tableClientShow;
        private System.Windows.Forms.Button button_tableEmployerShow;
        private System.Windows.Forms.Button button_tableProductsChange;
        private System.Windows.Forms.Button button_tableDishesChange;
        private System.Windows.Forms.Button button_tableOrderChange;
        private System.Windows.Forms.Button button_tableEmployerChange;
        private System.Windows.Forms.Button button_tableClientChange;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private RestoranDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
    }
}