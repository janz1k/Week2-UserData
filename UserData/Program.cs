using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kuvab kasutaja vanust konsoolist
            // 1985 - int (Kasutame arvutamiseks)
            // "1985" - string (Kasutame kirjapildi kuvamiseks)

            Console.WriteLine("Palun siseta oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");









        }
    }
}
