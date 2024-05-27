namespace SQLApp.Окна_редактирования
{
    partial class Form_Products_change
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
            this.Панель_админа = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_unit = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id_product = new System.Windows.Forms.TextBox();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.idProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new SQLApp.RestoranDataSet();
            this.productsTableAdapter = new SQLApp.RestoranDataSetTableAdapters.ProductsTableAdapter();
            this.Панель_админа.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Панель_админа
            // 
            this.Панель_админа.BackColor = System.Drawing.Color.DimGray;
            this.Панель_админа.Controls.Add(this.button_back);
            this.Панель_админа.Controls.Add(this.button_delete);
            this.Панель_админа.Controls.Add(this.button_change);
            this.Панель_админа.Controls.Add(this.button_add);
            this.Панель_админа.Controls.Add(this.textBox_unit);
            this.Панель_админа.Controls.Add(this.textBox_name);
            this.Панель_админа.Controls.Add(this.label3);
            this.Панель_админа.Controls.Add(this.label2);
            this.Панель_админа.Controls.Add(this.label1);
            this.Панель_админа.Controls.Add(this.textBox_id_product);
            this.Панель_админа.Location = new System.Drawing.Point(12, 12);
            this.Панель_админа.Name = "Панель_админа";
            this.Панель_админа.Size = new System.Drawing.Size(776, 118);
            this.Панель_админа.TabIndex = 16;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(677, 6);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(95, 35);
            this.button_back.TabIndex = 17;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_delete.Location = new System.Drawing.Point(687, 73);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(85, 35);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_change.Location = new System.Drawing.Point(596, 73);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(85, 35);
            this.button_change.TabIndex = 15;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_add.Location = new System.Drawing.Point(505, 73);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 35);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_unit
            // 
            this.textBox_unit.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_unit.Location = new System.Drawing.Point(129, 80);
            this.textBox_unit.Name = "textBox_unit";
            this.textBox_unit.Size = new System.Drawing.Size(220, 32);
            this.textBox_unit.TabIndex = 8;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(129, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(220, 32);
            this.textBox_name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ед.из.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Продукта";
            // 
            // textBox_id_product
            // 
            this.textBox_id_product.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id_product.Location = new System.Drawing.Point(129, 3);
            this.textBox_id_product.Name = "textBox_id_product";
            this.textBox_id_product.Size = new System.Drawing.Size(220, 32);
            this.textBox_id_product.TabIndex = 0;
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AutoGenerateColumns = false;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductsDataGridViewTextBoxColumn,
            this.nameProductsDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dataGridView_products.DataSource = this.productsBindingSource;
            this.dataGridView_products.Location = new System.Drawing.Point(12, 136);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowTemplate.Height = 24;
            this.dataGridView_products.Size = new System.Drawing.Size(776, 459);
            this.dataGridView_products.TabIndex = 15;
            // 
            // idProductsDataGridViewTextBoxColumn
            // 
            this.idProductsDataGridViewTextBoxColumn.DataPropertyName = "IdProducts";
            this.idProductsDataGridViewTextBoxColumn.HeaderText = "IdProducts";
            this.idProductsDataGridViewTextBoxColumn.Name = "idProductsDataGridViewTextBoxColumn";
            this.idProductsDataGridViewTextBoxColumn.ReadOnly = true;
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
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Products_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(816, 634);
            this.Controls.Add(this.Панель_админа);
            this.Controls.Add(this.dataGridView_products);
            this.Name = "Form_Products_change";
            this.Text = "Редактирование продуктов";
            this.Load += new System.EventHandler(this.Form_Products_change_Load);
            this.Панель_админа.ResumeLayout(false);
            this.Панель_админа.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Панель_админа;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_unit;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id_product;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private RestoranDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    }
}