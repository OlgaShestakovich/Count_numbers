using System;
/* 
1. Запросить имя пользователя. Вывести Hello, [имя пользователя].

2. Запросить у пользователя два целых числа и сохранить в двух переменных. Вывести значения.
Обменять значения переменных: например, если в переменной x было записано число 3, а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5. Вывести значения после обмена.

3.Запросить у пользователя целое число. Вывести количество цифр числа. Например, в числе 156 - 3 цифры.*/


namespace Сount_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello,  " + name+"! Введите два целых числа ");
           
            int FirstValue = int.Parse (Console.ReadLine());
            int SecondValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели " + FirstValue + " и " + SecondValue);

            int TempValue;
            TempValue = FirstValue;
            FirstValue = SecondValue;
            SecondValue = TempValue;
            Console.WriteLine("Программа поменяла введенные значения местами " + FirstValue + " и " + SecondValue);
            
            Console.WriteLine("Введите целое число, программа посчитает в нем количество цифр ");
           
            int ThirdValue = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("В веденном числе "+ ((int)Math.Log10(ThirdValue)+1) + " цифр ");
            Console.ReadLine();






        }
    }
}
