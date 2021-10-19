using System;

namespace Module_8.SKP
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите необходимый пункт меню:\n1 - Работа с листом\n2 - Телефонная книга\n3 - Проверка повторов\n4 - Записная книжка\nНажмите любую другую клавишу для закрытия приложения");
                var userChoice = Console.ReadKey();
                switch (userChoice.KeyChar)
                {
                    case '1':
                        Numbers.ShowMenu();
                        break;
                    case '2':
                        PhoneNumbers.ShowMenu();
                        break;
                    case '3':
                        Repeats.ShowMenu();
                        break;
                    case '4':
                        Note.CreateNewNote();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
