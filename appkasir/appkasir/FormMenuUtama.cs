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
        void frmKasir_formClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }
        void MenuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menuLaporan.Enabled = false;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            frmLogin = new FormLogin();
            frmLogin.Show();
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
    }
}
