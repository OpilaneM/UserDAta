using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            // kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis "oled liiga noor, et juhilube saada";
            // kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis " oled piisavalt vana, et juhilube saada";
            // kui kasutaja on 18, siis programm kuvab konsoolis " Palju õnne! Nüüd sa saad ka juhilube taotleda";

            Console.WriteLine("Palun, sisesta oma sünniaasta.");
            int yearofbirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearofbirth;

            if (userAge < 18)
            {
                Console.WriteLine("oled liiga noor, et juhilube saada");

            }

            else if (userAge > 18)
            {
                Console.WriteLine(" oled piisavalt vana, et juhilube saada");


            }

            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad ka juhilube taotleda");

            }
            Console.Read();

        }
    }
}


