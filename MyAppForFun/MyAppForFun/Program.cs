using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppForFun
{
    class Program
    {
        static void DisplayFancyMessage(ConsoleColor textColor,
                         ConsoleColor backgroundColor, string message)
        {
            // Сохранить старые цвета с целью их восстановления после вывода сообщения.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            // Установить новые цвета и вывести сообщение.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            // Восстановить предыдущие цвета.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
        static void Main(string[] args)
        {
            DisplayFancyMessage(message: "Welcome to my first application, Dear User!",
                backgroundColor:ConsoleColor.DarkRed, textColor: ConsoleColor.White);
            Console.WriteLine("Please, enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Great! Nice to meet you, {0}", userName);
            Console.WriteLine("What your favourite color?");
            string userColor = Console.ReadLine();
            Console.WriteLine("Ok. How old are you?");
            string userAge = Console.ReadLine();
            DisplayFancyMessage(message: "Please check information about you",
                backgroundColor: ConsoleColor.DarkBlue, textColor: ConsoleColor.Red);
            Console.WriteLine("Your name is: {0}, " +
                "Your favourite color is: {1}, " +
                "Your age is: {2} ", userName, userColor, userAge);
            DisplayFancyMessage(message: "Thank you for testing my application! " +
                "Please wait new version my own programm.", backgroundColor:ConsoleColor.Black,
                textColor: ConsoleColor.DarkGreen);
            Console.ReadLine();

        }
    }
}
