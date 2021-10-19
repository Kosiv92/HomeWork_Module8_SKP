using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.SKP
{
    static class Repeats
    {
        static HashSet<int> numbers = new HashSet<int>();

        /// <summary>
        /// Добавление числа в хэш-таблицу
        /// </summary>
        static void AddNumber()
        {
            Console.WriteLine();
            int number = AuxiliaryMethods.InputNumber();
            if (numbers.Contains(number)) Console.WriteLine("Указанное число уже добавлено. Необходимо новое уникальное число.");
            else
            {
                numbers.Add(number);
                Console.WriteLine("Число успешно сохранено");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод всех чисел на экран консоли
        /// </summary>
        static void PrintNumbers()
        {
            Console.WriteLine();
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();
        }

        public static void ShowMenu()
        {
            bool task3_On = true;

            while (task3_On)
            {
                Console.Clear();
                Console.WriteLine("Задание 3. Проверка повторов\nВыберите необходимое действие:\n1 - Добавить новое значение " +
                    "\n2 - Вывести все значения на экран\n3 - Выход в главное меню");

                var chooseByUser = Console.ReadKey();

                switch (chooseByUser.KeyChar)
                {
                    case '1':
                        AddNumber();
                        break;
                    case '2':
                        PrintNumbers();
                        break;
                    case '3':
                        task3_On = false;
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
