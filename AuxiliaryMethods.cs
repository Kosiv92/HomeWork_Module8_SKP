using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.SKP
{
    public static class AuxiliaryMethods
    {
        /// <summary>
        /// Метод ввода пользователем целого числа
        /// </summary>
        /// <returns>Введенное пользователем число</returns>
        public static int InputNumber()
        {
            int number = 0;
            while (true)
            {
                string inputByUser = Console.ReadLine();
                if (CheckNumber(inputByUser, ref number)) break;
                else Console.WriteLine("Некорректный ввод. Необходимо ввести целое число. Повторите попытку:");
            }
            return number;
        }

        /// <summary>
        /// Метод ввода пользователем номера телефона
        /// </summary>
        /// <returns>Введенный пользователем номер телефона</returns>
        public static long InputPhoneNumber()
        {
            long number = 0;
            while (true)
            {
                string inputByUser = Console.ReadLine();
                if (CheckPhoneNumber(inputByUser, ref number) && inputByUser.Length == 11) break;
                else Console.WriteLine("Некорректный ввод. Номер телефона должен состоять из 11 цифр (мобильный или городской с кодом города)");                
            }
            return number;
        }

        /// <summary>
        /// Проверка конвертации строки в число
        /// </summary>
        /// <param name="input">Проверяемая строка</param>
        /// <param name="number">Результат конвертации строки в число</param>
        /// <returns>Результат проверки</returns>
        private static bool CheckNumber(string input, ref int number)
        {
            return Int32.TryParse(input, out number);
        }

        private static bool CheckPhoneNumber(string input, ref long number)
        {
            return Int64.TryParse(input, out number);
        }

    }
}
