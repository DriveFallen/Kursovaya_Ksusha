using SQLApp.RestoranDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLApp.Окна_редактирования
{
    public partial class Form_Dishes_change : Form
    {
        public SqlConnection connection;

        public Form_Dishes_change()
        {
            InitializeComponent();
            string connectionString = @"Data Source = WIN-GOSD7FOPDHE\SQLEXPRESS ;Initial Catalog = Restoran ;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void Form_Dishes_change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.restoranDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.CompositionDishes". При необходимости она может быть перемещена или удалена.
            this.compositionDishesTableAdapter.Fill(this.restoranDataSet.CompositionDishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.DishesCategories". При необходимости она может быть перемещена или удалена.
            this.dishesCategoriesTableAdapter.Fill(this.restoranDataSet.DishesCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restoranDataSet.Dishes);

            foreach (DataGridViewRow row in dataGridView_products.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[0].Value.ToString();
                    comboBox_compositionDishes_idProducts.Items.Add(cellValue);
                }
            }

            foreach (DataGridViewRow row in dataGridView_Dishes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_compositionDishes_NameDishes.Items.Add(cellValue);
                }
            }
        }

        #region dishesCategories
        private void button_dishesCategories_add_Click(object sender, EventArgs e)
        {

        }

        private void button_dishesCategories_change_Click(object sender, EventArgs e)
        {

        }

        private void button_dishesCategories_delete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region compositionDishes
        private void button_compositionDishes_add_Click(object sender, EventArgs e)
        {
            string Add_compositionDishes = "INSERT INTO [dbo].[CompositionDishes] ([IdDishes], [IdProducts], [Quantity]) SELECT Dishes.IdDishes, @idProduct, @quantity FROM Dishes WHERE NameDishes = @nameDishes";
            SqlCommand Add_compositionDishes_query = new SqlCommand(Add_compositionDishes, connection);
            SqlParameter idProduct = new SqlParameter("@idProduct", comboBox_compositionDishes_idProducts.Text);
            SqlParameter quantity = new SqlParameter("@quantity", numericUpDown_compositionDishes_quantity.Value); 
            SqlParameter nameDishes = new SqlParameter("@nameDishes", comboBox_compositionDishes_NameDishes.Text);

            connection.Open();

            Add_compositionDishes_query.Parameters.Add(idProduct);
            Add_compositionDishes_query.Parameters.Add(quantity);
            Add_compositionDishes_query.Parameters.Add(nameDishes);

            if (comboBox_compositionDishes_idProducts.Text == string.Empty) // проверка на незаполненые поля текст боксов
            {
                MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
            }
            else
            {
                Add_compositionDishes_query.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void button_compositionDishes_change_Click(object sender, EventArgs e)
        {

        }

        private void button_compositionDishes_delete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Dishes
        private void button_dishes_add_Click(object sender, EventArgs e)
        {

        }

        private void button_dishes_change_Click(object sender, EventArgs e)
        {

        }

        private void button_dishes_delete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Admin form_admin = new Form_Admin();
            form_admin.Show();
            this.Close();
        }     
    }
}
