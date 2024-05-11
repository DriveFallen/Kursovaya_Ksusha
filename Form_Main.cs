using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.restoranDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.StatusPreOrders". При необходимости она может быть перемещена или удалена.
            this.statusPreOrdersTableAdapter.Fill(this.restoranDataSet.StatusPreOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.PreOrders". При необходимости она может быть перемещена или удалена.
            this.preOrdersTableAdapter.Fill(this.restoranDataSet.PreOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.restoranDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.restoranDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.DishesCategories". При необходимости она может быть перемещена или удалена.
            this.dishesCategoriesTableAdapter.Fill(this.restoranDataSet.DishesCategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restoranDataSet.Dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.CompositionDishes". При необходимости она может быть перемещена или удалена.
            this.compositionDishesTableAdapter.Fill(this.restoranDataSet.CompositionDishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.restoranDataSet.Clients);

        }

        private void button_tableProductsShow_Click(object sender, EventArgs e)
        {
            //dataGridView_products.Visible = false;
            dataGridView_compositionDishes.Visible = false;
            dataGridView_dishes.Visible = false;
            dataGridView_dishesCategories.Visible = false;
            dataGridView_employees.Visible = false;
            dataGridView_orders.Visible = false;
            dataGridView_preOrders.Visible = false;
            dataGridView_statusPreOrders.Visible = false;
            dataGridView_clients.Visible = false;

            if (dataGridView_products.Visible == false)
            {
                dataGridView_products.Visible = true;
            }
            else
            {
                dataGridView_products.Visible = false;
            }
        }

        private void button_tableDishesShow_Click(object sender, EventArgs e)
        {
            dataGridView_products.Visible = false;
            //dataGridView_dishes.Visible = false;
            //dataGridView_compositionDishes.Visible = false;
            //dataGridView_dishesCategories.Visible = false;
            dataGridView_employees.Visible = false;
            dataGridView_orders.Visible = false;
            dataGridView_preOrders.Visible = false;
            dataGridView_statusPreOrders.Visible = false;
            dataGridView_clients.Visible = false;

            if (dataGridView_dishes.Visible == false)
            {
                dataGridView_dishes.Visible = true;
                dataGridView_compositionDishes.Visible = true;
                dataGridView_dishesCategories.Visible = true;
            }
            else
            {
                dataGridView_dishes.Visible = false;
                dataGridView_compositionDishes.Visible = false;
                dataGridView_dishesCategories.Visible = false;
            }
        }

        private void button_tableEmployerShow_Click(object sender, EventArgs e)
        {
            dataGridView_products.Visible = false;
            dataGridView_compositionDishes.Visible = false;
            dataGridView_dishes.Visible = false;
            dataGridView_dishesCategories.Visible = false;
            //dataGridView_employees.Visible = false;
            dataGridView_orders.Visible = false;
            dataGridView_preOrders.Visible = false;
            dataGridView_statusPreOrders.Visible = false;
            dataGridView_clients.Visible = false;

            if (dataGridView_employees.Visible == false)
            {
                dataGridView_employees.Visible = true;
            }
            else
            {
                dataGridView_employees.Visible = false;
            }
        }

        private void button_tableOrderShow_Click(object sender, EventArgs e)
        {

            dataGridView_products.Visible = false;
            dataGridView_compositionDishes.Visible = false;
            dataGridView_dishes.Visible = false;
            dataGridView_dishesCategories.Visible = false;
            dataGridView_employees.Visible = false;
            //dataGridView_orders.Visible = false;
            //dataGridView_preOrders.Visible = false;
            //dataGridView_statusPreOrders.Visible = false;
            dataGridView_clients.Visible = false;

            if (dataGridView_orders.Visible == false)
            {
                dataGridView_orders.Visible = true;
                dataGridView_preOrders.Visible = true;
                dataGridView_statusPreOrders.Visible = true;
            }
            else
            {
                dataGridView_orders.Visible = false;
                dataGridView_preOrders.Visible = false;
                dataGridView_statusPreOrders.Visible = false;
            }
        }

        private void button_tableClientShow_Click(object sender, EventArgs e)
        {
            dataGridView_products.Visible = false;
            dataGridView_compositionDishes.Visible = false;
            dataGridView_dishes.Visible = false;
            dataGridView_dishesCategories.Visible = false;
            dataGridView_employees.Visible = false;
            dataGridView_orders.Visible = false;
            dataGridView_preOrders.Visible = false;
            dataGridView_statusPreOrders.Visible = false;
            //dataGridView_clients.Visible = false;

            if (dataGridView_clients.Visible == false)
            {
                dataGridView_clients.Visible = true;
            }
            else
            {
                dataGridView_clients.Visible = false;
            }
        }

        private void button_tableProductsChange_Click(object sender, EventArgs e)
        {

        }

        private void button_tableDishesChange_Click(object sender, EventArgs e)
        {

        }

        private void button_tableOrderChange_Click(object sender, EventArgs e)
        {

        }

        private void button_tableClientChange_Click(object sender, EventArgs e)
        {

        }

        private void button_tableEmployerChange_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
