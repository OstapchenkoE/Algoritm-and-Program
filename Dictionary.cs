using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace menu
{
    class Array
    {
        public static bool rgrka;
        public static Dictionary<int,string> list = new Dictionary<int,string>();
        static void Main()
        {
            rgrka = true;
            list.Add(001, "Евгений");
            list.Add(002, "Матвей");
            list.Add(003, "Петр");
            list.Add(004, "Юрий");

            MainMenu(list);

            while (rgrka)
            {
                rgrka = MainMenu(list);
            }

        }

        public static bool MainMenu(Dictionary<int,string> list)
        {
            Console.Clear();
            Console.WriteLine("Меню");
            Console.WriteLine("1) Добавление");
            Console.WriteLine("2) Размер таблицы");
            Console.WriteLine("3) Очистить таблицу");
            Console.WriteLine("4) Вывод");
            Console.WriteLine("5) Содержание ключа");
            Console.WriteLine("6) Разбиение");
            Console.WriteLine("7) Содержание элемнта");
            Console.WriteLine("8) Удаление");
            Console.WriteLine("9) Ключи");
            Console.WriteLine("10) Вывод типа");
            Console.WriteLine("11) Выход");
            Console.Write("\r\nВыберите действие: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Add(list);
                    return true;
                case "2":
                    Dlina(list);
                    return true;
                case "3":
                    Chisto(list);
                    return true;
                case "4":
                    Out(list);
                    return true;
                case "5":
                    ContainsKey(list);
                    return true;
                case "6":
                    CopyKey(list);
                    return true;
                case "7":
                    ContainsVal(list);
                    return true;
                case "8":
                    Delete(list);
                    return true;
                case "9":
                    Key(list);
                    return true;
                case "10":
                    GetType(list);
                    return true;
                case "11":
                    Console.WriteLine("\nДосвидание.");
                    Console.ReadKey();
                    return false;
                default:
                    return true;

            }
        }

        public static void Add(Dictionary<int,string> list)
        {
            Console.Clear();
            Console.WriteLine("Введите ключ, значение");
            int key = Convert.ToInt32(Console.ReadLine());
            var value = Console.ReadLine();
            list.Add(key, value);
            //Out(list);
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void Dlina(Dictionary<int,string> list)
        {
            Console.Clear();
            Console.Write("Количество элементов таблицы:\t");
            Console.WriteLine(list.Count);
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void Chisto(Dictionary<int,string> list)
        {
            Console.Clear();
            list.Clear();
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void ContainsKey(Dictionary<int,string> list)
        {
            Console.Clear();
            Console.Write("Введите ключ:\t");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write("Содержание данного ключа:\t");
            Console.WriteLine(list.ContainsKey(key));
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void ContainsVal(Dictionary<int,string> list)
        {
            Console.Clear();
            Console.Write("Введите элемент:\t");
            string el = Console.ReadLine();
            Console.Write("Содержание данного элемента:\t");
            Console.WriteLine(list.ContainsValue(el));
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }

        public static void Delete(Dictionary<int,string> list)
        {
            Console.Clear();
            Console.Write("Введите ключ:\t");
            int f = Convert.ToInt32(Console.ReadLine());
            list.Remove(f);
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void GetType(Dictionary<int,string> list)
        {
            Console.Clear();
            Console.WriteLine("Тип коллекции: {0}", list.GetType());
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void Out(Dictionary<int,string> list)
        {
            Console.Clear();
            foreach (var element in list.Keys)
            {
                Console.WriteLine(element + " - " + list[element]);
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void CopyKey(Dictionary<int,string> list)
        {
            Console.Clear();
            //копирует из list в mass 
            int[] massKey = new int[list.Count];
            string[] massVal = new string[list.Count];

            list.Keys.CopyTo(massKey, 0);
            list.Values.CopyTo(massVal, 0);

            Console.Write("Массив ключей: ");
            for (int i = 0; i < massKey.Length; i++) Console.Write("{0} ", massKey[i]);
            Console.WriteLine();
            Console.Write("Массив значений: ");
            for (int i = 0; i < massVal.Length; i++) Console.Write("{0} ", massVal[i]);
            Console.WriteLine();
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void Key(Dictionary<int,string> list)
        {
            Console.Clear();
            ICollection Key = list.Keys;
            foreach (var element in Key)
            {
                Console.WriteLine(element);
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
    }
}
