using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace org
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void Entrance_Click(object sender, EventArgs e)
        {
            if (Check_log_bd() == 1)
            {
                frmAdmin page = new frmAdmin();
                page.Show();
                this.Hide();
            }
            else if (Check_log_bd() == 2)
            {
                frmEmployee page = new frmEmployee();
                page.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверные данные");
        }

        private string check_password(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
        private int Check_log_bd()
        {
            SqlConnection con = new SqlConnection(@"Data Source=WIN-ПК;Initial Catalog=storage;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd = new SqlCommand("Select Логин, Пароль, Права, CотрудникНомер from Пользователь", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string userLogin = rd["Логин"].ToString();
                string passwordDB = rd["Пароль"].ToString();
                if (Login.Text.Trim() == userLogin && check_password(Password.Text.Trim()) == passwordDB)
                {
                    string rights = rd["Права"].ToString();
                    Options.FIO = rd["CотрудникНомер"].ToString();
                    if (rights == "Администратор")
                    {
                        con.Close();
                        return 1;
                    }
                    else
                    {
                        con.Close();
                        return 2;
                    }
                }
            }
            con.Close();
            return 3;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
