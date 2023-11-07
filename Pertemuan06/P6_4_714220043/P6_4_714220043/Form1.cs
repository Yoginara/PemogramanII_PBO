using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtJumlahPesanan_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtJumlahPesanan.Text, out int jumlahPizza) || jumlahPizza <= 0)
            {
                MessageBox.Show("Jumlah pesanan harus merupakan angka positif.", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJumlahPesanan.Focus();
                e.Cancel = true;
            }
        }

        private void txtNamaPemesan_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAlpha(txtNamaPemesan.Text))
            {
                MessageBox.Show("Nama pemesan hanya boleh berisi karakter huruf.", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamaPemesan.Focus();
                e.Cancel = true; 
            }
        }
        private bool IsAlpha(string text)
        {
            return !string.IsNullOrEmpty(text) && text.All(char.IsLetter);
        }

        private void txtAlamatPemesanan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlamatPemesanan.Text))
            {
                errorProvider1.SetError(txtAlamatPemesanan, "Alamat pengiriman harus diisi.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAlamatPemesanan, ""); 
            }
        }

        private void txtKodePromo_Validating(object sender, CancelEventArgs e)
        {
            string kodePromo = txtKodePromo.Text;

            // Mengubah input menjadi huruf besar
            kodePromo = kodePromo.ToUpper();

            if (!string.IsNullOrEmpty(kodePromo))
            {
                // Format Kode promo 3 huruf 3 angka
                string pattern = @"^[A-Z]{3}\d{3}$";

                if (!System.Text.RegularExpressions.Regex.IsMatch(kodePromo, pattern))
                {
                    MessageBox.Show("Format kode promo tidak valid. Contoh: ABC123", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKodePromo.Focus();
                    e.Cancel = true;
                }
            }
            else
            {

            }
        }

        private void txtcatatan_Validating(object sender, CancelEventArgs e)
        {
            string catatan = txtcatatan.Text;
            int maksPanjangCatatan = 100; // panjang maksimum

            if (!string.IsNullOrEmpty(catatan) && catatan.Length > maksPanjangCatatan)
            {
                MessageBox.Show("Catatan khusus tidak boleh melebihi " + maksPanjangCatatan + " karakter.", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcatatan.Focus(); 
                e.Cancel = true;
            }
        }

        private void txtNoTelephone_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string nomorTelepon = textBox.Text;
            int panjangHarapkan = 12;

            nomorTelepon = new string(nomorTelepon.Where(char.IsDigit).ToArray());

            if (nomorTelepon.Length != panjangHarapkan)
            {
                MessageBox.Show("Nomor telepon harus terdiri dari " + panjangHarapkan + " digit.", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                e.Cancel = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;

            email = email.ToLower();

            if (!string.IsNullOrEmpty(email))
            {
                if (!email.Contains("@"))
                {
                    MessageBox.Show("Alamat email tidak valid.", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    e.Cancel = true;
                }
            }
            else
            {

            }
        }

        private void cbPembayaran_Validating(object sender, CancelEventArgs e)
        {
            if (cbPembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih metode pembayaran.", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbPembayaran.Focus();
                e.Cancel = true;
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // Validasi telah terpenuhi, sekarang menampilkan data dalam MessageBox
                string pesan = "Rincian Pesanan:\n";
                pesan += "Nama Pemesan: " + txtNamaPemesan.Text + "\n";
                pesan += "Jumlah Pesanan: " + txtJumlahPesanan.Text + " pizza\n";
                pesan += "Alamat Pemesanan: " + txtAlamatPemesanan.Text + "\n";
                pesan += "Kode Promo: " + txtKodePromo.Text + "\n";
                pesan += "Catatan Khusus: " + txtcatatan.Text + "\n";
                pesan += "Nomor Telepon: " + txtNoTelephone.Text + "\n";
                pesan += "Email: " + txtEmail.Text + "\n";
                pesan += "Metode Pembayaran: " + cbPembayaran.SelectedItem.ToString();

                MessageBox.Show(pesan, "Rincian Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tampilkan pesan bahwa pesanan diterima
                MessageBox.Show("Pesanan Anda telah diterima. Terima kasih!", "Konfirmasi Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Harap perbaiki kesalahan dalam isian form sebelum mengirimkan pesanan.", "Kesalahan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

