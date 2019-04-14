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

namespace WindowsFormsApp2
{
    public partial class ModalFormAddUser : Form
    {
        public ModalFormAddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=remotemysql.com;user=VGUjNBFspl;database=VGUjNBFspl;password=8n7AJXhvtl";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "insert into men (id,surname,workshop_number,count_of_product_A,count_of_product_B,count_of_product_C) values (null,@surname,@workshop_number,@count_a,@count_b,@count_c)";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("surname", textBox1.Text);
            command.Parameters.AddWithValue("workshop_number", textBox2.Text);
            command.Parameters.AddWithValue("count_a", textBox3.Text);
            command.Parameters.AddWithValue("count_b", textBox4.Text);
            command.Parameters.AddWithValue("count_c", textBox5.Text);
            command.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
