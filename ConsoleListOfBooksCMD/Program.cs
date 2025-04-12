using System;
using ConsoleListOfBooksBL.Controller;

namespace ConsoleListOfBooksCMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение List of Books");

            Console.WriteLine("Введите имя пользователя: ");

            var name = Console.ReadLine();

            var userController = new UserController(name);
            userController.Save();
            userController.GetUser();
        }
    }
}
