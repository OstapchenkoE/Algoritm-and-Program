using System;
using System.Collections.Generic;

namespace deligates
{
    interface IMath
    {
        double Plus(double num1, double num2);
        double Minyc(double num1, double num2);
        double Ymnojit(double num1, double num2);
        double Razdelit(double num1, double num2);

    }

    public class Action : IMath
    {
        public double Plus(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Minyc(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Ymnojit(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Razdelit(double num1, double num2)
        {
            return num1 / num2;
        }
    }



    class Program
    {
        delegate double ActionMath(double number_1, double number_2);

        static Action mathClass = new Action();

        public static bool rgr = true;


        public static double[] Vvod()
        {
            double[] mas = new double[2];
            Console.WriteLine("Введите первое число:");
            mas[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            mas[1] = Convert.ToDouble(Console.ReadLine());
            //Menu();
            return mas;
        }



        public static void Menu()
        {
            ActionMath math;
            Console.WriteLine();
            Console.WriteLine("\t\tМеню");
            Console.WriteLine("1.Сложить");
            Console.WriteLine("2.Вычесть");
            Console.WriteLine("3.Умножить");
            Console.WriteLine("4.Разделить");
            Console.WriteLine("5. Завершить работу.");
            Console.WriteLine("Введите выбранный номер: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    math = mathClass.Plus;
                    double[] num1 = Vvod();
                    var rez_Plus = math(num1[0], num1[1]);
                    Console.WriteLine("Сумма чисел: {0}", rez_Plus);
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.ReadKey();
                    break;
                case 2:
                    math = mathClass.Minyc;
                    double[] num2 = Vvod();
                    var rez_Minyc = math(num2[0], num2[1]);
                    Console.WriteLine("Разность чисел: {0}", rez_Minyc);
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.ReadKey();
                    break;
                case 3:
                    math = mathClass.Ymnojit;
                    double[] num3 = Vvod();
                    var rez_Ymn = math(num3[0], num3[1]);
                    Console.WriteLine("Произведение чисел: {0}", rez_Ymn);
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.ReadKey();
                    break;
                case 4:
                    math = mathClass.Razdelit;
                    double[] num4 = Vvod();
                    var rez_Raz = math(num4[0], num4[1]);
                    if (num4[1] != 0) { Console.WriteLine("Частное чисел: {0}", rez_Raz); }
                    else { Console.WriteLine("Делить на 0 нельзя."); }
                    Console.WriteLine("Нажмите Enter для продолжения...");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Досвидание!");
                    End();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Выбранный номер не указан. ");
                    break;
            }
        }
        static void Main()
        {
            while (rgr == true)
            {
                Menu();
            }

        }

        static void End() { rgr = false; }
    }


}