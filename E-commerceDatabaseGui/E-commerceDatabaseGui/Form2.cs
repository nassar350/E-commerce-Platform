using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_commerceDatabaseGui
{
    public partial class Form2 : Form
    {
        private MySqlConnection _connection = new MySqlConnection();
        public Form2(MySqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string query = "";
            bool validID = int.TryParse(txt_id.Text, out int id);
            bool customerFound = false;

            if (!validID)
            {
                MessageBox.Show("Enter a Valid ID", "Error");
            }
            else if (validID)
            {
                query = $"SELECT * FROM customer WHERE Customer_id = {Convert.ToInt32(txt_id.Text)}";

                MySqlCommand mySqlCommand = new MySqlCommand(query, _connection);
                mySqlCommand.Connection.Open();

                if (mySqlCommand.ExecuteReader().Read())
                {
                    customerFound = true;
                    MessageBox.Show("Customer is already added", "Error");
                }
                mySqlCommand.Connection.Close();
            }
            if (!customerFound && validID)
            {
                if (!txt_email.Text.Contains('@') || txt_email.Text.Length == 1 && txt_email.Text.Contains('@'))
                {
                    MessageBox.Show("Enter a Valid Email", "Error");
                }
                else if (txt_name.Text.Length == 0)
                {
                    MessageBox.Show("Enter a Valid Name", "Error");
                }
                else if (txt_password.Text.Length == 0)
                {
                    MessageBox.Show("Enter a Valid Password", "Error");
                }
                else if (lstbox_gender.Text.Length == 0)
                {
                    MessageBox.Show("Select Your Gender", "Error");
                }
                else
                {
                    query = $"INSERT INTO customer VALUES ('{Convert.ToInt32(txt_id.Text)}','{txt_name.Text}','{txt_email.Text}'," +
                    $"'{txt_password.Text}','{lstbox_gender.Text}','{dateTimePicker1.Text}','{txt_address.Text}');";

                    MySqlCommand mySqlCommand = new MySqlCommand(query, _connection);
                    mySqlCommand.Connection.Open();

                    try
                    {
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Customer Added Successfully!", "Alert");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Please TryAgain!", "Execution Error");
                    }

                    mySqlCommand.Connection.Close();
                }
            }
        }
    }
}
