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
    public partial class DialogBarang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodebarang, namabarang, harga = "";
        Koneksi konn = new Koneksi();

        void RefreshBarang()
        {
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from TBL_BRNG", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "TBL_BRNG");
                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "TBL_BRNG";
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                kodebarang = row.Cells["KodeBarang"].Value.ToString();
                namabarang = row.Cells["NamaBarang"].Value.ToString();
                harga = row.Cells["HargaSatuan"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public String AmbilKodeBarang
        {
            get
            {
                return kodebarang;
            }
        }

        public String AmbilNamaBarang
        {
            get
            {
                return namabarang;
            }
        }

        public String AmbilHargaBarang
        {
            get
            {
                return harga;
            }
        }

        void CariBarang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from TBL_BRNG where KodeBarang like '%" + textBox1.Text + "%' or NamaBarang like '%" + textBox1.Text + "%' ", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "TBL_BRNG");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "TBL_BRNG";
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
        public DialogBarang()
        {
            InitializeComponent();
            RefreshBarang();
        }
    }
}
