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

        private void refetch_database()
        {
            conn.Open();
            string sql = "SELECT * from men";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();

            }
            foreach (string[] s in data) { dataGridView1.Rows.Add(s); }
        conn.Close();
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
           /* string sql = "update men set age = @age, name = @name where id = @id";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("id", textBox2.Text);
            command.Parameters.AddWithValue("age", textBox5.Text);
            command.Parameters.AddWithValue("name", textBox6.Text);
            command.ExecuteNonQuery();
            conn.Close();*/
            refetch_database();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            ModalFormAddUser addUserModal = new ModalFormAddUser();
            addUserModal.ShowDialog();
            refetch_database();
        }
    }
  
}
