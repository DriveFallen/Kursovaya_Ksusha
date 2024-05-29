using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp.Окна_редактирования
{
    public partial class Form_Products_change : Form
    {
        public SqlConnection connection;

        public Form_Products_change()
        {
            InitializeComponent();
            string connectionString = @"Data Source = WIN-GOSD7FOPDHE\SQLEXPRESS ;Initial Catalog = Restoran ;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void Form_Products_change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.restoranDataSet.Products);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Admin form_admin = new Form_Admin();
            form_admin.Show();
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // проверка при добавлении, существует ли уже продукт с таким названием
            string Proverka = "SELECT count(*) FROM Products WHERE idProducts = (SELECT idProducts WHERE NameProducts = @name)";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_product_id = new SqlParameter("@name", textBox_name.Text);

            // запрос на добавление нового продукта
            string Add_product = "INSERT INTO Products VALUES (@name, @unit)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_product_query = new SqlCommand(Add_product, connection);
            SqlParameter product_name = new SqlParameter("@name", textBox_name.Text);
            SqlParameter product_unit = new SqlParameter("@unit", textBox_unit.Text);      

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_product_id);
                Add_product_query.Parameters.Add(product_name);
                Add_product_query.Parameters.Add(product_unit);

                if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                {
                    if ((textBox_name.Text == string.Empty) || (textBox_unit.Text == string.Empty)) // проверка на незаполненые поля текст боксов
                    {
                        MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                    }
                    else
                    {
                        Add_product_query.ExecuteNonQuery();
                        MessageBox.Show("Продук добавлен", "Успех!");
                    }
                }    
                else
                {
                    MessageBox.Show("Такой продукт уже существует", "Ошибка!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при добавлении продукта!","Error");
            }
            finally
            {
                connection.Close();
                this.productsTableAdapter.Fill(this.restoranDataSet.Products);
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Products WHERE idProducts = @ID";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_product_id = new SqlParameter("@ID", textBox_id_product.Text);

            string Change_product = "UPDATE Products SET NameProducts = @name, Unit = @unit WHERE idProducts = @ID"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Change_product_query = new SqlCommand(Change_product, connection);
            SqlParameter product_id = new SqlParameter("@ID", textBox_id_product.Text);
            SqlParameter product_name = new SqlParameter("@name", textBox_name.Text);
            SqlParameter product_unit = new SqlParameter("@unit", textBox_unit.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_product_id);
                Change_product_query.Parameters.Add(product_id);
                Change_product_query.Parameters.Add(product_name);
                Change_product_query.Parameters.Add(product_unit);

                if ((textBox_id_product.Text == string.Empty) || (textBox_name.Text == string.Empty) || (textBox_unit.Text == string.Empty)) // проверка на незаполненые поля текст боксов
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
                else
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1) // проверка на существование товара с таким ID в БД
                    {
                        Change_product_query.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("ID товара не найден!", "Ошибка!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            finally
            {
                connection.Close();
                this.productsTableAdapter.Fill(this.restoranDataSet.Products);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Products WHERE idProducts = @ID";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_product_id = new SqlParameter("@ID", textBox_id_product.Text);

            string Delete_product = "DELETE FROM Products WHERE idProducts = @ID";
            SqlCommand Delete_product_query = new SqlCommand(Delete_product, connection);
            SqlParameter product_id = new SqlParameter("@ID", textBox_id_product.Text);

            try
            {
            connection.Open();

            Proverka_query.Parameters.Add(proverka_product_id);
            Delete_product_query.Parameters.Add(product_id);

            if (textBox_id_product.Text == string.Empty)
            {
                MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
            }
            else
            {
                if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                {
                    Delete_product_query.ExecuteNonQuery();
                    MessageBox.Show("Товар удалён из БД", "Успех!");
                }
                else
                {
                    MessageBox.Show("Товара с таким ID не найдено!", "Ошибка!");
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                this.productsTableAdapter.Fill(this.restoranDataSet.Products);
            }
        }
    }
}
