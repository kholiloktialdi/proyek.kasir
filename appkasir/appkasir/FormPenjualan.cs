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
    public partial class FormPenjualan : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        void KondisiAwal()
        {
            textBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button6.Enabled = false;
            button4.Enabled = false;
        }

        void MunculData()
        {
            KondisiAwal();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from vw_penjualan order by NoKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "vw_penjualan";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox1.Enabled = false;
            }
        }

        private void AutoNumber()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoKwitansi from TBL_PENJUALAN where NoKwitansi in(select MAX(NoKwitansi) from TBL_PENJUALAN) order by NoKwitansi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 12, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "TRX-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                urut = "TRX-0001/" + DateTime.Now.ToString("MM/yyyy");
            }
            rd.Close();
            textBox1.Text = urut;
            textBox1.Enabled = false;
            conn.Close();
        }

        void SimpanDataPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into TBL_PENJUALAN values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        void SimpanDetailPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into TBL_DETAILPENJUALAN values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox7.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        void RefreshPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from vw_detail where NoKwitansi= '" + textBox1.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "vw_detail";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void RefreshTransaksi()
        {
            RefreshPenjualan();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox7.Focus();
        }
        public FormPenjualan()
        {
            InitializeComponent();
            MunculData();
            AutoNumber();
            Link();
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        

        private void FormPenjualan_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MunculData();
            AutoNumber();
            dateTimePicker1.Focus();
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Link();
            //SqlDataReader reader = null;
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox7.Text.Trim() == "")
                {
                    MessageBox.Show("Semua Data Harus Diisi");
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from TBL_DETAILPENJUALAN where NoKwitansi = '" + textBox1.Text + "'", conn);
                    cmd.ExecuteNonQuery();

                    //if (reader.Read())
                    //{
                    //    SimpanDetailPenjualan();
                    //}
                    //else
                    //{
                    //    SimpanDataPenjualan();
                    //    SimpanDetailPenjualan();
                    //}
                    SimpanDataPenjualan();
                    SimpanDetailPenjualan();
                    button1.Enabled = false;
                    button6.Enabled = true;
                    groupBox1.Enabled = true;
                    RefreshTransaksi();
                    
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;
            DataGridViewRow row = this.dataGridView1.Rows
                [e.RowIndex];
            textBox4.Text = row.Cells
                ["KodeBarang"].Value.ToString();
            textBox5.Text = row.Cells
                ["NamaBarang"].Value.ToString();
            textBox6.Text = row.Cells["HargaSatuan"].Value.ToString();
            textBox7.Text = row.Cells["Jumlah"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("delete from TBL_DETAILPENJUALAN where NoKwitansi = '" + textBox1.Text + "' AND KodeBarang ='" + textBox4.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                RefreshTransaksi();
                button3.Enabled = true;
                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogKasir ksr = new DialogKasir();
            ksr.ShowDialog();
            textBox2.Text = ksr.AmbilKodeKasir;
            textBox3.Text = ksr.AmbilNamaKasir;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogBarang brg = new DialogBarang();
            brg.ShowDialog();
            textBox4.Text = brg.AmbilKodeBarang;
            textBox5.Text = brg.AmbilNamaBarang;
            textBox6.Text = brg.AmbilHargaBarang;
        }

        public static void Link()
        {
             SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\DESKTOP-34TM88K\\SQLEXPRESS;initial catalog=DB_KASIR;integrated security=true"); 
        }
    }
}
