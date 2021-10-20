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
        static void AddContact(long number, string name)
        {                        
            phoneBook.Add(number, name);
        }

        /// <summary>
        /// Поиск контакта в телефонной книге и вывод его на экран
        /// </summary>
        static string FindNameContact(long phoneNumber)
        {            
            bool contactExist = phoneBook.TryGetValue(phoneNumber, out string fullName);
            Console.WriteLine();
            if (contactExist) return ($"Номер телефона:{phoneNumber}; ФИО:{fullName}");
            else return("Контакта с указанным номером нет в телефонной книге");
        }

        /// <summary>
        /// Показать меню работы с телефонной книгой
        /// </summary>
        public static void ShowMenu()
        {
            bool task2_On = true;
            long phoneNumber;
            string name;

            while (task2_On)
            {
                Console.Clear();
                Console.WriteLine("Задание 2. Телефонная книга\nВыберите необходимое действие\n1 - Добавить новый контакт в телефонную книгу" +
                    "\n2 - Найти контакт в телефонной книге\n3 - Выход в главное меню");
                var chooseByUser = Console.ReadKey();

                switch (chooseByUser.KeyChar)
                {
                    case '1':
                        name = AuxiliaryMethods.InputContactName();
                        phoneNumber = AuxiliaryMethods.InputContactPhone();
                        AddContact(phoneNumber,name);
                        break;
                    case '2':
                        phoneNumber = AuxiliaryMethods.InputContactPhone();
                        Console.WriteLine(FindNameContact(phoneNumber));
                        Console.ReadKey();
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
