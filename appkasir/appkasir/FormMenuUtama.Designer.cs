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
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKasir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJual = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMaster,
            this.menuTransaksi,
            this.menuLaporan});
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
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(49, 20);
            this.menuFile.Text = "Akses";
            this.menuFile.Click += new System.EventHandler(this.menuFile_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(112, 22);
            this.menuExit.Text = "Logout";
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
            this.menuBarang.Click += new System.EventHandler(this.menuBarang_Click);
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
            this.menuPenjualan.Click += new System.EventHandler(this.menuPenjualan_Click);
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
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Yellow;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 34);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEM APLIKASI KASIR ELMART";
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appkasir.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuKasir;
        private System.Windows.Forms.ToolStripMenuItem menuBarang;
        private System.Windows.Forms.ToolStripMenuItem menuPenjualan;
        private System.Windows.Forms.ToolStripMenuItem menuJual;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Windows.Forms.ToolStripMenuItem menuFile;
        public System.Windows.Forms.ToolStripMenuItem menuMaster;
        public System.Windows.Forms.ToolStripMenuItem menuTransaksi;
        public System.Windows.Forms.ToolStripMenuItem menuLaporan;
        private System.Windows.Forms.Label label1;
    }
}