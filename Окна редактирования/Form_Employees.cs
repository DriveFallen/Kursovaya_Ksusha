using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLApp.Окна_редактирования
{
    public partial class Form_Employees : Form
    {
        public SqlConnection connection;

        public Form_Employees()
        {
            InitializeComponent();
            string connectionString = @"Data Source = WIN-GOSD7FOPDHE\SQLEXPRESS ;Initial Catalog = Restoran ;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UpdateWindowInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.restoranDataSet.Employees);
        }

        private void Form_Employees_Load(object sender, EventArgs e)
        {
            UpdateWindowInformation();
        }

        private void button_employees_add_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Employees WHERE Login = @login";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_login = new SqlParameter("@login", textBox_employees_login.Text);

            string Add = "INSERT INTO Employees VALUES (@fullName, @number, @post, @login, @password)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_query = new SqlCommand(Add, connection);
            SqlParameter fullName = new SqlParameter("@fullName", textBox_employees_fullName.Text);
            SqlParameter number = new SqlParameter("@number", textBox_employees_number.Text);
            SqlParameter post = new SqlParameter("@post", textBox_employees_post.Text);
            SqlParameter login = new SqlParameter("@login", textBox_employees_login.Text);
            SqlParameter password = new SqlParameter("@password", textBox_employees_password.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_login);
                Add_query.Parameters.Add(fullName);
                Add_query.Parameters.Add(number);
                Add_query.Parameters.Add(post);
                Add_query.Parameters.Add(login);
                Add_query.Parameters.Add(password);

                if (textBox_employees_fullName.Text != string.Empty || textBox_employees_number.Text != string.Empty || textBox_employees_post.Text != string.Empty || textBox_employees_login.Text != string.Empty || textBox_employees_password.Text != string.Empty)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 0)
                    {
                        Add_query.ExecuteNonQuery();
                        MessageBox.Show("Данные внесены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Логин уже занят", "Ошибка!");
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

        private void button_employees_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Employees WHERE IdEmployees = @ID";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_ID = new SqlParameter("@ID", textBox_employees_id.Text);

            string Change = "UPDATE Employees SET FullName = @fullName, PhoneNumber = @number, Post = @post, Login = @login, Password = @password WHERE IdEmployees = @ID";
            SqlCommand Change_query = new SqlCommand(Change, connection);
            SqlParameter ID = new SqlParameter("@ID", textBox_employees_id.Text);
            SqlParameter fullName = new SqlParameter("@fullName", textBox_employees_fullName.Text);
            SqlParameter number = new SqlParameter("@number", textBox_employees_number.Text);
            SqlParameter post = new SqlParameter("@post", textBox_employees_post.Text);
            SqlParameter login = new SqlParameter("@login", textBox_employees_login.Text);
            SqlParameter password = new SqlParameter("@password", textBox_employees_password.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_ID);
                Change_query.Parameters.Add(ID);
                Change_query.Parameters.Add(fullName);
                Change_query.Parameters.Add(number);
                Change_query.Parameters.Add(post);
                Change_query.Parameters.Add(login);
                Change_query.Parameters.Add(password);

                if (textBox_employees_id.Text != string.Empty || textBox_employees_fullName.Text != string.Empty || textBox_employees_number.Text != string.Empty || textBox_employees_post.Text != string.Empty || textBox_employees_login.Text != string.Empty || textBox_employees_password.Text != string.Empty)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Change_query.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Работник с таким ID не найден", "Ошибка!");
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

        private void button_employees_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Employees WHERE IdEmployees = @ID";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_ID = new SqlParameter("@ID", textBox_employees_id.Text);

            string Delete = "DELETE FROM Employees WHERE IdEmployees = @ID";
            SqlCommand Delete_query = new SqlCommand(Delete, connection);
            SqlParameter ID = new SqlParameter("@ID", textBox_employees_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_ID);
                Delete_query.Parameters.Add(ID);

                if (textBox_employees_id.Text != string.Empty)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_query.ExecuteNonQuery();
                        MessageBox.Show("Работник удалён", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Работник с таким ID не найден", "Ошибка!");
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

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Admin form_admin = new Form_Admin();
            form_admin.Show();
            this.Close();
        }
    }
}
