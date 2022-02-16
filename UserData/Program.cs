using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvad kasutaja vanust konsoolis;
            //pea meeles
            //et 1985 - int
            // "1985" - string

            Console.WriteLine("Palun, sisesta oma sünniaasta");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearofbirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");
            // string interpolation - võimalik kirjutada täislaused ja sisestada muutujad otseselt

            Console.WriteLine($"Oled {userAge} aastat vana.");



            Console.Read();
        }
    }
}
