using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLApp.Окна_редактирования
{
    public partial class Form_Clients : Form
    {
        public SqlConnection connection;

        public Form_Clients()
        {
            InitializeComponent();
            string connectionString = @"Data Source = WIN-GOSD7FOPDHE\SQLEXPRESS ;Initial Catalog = Restoran ;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void UpdateWindowInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.restoranDataSet.Clients);
        }

        private void Form_Clients_Load(object sender, EventArgs e)
        {
            UpdateWindowInformation();
        }

        private void button_clients_add_Click(object sender, EventArgs e)
        {
            string Add_Clients = "INSERT INTO Clients VALUES (@fullName)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_Clients_query = new SqlCommand(Add_Clients, connection);
            SqlParameter Clients_fullName = new SqlParameter("@fullName", textBox_clients_fullName.Text);

            try
            {
                connection.Open();

                Add_Clients_query.Parameters.Add(Clients_fullName);

                if (textBox_clients_fullName.Text != string.Empty) // проверка на незаполненые поля
                {
                    Add_Clients_query.ExecuteNonQuery();
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

        private void button_clients_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Clients WHERE IdClients = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_clients_id.Text);

            string Change_clients = "UPDATE Clients SET FullName = @fullName WHERE IdClients = @id";
            SqlCommand Change_clients_query = new SqlCommand(Change_clients, connection);
            SqlParameter clients_id = new SqlParameter("@id", textBox_clients_id.Text);
            SqlParameter clients_fullName = new SqlParameter("@fullName", textBox_clients_fullName.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_clients_query.Parameters.Add(clients_id);
                Change_clients_query.Parameters.Add(clients_fullName);


                if ((textBox_clients_id.Text != string.Empty) || (textBox_clients_fullName.Text != string.Empty)) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1) // проверка на существование блюда с таким ID в БД
                    {
                        Change_clients_query.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("ID клиента не найден!", "Ошибка!");
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

        private void button_clients_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM Clients WHERE IdClients = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_clients_id.Text);

            string Delete_Clients = "DELETE FROM Clients WHERE IdClients = @ID";
            SqlCommand Delete_Clients_query = new SqlCommand(Delete_Clients, connection);
            SqlParameter Clients_id = new SqlParameter("@ID", textBox_clients_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Delete_Clients_query.Parameters.Add(Clients_id);

                if (textBox_clients_id.Text != string.Empty)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_Clients_query.ExecuteNonQuery();
                        MessageBox.Show("Клиент удален из БД", "Успех!");
                    }
                    else
                    {
                        MessageBox.Show("Клиента с таким ID не найдено!", "Ошибка!");
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
