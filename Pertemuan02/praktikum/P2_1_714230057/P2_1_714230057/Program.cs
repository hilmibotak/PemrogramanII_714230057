using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan angka pertama: ");
            double angkapertama = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukan angka kedua: ");
            double angkakedua = Convert.ToDouble(Console.ReadLine());

            double penjumlahan = angkapertama + angkakedua;
            double pengurangan = angkapertama - angkakedua;
            double perkalian = angkapertama * angkakedua;
            double pembagian = angkapertama / angkakedua;

            Console.WriteLine($"{angkapertama} + {angkakedua} = {penjumlahan}");
            Console.WriteLine($"{angkapertama} - {angkakedua} = {pengurangan}");
            Console.WriteLine($"{angkapertama} x {angkakedua} = {perkalian}");
            Console.WriteLine($"{angkapertama} / {angkakedua} = {pembagian}");
        }
    }
}
