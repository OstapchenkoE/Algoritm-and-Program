using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace База_Учителей
{

    class Teacher
    {
        public string name;
        public string fname;
        public string otch;
        public string age;
        public string org;
        public string subject;
        public string[,] book;
        public Teacher(){        }
        

        public Teacher(string tfname, string tname, string totch, string tage, string torg, string tsubject)
        {
            fname = tfname;
            name = tname;
            otch = totch;
            age = tage;
            org = torg;
            subject = tsubject;
        }

        public void Print()
        {
            Console.WriteLine($"{fname} {name} {otch} {age} {org} {subject}");
        }
    }



    internal class Program
    {
        public static bool rgr = true;

        public static void Addtea(List<Teacher> BASA)
        {
            Console.Clear();

            Console.WriteLine("Введите сколько учителей хотите добавить:");
            int yet_tea = BASA.Count;
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = yet_tea; i < yet_tea + n; i++)
            {
                Teacher tea = new Teacher();
                Console.WriteLine("Введите Фамилию:");
                tea.fname = Console.ReadLine();
                Console.WriteLine("Введите Имя:");
                tea.name = Console.ReadLine();
                Console.WriteLine("Введите Отчество:");
                tea.otch = Console.ReadLine();
                Console.WriteLine("Введите дату рождения(день.месяц.год):");
                tea.age = Console.ReadLine();
                Console.WriteLine("Введите Организацию:");
                tea.org = Console.ReadLine();
                Console.WriteLine("Введите предмет");
                tea.subject = Console.ReadLine();
                BASA.Add(tea);
            }
        }
        static void Menu(List<Teacher> BASA)
        {
            Console.WriteLine();
            Console.WriteLine("\t\tМеню");
            Console.WriteLine("1.Вывод всех учителей");
            Console.WriteLine("2.Добавление учителей");
            Console.WriteLine("3.Поиск по предмету");
            Console.WriteLine("4.Поиск по стажу на последнем месте");
            Console.WriteLine("5.Общий стаж сотрудника");
            Console.WriteLine("6.Добавление трудовой книги");
            Console.WriteLine("7. Завершить работу.");
            Console.WriteLine("Введите выбранный номер: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    for (int i = 0; i < BASA.Count; i++)
                    {
                        BASA[i].Print();
                    }
                    break;
                case 2:
                    Addtea(BASA);
                    break;
                case 3:
                    Console.WriteLine("Введите название предмета:");
                    string sub = Console.ReadLine();
                    FindSub(BASA, sub);
                    break;
                case 4:
                    Console.WriteLine("Введите фамилию учителя:");
                    var staj_teacherLast = Console.ReadLine();
                    bool flag4 = true;
                    foreach (Teacher perebor_teach4 in BASA)
                    {
                        if (perebor_teach4.fname == staj_teacherLast)
                        {
                            var timeLast = StajLast(perebor_teach4);
                            int years1 = Staj(perebor_teach4) / 365;
                            int months1 = (Staj(perebor_teach4) % 365) / 30;
                            int days1 = months1 % 30;
                            Console.WriteLine("Его стаж: {0} г. {1} м. {2} д.", years1, months1, days1);
                            flag4 = false;
                        }
                    }
                    if (flag4)
                    {
                        Console.WriteLine("Такого учителя нет в базе.");
                    }

                    
                    break;
                case 5:
                    Console.WriteLine("Введите фамилию учителя:");
                    var staj_teacher = Console.ReadLine();
                    bool flag5=true;
                    foreach (Teacher perebor_teach in BASA)
                    {
                        if (perebor_teach.fname == staj_teacher)
                        {
                            var time = Staj(perebor_teach);
                            int years = time  / 365;
                            int months = (time % 365) / 30;
                            int days = months % 30;
                            Console.WriteLine("Его стаж: {0} г. {1} м. {2} д.", years,months,days);
                            flag5 =false;
                        }
                    }
                    if (flag5)
                    {
                        Console.WriteLine("Такого учителя нет в базе.");
                    }
                    
                    break;
                case 6:
                    Console.WriteLine("Введите фамилию учителя:");
                    string find_name = Console.ReadLine();
                    bool flag6 = true;
                    foreach (Teacher perebor_teach in BASA)
                    {
                        //Console.WriteLine(perebor_teach.fname, find_name);
                        if (perebor_teach.fname == find_name)
                        {
                            
                            Console.WriteLine("Введите количество организаций:");
                            int num = Convert.ToInt32(Console.ReadLine());
                            string[,] tryd = new string[num,3];
                            for(int i = 0; i < num; i++)
                            {
                                Console.WriteLine("Введите дату начала работы(ЧЧ.ММ.ГГ):");
                                tryd[i,0]=Console.ReadLine();
                                Console.WriteLine("Введите Организацию:");
                                tryd[i,1] = Console.ReadLine();
                                Console.WriteLine("Введите дату конца работы(ЧЧ.ММ.ГГ):");
                                tryd[i,2] = Console.ReadLine();
                            }
                            perebor_teach.book = tryd;
                            flag6 = false;
                        }
                    }
                    if(flag6)
                    {
                        Console.WriteLine("Такого учителя нет в базе.");
                    }       
                    break;
                case 7:
                    Console.WriteLine("Досвидание!");
                    End();
                    break;
                default:
                    Console.WriteLine("Выбранный номер не указан. ");
                    break;
            }
        }

        static int StajLast(Teacher staj_teacher)
        {

            string[,] trydLast = staj_teacher.book;
            var i = trydLast.GetUpperBound(0);
            int obhui_staj_1 = 0;

            
            string[] start_data = trydLast[i, 0].Split('.');
            string[] finis_data = trydLast[i, 2].Split('.');
            int start = Convert.ToInt32(start_data[0]) + 30 * Convert.ToInt32(start_data[1]) + 365 * Convert.ToInt32(start_data[2]);
            int finis = Convert.ToInt32(finis_data[0]) + 30 * Convert.ToInt32(finis_data[1]) + 365 * Convert.ToInt32(finis_data[2]);
            obhui_staj_1 = finis - start;
           
            return obhui_staj_1;
        }

        static int Staj(Teacher staj_teacher)
        {
            int obhui_staj = 0;
            string[,] tryd=staj_teacher.book;
            for (int i=0;i<tryd.GetLength(0);i++)
            {
                string[] start_data = tryd[i,0].Split('.');
                string[] finis_data = tryd[i, 2].Split('.');
                int start = Convert.ToInt32(start_data[0]) + 30 * Convert.ToInt32(start_data[1]) + 365*Convert.ToInt32(start_data[2]);
                int finis = Convert.ToInt32(finis_data[0]) + 30 * Convert.ToInt32(finis_data[1]) + 365*Convert.ToInt32(finis_data[2]);
                obhui_staj+= finis - start;
            }
            return obhui_staj;
        }
        static void FindSub(List<Teacher> BASA, string sub)
        {
            int k = 0;
            for (int i = 0; i < BASA.Count; i++)
            {
                if (BASA[i].subject == sub)
                {
                    BASA[i].Print();
                    k++;
                }
            }
            if (k > 0)
            {
                Console.WriteLine($"Учетелей по этому предмету: {k}");
                //return true;
            }
            else
            {
                Console.WriteLine("Учетелей по этому предмету нет.");
                //return false;
            }
        }

        static void End() { rgr = false; }
        static void Main()
        {

            List<Teacher> BASA = new List<Teacher>();
            Teacher one = new Teacher("Петров", "Иван", "Васильевич", "12.12.1977", "ВУЗ № 11", "Русский");
            Teacher two = new Teacher("Иванов", "Петр", "Олегович", "13.07.1989", "МГТУ", "Физика");
            Teacher tre = new Teacher("Сидоров", "Николай", "Петрович", "02.02.1969", "ТГУ", "История");
            Teacher fro = new Teacher("Петрин", "Иван", "Дмитревич", "17.09.1987", "МГТУ", "Физика");
            BASA.Add(one);
            BASA.Add(two);
            BASA.Add(tre);
            BASA.Add(fro);

            string[,] tryd = new string[2, 3] { { "12.03.2002", "org", "12.03.2003" }, {"22.02.2005", "shool","22.02.2010" } };
            one.book = tryd;
            while (rgr)
            {

                Menu(BASA);
            }

        }
    }
}
