using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester2
{
    public class mahasiswa {
        public void intro()
        {
            Console.Title = "Praktikum Pemrograman II";
            Console.WriteLine("\n");
            Console.WriteLine("(>>)\t" + "Nama \t\t\t:" + " Alexander Achmad Khan");
            Console.WriteLine("(>>)\t" + "NIM/NPM \t\t:" + " 120103048");
            Console.WriteLine("(>>)\t" + "Program Studi \t\t:" + " Ilmu Komputer");
            Console.WriteLine("(>>)\t" + "Mata Kuliah \t\t:" + " Praktikum Pemrograman II");
            Console.WriteLine("================================================================\n");
        }
    }
    
    class Triangle {

        static void Main(string[] args) {
            mahasiswa test = new mahasiswa();
            test.intro();

            pilih();
            string choose = Console.ReadLine();
            switch (choose) {
                case "1":
                    LuasSegitiga();
                    break;
                case "2":
                    SegitigaLuas();
                    break;
                default:
                    break;
            }

            char C = Console.ReadKey(true).KeyChar;
            Console.Clear();
        }

        static void LuasSegitiga() {
            Console.Write("\n");
            Console.Write("(++)\t Masukkan Nilai Alas Segitiga \t: ");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("(++)\t Masukkan Nilai Tinggi Segitiga : ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double luas = (alas * tinggi) / 2;
            Console.WriteLine("(>>>)\t Total luas segitiga \t\t==> " + luas + " cm2");
            Console.Write("\n");
        }

        static void SegitigaLuas() {
            Console.Write("\n");
            Console.Write("(++)\t Masukkan Nilai Alas Segitiga \t\t: ");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("(++)\t Masukkan Nilai Tinggi Segitiga \t: ");
            double tinggi = Convert.ToDouble(Console.ReadLine());
            Console.Write("(++)\t Masukkan Nilai samping Segitiga \t: ");
            double samping = Convert.ToDouble(Console.ReadLine());

            double total = (alas + tinggi + samping) / 2;
            double totalLuas = Math.Sqrt(total * (total - alas) * (total - tinggi) * (total - samping));

            Console.WriteLine("(>>>)\t Total luas segitiga \t\t\t==> " + totalLuas + " cm2");
        }

        static void pilih() {
            
            Console.WriteLine("\t ======== Menghitung Luas Segitiga ======== \n");
            Console.WriteLine("(1)\t Luas Segitiga dengan diketahui 2 sisi. ");
            Console.WriteLine("(2)\t Luas Segitiga dengan diketahui 3 sisi. ");

            Console.Write("(>>>)\t Pilih... ");
        }
    }
}
