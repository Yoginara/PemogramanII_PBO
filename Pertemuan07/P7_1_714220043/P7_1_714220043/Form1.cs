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

namespace P7_1_714220043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size= new Size(459, 250);
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxProdi.Text)) 
            {
                errorMessage += "Prodi belum diisi\n";
            }else if(!Regex.IsMatch(textBoxProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Starta]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text)) 
            {
                errorMessage += "Kelas belum diisi\n";
            }

            if(string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK,MessageBoxIcon.Information
                    );
                this.Size = new Size(459, 500);
            }
            else
            {
                MessageBox.Show(
                     errorMessage,
                     "Informasi Data Submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                     );
            }
        }

        private void radioButtonSenin_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSenin.Checked)
            {
                checkBoxKuliah.Enabled = true;checkBoxKuliah.Checked = true;
                checkBoxTravelling.Enabled = false; checkBoxTravelling.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
            }
        }

        private void radioButtonMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinggu.Checked)
            {
                checkBoxKuliah.Enabled = false;
                checkBoxTravelling.Enabled = true;
                checkBoxTidur.Enabled = true;
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //textBoxNama.Text = null;
            //textBoxProdi.Text = null;
            //textBoxKelas.Text = null;

            foreach(Control control in Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                   ((ComboBox)control).SelectedIndex = -1;
            }
            this.Size = new Size(459, 250);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string pilihHari = "";
            string pilihKegiatan = "";

            if (radioButtonSenin.Checked)
            {
                pilihHari = "Senin";
                pilihKegiatan = GetSelectedActivities();
            }
            else if (radioButtonMinggu.Checked)
            {
                pilihHari = "Minggu";
                pilihKegiatan = GetSelectedActivities();
            }

            string errorMsg = ValidateInputs();

            if (string.IsNullOrEmpty(errorMsg))
            {
                string hasilPrint = $"Nama: {textBoxNama.Text}\nProdi: {textBoxProdi.Text}\nKelas: {textBoxKelas.Text}\nHari: {pilihHari}\nKegiatan: {pilihKegiatan}";

                MessageBox.Show(hasilPrint, "Cetak Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMsg, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetSelectedActivities()
        {
            List<string> selectedActivitiesList = new List<string>();

            if (checkBoxTidur.Checked)
            {
                selectedActivitiesList.Add(checkBoxTidur.Text);
            }
            if (checkBoxKuliah.Checked)
            {
                selectedActivitiesList.Add(checkBoxKuliah.Text);
            }
            if (checkBoxTravelling.Checked)
            {
                selectedActivitiesList.Add(checkBoxTravelling.Text);
            }

            return string.Join(", ", selectedActivitiesList);
        }

        private string ValidateInputs()
        {
            StringBuilder errorMsgBuilder = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMsgBuilder.AppendLine("Nama belum diisi");
            }
            if (string.IsNullOrWhiteSpace(textBoxProdi.Text))
            {
                errorMsgBuilder.AppendLine("Prodi belum diisi");
            }
            else if (!Regex.IsMatch(textBoxProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMsgBuilder.AppendLine("Prodi harus berformat [Strata]-[Prodi]");
            }
            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMsgBuilder.AppendLine("Kelas belum diisi");
            }

            return errorMsgBuilder.ToString().Trim();
        }

    }
}
