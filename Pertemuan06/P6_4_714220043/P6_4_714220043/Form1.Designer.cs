namespace P6_4_714220043
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
            this.components = new System.ComponentModel.Container();
            this.txtNamaPemesan = new System.Windows.Forms.TextBox();
            this.txtAlamatPemesanan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.txtJumlahPesanan = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtKodePromo = new System.Windows.Forms.TextBox();
            this.txtcatatan = new System.Windows.Forms.TextBox();
            this.txtNoTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbPembayaran = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamaPemesan
            // 
            this.txtNamaPemesan.Location = new System.Drawing.Point(191, 36);
            this.txtNamaPemesan.Name = "txtNamaPemesan";
            this.txtNamaPemesan.Size = new System.Drawing.Size(161, 22);
            this.txtNamaPemesan.TabIndex = 0;
            this.txtNamaPemesan.Validating += new System.ComponentModel.CancelEventHandler(this.txtNamaPemesan_Validating);
            // 
            // txtAlamatPemesanan
            // 
            this.txtAlamatPemesanan.Location = new System.Drawing.Point(606, 36);
            this.txtAlamatPemesanan.Name = "txtAlamatPemesanan";
            this.txtAlamatPemesanan.Size = new System.Drawing.Size(145, 22);
            this.txtAlamatPemesanan.TabIndex = 6;
            this.txtAlamatPemesanan.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlamatPemesanan_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nama Pemesan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alamat Pemesan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jumlah Pesanan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kode Promo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nomor Telphone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Catatan :";
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(360, 371);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(75, 23);
            this.btnPesan.TabIndex = 18;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // txtJumlahPesanan
            // 
            this.txtJumlahPesanan.Location = new System.Drawing.Point(189, 93);
            this.txtJumlahPesanan.Name = "txtJumlahPesanan";
            this.txtJumlahPesanan.Size = new System.Drawing.Size(161, 22);
            this.txtJumlahPesanan.TabIndex = 19;
            this.txtJumlahPesanan.Validating += new System.ComponentModel.CancelEventHandler(this.txtJumlahPesanan_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtKodePromo
            // 
            this.txtKodePromo.Location = new System.Drawing.Point(191, 157);
            this.txtKodePromo.Name = "txtKodePromo";
            this.txtKodePromo.Size = new System.Drawing.Size(161, 22);
            this.txtKodePromo.TabIndex = 20;
            this.txtKodePromo.Validating += new System.ComponentModel.CancelEventHandler(this.txtKodePromo_Validating);
            // 
            // txtcatatan
            // 
            this.txtcatatan.Location = new System.Drawing.Point(189, 209);
            this.txtcatatan.Name = "txtcatatan";
            this.txtcatatan.Size = new System.Drawing.Size(161, 22);
            this.txtcatatan.TabIndex = 21;
            this.txtcatatan.Validating += new System.ComponentModel.CancelEventHandler(this.txtcatatan_Validating);
            // 
            // txtNoTelephone
            // 
            this.txtNoTelephone.Location = new System.Drawing.Point(606, 91);
            this.txtNoTelephone.Name = "txtNoTelephone";
            this.txtNoTelephone.Size = new System.Drawing.Size(145, 22);
            this.txtNoTelephone.TabIndex = 22;
            this.txtNoTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.txtNoTelephone_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(596, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 22);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // cbPembayaran
            // 
            this.cbPembayaran.FormattingEnabled = true;
            this.cbPembayaran.Items.AddRange(new object[] {
            "Cash",
            "Bank Rakyat Indonesia (BRI)",
            "Bank Central Asia (BCA)",
            "Bank Negara Indonesia (BNI)",
            "Bank Mandiri",
            "DANA",
            "Gopay"});
            this.cbPembayaran.Location = new System.Drawing.Point(596, 215);
            this.cbPembayaran.Name = "cbPembayaran";
            this.cbPembayaran.Size = new System.Drawing.Size(121, 24);
            this.cbPembayaran.TabIndex = 24;
            this.cbPembayaran.Validating += new System.ComponentModel.CancelEventHandler(this.cbPembayaran_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Pembayaran :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPembayaran);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNoTelephone);
            this.Controls.Add(this.txtcatatan);
            this.Controls.Add(this.txtKodePromo);
            this.Controls.Add(this.txtJumlahPesanan);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlamatPemesanan);
            this.Controls.Add(this.txtNamaPemesan);
            this.Name = "Form1";
            this.Text = "PemeasananPizzaForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamaPemesan;
        private System.Windows.Forms.TextBox txtAlamatPemesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.TextBox txtJumlahPesanan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtKodePromo;
        private System.Windows.Forms.TextBox txtcatatan;
        private System.Windows.Forms.TextBox txtNoTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbPembayaran;
        private System.Windows.Forms.Label label8;
    }
}

