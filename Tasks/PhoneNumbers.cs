using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.SKP
{
    class PhoneNumbers
    {
        static Dictionary<long, string> phoneBook = new Dictionary<long, string>();

        /// <summary>
        /// Добавление контакта в телефонную книгу
        /// </summary>
        static void AddContact()
        {
            Console.Write("Введите номер телефона (11 цифр):");
            long number = AuxiliaryMethods.InputPhoneNumber();
            Console.WriteLine();
            Console.Write("Введите ФИО контакта:");
            string fullName = Console.ReadLine();
            phoneBook.Add(number, fullName);
        }

        /// <summary>
        /// Поиск контакта в телефонной книге и вывод его на экран
        /// </summary>
        static void FindContact()
        {
            Console.Write("Введите номер телефона (11 цифр) для поиска ФИО контакта в телефонной книге:");
            long number = AuxiliaryMethods.InputPhoneNumber();
            bool contactExist = phoneBook.TryGetValue(number, out string fullName);
            Console.WriteLine();
            if (contactExist) Console.WriteLine($"Номер телефона:{number}; ФИО:{fullName}");
            else Console.WriteLine("Контакта с указанным номером нет в телефонной книге");
            Console.ReadKey();
        }

        /// <summary>
        /// Показать меню работы с телефонной книгой
        /// </summary>
        public static void ShowMenu()
        {
            bool task2_On = true;
            while (task2_On)
            {
                Console.Clear();
                Console.WriteLine("Задание 2. Телефонная книга\nВыберите необходимое действие\n1 - Добавить новый контакт в телефонную книгу" +
                    "\n2 - Найти контакт в телефонной книге\n3 - Выход в главное меню");
                var chooseByUser = Console.ReadKey();

                switch (chooseByUser.KeyChar)
                {
                    case '1':
                        AddContact();
                        break;
                    case '2':
                        FindContact();
                        break;
                    case '3':
                        task2_On = false;
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную клавишу. Попробуйте снова...");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
