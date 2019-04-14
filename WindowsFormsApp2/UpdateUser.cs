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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }
 

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            string connStr = "server=remotemysql.com;user=VGUjNBFspl;database=VGUjNBFspl;password=8n7AJXhvtl";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * from men";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               comboBox1.Items.Add(reader[0].ToString());

            }
            reader.Close();
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
             string connStr = "server=remotemysql.com;user=VGUjNBFspl;database=VGUjNBFspl;password=8n7AJXhvtl";
              MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();


              string sql = "SELECT * from men where id =" + selectedState; 
                MySqlCommand command = new MySqlCommand(sql, conn);
               MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[1].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();
                    textBox4.Text = reader[4].ToString();
                    textBox5.Text = reader[5].ToString();
                }
              reader.Close();
                conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            string connStr = "server=remotemysql.com;user=VGUjNBFspl;database=VGUjNBFspl;password=8n7AJXhvtl";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "update men set surname = @surname, workshop_number =@workshop_number ,count_of_product_A = @count_a ,count_of_product_B = @count_b,count_of_product_C= @count_c where id = @id ";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", selectedState);
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
