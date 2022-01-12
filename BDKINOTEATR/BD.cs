using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BDKINOTEATR
{
    public partial class BD : Form
    {
        static string db = "BDKINOTEATR";
        static string sername;
        string connString;
        public BD()
        {
            InitializeComponent();
            label1.Visible = false;
            button1.Visible = false;
            comboBox1.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            db = comboBox1.Text;
            string connString = $@"Data Source=DESKTOP-08SJV26\SQLEXPRESS;Initial Catalog = {db};Integrated Security=SSPI;";
            if (db == "")
            {
                MessageBox.Show("Выберите базу данных из списка или введите название вручную.","Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool Flag = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(connString))
                    {
                        con.Open();
                    }
                }
                catch
                {
                    Flag = true;
                    MessageBox.Show("Не удалось подключиться!", "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Flag == false)
                    {
                        MessageBox.Show("Вы успешно подключены!", "Success notification.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Avtorization avto = new Avtorization();
                        this.Hide();
                        avto.Show();
                    }
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            sername = textBox1.Text;
            if (sername == "")
            {
                MessageBox.Show("Введите имя сервера!", "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connString = $@"Data Source={sername};Integrated Security=SSPI;";
                using (
                SqlConnection connection = new SqlConnection(connString))
                {
                    int i = 0;
                    SqlCommand command = new SqlCommand("SELECT name FROM sys.databases Where database_id > 4", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            i = i++;
                            comboBox1.Items.Add(reader.GetString(i));
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                label1.Visible = true;
                button1.Visible = true;
                comboBox1.Visible = true;
                button2.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
            }
        }
    }
}

