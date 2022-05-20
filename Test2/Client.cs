using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        ConnectBd bd = new ConnectBd();
        private void Client_Load(object sender, EventArgs e)
        {
            bd.View("Select * From Client", dataGridView1);
            bd.View("Select Client.ID,Name,Date,Money, GenderTable.Gender From Client  JOIN GenderTable  ON Client.Gender = GenderTable.ID", dataGridView2);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddClient a = new AddClient();
            a.add = true;
            a.table = dataGridView1;
            a.ShowDialog();
        }

        private void del_Click(object sender, EventArgs e)
        {
            bd.Command($"delete from Client Where ID = {textBox1.Text}");
            bd.View("Select Client.ID,Name,Date,Money, GenderTable.Gender From Client  JOIN GenderTable  ON Client.Gender = GenderTable.ID", dataGridView2);
            bd.View("Select * From Client", dataGridView1);
        }
        string id, name, date, money, gender;

        private void UpdTableBtn_Click(object sender, EventArgs e)
        {
            bd.View("Select Client.ID,Name,Date,Money, GenderTable.Gender From Client  JOIN GenderTable  ON Client.Gender = GenderTable.ID", dataGridView2);
            bd.View("Select * From Client", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Updform_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.id = id;
            s.name = name;
            s.date = date;
            s.money = money;
            s.gender = gender;
            s.ShowDialog();     
           
        }

        bool select = false;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select = true;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];           
            id = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();// row.Cells[1].Value;
            name = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();// row.Cells[1].Value;
            date = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();// row.Cells[1].Value;
            money = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();// row.Cells[1].Value;
            gender = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();// row.Cells[1].Value;
            textBox1.Text = id;
            
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
           if (select == true)
            {
                AddClient a = new AddClient();
                a.id = id;
                a.name = name;
                a.date = date;
                a.money = money;
                a.gender = gender;
                a.table = dataGridView1;
                a.ShowDialog();
            }else
            { MessageBox.Show("Выбреите клиента"); }
        }
    }
}
