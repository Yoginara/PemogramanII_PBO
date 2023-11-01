namespace P6_3_714220043
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHuruf = new System.Windows.Forms.Label();
            this.lblAngka = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAngka1 = new System.Windows.Forms.Label();
            this.lblAngka2 = new System.Windows.Forms.Label();
            this.textHuruf = new System.Windows.Forms.TextBox();
            this.textAngka = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textAngka1 = new System.Windows.Forms.TextBox();
            this.textAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHuruf
            // 
            this.lblHuruf.AutoSize = true;
            this.lblHuruf.Location = new System.Drawing.Point(93, 30);
            this.lblHuruf.Name = "lblHuruf";
            this.lblHuruf.Size = new System.Drawing.Size(38, 16);
            this.lblHuruf.TabIndex = 0;
            this.lblHuruf.Text = "Huruf";
            // 
            // lblAngka
            // 
            this.lblAngka.AutoSize = true;
            this.lblAngka.Location = new System.Drawing.Point(93, 92);
            this.lblAngka.Name = "lblAngka";
            this.lblAngka.Size = new System.Drawing.Size(46, 16);
            this.lblAngka.TabIndex = 1;
            this.lblAngka.Text = "Angka";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(93, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(93, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Angka 1 > Angka 2";
            // 
            // lblAngka1
            // 
            this.lblAngka1.AutoSize = true;
            this.lblAngka1.Location = new System.Drawing.Point(93, 307);
            this.lblAngka1.Name = "lblAngka1";
            this.lblAngka1.Size = new System.Drawing.Size(56, 16);
            this.lblAngka1.TabIndex = 4;
            this.lblAngka1.Text = "Angka 1";
            // 
            // lblAngka2
            // 
            this.lblAngka2.AutoSize = true;
            this.lblAngka2.Location = new System.Drawing.Point(93, 375);
            this.lblAngka2.Name = "lblAngka2";
            this.lblAngka2.Size = new System.Drawing.Size(56, 16);
            this.lblAngka2.TabIndex = 5;
            this.lblAngka2.Text = "Angka 2";
            // 
            // textHuruf
            // 
            this.textHuruf.Location = new System.Drawing.Point(395, 23);
            this.textHuruf.Name = "textHuruf";
            this.textHuruf.Size = new System.Drawing.Size(224, 22);
            this.textHuruf.TabIndex = 6;
            this.textHuruf.Leave += new System.EventHandler(this.textHuruf_Leave);
            // 
            // textAngka
            // 
            this.textAngka.Location = new System.Drawing.Point(395, 86);
            this.textAngka.Name = "textAngka";
            this.textAngka.Size = new System.Drawing.Size(224, 22);
            this.textAngka.TabIndex = 7;
            this.textAngka.Leave += new System.EventHandler(this.textAngka_Leave);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(395, 151);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(224, 22);
            this.textEmail.TabIndex = 8;
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textAngka1
            // 
            this.textAngka1.Location = new System.Drawing.Point(395, 301);
            this.textAngka1.Name = "textAngka1";
            this.textAngka1.Size = new System.Drawing.Size(224, 22);
            this.textAngka1.TabIndex = 9;
            this.textAngka1.Leave += new System.EventHandler(this.textAngka1_Leave);
            // 
            // textAngka2
            // 
            this.textAngka2.Location = new System.Drawing.Point(395, 369);
            this.textAngka2.Name = "textAngka2";
            this.textAngka2.Size = new System.Drawing.Size(224, 22);
            this.textAngka2.TabIndex = 10;
            this.textAngka2.Leave += new System.EventHandler(this.textAngka2_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textAngka2);
            this.Controls.Add(this.textAngka1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textAngka);
            this.Controls.Add(this.textHuruf);
            this.Controls.Add(this.lblAngka2);
            this.Controls.Add(this.lblAngka1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAngka);
            this.Controls.Add(this.lblHuruf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHuruf;
        private System.Windows.Forms.Label lblAngka;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAngka1;
        private System.Windows.Forms.Label lblAngka2;
        private System.Windows.Forms.TextBox textHuruf;
        private System.Windows.Forms.TextBox textAngka;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textAngka1;
        private System.Windows.Forms.TextBox textAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

