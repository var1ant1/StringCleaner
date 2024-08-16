using System;
using System.Globalization;

namespace projects
{
    class Program
    {
        static void Main()
        {
            // ~#$%^&!@*():;"'.,? эти элементы остаются

            Console.Write("Введите текст, который нужно очистить:\n");
            string? s = Console.ReadLine(); // читаем введенный текст; s - нужный текст

            char[] nums = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0']; // массив цифр, которых быть не должно

            foreach(char number in nums)
            {
                foreach(char letter in s)
                {
                    if(number == letter)
                    {
                        string tempNumber = number.ToString();
                        s = s.Replace(tempNumber, "");
                    }
                }
            }
            
            Console.WriteLine("Ваш готовый текст:");
            Console.WriteLine(s);

            Console.WriteLine("Нажмите любую клавишу для выхода....");
            Console.ReadKey();
        }
    }
}

