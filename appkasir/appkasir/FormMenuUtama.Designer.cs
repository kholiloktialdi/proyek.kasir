namespace appkasir
{
    partial class FormMenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKasir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGantiPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMaster,
            this.menuTransaksi,
            this.menuLaporan,
            this.menuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuLogout,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(112, 22);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(112, 22);
            this.menuLogout.Text = "Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(112, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuMaster
            // 
            this.menuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKasir,
            this.menuBarang});
            this.menuMaster.Name = "menuMaster";
            this.menuMaster.Size = new System.Drawing.Size(55, 20);
            this.menuMaster.Text = "Master";
            // 
            // menuKasir
            // 
            this.menuKasir.Name = "menuKasir";
            this.menuKasir.Size = new System.Drawing.Size(111, 22);
            this.menuKasir.Text = "Kasir";
            this.menuKasir.Click += new System.EventHandler(this.kasirToolStripMenuItem_Click);
            // 
            // menuBarang
            // 
            this.menuBarang.Name = "menuBarang";
            this.menuBarang.Size = new System.Drawing.Size(111, 22);
            this.menuBarang.Text = "Barang";
            // 
            // menuTransaksi
            // 
            this.menuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPenjualan});
            this.menuTransaksi.Name = "menuTransaksi";
            this.menuTransaksi.Size = new System.Drawing.Size(66, 20);
            this.menuTransaksi.Text = "Transaksi";
            // 
            // menuPenjualan
            // 
            this.menuPenjualan.Name = "menuPenjualan";
            this.menuPenjualan.Size = new System.Drawing.Size(126, 22);
            this.menuPenjualan.Text = "Penjualan";
            // 
            // menuLaporan
            // 
            this.menuLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuJual});
            this.menuLaporan.Name = "menuLaporan";
            this.menuLaporan.Size = new System.Drawing.Size(62, 20);
            this.menuLaporan.Text = "Laporan";
            // 
            // menuJual
            // 
            this.menuJual.Name = "menuJual";
            this.menuJual.Size = new System.Drawing.Size(172, 22);
            this.menuJual.Text = "Laporan Penjualan";
            // 
            // menuUtility
            // 
            this.menuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGantiPassword,
            this.menuAbout});
            this.menuUtility.Name = "menuUtility";
            this.menuUtility.Size = new System.Drawing.Size(50, 20);
            this.menuUtility.Text = "Utility";
            // 
            // menuGantiPassword
            // 
            this.menuGantiPassword.Name = "menuGantiPassword";
            this.menuGantiPassword.Size = new System.Drawing.Size(155, 22);
            this.menuGantiPassword.Text = "Ganti Password";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(155, 22);
            this.menuAbout.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(14, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Penjualan Bulan ini";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Yellow;
            this.monthCalendar1.Location = new System.Drawing.Point(522, 52);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 302);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Berhasil Login Sebagai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kode Kasir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Kasir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level Kasir";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "admin";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(132, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 29);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "admin";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(132, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 29);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "admin";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(15, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 29);
            this.textBox4.TabIndex = 3;
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuMaster;
        private System.Windows.Forms.ToolStripMenuItem menuKasir;
        private System.Windows.Forms.ToolStripMenuItem menuBarang;
        private System.Windows.Forms.ToolStripMenuItem menuTransaksi;
        private System.Windows.Forms.ToolStripMenuItem menuPenjualan;
        private System.Windows.Forms.ToolStripMenuItem menuLaporan;
        private System.Windows.Forms.ToolStripMenuItem menuJual;
        private System.Windows.Forms.ToolStripMenuItem menuUtility;
        private System.Windows.Forms.ToolStripMenuItem menuGantiPassword;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
    }
}