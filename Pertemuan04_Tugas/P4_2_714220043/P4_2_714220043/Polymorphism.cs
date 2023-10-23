using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220043
{
    public class Polymorphism 
    {

        static void TampilkanInfoAkun(AkunBank akun)
        {
            akun.Info();
        }

        static void Main(string[] args)
        {
            AkunTabungan tabungan1 = new AkunTabungan("Yoginara", 250000.0M, 2.5);
            AkunGiro giro1 = new AkunGiro("Susanti", 100000.0M, 10.0M);

            TampilkanInfoAkun(tabungan1);
            TampilkanInfoAkun(giro1);

            AkunBankDenganProperty akunProperty = new AkunBankDenganProperty("Ayunda", 150000.0M);
            Console.WriteLine($"Pemilik: {akunProperty.NamaPemilik}, Saldo: {akunProperty.Saldo:C}");

            Nasabah nasabah1 = new Nasabah("Tika", "Jl. SariasihII", tabungan1);
            Nasabah nasabah2 = new Nasabah("Boby", "Jl. SariasihIV", giro1);

            Console.WriteLine($"Nasabah: {nasabah1.Nama}, Alamat: {nasabah1.Alamat}");
            TampilkanInfoAkun(nasabah1.Akun);

            Console.WriteLine($"Nasabah: {nasabah2.Nama}, Alamat: {nasabah2.Alamat}");
            TampilkanInfoAkun(nasabah2.Akun);
        }
    }
}
