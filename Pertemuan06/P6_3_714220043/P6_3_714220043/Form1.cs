using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void textHuruf_Leave(object sender, EventArgs e)
        {
            if(textHuruf .Text == "")
            {
                epWarning.SetError(textHuruf, "Textbox huruf tidak boleh kosong !");
                epWrong.SetError(textHuruf, "");
                epCorrect.SetError(textHuruf, "");
            }
            else
            {
                if ((textHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textHuruf, "");
                    epWrong.SetError(textHuruf, "");
                    epCorrect.SetError(textHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(textHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(textHuruf, "");
                    epCorrect.SetError(textHuruf, "");
                }
            }
        }

        private void textAngka_Leave(object sender, EventArgs e)
        {
            if (textAngka.Text == "")
            {
                epCorrect.SetError(textAngka, "");
                epWarning.SetError(textAngka, "Textbox angka tidak boleh kosong !");
                epWrong.SetError(textAngka, "");
            }
            else
            {
                if ((textAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textAngka, "Betul!");
                    epWarning.SetError(textAngka, "");
                    epWrong.SetError(textAngka, "");
                }
                else
                {
                    epCorrect.SetError(textAngka, "");
                    epWarning.SetError(textAngka, "");
                    epWrong.SetError(textAngka, "Inputan hanya boleh angka!");
                }
            }
            
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                epWarning.SetError(textEmail, "Textbox email tidak boleh kosong !");
                epWrong.SetError(textEmail, "");
                epCorrect.SetError(textEmail, "");
            }
            else
            {
                 if (Regex.IsMatch(textEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                 {

                      epWarning.SetError(textEmail, "");
                      epWrong.SetError(textEmail, "");
                      epCorrect.SetError(textEmail, "Betul!");
                  }
                  else
                  {
                       epWrong.SetError(textEmail, "Format email salah!\nContoh: a@b.c");
                       epWarning.SetError(textEmail, "");
                       epCorrect.SetError(textEmail, "");
                   }
            }
        }

        private void textAngka1_Leave(object sender, EventArgs e)
        {
            if (textAngka1.Text == "")
            {
                epCorrect.SetError(textAngka1, "");
                epWarning.SetError(textAngka1, "Textbox angka1 tidak boleh kosong !");
                epWrong.SetError(textAngka1, "");
            }
            else
            {
                if ((textAngka1.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textAngka1, "Betul!");
                    epWarning.SetError(textAngka1, "");
                    epWrong.SetError(textAngka1, "");
                }
                else
                {
                    epCorrect.SetError(textAngka1, "");
                    epWarning.SetError(textAngka1, "");
                    epWrong.SetError(textAngka1, "Hanya boleh angka");
                }
            }
        }

        private void textAngka2_Leave(object sender, EventArgs e)
        {
            if (textAngka2.Text == "")
            {
                epCorrect.SetError(textAngka2, "");
                epWarning.SetError(textAngka2, "Textbox angka2 tidak boleh kosong !");
                epWrong.SetError(textAngka2, "");
            }
            else
            {
                if ((textAngka2.Text).All(Char.IsNumber))
                {
                    int angka1 = 0;
                    int angka2 = 0;

                    if (!string.IsNullOrEmpty(textAngka1.Text))
                    {
                        angka1 = int.Parse(textAngka1.Text);
                    }

                    angka2 = int.Parse(textAngka2.Text);

                    if (angka1 > angka2)
                    {
                        epCorrect.SetError(textAngka2, "Betul!");
                        epWarning.SetError(textAngka2, "");
                        epWrong.SetError(textAngka2, "");
                    }
                    else
                    {
                        epCorrect.SetError(textAngka2, "");
                        epWarning.SetError(textAngka2, "");
                        epWrong.SetError(textAngka2, "Angka1 harus lebih besar dari Angka2");
                    }
                }
                else
                {
                    epCorrect.SetError(textAngka2, "");
                    epWarning.SetError(textAngka2, "");
                    epWrong.SetError(textAngka2, "Hanya boleh angka");
                }
            }
        }
    }
}
