using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkasir
{
    public partial class FormMenuUtama : Form
    {
      
        FormLogin frmLogin;
        FormMasterKasir frmKasir;
        FormMasterBarang frmBarang;
        FormPenjualan frmJual;
   
        
        void frmKasir_formClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        //}
        ////void MenuTerkunci()
        ////{
        ////    menuLogin.Enabled = true;
        ////    menuLogout.Enabled = false;
        ////    menuMaster.Enabled = false;
        ////    menuTransaksi.Enabled = false;
        ////    menuUtility.Enabled = false;
        ////    menuLaporan.Enabled = false;
        }

        void frmBarang_formClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }

        void frmJual_formClosed(object sender, FormClosedEventArgs e)
        {
            frmJual = null;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void FormMenuUtama_Load(object sender, EventArgs e)
        //{
        //    MenuTerkunci();
        //}

        private void menuLogin_Click(object sender, EventArgs e)
        {
        //    frmLogin = new FormLogin();
        //    frmLogin.Show();
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_formClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuBarang_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new FormMasterBarang();
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_formClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void menuPenjualan_Click(object sender, EventArgs e)
        {
            if (frmJual == null)
            {
                frmJual = new FormPenjualan();
                frmJual.FormClosed += new FormClosedEventHandler(frmJual_formClosed);
                frmJual.ShowDialog();
            }
            else
            {
                frmJual.Activate();
            }
        }

        private void menuFile_Click(object sender, EventArgs e)
        {

        }
    }
}
