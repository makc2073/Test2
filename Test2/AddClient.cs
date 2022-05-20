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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        public string id, name, date, money, gender;
        public bool add = false;

       
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.Cancel)// Выбор картинки
                return;
            // получаем выбранный файл
           string filename = open.FileName;
           string Name = System.IO.Path.GetFileNameWithoutExtension(filename);
           textBox4.Text = Name + ".png";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedValue.ToString();
        }

        public DataGridView table;
        
        private void AddClient_Load(object sender, EventArgs e)
        {
            ConnectBd connectBd = new ConnectBd();
            connectBd.ViewCombo("Select * From GenderTable", comboBox1);


            if (add == false)
            {
                textBox1.Text = name;
                textBox2.Text = money.Replace(",", ".");                   
                textBox3.Text = gender;
                dateTimePicker1.Value = Convert.ToDateTime(date);
            }
        }
        ConnectBd command = new ConnectBd();
        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            ConnectBd connectBd = new ConnectBd();
            if (add == true)
            {
                command.Command($"insert into Client Values('{textBox1.Text}', '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', {textBox2.Text}, {textBox3.Text})");
                MessageBox.Show("Клиент добавлен");
                connectBd.View("Select * From Client", table);
            }
            else
            {
                command.Command($"UPDATE Client SET Name = '{textBox1.Text}', Date = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', Money = {textBox2.Text}, Gender = {textBox3.Text} WHERE ID = {id}");
                MessageBox.Show("Клиент изменен");
                connectBd.View("Select * From Client", table);
            }
            
        }
    }
}
