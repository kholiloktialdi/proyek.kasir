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
    public partial class DialogKasir : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodekasir, namakasir = "";
        Koneksi konn = new Koneksi();

        void RefreshKasir()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from TBL_KASIR", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "TBL_KASIR");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "TBL_KASIR";
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

        void CariKasir()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from TBL_KASIR where KodeKasir like '%" + textBox1.Text + "%' or NamaKasir like '%" + textBox1.Text + "%' ", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "TBL_KASIR");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "TBL_KASIR";
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
        public DialogKasir()
        {
            InitializeComponent();
            RefreshKasir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CariKasir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                kodekasir = row.Cells["KodeKasir"].Value.ToString();
                namakasir = row.Cells["NamaKasir"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public String AmbilKodeKasir
        {
            get
            {
                return kodekasir;
            }
        }

        public String AmbilNamaKasir
        {
            get
            {
                return namakasir;
            }
        }


        private void DialogKasir_Load(object sender, EventArgs e)
        {

        }
    }
}
