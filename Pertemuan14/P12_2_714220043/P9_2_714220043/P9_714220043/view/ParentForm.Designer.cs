namespace P9_714220043.view
{
    partial class ParentForm
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
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataNilaiItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tugasPratikum12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MdiMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.dataMahasiswaItem,
            this.dataNilaiItem,
            this.tugasPratikum12ToolStripMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(800, 30);
            this.MdiMenu.TabIndex = 1;
            this.MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 26);
            this.FileMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataMahasiswaItem
            // 
            this.dataMahasiswaItem.Name = "dataMahasiswaItem";
            this.dataMahasiswaItem.Size = new System.Drawing.Size(131, 26);
            this.dataMahasiswaItem.Text = "Data Mahasiswa";
            this.dataMahasiswaItem.Click += new System.EventHandler(this.dataMahasiswaItem_Click);
            // 
            // dataNilaiItem
            // 
            this.dataNilaiItem.Name = "dataNilaiItem";
            this.dataNilaiItem.Size = new System.Drawing.Size(90, 26);
            this.dataNilaiItem.Text = "Data Nilai";
            this.dataNilaiItem.Click += new System.EventHandler(this.dataNilaiItem_Click);
            // 
            // tugasPratikum12ToolStripMenuItem
            // 
            this.tugasPratikum12ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterBarangToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem});
            this.tugasPratikum12ToolStripMenuItem.Name = "tugasPratikum12ToolStripMenuItem";
            this.tugasPratikum12ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.tugasPratikum12ToolStripMenuItem.Text = "Tugas Pratikum 12";
            // 
            // dataMasterBarangToolStripMenuItem
            // 
            this.dataMasterBarangToolStripMenuItem.Name = "dataMasterBarangToolStripMenuItem";
            this.dataMasterBarangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataMasterBarangToolStripMenuItem.Text = "Data Master Barang";
            this.dataMasterBarangToolStripMenuItem.Click += new System.EventHandler(this.dataMasterBarangToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            this.dataTransaksiToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenu;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParentForm_FormClosing);
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaItem;
        private System.Windows.Forms.ToolStripMenuItem dataNilaiItem;
        private System.Windows.Forms.ToolStripMenuItem tugasPratikum12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMasterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
    }
}