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
    public partial class FormMasterBarang : Form
    {
        Koneksi konn = new Koneksi();
        public SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void munculSatuan()
        {
            comboBox1.Items.Add("KILOGRAM");
            comboBox1.Items.Add("KARDUS");
            comboBox1.Items.Add("SACHET");
            comboBox1.Items.Add("BUNGKUS");
            comboBox1.Items.Add("PCS");
            comboBox1.Items.Add("LITER");
            comboBox1.Items.Add("GALON");
            comboBox1.Items.Add("BOTOL");
            comboBox1.Items.Add("KALENG");
            comboBox1.Items.Add("KARUNG");
        }

        void KondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "--Pilih jenis barang--";
            comboBox1.Items.Clear();
            munculSatuan();
            MunculDataBarang();
            CariDataBarang();
            AutoNumber();
            button1.Enabled = true;
        }

        
        public FormMasterBarang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void MunculDataBarang()
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("select * from TBL_BRNG", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_BRNG");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_BRNG";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }

        void AutoNumber()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBarang from TBL_BRNG where KodeBarang in(select max(KodeBarang) from TBL_BRNG) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
                string kodeurutan = "000" + hitung;
                urutan = "brg" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
            }
            else
            {
                urutan = "brg001";
            }
            rd.Close();
            textBox1.Enabled = false;
            textBox1.Text = urutan;
            conn.Close();
        }

        void CariDataBarang()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from TBL_BRNG where KodeBarang like '%" + textBox4.Text + "%' or NamaBarang like '%" + textBox4.Text + "%' ", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_BRNG");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_BRNG";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }


        private void FormMasterBarang_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Semua Form Harus Diisi");
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                //conn.Open();
                cmd = new SqlCommand("insert into TBL_BRNG values('" + textBox1.Text + "','" + textBox2.Text + "','" +
                    textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text +"')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Input");
                KondisiAwal();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Semua Form Harus Diisi");
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                //conn.Open();
                cmd = new SqlCommand("update TBL_BRNG set NamaBarang='" + textBox2.Text + "',HargaSatuan='" + textBox3.Text +
                    "',JenisSatuan='" + comboBox1.Text + "',Stok='" + textBox5.Text + "'where KodeBarang='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Edit");
                KondisiAwal();

            }
        }

        private void FormMasterBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    SqlConnection conn = konn.GetConn();
            //    //conn.Open();
            //    cmd = new SqlCommand("select * from TBL_BRNG where KodeBarang='" + textBox1.Text + "'", conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    rd = cmd.ExecuteReader();
            //    if (rd.Read())
            //    {
            //        textBox1.Text = rd[0].ToString();
            //        textBox2.Text = rd[1].ToString();
            //        textBox3.Text = rd[2].ToString();
            //        comboBox1.Text = rd[3].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Data tidak ada");
            //    }
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    button1.Enabled = false;
            //    //button3.Enabled = false;
            //    SqlConnection conn = konn.GetConn();
            //    //conn.Open();
            //    cmd = new SqlCommand("select * from TBL_BRNG where KodeBarang='" + textBox1.Text + "'", conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    rd = cmd.ExecuteReader();
            //    if (rd.Read())
            //    {
            //        textBox1.Text = rd[0].ToString();
            //        textBox2.Text = rd[1].ToString();
            //        textBox3.Text = rd[2].ToString();
            //        comboBox1.Text = rd[3].ToString();
            //    }
            //    else
            //    {
            //        button1.Enabled = true;
            //        MessageBox.Show("Data tidak ada");
            //    }
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox2.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox3.Text = row.Cells["HargaSatuan"].Value.ToString();
                comboBox1.Text = row.Cells["JenisSatuan"].Value.ToString();
                textBox5.Text = row.Cells["Stok"].Value.ToString();
                button1.Enabled = false;
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void REFRESH(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Akan Menghapus Data Barang :" + textBox2.Text +" ?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox5.Text.Trim() == "")
                {
                    MessageBox.Show("Semua Form Harus Diisi");
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    //conn.Open();
                    cmd = new SqlCommand("delete TBL_BRNG where KodeBarang='" + textBox1.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil di Hapus");
                    KondisiAwal();

                }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CariDataBarang();
        }
    }
}
