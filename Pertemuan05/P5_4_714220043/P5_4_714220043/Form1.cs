using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string jenisKelamin = comboBox1.SelectedItem.ToString();
            DateTime tanggalLahir = dtpLahir.Value;
            string kelas = "";
            string jadwal = "";


            if (cbBiola.Checked)
            {
                kelas += "Biola, ";
            }
            if (cbGitar.Checked)
            {
                kelas += "Gitar, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (cbKonduktor.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas += "Piano, ";
            }
            if (cbDrum.Checked)
            {
                kelas += "Drum, ";
            }
            if (cbVokal.Checked)
            {
                kelas += "Vokal, ";
            }
            if (cbKomposer.Checked)
            {
                kelas += "Komposer, ";
            }


            if (rb_senin.Checked)
            {
                jadwal = "Senin && Rabu, 14.00 - 16.00";
            }
            else if (rb_selasa.Checked)
            {
                jadwal = "Selasa && Kamis, 14.00 - 16.00";
            }
            else if (rb_sabtu.Checked)
            {
                jadwal = "Sabtu && Minggu, 09.00 - 11.00";
            }
            else if (rb_minggu.Checked)
            {
                jadwal = "Minggu, 13.00 - 13.00";
            }

            MessageBox.Show(
                "Nama : " + txtNama.Text +
                "\nJenis Kelamin: " + jenisKelamin +
                "\nTanggal Lahir: " + tanggalLahir.ToString("dd MMMM yyyy") +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );

        }




        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
