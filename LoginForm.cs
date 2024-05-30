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

namespace SQLApp
{
    public partial class LoginForm : Form
    {
        public SqlConnection connection;

        public LoginForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source = WIN-GOSD7FOPDHE\SQLEXPRESS ;Initial Catalog = Restoran ;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            string Query = "Select count(*) from Employees where Login = @login";
            SqlCommand Select_Login = new SqlCommand(Query, connection);
            SqlParameter parametr_login = new SqlParameter("@login", LoginField.Text);
            Select_Login.Parameters.Add(parametr_login);

            string Query_2 = "Select count(*) from Employees where Login = @login and HashPassword = HASHBYTES('SHA2_512', @password)";
            SqlCommand Select_Log_Pass = new SqlCommand(Query_2, connection);
            SqlParameter parametr_login_2 = new SqlParameter("@login", LoginField.Text);
            SqlParameter parametr_password_2 = new SqlParameter("@password", PassField.Text);
            Select_Log_Pass.Parameters.Add(parametr_login_2);
            Select_Log_Pass.Parameters.Add(parametr_password_2);

            string Query_3 = "Select count(*) from Employees where Login = @login and HashPassword = HASHBYTES('SHA2_512', @password) and Post = 'Admin'";
            SqlCommand Select_Login_Pass_Adm = new SqlCommand(Query_3, connection);
            SqlParameter parametr_login_3 = new SqlParameter("@login", LoginField.Text);
            SqlParameter parametr_password_3 = new SqlParameter("@password", PassField.Text);
            Select_Login_Pass_Adm.Parameters.Add(parametr_login_3);
            Select_Login_Pass_Adm.Parameters.Add(parametr_password_3);

            try
            {
                connection.Open();

                if (Convert.ToInt32(Select_Login.ExecuteScalar()) >= 1)
                {
                    if (Convert.ToInt32(Select_Log_Pass.ExecuteScalar()) == 1)
                    {
                        if (Convert.ToInt32(Select_Login_Pass_Adm.ExecuteScalar()) == 1)
                        {
                            Form_Admin form_admin = new Form_Admin();
                            form_admin.Show();
                            MessageBox.Show("Авторизация под Администратором успешной пройдена, \n добро пожаловать на сервер ШиЗоФрЕнИя!", "Авторизация");
                            this.Hide();
                        }
                        else
                        {
                            Form_Main form_main = new Form_Main();
                            form_main.Show();
                            MessageBox.Show("Авторизация в режиме просмотра успешной пройдена, \n добро пожаловать на сервер ШиЗоФрЕнИя!", "Авторизация");
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль, \n Попробуйте снова!", "Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Такой пользователь не обнаружен, \n Попробуйте снова!", "Ошибка!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "пиздец");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
