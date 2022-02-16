using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaasta;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal"

            Console.WriteLine("Palun sisesta oma vanus.");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int yearofBirth = 2022 - userAge;
            Console.WriteLine($"Oled sündinud aastal {yearofBirth}.");
            Console.Read();

        }
    }
}
