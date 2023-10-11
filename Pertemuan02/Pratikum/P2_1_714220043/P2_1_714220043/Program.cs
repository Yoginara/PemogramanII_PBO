using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Angka pertama
            Console.Write("Masukkan angka pertama: ");
            double angkaPertama = Convert.ToDouble(Console.ReadLine());
                
            // Angka kedua
            Console.Write("Masukkan angka kedua: ");
            double angkaKedua = Convert.ToDouble(Console.ReadLine());

            // Penjumlahan
            double hasilPenjumlahan = angkaPertama + angkaKedua;
            Console.WriteLine($"Penjumlahan: {angkaPertama} + {angkaKedua} = {hasilPenjumlahan}");

            // Pengurangan
            double hasilPengurangan = angkaPertama - angkaKedua;
            Console.WriteLine($"Pengurangan: {angkaPertama} - {angkaKedua} = {hasilPengurangan}");

            // Perkalian
            double hasilPerkalian = angkaPertama * angkaKedua;
            Console.WriteLine($"Perkalian: {angkaPertama} * {angkaKedua} = {hasilPerkalian}");

            // Pembagian
            double hasilPembagian = angkaPertama / angkaKedua;
            Console.WriteLine($"Pembagian: {angkaPertama} / {angkaKedua} = {hasilPembagian}");

            Console.ReadLine();
        }
    }
}
