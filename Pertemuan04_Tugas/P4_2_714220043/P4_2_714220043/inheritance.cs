using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220043
{
    internal class inheritance
    {
    }
    class AkunBank
    {
        public string NamaPemilik { get; set; }
        public decimal Saldo { get; set; }

        public AkunBank(string namaPemilik, decimal saldo)
        {
            NamaPemilik = namaPemilik;
            Saldo = saldo;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Pemilik: {NamaPemilik}, Saldo: {Saldo:C}");
        }
    }

    class AkunTabungan : AkunBank
    {
        public double TingkatBunga { get; set; }

        public AkunTabungan(string namaPemilik, decimal saldo, double tingkatBunga)
            : base(namaPemilik, saldo)
        {
            TingkatBunga = tingkatBunga;
        }

        public override void Info()
        {
            Console.WriteLine($"Jenis Akun: Tabungan, Pemilik: {NamaPemilik}, Saldo: {Saldo:C}, Bunga: {TingkatBunga}%");
        }
    }

    class AkunGiro : AkunBank
    {
        public decimal BiayaAdmin { get; set; }

        public AkunGiro(string namaPemilik, decimal saldo, decimal biayaAdmin)
            : base(namaPemilik, saldo)
        {
            BiayaAdmin = biayaAdmin;
        }

        public override void Info()
        {
            Console.WriteLine($"Jenis Akun: Giro, Pemilik: {NamaPemilik}, Saldo: {Saldo:C}, Biaya Admin: {BiayaAdmin:C}");
        }
    }
}
