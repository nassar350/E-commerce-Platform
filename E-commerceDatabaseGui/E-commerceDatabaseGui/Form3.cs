using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerceDatabaseGui
{
    public partial class Form3 : Form
    {
        int ID = 0;
        private MySqlDataReader reader;
        private MySqlConnection _connection = new MySqlConnection();
        public Form3(int id, MySqlDataReader Reader, MySqlConnection connection)
        {
            InitializeComponent();
            ID = id;
            reader = Reader;
            _connection = connection;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            txt_name.Text = reader[0].ToString();
            txt_email.Text = reader[1].ToString();
            txt_password.Text = reader[2].ToString();
            lstbox_gender.Text = reader[3].ToString();
            dateTimePicker1.Text = reader[4].ToString();
            txt_address.Text = reader[5].ToString();

            _connection.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length == 0)
            {
                MessageBox.Show("Enter a Valid Name", "Error");
            }
            else if (!txt_email.Text.Contains('@') || txt_email.Text.Length == 1 && txt_email.Text.Contains('@'))
            {
                MessageBox.Show("Enter a Valid Email", "Error");
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
                string query = $"UPDATE customer SET Name = '{txt_name.Text}', Email = '{txt_email.Text}', Password = '{txt_password.Text}'," +
                    $"Gender = '{lstbox_gender.Text}', Birth_date = '{dateTimePicker1.Text}', Address = '{txt_address.Text}'" +
                    $"WHERE Customer_id = {ID}";

                MySqlCommand mySqlCommand = new MySqlCommand(query,_connection);
                mySqlCommand.Connection.Open();

                try
                {
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated Successfully!", "Alert");
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
