using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLApp.Окна_редактирования
{
    public partial class Form_Orders : Form
    {
        public SqlConnection connection;

        public Form_Orders()
        {
            InitializeComponent();
            string connectionString = @"Data Source = WIN-GOSD7FOPDHE\SQLEXPRESS ;Initial Catalog = Restoran ;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }
        private void UpdateWindowInformation()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.restoranDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.PreOrders". При необходимости она может быть перемещена или удалена.
            this.preOrdersTableAdapter.Fill(this.restoranDataSet.PreOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.StatusPreOrders". При необходимости она может быть перемещена или удалена.
            this.statusPreOrdersTableAdapter.Fill(this.restoranDataSet.StatusPreOrders);

            // заполняем комбо-бокс с статусами заказов из таблицы Статусы
            foreach (DataGridViewRow row in dataGridView_statusPreOrders.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_preOrders_status.Items.Add(cellValue);
                }
            }

            // заполняем комбо-бокс с блюдами из таблицы Блюд
            foreach (DataGridViewRow row in dataGridView_dishes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_preOrders_dishes.Items.Add(cellValue);
                }
            }

            // заполняем комбо-бокс с работниками из таблицы Работники
            foreach (DataGridViewRow row in dataGridView_employers.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_orders_employer.Items.Add(cellValue);
                }
            }

            // заполняем комбо-бокс с клиентами из таблицы Клиенты
            foreach (DataGridViewRow row in dataGridView_clients.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string cellValue = row.Cells[1].Value.ToString();
                    comboBox_orders_client.Items.Add(cellValue);
                }
            }
        }

        private void Form_Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.restoranDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.restoranDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restoranDataSet.Dishes);

            UpdateWindowInformation();
        }

        private void button_statusPreOrders_add_Click(object sender, EventArgs e)
        {
            string Add_statusPreOrders = "INSERT INTO StatusPreOrders VALUES (@name)"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_statusPreOrders_query = new SqlCommand(Add_statusPreOrders, connection);
            SqlParameter StatusPreOrders_fullName = new SqlParameter("@name", textBox_statusPreOrders_nameStatus.Text);

            try
            {
                connection.Open();

                Add_statusPreOrders_query.Parameters.Add(StatusPreOrders_fullName);

                if (textBox_statusPreOrders_nameStatus.Text != string.Empty) // проверка на незаполненые поля
                {
                    Add_statusPreOrders_query.ExecuteNonQuery();
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

        private void button_statusPreOrders_change_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM StatusPreOrders WHERE IdStatus = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_statusPreOrders_id.Text);

            string Change_statusPreOrders = "UPDATE StatusPreOrders SET NameStatus = @name WHERE IdStatus = @id";
            SqlCommand Change_statusPreOrders_query = new SqlCommand(Change_statusPreOrders, connection);
            SqlParameter statusPreOrders_id = new SqlParameter("@id", textBox_statusPreOrders_id.Text);
            SqlParameter statusPreOrders_fullName = new SqlParameter("@name", textBox_statusPreOrders_nameStatus.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Change_statusPreOrders_query.Parameters.Add(statusPreOrders_id);
                Change_statusPreOrders_query.Parameters.Add(statusPreOrders_fullName);


                if (textBox_statusPreOrders_id.Text != string.Empty || textBox_statusPreOrders_nameStatus.Text != string.Empty) // проверка на незаполненые поля
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1) // проверка на существование статуса с таким ID в БД
                    {
                        Change_statusPreOrders_query.ExecuteNonQuery();
                        MessageBox.Show("Данные изменены", "Успешно");
                    }
                    else
                    {
                        MessageBox.Show("ID статуса не найден!", "Ошибка!");
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

        private void button_statusPreOrders_delete_Click(object sender, EventArgs e)
        {
            string Proverka = "SELECT count(*) FROM StatusPreOrders WHERE IdStatus = @id";
            SqlCommand Proverka_query = new SqlCommand(Proverka, connection);
            SqlParameter proverka_id = new SqlParameter("@id", textBox_statusPreOrders_id.Text);

            string Delete_statusPreOrders = "DELETE FROM StatusPreOrders WHERE IdStatus = @id";
            SqlCommand Delete_statusPreOrders_query = new SqlCommand(Delete_statusPreOrders, connection);
            SqlParameter statusPreOrders_id = new SqlParameter("@id", textBox_statusPreOrders_id.Text);

            try
            {
                connection.Open();

                Proverka_query.Parameters.Add(proverka_id);
                Delete_statusPreOrders_query.Parameters.Add(statusPreOrders_id);

                if (textBox_statusPreOrders_id.Text != string.Empty)
                {
                    if (Convert.ToInt32(Proverka_query.ExecuteScalar()) == 1)
                    {
                        Delete_statusPreOrders_query.ExecuteNonQuery();
                        MessageBox.Show("Статус удален из БД", "Успех!");
                    }
                    else
                    {
                        MessageBox.Show("Статуса с таким ID не найдено!", "Ошибка!");
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


        private void button_preOrders_add_Click(object sender, EventArgs e)
        {

        }

        private void button_preOrders_change_Click(object sender, EventArgs e)
        {

        }

        private void button_preOrders_delete_Click(object sender, EventArgs e)
        {

        }


        private void button_orders_add_Click(object sender, EventArgs e)
        {
            string Add_orders = "INSERT INTO Orders (DateTimeOrders, IdEmployees, IdClients, NumberTables, PriceOrders) SELECT @dateTime, Employees.IdEmployees, Clients.IdClients, @table, 0 FROM Employees, Clients WHERE Employees.FullName = @employer and Clients.FullName = @client"; // не прописываем ID так как стоит автоматический счёт в самой БД
            SqlCommand Add_orders_query = new SqlCommand(Add_orders, connection);
            SqlParameter Orders_dateTime = new SqlParameter("@dateTime", dateTimePicker_orders_dateTime.Value);
            SqlParameter Orders_employer = new SqlParameter("@employer", comboBox_orders_employer.Text);
            SqlParameter Orders_client = new SqlParameter("@client", comboBox_orders_client.Text);
            SqlParameter Orders_table = new SqlParameter("@table", textBox_orders_numberTable.Text);         

            try
            {
                connection.Open();

                Add_orders_query.Parameters.Add(Orders_dateTime);
                Add_orders_query.Parameters.Add(Orders_employer);
                Add_orders_query.Parameters.Add(Orders_client);
                Add_orders_query.Parameters.Add(Orders_table);

                if (comboBox_orders_employer.Text != string.Empty || comboBox_orders_client.Text != string.Empty || textBox_orders_numberTable.Text != string.Empty) // проверка на незаполненые поля
                {
                    Add_orders_query.ExecuteNonQuery();
                    MessageBox.Show("Заказ добавлен", "Успех");
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

        private void button_orders_change_Click(object sender, EventArgs e)
        {

        }

        private void button_orders_delete_Click(object sender, EventArgs e)
        {

        }


        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Admin form = new Form_Admin();
            form.Show();
            this.Close();
        }

    }
}
