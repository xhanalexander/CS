using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaTest
{
    public class mahasiswa
    {

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

    class Fruits
    {

        public string name, color, taste;
        public int quantity;

        static void apple()
        {
            Fruits fruit1 = new Fruits();
            fruit1.name = "Apple";
            fruit1.color = "Red";
            fruit1.taste = "Sweet";
            fruit1.quantity = 1;
            Console.WriteLine(">> \t" + fruit1.name);
        }

        static void banana()
        {
            Fruits fruit1 = new Fruits();
            fruit1.name = "Banana";
            fruit1.color = "Yellow";
            fruit1.taste = "Sweet";
            fruit1.quantity = 5;
            Console.WriteLine(">> \t" + fruit1.name);
        }

        static void mango()
        {
            Fruits fruit1 = new Fruits();
            fruit1.name = "Mango";
            fruit1.color = "Green Yellowish";
            fruit1.taste = "Sweet Sour";
            fruit1.quantity = 7;
            Console.WriteLine(">> \t" + fruit1.name);
        }
        /*
        static void Main(string[] args) {
            mahasiswa test = new mahasiswa();

            test.intro();
            apple();
            banana();
            mango();
            char C = Console.ReadKey(true).KeyChar;     //getch() C++ / C
        }
        */
    }

    class vehicle
    {

        public string brand;

        static void volvo()
        {
            vehicle car = new vehicle();
            car.brand = "Volvo";
            Console.WriteLine(">> \t" + car.brand);
        }

        static void Audi()
        {
            vehicle car = new vehicle();
            car.brand = "Audi";
            Console.WriteLine(">> \t" + car.brand);
        }

        static void Toyota()
        {
            vehicle car = new vehicle();
            car.brand = "Toyota";
            Console.WriteLine(">> \t" + car.brand);
        }

        static void Tesla()
        {
            vehicle car = new vehicle();
            car.brand = "Tesla";
            Console.WriteLine(">> \t" + car.brand);
        }

        static void Main(string[] args)
        {
            mahasiswa test = new mahasiswa();

            test.intro();
            volvo();
            Audi();
            Toyota();
            Tesla();
            char C = Console.ReadKey(true).KeyChar;
        }
    }
}

