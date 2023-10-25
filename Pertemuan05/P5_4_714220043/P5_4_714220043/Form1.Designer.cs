namespace P5_4_714220043
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpLahir = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.cbJenisKelamin = new System.Windows.Forms.Label();
            this.cbTanggalLahir = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.Kelas = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.Jadwal = new System.Windows.Forms.GroupBox();
            this.rb_minggu = new System.Windows.Forms.RadioButton();
            this.rb_sabtu = new System.Windows.Forms.RadioButton();
            this.rb_selasa = new System.Windows.Forms.RadioButton();
            this.rb_senin = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.Kelas.SuspendLayout();
            this.Jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
            this.comboBox1.Location = new System.Drawing.Point(379, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "--- Pilih Jenis Kelamin ---";
            // 
            // dtpLahir
            // 
            this.dtpLahir.Location = new System.Drawing.Point(379, 165);
            this.dtpLahir.Name = "dtpLahir";
            this.dtpLahir.Size = new System.Drawing.Size(222, 22);
            this.dtpLahir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(183, 71);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(54, 23);
            this.nama.TabIndex = 2;
            this.nama.Text = "Nama";
            // 
            // cbJenisKelamin
            // 
            this.cbJenisKelamin.AutoSize = true;
            this.cbJenisKelamin.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJenisKelamin.Location = new System.Drawing.Point(183, 116);
            this.cbJenisKelamin.Name = "cbJenisKelamin";
            this.cbJenisKelamin.Size = new System.Drawing.Size(121, 23);
            this.cbJenisKelamin.TabIndex = 3;
            this.cbJenisKelamin.Text = "Jenis Kelamin";
            // 
            // cbTanggalLahir
            // 
            this.cbTanggalLahir.AutoSize = true;
            this.cbTanggalLahir.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanggalLahir.Location = new System.Drawing.Point(183, 164);
            this.cbTanggalLahir.Name = "cbTanggalLahir";
            this.cbTanggalLahir.Size = new System.Drawing.Size(114, 23);
            this.cbTanggalLahir.TabIndex = 4;
            this.cbTanggalLahir.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(379, 72);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(222, 22);
            this.txtNama.TabIndex = 5;
            // 
            // Kelas
            // 
            this.Kelas.Controls.Add(this.cbKomposer);
            this.Kelas.Controls.Add(this.cbVokal);
            this.Kelas.Controls.Add(this.cbDrum);
            this.Kelas.Controls.Add(this.cbPiano);
            this.Kelas.Controls.Add(this.cbKonduktor);
            this.Kelas.Controls.Add(this.cbSaxophone);
            this.Kelas.Controls.Add(this.cbGitar);
            this.Kelas.Controls.Add(this.cbBiola);
            this.Kelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kelas.Location = new System.Drawing.Point(69, 200);
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(295, 187);
            this.Kelas.TabIndex = 6;
            this.Kelas.TabStop = false;
            this.Kelas.Text = "Pilihan Kelas";
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(159, 144);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(99, 20);
            this.cbKomposer.TabIndex = 7;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(159, 105);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(69, 20);
            this.cbVokal.TabIndex = 6;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(161, 68);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(65, 20);
            this.cbDrum.TabIndex = 5;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(161, 31);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(69, 20);
            this.cbPiano.TabIndex = 4;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(17, 145);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(98, 20);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(17, 106);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(107, 20);
            this.cbSaxophone.TabIndex = 2;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(17, 68);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(62, 20);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(17, 31);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(65, 20);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // Jadwal
            // 
            this.Jadwal.Controls.Add(this.rb_minggu);
            this.Jadwal.Controls.Add(this.rb_sabtu);
            this.Jadwal.Controls.Add(this.rb_selasa);
            this.Jadwal.Controls.Add(this.rb_senin);
            this.Jadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jadwal.Location = new System.Drawing.Point(412, 200);
            this.Jadwal.Name = "Jadwal";
            this.Jadwal.Size = new System.Drawing.Size(305, 197);
            this.Jadwal.TabIndex = 7;
            this.Jadwal.TabStop = false;
            this.Jadwal.Text = "Pilihan Jadwal";
            // 
            // rb_minggu
            // 
            this.rb_minggu.AutoSize = true;
            this.rb_minggu.Location = new System.Drawing.Point(27, 144);
            this.rb_minggu.Name = "rb_minggu";
            this.rb_minggu.Size = new System.Drawing.Size(171, 20);
            this.rb_minggu.TabIndex = 3;
            this.rb_minggu.Text = "Minggu, 13.00 - 17.00";
            this.rb_minggu.UseVisualStyleBackColor = true;
            // 
            // rb_sabtu
            // 
            this.rb_sabtu.AutoSize = true;
            this.rb_sabtu.Location = new System.Drawing.Point(27, 105);
            this.rb_sabtu.Name = "rb_sabtu";
            this.rb_sabtu.Size = new System.Drawing.Size(229, 20);
            this.rb_sabtu.TabIndex = 2;
            this.rb_sabtu.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rb_sabtu.UseVisualStyleBackColor = true;
            // 
            // rb_selasa
            // 
            this.rb_selasa.AutoSize = true;
            this.rb_selasa.Location = new System.Drawing.Point(27, 67);
            this.rb_selasa.Name = "rb_selasa";
            this.rb_selasa.Size = new System.Drawing.Size(230, 20);
            this.rb_selasa.TabIndex = 1;
            this.rb_selasa.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rb_selasa.UseVisualStyleBackColor = true;
            // 
            // rb_senin
            // 
            this.rb_senin.AutoSize = true;
            this.rb_senin.Location = new System.Drawing.Point(27, 31);
            this.rb_senin.Name = "rb_senin";
            this.rb_senin.Size = new System.Drawing.Size(215, 20);
            this.rb_senin.TabIndex = 0;
            this.rb_senin.Text = "Senin && Rabu, 14.00 - 16.00";
            this.rb_senin.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(280, 409);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(84, 23);
            this.btnTampilkan.TabIndex = 8;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(412, 409);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(84, 23);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 473);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.Jadwal);
            this.Controls.Add(this.Kelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.cbTanggalLahir);
            this.Controls.Add(this.cbJenisKelamin);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLahir);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Astrra Musik School";
            this.Kelas.ResumeLayout(false);
            this.Kelas.PerformLayout();
            this.Jadwal.ResumeLayout(false);
            this.Jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpLahir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label cbJenisKelamin;
        private System.Windows.Forms.Label cbTanggalLahir;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.GroupBox Kelas;
        private System.Windows.Forms.GroupBox Jadwal;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.RadioButton rb_senin;
        private System.Windows.Forms.RadioButton rb_minggu;
        private System.Windows.Forms.RadioButton rb_sabtu;
        private System.Windows.Forms.RadioButton rb_selasa;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
    }
}

