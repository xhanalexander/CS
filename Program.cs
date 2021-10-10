using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaTest
{
    public class mahasiswa {

        public void intro() {
            Console.Title = "Praktikum Pemrograman";
            Console.WriteLine("\n");
            Console.WriteLine("(>>)\t" + "Nama \t\t\t:" + " Alexander Achmad Khan");
            Console.WriteLine("(>>)\t" + "NIM/NPM \t\t:" + " 120103048");
            Console.WriteLine("(>>)\t" + "Program Studi \t\t:" + " Ilmu Komputer");
            Console.WriteLine("(>>)\t" + "Mata Kuliah \t\t:" + " Praktikum Pemrograman II");
            Console.WriteLine("================================================================\n");    
        }
    }

    class Fruits {
        
        public string name, color, taste;
        public int quantity;

        static void apple() {
            Fruits fruit1 = new Fruits();

            fruit1.name = "Apple";
            fruit1.color = "Red";
            fruit1.taste = "Sweet";
            fruit1.quantity = 1;

            Console.WriteLine(">> " + fruit1.name);
        }

        static void banana() {
            Fruits fruit2 = new Fruits();
            fruit2.name = "Banana";
            fruit2.color = "Yellow";
            fruit2.taste = "Sweet";
            fruit2.quantity = 5;

            Console.WriteLine(">> " + fruit2.name);
        }

        static void mango() {
            Fruits fruit3 = new Fruits();
            fruit3.name = "Mango";
            fruit3.color = "Green Yellowish";
            fruit3.taste = "Sweet Sour";
            fruit3.quantity = 7;

            Console.WriteLine(">> " + fruit3.name);
        }

        static void Main(string[] args) {

            mahasiswa test = new mahasiswa();

            test.intro();
            apple();
            banana();
            mango();

            char C = Console.ReadKey(true).KeyChar;     //getch() C++ / C */
        }
    }

    class vehicle {

        public string brand;

        static void volvo() {
            vehicle car1 = new vehicle();
            car1.brand = "Volvo";
            Console.WriteLine(">> " + car1.brand);
        }

        static void Audi() {
            vehicle car2 = new vehicle();
            car2.brand = "Audi";
            Console.WriteLine(">> " + car2.brand);
        }

        static void Toyota() {
            vehicle car3 = new vehicle();
            car3.brand = "Toyota";
            Console.WriteLine(">> " + car3.brand);
        }

        static void Main2(string[] args) {

            volvo();
            Audi();
            Toyota();
            char C = Console.ReadKey(true).KeyChar;
        }

    }
}

