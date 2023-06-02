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
        public static HashSet<string> list = new HashSet<string>();
        static void Main()
        {
            rgrka = true;
            list.Add("test");
            list.Add("exempl");
            list.Add("003");
            list.Add("25gf");

            MainMenu(list);

            while (rgrka)
            {
                rgrka = MainMenu(list);
            }

        }

        public static bool MainMenu(HashSet<string> list)
        {
            Console.Clear();
            Console.WriteLine("Меню");
            Console.WriteLine("1) Добавление");
            Console.WriteLine("2) Размер массива");
            Console.WriteLine("3) Очистить массив");
            Console.WriteLine("4) Вывод");
            Console.WriteLine("5) Хеш код таблицы");
            Console.WriteLine("6) Метод TryGetValue");
            Console.WriteLine("7) Содержание элемнта");
            Console.WriteLine("8) Удаление");
            Console.WriteLine("9) Перевернуть");
            Console.WriteLine("10) Вывод типа");
            Console.WriteLine("11) Выход");
            Console.Write("\r\nВыберите действие: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Введите значение");
                    var add = Console.ReadLine();
                    list.Add(add);
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Длинна массива");
                    Console.WriteLine(list.Count);
                    
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Массив очищен");
                    
                    list.Clear();
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Значения");
                    foreach(var a in list){
                        Console.Write(a+" ");
                    }
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.Clear();
                    //Console.WriteLine("Введите индекс");
                    //int i = Convert.ToInt32(Console.ReadLine());
                    //if(i>list.Count-1) Console.WriteLine("Такого индекса нет");
                    Console.WriteLine("Хеш код таблицы "+list.GetHashCode());
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Введите значения");
                    var val = Console.ReadLine();
                    if(!(list.TryGetValue(val, out string rez))) Console.WriteLine("Такого элемента нет");
                    else Console.WriteLine("Элемент "+rez+" взят");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Введите значение");
                    var el = Console.ReadLine();
                    Console.WriteLine("Элемент содержится в массиве: "+list.Contains(el));
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.Clear();
                    Console.WriteLine("Введите элемент");
                    var del = Console.ReadLine();
                    list.Remove(del);
                    if(list.Contains(del)) Console.WriteLine("Такого элемента нет");
                    else Console.WriteLine("Элемент "+del+" удален");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.Clear();
                    list.Reverse();
                    Console.WriteLine("Массив перевернут");
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.Clear();
                    Console.WriteLine("Тип коллекции: {0}", list.GetType());
                    Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
                    Console.ReadLine();
                    return true;
                case "11":
                    Console.WriteLine("\nДосвидание.");
                    Console.ReadKey();
                    return false;
                default:
                    return true;

            }
        }

    }
}
