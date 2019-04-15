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
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
  

    public partial class Form1 : Form
    {
        static string connStr = "server=remotemysql.com;user=VGUjNBFspl;database=VGUjNBFspl;password=8n7AJXhvtl";
        MySqlConnection conn = new MySqlConnection(connStr);

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.FileName = "file-test";
            saveFileDialog1.DefaultExt = "docx";
            saveFileDialog1.Filter = "Word Doc (*.docx)|*.docx|All files (*.*)|*.*";

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
            if (textBox3.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Ви дійсно хочете видалити робітника", "Підтверження операції", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "delete from men where id = @id";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.AddWithValue("id", textBox3.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    refetch_database();
                    textBox3.Text = "";
                }
                else textBox3.Text = "";
            }
            else MessageBox.Show("Ви не вказали ідентифиікатор для видалення");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateUser updateUserModal = new UpdateUser();
            updateUserModal.ShowDialog();
            refetch_database();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            ModalFormAddUser addUserModal = new ModalFormAddUser();
            addUserModal.ShowDialog();
            refetch_database();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refetch_database();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                 return;
             string filename = saveFileDialog1.FileName;
             System.IO.File.WriteAllText(filename, "test");
             MessageBox.Show("Файл сохранен");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Будь ласка, вводьте тільки цілі числа.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }
    }
  
}
