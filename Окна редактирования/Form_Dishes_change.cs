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

        private void UpdateWindowInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.restoranDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.CompositionDishes". При необходимости она может быть перемещена или удалена.
            this.compositionDishesTableAdapter.Fill(this.restoranDataSet.CompositionDishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.DishesCategories". При необходимости она может быть перемещена или удалена.
            this.dishesCategoriesTableAdapter.Fill(this.restoranDataSet.DishesCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restoranDataSet.Dishes);

            comboBox_compositionDishes_dishes.Items.Clear();
            comboBox_compositionDishes_products.Items.Clear();
            comboBox_dishes_Categories.Items.Clear();

            // заполняем комбо-бокс с названиями блюд из таблицы Блюда
            foreach (DataGridViewRow row in dataGridView_Dishes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_compositionDishes_dishes.Items.Add(cellValue);
                }
            }

            // заполняем комбо-бокс с продуктами их названиями из таблицы Продукты
            foreach (DataGridViewRow row in dataGridView_products.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_compositionDishes_products.Items.Add(cellValue);
                }
            }

            // заполняем комбо-бокс с категориями из таблицы Категорий блюд
            foreach (DataGridViewRow row in dataGridView_DishesCategories.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_dishes_Categories.Items.Add(cellValue);
                }
            }
        }

        private void Form_Dishes_change_Load(object sender, EventArgs e)
        {
            UpdateWindowInformation();
        }

        #region dishesCategories
        private void button_dishesCategories_add_Click(object sender, EventArgs e)
        {
            string Add_dishesCategories = "INSERT INTO DishesCategories VALUES (@name)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_dishesCategories_query = new SqlCommand(Add_dishesCategories, connection);
            SqlParameter dishesCategories_name = new SqlParameter("@name", textBox_dishesCategories_name.Text);

            try
            {
                connection.Open();

                Add_dishesCategories_query.Parameters.Add(dishesCategories_name);

                if (textBox_dishesCategories_name.Text != string.Empty) // проверка на незаполненые поля текст боксов
                {
                    Add_dishesCategories_query.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }   
        }

        private void button_dishesCategories_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM DishesCategories WHERE idCategories = @ID";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_dishesCategories_id = new SqlParameter("@ID", textBox_dishesCategories_id.Text);

            string Change_dishesCategories = "UPDATE DishesCategories SET NameCategories = @name WHERE idCategories = @ID";
            SqlCommand Change_dishesCategories_query = new SqlCommand(Change_dishesCategories, connection);
            SqlParameter dishesCategories_id = new SqlParameter("@ID", textBox_dishesCategories_id.Text);
            SqlParameter dishesCategories_name = new SqlParameter("@name", textBox_dishesCategories_name.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_dishesCategories_id);
                Change_dishesCategories_query.Parameters.Add(dishesCategories_id);
                Change_dishesCategories_query.Parameters.Add(dishesCategories_name);

                if ((textBox_dishesCategories_id.Text != string.Empty) || (textBox_dishesCategories_name.Text != string.Empty)) // проверка на незаполненые поля текст боксов
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1) // проверка на существование категории с таким ID в БД
                    {
                        Change_dishesCategories_query.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("ID категории не найден!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_dishesCategories_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM DishesCategories WHERE idCategories = @ID";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_Categories_id = new SqlParameter("@ID", textBox_dishesCategories_id.Text);

            string Delete_Categories = "DELETE FROM DishesCategories WHERE idCategories = @ID";
            SqlCommand Delete_Categories_query = new SqlCommand(Delete_Categories, connection);
            SqlParameter Categories_id = new SqlParameter("@ID", textBox_dishesCategories_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_Categories_id);
                Delete_Categories_query.Parameters.Add(Categories_id);

                if (textBox_dishesCategories_id.Text != string.Empty)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_Categories_query.ExecuteNonQuery();
                        MessageBox.Show("Категория удалён из БД", "Успех!");
                    }
                    else
                    {
                        MessageBox.Show("Категория с таким ID не найдено!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                this.dishesCategoriesTableAdapter.Fill(this.restoranDataSet.DishesCategories);
            }
        } 
        #endregion

        #region compositionDishes
        private void button_compositionDishes_add_Click(object sender, EventArgs e)
        {
            string Add_compositionDishes = "INSERT INTO CompositionDishes (IdDishes, IdProducts, Quantity) SELECT Dishes.IdDishes, Products.idProducts, @quantity FROM Dishes, Products WHERE NameDishes = @nameDishes and NameProducts = @nameProduct";
            SqlCommand Add_compositionDishes_query = new SqlCommand(Add_compositionDishes, connection);
            SqlParameter nameProduct = new SqlParameter("@nameProduct", comboBox_compositionDishes_products.Text);
            SqlParameter quantity = new SqlParameter("@quantity", numericUpDown_compositionDishes_quantity.Value); 
            SqlParameter nameDishes = new SqlParameter("@nameDishes", comboBox_compositionDishes_dishes.Text);

            try
            {
                connection.Open();

                Add_compositionDishes_query.Parameters.Add(nameProduct);
                Add_compositionDishes_query.Parameters.Add(quantity);
                Add_compositionDishes_query.Parameters.Add(nameDishes);

                if (comboBox_compositionDishes_products.Text == string.Empty) // проверка на незаполненые поля текст боксов
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
                else
                {
                    Add_compositionDishes_query.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_compositionDishes_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM CompositionDishes WHERE IdDishes = (SELECT IdDishes FROM Dishes WHERE NameDishes = @dishes) and IdProducts = (SELECT IdProducts FROM Products WHERE NameProducts = @product)";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_dishes = new SqlParameter("@dishes", comboBox_compositionDishes_dishes.Text);
            SqlParameter proverka_product = new SqlParameter("@product", comboBox_compositionDishes_products.Text);

            string Change_compositionDishes = "UPDATE CompositionDishes SET Quantity = @quantity WHERE IdDishes = (SELECT IdDishes FROM Dishes WHERE NameDishes = @nameDishes) and IdProducts = (SELECT IdProducts FROM Products WHERE NameProducts = @nameProduct)";
            SqlCommand Change_compositionDishes_query = new SqlCommand(Change_compositionDishes, connection);
            SqlParameter compositionDishes_nameProduct = new SqlParameter("@nameProduct", comboBox_compositionDishes_products.Text);
            SqlParameter compositionDishes_quantity = new SqlParameter("@quantity", numericUpDown_compositionDishes_quantity.Text);
            SqlParameter compositionDishes_nameDishes = new SqlParameter("@nameDishes", comboBox_compositionDishes_dishes.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_dishes);
                Proverka_query.Parameters.Add(proverka_product);
                Change_compositionDishes_query.Parameters.Add(compositionDishes_nameProduct);
                Change_compositionDishes_query.Parameters.Add(compositionDishes_quantity);
                Change_compositionDishes_query.Parameters.Add(compositionDishes_nameDishes);

                if (comboBox_compositionDishes_dishes.Text != string.Empty || comboBox_dishes_Categories.Text != string.Empty) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) > 0) // проверка на существование блюда и продукта с такими ID в БД
                    {
                        Change_compositionDishes_query.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Блюда с таким продуктом не найдено!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_compositionDishes_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM CompositionDishes WHERE IdDishes = (SELECT IdDishes FROM Dishes WHERE NameDishes = @dishes) and IdProducts = (SELECT IdProducts FROM Products WHERE NameProducts = @product)";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_dishes = new SqlParameter("@dishes", comboBox_compositionDishes_dishes.Text);
            SqlParameter proverka_product = new SqlParameter("@product", comboBox_compositionDishes_products.Text);

            string Delete_compositionDishes = "DELETE FROM CompositionDishes WHERE IdDishes = (SELECT IdDishes FROM Dishes WHERE NameDishes = @nameDishes) and IdProducts = (SELECT IdProducts FROM Products WHERE NameProducts = @nameProduct)";
            SqlCommand Delete_compositionDishes_query = new SqlCommand(Delete_compositionDishes, connection);
            SqlParameter compositionDishes_nameProduct = new SqlParameter("@nameProduct", comboBox_compositionDishes_products.Text);
            SqlParameter compositionDishes_nameDishes = new SqlParameter("@nameDishes", comboBox_compositionDishes_dishes.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_dishes);
                Proverka_query.Parameters.Add(proverka_product);
                Delete_compositionDishes_query.Parameters.Add(compositionDishes_nameProduct);
                Delete_compositionDishes_query.Parameters.Add(compositionDishes_nameDishes);

                if (comboBox_compositionDishes_dishes.Text != string.Empty || comboBox_dishes_Categories.Text != string.Empty) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) > 0) // проверка на существование блюда и продукта с такими ID в БД
                    {
                        Delete_compositionDishes_query.ExecuteNonQuery();
                        MessageBox.Show("Продук удален из состава блюда", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Блюда с таким продуктом не найдено!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }
        #endregion

        #region Dishes
        private void button_dishes_add_Click(object sender, EventArgs e)
        {
            string Add_Dishes = "INSERT INTO Dishes (NameDishes, Price, IdCategories) SELECT @name, @price, DishesCategories.IdCategories FROM DishesCategories WHERE NameCategories = @categories"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_Dishes_query = new SqlCommand(Add_Dishes, connection);
            SqlParameter Dishes_name = new SqlParameter("@name", textBox_dishes_name.Text);
            SqlParameter Dishes_price = new SqlParameter("@price", numericUpDown_dishes_price.Text);
            SqlParameter Dishes_nameCategories = new SqlParameter("@categories", comboBox_dishes_Categories.Text);

            try
            {
                connection.Open();

                Add_Dishes_query.Parameters.Add(Dishes_name);
                Add_Dishes_query.Parameters.Add(Dishes_price);
                Add_Dishes_query.Parameters.Add(Dishes_nameCategories);

                if ((textBox_dishesCategories_name.Text != string.Empty) || comboBox_dishes_Categories.Text != string.Empty) // проверка на незаполненые поля
                {
                    Add_Dishes_query.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_dishes_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Dishes WHERE IdDishes = @idDishes";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_idDishes = new SqlParameter("@idDishes", textBox_dishes_idDishes.Text);

            string Change_dishes = "UPDATE Dishes SET NameDishes = @name, Price = @price, IdCategories = (SELECT IDCategories FROM DishesCategories WHERE NameCategories = @nameCategories) WHERE IdDishes = @idDishes;";
            SqlCommand Change_dishes_query = new SqlCommand(Change_dishes, connection);
            SqlParameter dishes_idDishes = new SqlParameter("@idDishes", textBox_dishes_idDishes.Text);
            SqlParameter dishes_name = new SqlParameter("@name", textBox_dishes_name.Text);
            SqlParameter dishes_price = new SqlParameter("@price", numericUpDown_dishes_price.Text);
            SqlParameter dishes_nameCategories = new SqlParameter("@nameCategories", comboBox_dishes_Categories.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_idDishes);
                Change_dishes_query.Parameters.Add(dishes_idDishes);
                Change_dishes_query.Parameters.Add(dishes_nameCategories);
                Change_dishes_query.Parameters.Add(dishes_price);
                Change_dishes_query.Parameters.Add(dishes_name);

                if ((textBox_dishes_idDishes.Text != string.Empty) || (textBox_dishes_name.Text != string.Empty) || (comboBox_dishes_Categories.Text != string.Empty)) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1) // проверка на существование блюда с таким ID в БД
                    {
                        Change_dishes_query.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("ID блюда не найден!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
        }

        private void button_dishes_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Dishes WHERE IdDishes = @ID";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_Dishes_id = new SqlParameter("@ID", textBox_dishes_idDishes.Text);

            string Delete_Dishes = "DELETE FROM Dishes WHERE idDishes = @ID";
            SqlCommand Delete_Dishes_query = new SqlCommand(Delete_Dishes, connection);
            SqlParameter Dishes_id = new SqlParameter("@ID", textBox_dishes_idDishes.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_Dishes_id);
                Delete_Dishes_query.Parameters.Add(Dishes_id);

                if (textBox_dishes_idDishes.Text != string.Empty)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_Dishes_query.ExecuteNonQuery();
                        MessageBox.Show("Блюдо удалено из БД", "Успех!");
                    }
                    else
                    {
                        MessageBox.Show("Блюдо с таким ID не найдено!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Есть незаполненые поля!", "Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
                UpdateWindowInformation();
            }
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
