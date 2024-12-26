using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerceDatabaseGui
{
    public partial class Form4 : Form
    {
        private MySqlConnection _connection;
        public Form4(MySqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customer";
            MySqlCommand mySqlCommand = new MySqlCommand(query, _connection);
            _connection.Open();
            //mySqlCommand.ExecuteNonQuery();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            _connection.Close();
        }
    }
}
