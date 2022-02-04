using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm arvutab kasutaja vanust
            //Kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhiluba saada";
            //Kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhiluba taotleda";
            //Kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd saate taotelda juhiluba endale"

            Console.WriteLine("Mis sünniaastal sa sündinud oled?");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube taotleda");
            }
            else if(userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube taotleda");
            }
            else
            {
                Console.WriteLine("Palju õnne! Saate nüüd taotleda endale juhiluba!");
            }

            Console.WriteLine("Kena päeva teile!");




        }
    }
}
