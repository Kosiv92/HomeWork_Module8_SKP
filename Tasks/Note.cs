using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module_8.SKP
{

    static class Note
    {
        static int numberOfContact = 1;

        /// <summary>
        /// Метод создания новой карточки контакта
        /// </summary>
        public static void CreateNewNote()
        {
            XElement Person = InputNoteData();
            Person.Save("contact_" + numberOfContact);
            Console.WriteLine("Контакт успешно сохранено в папке с программой");
            Console.ReadKey();
            numberOfContact++;
        }

        /// <summary>
        /// Ввод данных адреса пользователем
        /// </summary>
        /// <param name="Person"></param>
        public static void InputAddressData(XElement Person)
        {
            Console.Write("Укажите адресс. Введите название улицы:");
            string street = Console.ReadLine();
            Console.WriteLine();
            XElement Address = new XElement("Address");
            XAttribute XAttributeStreetName = new XAttribute("street_name", street);
            Console.Write("Введите номер дома:");
            string houseNumber = Console.ReadLine();
            Console.WriteLine();
            XAttribute XAttributeHouseNumber = new XAttribute("house_number", houseNumber);
            Console.Write("Введите номер квартиры:");
            string flatNumber = Console.ReadLine();
            Console.WriteLine();
            XAttribute XAttributeFlatNumber = new XAttribute("flat_number", flatNumber);
            Address.Add(XAttributeStreetName);
            Address.Add(XAttributeHouseNumber);
            Address.Add(XAttributeFlatNumber);
            Person.Add(Address);
        }

        /// <summary>
        /// Ввод данных контактных данных пользователем
        /// </summary>
        /// <param name="Person"></param>
        public static void InputPhoneData(XElement Person)
        { 
            XElement Phones = new XElement("Phones");
            Console.Write("Введите номер мобильного телефона:");
            string mobilePhone = Console.ReadLine();
            Console.WriteLine();
            XAttribute XAttributeMobilePhone = new XAttribute("mobile_phone", mobilePhone);
            Console.Write("Введите номер домашнего телефона:");
            string flatPhone = Console.ReadLine();
            Console.WriteLine();
            XAttribute XAttributeFlatPhone = new XAttribute("flat_phone", flatPhone);
            Phones.Add(XAttributeMobilePhone);
            Phones.Add(XAttributeFlatPhone);
            Person.Add(Phones);
            }


        public static XElement InputNoteData()
        {
            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine();
            XElement Person = new XElement("Person");
            XAttribute XAttributeName = new XAttribute("name", name);
            Person.Add(XAttributeName);
            InputAddressData(Person);
            InputPhoneData(Person);                        
            return Person;
        }







    }
}
