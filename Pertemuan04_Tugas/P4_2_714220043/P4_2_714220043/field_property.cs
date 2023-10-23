using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220043
{
    internal class field_property
    {
    }
    class AkunBankDenganProperty
    {
        private string namaPemilik;
        private decimal saldo;

        public string NamaPemilik
        {
            get { return namaPemilik; }
            set { namaPemilik = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public AkunBankDenganProperty(string namaPemilik, decimal saldo)
        {
            NamaPemilik = namaPemilik;
            Saldo = saldo;
        }
    }
}
