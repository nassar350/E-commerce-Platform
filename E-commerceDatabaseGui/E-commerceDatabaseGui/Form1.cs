using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using System;
using MySql.Data.MySqlClient;
using DotNetEnv;

namespace E_commerceDatabaseGui
{
    public partial class Form1 : Form
    {
        string DB_Connection = "";

        private MySqlConnection _connection = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Env.Load();

            DB_Connection = $"Server={Env.GetString("DB_server")};Database={Env.GetString("DB_name")};" +
                $"User={Env.GetString("DB_user")};Password={Env.GetString("DB_password")};Port={Env.GetString("DB_port")};";

            try
            {
                _connection = new MySqlConnection(DB_Connection);
                _connection.Open();
                _connection.Close();
            }
            catch
            {
                MessageBox.Show($"Please TryAgain.", "Connection Error!");
                this.Close();
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2(_connection);
            add.ShowDialog();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            bool validID = int.TryParse(txtbox_id.Text, out int ID);

            if (validID)
            {
                string query = $"SELECT Name, Email, Password, Gender, Birth_date, Address FROM customer " +
                    $"WHERE Customer_id = {Convert.ToInt32(txtbox_id.Text)}";

                MySqlCommand mySqlCommand = new MySqlCommand(query, _connection);
                mySqlCommand.Connection.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    Form3 update = new Form3(ID, reader, _connection);
                    update.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Customer NOT Found!", "Error");
                }
                mySqlCommand.Connection.Close();
            }
            else
            {
                MessageBox.Show("Enter a Valid ID", "Error");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool validID = int.TryParse(txtbox_id.Text, out int ID);

            if (validID)
            {
                string query = $"SELECT * FROM customer WHERE Customer_id = {Convert.ToInt32(txtbox_id.Text)}";

                MySqlCommand mySqlCommand = new MySqlCommand(query, _connection);
                mySqlCommand.Connection.Open();

                if (mySqlCommand.ExecuteReader().Read())
                {
                    query = $"DELETE FROM customer WHERE Customer_id = {Convert.ToInt32(txtbox_id.Text)}";
                    mySqlCommand = new MySqlCommand(query, _connection);
                    mySqlCommand.Connection.Close();

                    try
                    {
                        mySqlCommand.Connection.Open();
                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Customer Removed Successfully!", "Alert");
                    }
                    catch
                    {
                        MessageBox.Show("Please TryAgain!", "Execution Error");
                    }
                    mySqlCommand.Connection.Close();
                }
                else
                {
                    MessageBox.Show("Customer NOT Found!", "Error");
                }
                mySqlCommand.Connection.Close();
            }
            else
            {
                MessageBox.Show("Enter a Valid ID", "Error");
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(_connection);
            form4.ShowDialog();
        }
    }
}
