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
    public partial class Form1 : Form
    {
        static string connStr = "server=remotemysql.com;user=VGUjNBFspl;database=VGUjNBFspl;password=8n7AJXhvtl";
        MySqlConnection conn = new MySqlConnection(connStr);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refetch_database();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "insert into men (id,age,name) values (null,@age,@name)";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("age", textBox1.Text);
            command.Parameters.AddWithValue("name", textBox4.Text);
            command.ExecuteNonQuery();
            conn.Close();
            refetch_database();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refetch_database();
        }

        private void refetch_database()
        {
            conn.Open();
            string sql = "SELECT * from men";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Insert(0, reader[0].ToString() + " " + reader[1].ToString() + "  " + reader[2].ToString());
                i++;
            }
            conn.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "delete from men where id = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", textBox3.Text);
            command.ExecuteNonQuery();
            conn.Close();
            refetch_database();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "update men set age = @age, name = @name where id = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", textBox2.Text);
            command.Parameters.AddWithValue("age", textBox5.Text);
            command.Parameters.AddWithValue("name", textBox6.Text);
            command.ExecuteNonQuery();
            conn.Close();
            refetch_database();
        }
        private string sortBy()
        {
            string isASC;
            if (checkBox1.Checked == true)
            {
                isASC = "ASC";
            }
            else
            {
                isASC = "DESC";
            }
            return isASC;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string filter = sortBy();
            conn.Open();
            string sql = "select * from men order by id "+ filter;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Insert(0, reader[0].ToString() + " " + reader[1].ToString() + "  " + reader[2].ToString());
                i++;
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filter = sortBy();
            conn.Open();
            string sql = "select * from men order by age " + filter;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Insert(0, reader[0].ToString() + " " + reader[1].ToString() + "  " + reader[2].ToString());
                i++;
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filter = sortBy();
            conn.Open();
            string sql = "select * from men order by name " + filter;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            int i = 0;
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Insert(0, reader[0].ToString() + " " + reader[1].ToString() + "  " + reader[2].ToString());
                i++;
            }
            conn.Close();
        }
    }

}
