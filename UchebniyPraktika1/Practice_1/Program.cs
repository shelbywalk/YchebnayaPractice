using System;

namespace Practice_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            string a = "Hello";
            string b = "world";
            string c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
            
            //Задание 2
            Console.WriteLine("Задание 2");
            int w = 7;
            int u = 9;
            int q = 5;
            Console.WriteLine(w + u);
            Console.WriteLine(u - q);
            Console.WriteLine(q * w);
            Console.WriteLine(u / q);
            Console.ReadKey();
            
            //Задание 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите свое ФИО");
            a = Console.ReadLine();
            Console.WriteLine(a);

            Console.ReadKey();
            
            //Задание 4
            Console.WriteLine("Задание 4");
            int healthp_p = 1728;
            int damage_p = 540;
            int defence_p = 430;
            int healthp_m = 11000;
            int damage_m = 824;
            int defence_m = 143;
            Console.WriteLine("Здоровье игрока:" + " " + Convert.ToString(healthp_p - damage_m));
            Console.WriteLine("Здоровье монстра:" + " " + Convert.ToString(healthp_m - damage_p));
            Console.WriteLine("Здоровье урон монстра:" + " " + (damage_m - defence_p));
            Console.WriteLine("Здоровье урон игрока:" + " " + (damage_p - defence_m));

            Console.ReadKey();
            
        }
    }
}