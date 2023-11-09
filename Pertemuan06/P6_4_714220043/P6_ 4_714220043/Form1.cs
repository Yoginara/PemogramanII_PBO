using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6__4_714220043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNama_Leave(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                epCorrect.SetError(textBoxNama, "");
                epWarning.SetError(textBoxNama, "Nama harus di isi, Tidak boleh kosong");
                epWrong.SetError(textBoxNama, ""); ;
            }
            else
            {
                if ((textBoxNama.Text).All(Char.IsLetter))
                {
                    epCorrect.SetError(textBoxNama, "benar");
                    epWarning.SetError(textBoxNama, "");
                    epWrong.SetError(textBoxNama, "");
                }
                else
                {
                    epCorrect.SetError(textBoxNama, "");
                    epWarning.SetError(textBoxNama, "");
                    epWrong.SetError(textBoxNama, "Nama hanya boleh berisi karakter huruf");
                }
            }
        }

        private void numericUpDownJumlah_Leave(object sender, EventArgs e)
        {
            int tiket = (int)numericUpDownJumlah.Value;

            if (tiket > 0 && tiket <= 5)
            {
                epCorrect.SetError(numericUpDownJumlah, "benar");
                epWarning.SetError(numericUpDownJumlah, "");
                epWrong.SetError(numericUpDownJumlah, "");
            }
            else if (tiket > 5)
            {
                epCorrect.SetError(numericUpDownJumlah, "");
                epWarning.SetError(numericUpDownJumlah, "Pesanan tidak boleh lebih dari 5");
                epWrong.SetError(numericUpDownJumlah, "");
            }
            else if (tiket == 0)
            {
                epCorrect.SetError(numericUpDownJumlah, "");
                epWarning.SetError(numericUpDownJumlah, "");
                epWrong.SetError(numericUpDownJumlah, "Pesanan tidak boleh 0");
            }
        }

        private void comboBoxRasa_Leave(object sender, EventArgs e)
        {
            if (comboBoxRasa.SelectedItem != null)
            {
                string pilihRasa = comboBoxRasa.SelectedItem.ToString();
                epCorrect.SetError(comboBoxRasa, "Rasa Terpilih");
                epWarning.SetError(comboBoxRasa, "");
                epWrong.SetError(comboBoxRasa, "");
            }
            else if (string.IsNullOrWhiteSpace(comboBoxRasa.Text))
            {
                epCorrect.SetError(comboBoxRasa, "");
                epWarning.SetError(comboBoxRasa, "Pilih salah satu rasa");
                epWrong.SetError(comboBoxRasa, "");
            }
            else
            {
                epCorrect.SetError(comboBoxRasa, "");
                epWarning.SetError(comboBoxRasa, "");
                epWrong.SetError(comboBoxRasa, "Rasa Tidak Boleh Lain dari pilihan dan berbentuk angka");
            }
        }

        private void textBoxPonsel_Leave(object sender, EventArgs e)
        {
            string ponsel = textBoxPonsel.Text;

            if (!string.IsNullOrWhiteSpace(ponsel))
            {
                if (ponsel.Length >= 10 && ponsel.Length <= 12)
                {
                    epCorrect.SetError(textBoxPonsel, "Correct");
                    epWarning.SetError(textBoxPonsel, "");
                    epWrong.SetError(textBoxPonsel, "");
                }
                else if (ponsel.Length < 10)
                {
                    epCorrect.SetError(textBoxPonsel, "");
                    epWarning.SetError(textBoxPonsel, "Minimal 10 digit");
                    epWrong.SetError(textBoxPonsel, "");
                }
                else if (ponsel.Length > 12)
                {
                    epCorrect.SetError(textBoxPonsel, "");
                    epWarning.SetError(textBoxPonsel, "Maksimal 12 digit");
                    epWrong.SetError(textBoxPonsel, "");
                }
            }

            else
            {
                epCorrect.SetError(textBoxPonsel, "");
                epWarning.SetError(textBoxPonsel, "");
                epWrong.SetError(textBoxPonsel, "Nomor ponsel tidak boleh kosong.");
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epCorrect.SetError(textBoxEmail, "Correct");
                epWarning.SetError(textBoxEmail, "");
                epWrong.SetError(textBoxEmail, "");
            }
            else
            {
                epCorrect.SetError(textBoxEmail, "");
                epWarning.SetError(textBoxEmail, "");
                epWrong.SetError(textBoxEmail, "Format email salah!");
            }
            if (textBoxEmail.Text == "")
            {
                epCorrect.SetError(textBoxEmail, "");
                epWarning.SetError(textBoxEmail, "eamil wajib diisi!");
                epWrong.SetError(textBoxEmail, "");
            }
        }

        private void textBoxAlamat_Leave(object sender, EventArgs e)
        {
            if ((textBoxAlamat.Text).All(Char.IsUpper))
            {
                epCorrect.SetError(textBoxAlamat, "Betul!");
                epWarning.SetError(textBoxAlamat, "");
                epWrong.SetError(textBoxAlamat, "");
            }
            if ((textBoxAlamat.Text).Any(Char.IsLower))
            {
                epCorrect.SetError(textBoxAlamat, "");
                epWarning.SetError(textBoxAlamat, "");
                epWrong.SetError(textBoxAlamat, "Alamat Harus Huruf Besar");
            }

            if ((textBoxAlamat.Text == ""))
            {
                epCorrect.SetError(textBoxAlamat, "");
                epWarning.SetError(textBoxAlamat, "Alamat Tidak Boleh Kosong");
                epWrong.SetError(textBoxAlamat, "");
            }
        }

        private void textBoxPromo_Leave(object sender, EventArgs e)
        {
            if ((textBoxPromo.Text).All(Char.IsLower))
            {
                epCorrect.SetError(textBoxPromo, "Betul!");
                epWarning.SetError(textBoxPromo, "");
                epWrong.SetError(textBoxPromo, "");
            }
            if ((textBoxPromo.Text).Any(Char.IsUpper))
            {
                epCorrect.SetError(textBoxPromo, "");
                epWarning.SetError(textBoxPromo, "");
                epWrong.SetError(textBoxPromo, "Gunakan Huruf kecil'");
            }

            if ((textBoxPromo.Text == ""))
            {
                epCorrect.SetError(textBoxPromo, "");
                epWarning.SetError(textBoxPromo, "Huruf jangan Kosong");
                epWrong.SetError(textBoxPromo, "");
            }
        }


        private void buttonBatal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            int jumlahTiket = (int)numericUpDownJumlah.Value;
            string rasa = comboBoxRasa.SelectedItem.ToString(); 
            string nomorPonsel = textBoxPonsel.Text;
            string email = textBoxEmail.Text;
            string promo = textBoxPromo.Text;
            string alamat = textBoxAlamat.Text;


            string hasilPesan = $"Nama: {nama}\nJumlah Tiket: {jumlahTiket}\nRasa: {rasa}\nNomor Ponsel: {nomorPonsel}\nEmail: {email}\nPromo: {promo}\nAlamat: {alamat}";

            MessageBox.Show(hasilPesan, "Detail Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
