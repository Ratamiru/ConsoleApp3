using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal static class Validator
    {
        public static bool validation(string text, bool isDigit)
        {
            //Проверка пуст ли вообще ввод пользователя
            string temp = text;
            if(String.IsNullOrEmpty(text))
            {
                return false;
            }

            if (isDigit)
            {
                //Проверка на цифры
                if (!int.TryParse(temp, out int value))
                {
                    Console.WriteLine("Было введено не цифра");
                    return false;
                }
            }
            else
            {
                //Проверка на только символы
                if (!temp.All(char.IsLetter))
                {
                    Console.WriteLine("Было введен символ, а не цифра");
                    return false;
                }
            }
            return true;
        }
        public static void debug()
        {
            Console.WriteLine("IM debug class");
        }
    }
}
