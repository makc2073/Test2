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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            ConnectBd connectBd = new ConnectBd();
            connectBd.Command($"UPDATE Client SET Name = '{textBox1.Text}', Date = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', Money = {textBox3.Text}, Gender = {textBox4.Text} WHERE ID = {id}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            dateTimePicker1.Value = Convert.ToDateTime(date);
            textBox3.Text = money.Replace(",", ".");
            textBox4.Text = gender;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       public string id, name, date, money, gender;

    }
}
