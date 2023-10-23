using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220043
{
    internal class contructor
    {
    }
    class Nasabah
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public AkunBank Akun { get; set; }

        public Nasabah(string nama, string alamat, AkunBank akun)
        {
            Nama = nama;
            Alamat = alamat;
            Akun = akun;
        }
    }
}
