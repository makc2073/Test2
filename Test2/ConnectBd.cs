using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public class ConnectBd
    {
        string connectionString = "Data Source=DESKTOP-7NNKHGF;Initial Catalog=TestBd;Integrated Security=True";
        public void View(string sql, DataGridView table)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection); // создание адаптера
                DataSet ds = new DataSet(); // Выбор данных
                adapter.Fill(ds); // заполнение адаптера
                table.DataSource = ds.Tables[0]; // заполнение таблицы
                connection.Close();
            }
        }
        public void Command(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int e = command.ExecuteNonQuery();      
                connection.Close();
            }
        }
        public void ViewCombo(string sql,ComboBox comboBox)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                comboBox.DataSource = ds;
                comboBox.DisplayMember = "Gender";
                comboBox.ValueMember = "ID";
               //comboBox.ValueMember = "ID";
                connection.Close();
            }
        }
        public string Status(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                return cmd.ExecuteScalar().ToString();
                connection.Close();
            }
        }

    }
}
