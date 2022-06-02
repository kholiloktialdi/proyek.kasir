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

namespace appkasir
{
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi Konn = new Koneksi();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from TBL_KASIR WHERE KodeKasir='" + textBox1.Text + "' and PasswordKasir='" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FormMenuUtama frmUtama = new FormMenuUtama();
                    MessageBox.Show("Berhasil Login");
                    frmUtama.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Login Gagal!");
                }
            }



            //if (textBox1.Text == "admin" && textBox2.Text == "admin")
            //{
            //    FormMenuUtama frmUtama = new FormMenuUtama();
            //    frmUtama.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Login Gagal");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
