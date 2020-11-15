using System;

namespace LearnConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(12.3m);
            
Console.Beep(523, 500);
            Console.Beep(523, 500);
            
                        int a = 10;
                        int b = 15;
                        int summer = a + b * 2;



                        Console.WriteLine("Примитивный калькулятор");

                        Console.WriteLine("Произведем операцию складывания двух чисел \n\n" +

                            "Введите пепрвое число X");

                        String inputString = Console.ReadLine();
                        int x = Convert.ToInt32(inputString);
                        Console.WriteLine("Вы ввели первое число: X = {0} \n", x);
                        Console.WriteLine("Введите второе число: Y");

                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Вы ввели второе число: Y = {0} \n", y);

                        Console.WriteLine("Вы ввели первое число: X = {0} \n", x);

                        Console.WriteLine();

                       // Console.WriteLine($"x = {   ");


                        //Карманный справочник
                        double summ = x + y;
                        System.Console.WriteLine("Сумма двух введенных переменных X и Y равна: \n X + Y = {0}", summ);

                        Console.Beep();
                        //задержка консоли от закрытия
                        Console.ReadLine();
                        
                Console.WriteLine("Test text");
                        //2020.11.15 ---> Создание интерактивной вселенной LiveSix
            Console.WriteLine("Creating an interactive life six");
        }
    }
}
