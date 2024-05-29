namespace SQLApp.Окна_редактирования
{
    partial class Form_Dishes_change
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
            this.dataGridView_Dishes = new System.Windows.Forms.DataGridView();
            this.idDishesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDishesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new SQLApp.RestoranDataSet();
            this.dataGridView_DishesCategories = new System.Windows.Forms.DataGridView();
            this.idCategoriesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_CompositionDishes = new System.Windows.Forms.DataGridView();
            this.idDishesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Панель_админа = new System.Windows.Forms.Panel();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.idProductsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_dishes_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_dishes_idDishes = new System.Windows.Forms.TextBox();
            this.numericUpDown_dishes_price = new System.Windows.Forms.NumericUpDown();
            this.comboBox_dishes_Categories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_dishes_delete = new System.Windows.Forms.Button();
            this.button_dishes_change = new System.Windows.Forms.Button();
            this.button_dishes_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_compositionDishes_quantity = new System.Windows.Forms.NumericUpDown();
            this.comboBox_compositionDishes_products = new System.Windows.Forms.ComboBox();
            this.comboBox_compositionDishes_dishes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_compositionDishes_delete = new System.Windows.Forms.Button();
            this.button_compositionDishes_change = new System.Windows.Forms.Button();
            this.button_compositionDishes_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_dishesCategories_delete = new System.Windows.Forms.Button();
            this.button_dishesCategories_change = new System.Windows.Forms.Button();
            this.button_dishesCategories_add = new System.Windows.Forms.Button();
            this.textBox_dishesCategories_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dishesCategories_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dishesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.DishesTableAdapter();
            this.dishesCategoriesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.DishesCategoriesTableAdapter();
            this.compositionDishesTableAdapter = new SQLApp.RestoranDataSetTableAdapters.CompositionDishesTableAdapter();
            this.productsTableAdapter = new SQLApp.RestoranDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DishesCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CompositionDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionDishesBindingSource)).BeginInit();
            this.Панель_админа.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dishes_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_compositionDishes_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Dishes
            // 
            this.dataGridView_Dishes.AutoGenerateColumns = false;
            this.dataGridView_Dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDishesDataGridViewTextBoxColumn,
            this.nameDishesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idCategoriesDataGridViewTextBoxColumn});
            this.dataGridView_Dishes.DataSource = this.dishesBindingSource;
            this.dataGridView_Dishes.Location = new System.Drawing.Point(673, 322);
            this.dataGridView_Dishes.Name = "dataGridView_Dishes";
            this.dataGridView_Dishes.Size = new System.Drawing.Size(486, 254);
            this.dataGridView_Dishes.TabIndex = 0;
            // 
            // idDishesDataGridViewTextBoxColumn
            // 
            this.idDishesDataGridViewTextBoxColumn.DataPropertyName = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn.HeaderText = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn.Name = "idDishesDataGridViewTextBoxColumn";
            this.idDishesDataGridViewTextBoxColumn.ReadOnly = true;
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
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_DishesCategories
            // 
            this.dataGridView_DishesCategories.AutoGenerateColumns = false;
            this.dataGridView_DishesCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DishesCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriesDataGridViewTextBoxColumn1,
            this.nameCategoriesDataGridViewTextBoxColumn});
            this.dataGridView_DishesCategories.DataSource = this.dishesCategoriesBindingSource;
            this.dataGridView_DishesCategories.Location = new System.Drawing.Point(12, 322);
            this.dataGridView_DishesCategories.Name = "dataGridView_DishesCategories";
            this.dataGridView_DishesCategories.Size = new System.Drawing.Size(281, 254);
            this.dataGridView_DishesCategories.TabIndex = 1;
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
            // dataGridView_CompositionDishes
            // 
            this.dataGridView_CompositionDishes.AutoGenerateColumns = false;
            this.dataGridView_CompositionDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CompositionDishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDishesDataGridViewTextBoxColumn1,
            this.idProductsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView_CompositionDishes.DataSource = this.compositionDishesBindingSource;
            this.dataGridView_CompositionDishes.Location = new System.Drawing.Point(299, 322);
            this.dataGridView_CompositionDishes.Name = "dataGridView_CompositionDishes";
            this.dataGridView_CompositionDishes.Size = new System.Drawing.Size(368, 254);
            this.dataGridView_CompositionDishes.TabIndex = 2;
            // 
            // idDishesDataGridViewTextBoxColumn1
            // 
            this.idDishesDataGridViewTextBoxColumn1.DataPropertyName = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn1.HeaderText = "IdDishes";
            this.idDishesDataGridViewTextBoxColumn1.Name = "idDishesDataGridViewTextBoxColumn1";
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
            // Панель_админа
            // 
            this.Панель_админа.BackColor = System.Drawing.Color.DimGray;
            this.Панель_админа.Controls.Add(this.dataGridView_products);
            this.Панель_админа.Controls.Add(this.label7);
            this.Панель_админа.Controls.Add(this.textBox_dishes_name);
            this.Панель_админа.Controls.Add(this.label9);
            this.Панель_админа.Controls.Add(this.textBox_dishes_idDishes);
            this.Панель_админа.Controls.Add(this.numericUpDown_dishes_price);
            this.Панель_админа.Controls.Add(this.comboBox_dishes_Categories);
            this.Панель_админа.Controls.Add(this.label6);
            this.Панель_админа.Controls.Add(this.button_dishes_delete);
            this.Панель_админа.Controls.Add(this.button_dishes_change);
            this.Панель_админа.Controls.Add(this.button_dishes_add);
            this.Панель_админа.Controls.Add(this.label8);
            this.Панель_админа.Controls.Add(this.numericUpDown_compositionDishes_quantity);
            this.Панель_админа.Controls.Add(this.comboBox_compositionDishes_products);
            this.Панель_админа.Controls.Add(this.comboBox_compositionDishes_dishes);
            this.Панель_админа.Controls.Add(this.label5);
            this.Панель_админа.Controls.Add(this.label3);
            this.Панель_админа.Controls.Add(this.button_compositionDishes_delete);
            this.Панель_админа.Controls.Add(this.button_compositionDishes_change);
            this.Панель_админа.Controls.Add(this.button_compositionDishes_add);
            this.Панель_админа.Controls.Add(this.label4);
            this.Панель_админа.Controls.Add(this.button_back);
            this.Панель_админа.Controls.Add(this.button_dishesCategories_delete);
            this.Панель_админа.Controls.Add(this.button_dishesCategories_change);
            this.Панель_админа.Controls.Add(this.button_dishesCategories_add);
            this.Панель_админа.Controls.Add(this.textBox_dishesCategories_name);
            this.Панель_админа.Controls.Add(this.label2);
            this.Панель_админа.Controls.Add(this.label1);
            this.Панель_админа.Controls.Add(this.textBox_dishesCategories_id);
            this.Панель_админа.Location = new System.Drawing.Point(12, 12);
            this.Панель_админа.Name = "Панель_админа";
            this.Панель_админа.Size = new System.Drawing.Size(1147, 304);
            this.Панель_админа.TabIndex = 17;
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
            this.dataGridView_products.Location = new System.Drawing.Point(486, 162);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowTemplate.Height = 24;
            this.dataGridView_products.Size = new System.Drawing.Size(143, 126);
            this.dataGridView_products.TabIndex = 44;
            this.dataGridView_products.Visible = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(657, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "Категория";
            // 
            // textBox_dishes_name
            // 
            this.textBox_dishes_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dishes_name.Location = new System.Drawing.Point(661, 95);
            this.textBox_dishes_name.Name = "textBox_dishes_name";
            this.textBox_dishes_name.Size = new System.Drawing.Size(220, 29);
            this.textBox_dishes_name.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(657, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Название";
            // 
            // textBox_dishes_idDishes
            // 
            this.textBox_dishes_idDishes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dishes_idDishes.Location = new System.Drawing.Point(661, 31);
            this.textBox_dishes_idDishes.Name = "textBox_dishes_idDishes";
            this.textBox_dishes_idDishes.Size = new System.Drawing.Size(220, 29);
            this.textBox_dishes_idDishes.TabIndex = 40;
            // 
            // numericUpDown_dishes_price
            // 
            this.numericUpDown_dishes_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_dishes_price.Location = new System.Drawing.Point(662, 156);
            this.numericUpDown_dishes_price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_dishes_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_dishes_price.Name = "numericUpDown_dishes_price";
            this.numericUpDown_dishes_price.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_dishes_price.TabIndex = 39;
            this.numericUpDown_dishes_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_dishes_Categories
            // 
            this.comboBox_dishes_Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_dishes_Categories.FormattingEnabled = true;
            this.comboBox_dishes_Categories.Location = new System.Drawing.Point(662, 217);
            this.comboBox_dishes_Categories.Name = "comboBox_dishes_Categories";
            this.comboBox_dishes_Categories.Size = new System.Drawing.Size(220, 28);
            this.comboBox_dishes_Categories.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(658, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Цена";
            // 
            // button_dishes_delete
            // 
            this.button_dishes_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_dishes_delete.Location = new System.Drawing.Point(1025, 190);
            this.button_dishes_delete.Name = "button_dishes_delete";
            this.button_dishes_delete.Size = new System.Drawing.Size(85, 35);
            this.button_dishes_delete.TabIndex = 34;
            this.button_dishes_delete.Text = "Удалить";
            this.button_dishes_delete.UseVisualStyleBackColor = false;
            this.button_dishes_delete.Click += new System.EventHandler(this.button_dishes_delete_Click);
            // 
            // button_dishes_change
            // 
            this.button_dishes_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_dishes_change.Location = new System.Drawing.Point(934, 213);
            this.button_dishes_change.Name = "button_dishes_change";
            this.button_dishes_change.Size = new System.Drawing.Size(85, 35);
            this.button_dishes_change.TabIndex = 33;
            this.button_dishes_change.Text = "Изменить";
            this.button_dishes_change.UseVisualStyleBackColor = false;
            this.button_dishes_change.Click += new System.EventHandler(this.button_dishes_change_Click);
            // 
            // button_dishes_add
            // 
            this.button_dishes_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_dishes_add.Location = new System.Drawing.Point(934, 170);
            this.button_dishes_add.Name = "button_dishes_add";
            this.button_dishes_add.Size = new System.Drawing.Size(85, 35);
            this.button_dishes_add.TabIndex = 32;
            this.button_dishes_add.Text = "Добавить";
            this.button_dishes_add.UseVisualStyleBackColor = false;
            this.button_dishes_add.Click += new System.EventHandler(this.button_dishes_add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(657, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "ID Блюда";
            // 
            // numericUpDown_compositionDishes_quantity
            // 
            this.numericUpDown_compositionDishes_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_compositionDishes_quantity.Location = new System.Drawing.Point(287, 156);
            this.numericUpDown_compositionDishes_quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_compositionDishes_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_compositionDishes_quantity.Name = "numericUpDown_compositionDishes_quantity";
            this.numericUpDown_compositionDishes_quantity.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_compositionDishes_quantity.TabIndex = 30;
            this.numericUpDown_compositionDishes_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_compositionDishes_products
            // 
            this.comboBox_compositionDishes_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_compositionDishes_products.FormattingEnabled = true;
            this.comboBox_compositionDishes_products.Location = new System.Drawing.Point(287, 95);
            this.comboBox_compositionDishes_products.Name = "comboBox_compositionDishes_products";
            this.comboBox_compositionDishes_products.Size = new System.Drawing.Size(220, 28);
            this.comboBox_compositionDishes_products.TabIndex = 29;
            // 
            // comboBox_compositionDishes_dishes
            // 
            this.comboBox_compositionDishes_dishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_compositionDishes_dishes.FormattingEnabled = true;
            this.comboBox_compositionDishes_dishes.Location = new System.Drawing.Point(287, 30);
            this.comboBox_compositionDishes_dishes.Name = "comboBox_compositionDishes_dishes";
            this.comboBox_compositionDishes_dishes.Size = new System.Drawing.Size(220, 28);
            this.comboBox_compositionDishes_dishes.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(283, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(283, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Продукт";
            // 
            // button_compositionDishes_delete
            // 
            this.button_compositionDishes_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_compositionDishes_delete.Location = new System.Drawing.Point(378, 235);
            this.button_compositionDishes_delete.Name = "button_compositionDishes_delete";
            this.button_compositionDishes_delete.Size = new System.Drawing.Size(85, 35);
            this.button_compositionDishes_delete.TabIndex = 24;
            this.button_compositionDishes_delete.Text = "Удалить";
            this.button_compositionDishes_delete.UseVisualStyleBackColor = false;
            this.button_compositionDishes_delete.Click += new System.EventHandler(this.button_compositionDishes_delete_Click);
            // 
            // button_compositionDishes_change
            // 
            this.button_compositionDishes_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_compositionDishes_change.Location = new System.Drawing.Point(287, 253);
            this.button_compositionDishes_change.Name = "button_compositionDishes_change";
            this.button_compositionDishes_change.Size = new System.Drawing.Size(85, 35);
            this.button_compositionDishes_change.TabIndex = 23;
            this.button_compositionDishes_change.Text = "Изменить";
            this.button_compositionDishes_change.UseVisualStyleBackColor = false;
            this.button_compositionDishes_change.Click += new System.EventHandler(this.button_compositionDishes_change_Click);
            // 
            // button_compositionDishes_add
            // 
            this.button_compositionDishes_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_compositionDishes_add.Location = new System.Drawing.Point(287, 212);
            this.button_compositionDishes_add.Name = "button_compositionDishes_add";
            this.button_compositionDishes_add.Size = new System.Drawing.Size(85, 35);
            this.button_compositionDishes_add.TabIndex = 22;
            this.button_compositionDishes_add.Text = "Добавить";
            this.button_compositionDishes_add.UseVisualStyleBackColor = false;
            this.button_compositionDishes_add.Click += new System.EventHandler(this.button_compositionDishes_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(283, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Блюда";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(1048, 6);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(95, 35);
            this.button_back.TabIndex = 17;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_dishesCategories_delete
            // 
            this.button_dishesCategories_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_dishesCategories_delete.Location = new System.Drawing.Point(104, 170);
            this.button_dishesCategories_delete.Name = "button_dishesCategories_delete";
            this.button_dishesCategories_delete.Size = new System.Drawing.Size(85, 35);
            this.button_dishesCategories_delete.TabIndex = 16;
            this.button_dishesCategories_delete.Text = "Удалить";
            this.button_dishesCategories_delete.UseVisualStyleBackColor = false;
            this.button_dishesCategories_delete.Click += new System.EventHandler(this.button_dishesCategories_delete_Click);
            // 
            // button_dishesCategories_change
            // 
            this.button_dishesCategories_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_dishesCategories_change.Location = new System.Drawing.Point(13, 188);
            this.button_dishesCategories_change.Name = "button_dishesCategories_change";
            this.button_dishesCategories_change.Size = new System.Drawing.Size(85, 35);
            this.button_dishesCategories_change.TabIndex = 15;
            this.button_dishesCategories_change.Text = "Изменить";
            this.button_dishesCategories_change.UseVisualStyleBackColor = false;
            this.button_dishesCategories_change.Click += new System.EventHandler(this.button_dishesCategories_change_Click);
            // 
            // button_dishesCategories_add
            // 
            this.button_dishesCategories_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_dishesCategories_add.Location = new System.Drawing.Point(13, 147);
            this.button_dishesCategories_add.Name = "button_dishesCategories_add";
            this.button_dishesCategories_add.Size = new System.Drawing.Size(85, 35);
            this.button_dishesCategories_add.TabIndex = 14;
            this.button_dishesCategories_add.Text = "Добавить";
            this.button_dishesCategories_add.UseVisualStyleBackColor = false;
            this.button_dishesCategories_add.Click += new System.EventHandler(this.button_dishesCategories_add_Click);
            // 
            // textBox_dishesCategories_name
            // 
            this.textBox_dishesCategories_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dishesCategories_name.Location = new System.Drawing.Point(13, 95);
            this.textBox_dishesCategories_name.Name = "textBox_dishesCategories_name";
            this.textBox_dishesCategories_name.Size = new System.Drawing.Size(220, 29);
            this.textBox_dishesCategories_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Категории";
            // 
            // textBox_dishesCategories_id
            // 
            this.textBox_dishesCategories_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dishesCategories_id.Location = new System.Drawing.Point(13, 30);
            this.textBox_dishesCategories_id.Name = "textBox_dishesCategories_id";
            this.textBox_dishesCategories_id.Size = new System.Drawing.Size(220, 29);
            this.textBox_dishesCategories_id.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(91, 579);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Категории";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(435, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Состав блюда";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(867, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "блюда";
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // dishesCategoriesTableAdapter
            // 
            this.dishesCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // compositionDishesTableAdapter
            // 
            this.compositionDishesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Dishes_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1167, 619);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Панель_админа);
            this.Controls.Add(this.dataGridView_CompositionDishes);
            this.Controls.Add(this.dataGridView_DishesCategories);
            this.Controls.Add(this.dataGridView_Dishes);
            this.Name = "Form_Dishes_change";
            this.Text = "Form_ВDishes_change";
            this.Load += new System.EventHandler(this.Form_Dishes_change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DishesCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CompositionDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionDishesBindingSource)).EndInit();
            this.Панель_админа.ResumeLayout(false);
            this.Панель_админа.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dishes_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_compositionDishes_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Dishes;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestoranDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDishesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDishesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_DishesCategories;
        private System.Windows.Forms.BindingSource dishesCategoriesBindingSource;
        private RestoranDataSetTableAdapters.DishesCategoriesTableAdapter dishesCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_CompositionDishes;
        private System.Windows.Forms.BindingSource compositionDishesBindingSource;
        private RestoranDataSetTableAdapters.CompositionDishesTableAdapter compositionDishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDishesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel Панель_админа;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_dishesCategories_delete;
        private System.Windows.Forms.Button button_dishesCategories_change;
        private System.Windows.Forms.Button button_dishesCategories_add;
        private System.Windows.Forms.TextBox textBox_dishesCategories_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dishesCategories_id;
        private System.Windows.Forms.Button button_compositionDishes_delete;
        private System.Windows.Forms.Button button_compositionDishes_change;
        private System.Windows.Forms.Button button_compositionDishes_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_compositionDishes_quantity;
        private System.Windows.Forms.ComboBox comboBox_compositionDishes_products;
        private System.Windows.Forms.ComboBox comboBox_compositionDishes_dishes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_dishes_price;
        private System.Windows.Forms.ComboBox comboBox_dishes_Categories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_dishes_delete;
        private System.Windows.Forms.Button button_dishes_change;
        private System.Windows.Forms.Button button_dishes_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_dishes_idDishes;
        private System.Windows.Forms.TextBox textBox_dishes_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private RestoranDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    }
}