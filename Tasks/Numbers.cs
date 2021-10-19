using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.SKP
{
    /// <summary>
    /// Класс для работы со списком чисел (1е задание модуля)
    /// </summary>
    class Numbers
    {
        #region Поля
        /// <summary>
        /// Максимальное число (для фильтрации списка)
        /// </summary>
        static int maxFilterValue = 50;

        /// <summary>
        /// Минимальное число (для фильтрации списка)
        /// </summary>
        static int minFilterValue = 25;

        /// <summary>
        /// Маскимальное значение для генерации случайных значений
        /// </summary>
        static int maxRamndomValue = 100;



        /// <summary>
        /// Список чисел
        /// </summary>
        List<int> numbers;

        #endregion

        #region Методы
        /// <summary>
        /// Конструктор экземпляра класса
        /// </summary>
        public Numbers()
        {
           this.numbers = new List<int>(); 
            
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                this.numbers.Add(random.Next(maxRamndomValue));
            }

        }

        /// <summary>
        /// Метод преобразования списка чисел класса в форму для вывода в консоль
        /// </summary>
        /// <returns>Строка со всеми числами из списка в классе</returns>
        public override string ToString()
        {
            StringBuilder numbersToString = new StringBuilder();

            foreach (int number in this.numbers)
            {
                numbersToString.Append(number + " ");
            }

            return Convert.ToString(numbersToString);
        }

        /// <summary>
        /// Фильтрация последовательности чисел в классе в соответствии с заданными в классе верхним (maxFilterValue) и нижним (minFilterValue) пределами
        /// </summary>
        private void FilterNumbers()
        {
            List<int> filteredNumbers = (List<int>)numbers.Where(n => n < maxFilterValue).Where(n => n > minFilterValue).ToList<int>();
            this.numbers = filteredNumbers;
        }

        /// <summary>
        /// Показать меню работы со списком чисел
        /// </summary>
        public static void ShowMenu()
        {
            bool task1_On = true;

            while (task1_On)
            {
                Console.Clear();
                Console.WriteLine("Задание 1. Работа с листом\nВыберите необходимое действие\n1 - Запуск! (Получить новый список чисел и отфильтровать его) " +
                    "\n2 - Задать новые границы для фильтрации\n3 - Выход в главное меню");

                var chooseByUser = Console.ReadKey();

                switch (chooseByUser.KeyChar)
                {
                    case '1':
                        Numbers newNumbers = new Numbers();
                        Console.WriteLine("Список чисел до фильтрации:");
                        Console.WriteLine(newNumbers.ToString());
                        Console.ReadKey();
                        newNumbers.FilterNumbers();
                        Console.WriteLine("Список чисел после фильтрации:");
                        Console.WriteLine(newNumbers.ToString());
                        Console.ReadKey();
                        break;
                    case '2':

                        while (true)
                        {
                            Console.WriteLine("Введите минимальное значение диапозона фильтрации (по умолчанию - 25)");
                            minFilterValue = AuxiliaryMethods.InputNumber();

                            Console.WriteLine("Введите максимальное значение диапозона фильтрации (по умолчанию - 50)");
                            maxFilterValue = AuxiliaryMethods.InputNumber();

                            if (minFilterValue <= maxFilterValue)
                            {
                                Console.WriteLine($"Значения диапозона фильтрации успешно изменены. \nМинимальное значение более {minFilterValue};\nМаксимальное значение не более {maxFilterValue}");
                                Console.ReadKey();
                                break;
                            }
                            else Console.WriteLine("Введены некорректные границы диапозона. Нижняя граница должна быть мень или равно верхней границе. Повторите ввод...");
                        }
                        break;
                    case '3':
                        task1_On = false;
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную клавишу. Попробуйте снова...");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
        #endregion

    }

    

}

