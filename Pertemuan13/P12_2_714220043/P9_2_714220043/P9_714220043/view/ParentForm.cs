﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714220043.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataMahasiswaItem_Click(object sender, EventArgs e)
        {
            Form1 FormMhs = new Form1();
            FormMhs.MdiParent = this;
            FormMhs.Show();
        }

        private void dataNilaiItem_Click(object sender, EventArgs e)
        {
            FormNilai FrmNilai = new FormNilai();
            FrmNilai.MdiParent = this;
            FrmNilai.Show();
        }

        private void dataMasterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.MdiParent = this;
            formBarang.Show();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiBarang formTransaksiBarang = new FormTransaksiBarang();
            formTransaksiBarang.MdiParent = this;
            formTransaksiBarang.Show();
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}