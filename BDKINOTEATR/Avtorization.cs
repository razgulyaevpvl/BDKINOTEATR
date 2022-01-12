using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDKINOTEATR
{
    public partial class Avtorization : Form
    {
        public List<Avtorizaciya> Avtor = new List<Avtorizaciya>();
        public List<Roli> Rolex = new List<Roli>();
        public Avtorization()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelBD connect = new ModelBD();
            Avtor = connect.Avtorizaciya.ToList();
            string Logins = textBox1.Text;
            string Passwords = textBox2.Text;
            if (Logins != "" && Passwords != "")
            {
                Avtorizaciya f = Avtor.Find(item => item.Login == Logins && item.Password == Passwords);
                if (f == null)
                {
                    MessageBox.Show("Логин или пароль не верны!", "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (f.Login == Logins && f.Password == Passwords)
                {
                    if (f.IDRols == 1)
                    {
                        MessageBox.Show("Авторизация Администратора выполнена успешно!", "Success notification.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    if (f.IDRols == 2)
                    {
                        MessageBox.Show("Авторизация Пользователя выполнена успешно!", "Success notification.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    BDKINOTEATR bd = new BDKINOTEATR();
                    this.Hide();
                    bd.Show();
                }
            }
            else if (Logins == "" && Passwords != "")
            {
                MessageBox.Show("Введите логин!", "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Logins != "" && Passwords == "")
            {
                MessageBox.Show("Введите пароль!", "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Введите данные!", "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Avtorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
