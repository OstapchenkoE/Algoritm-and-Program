using System;
class HelloWorld
{
 public static void PrintValues (Array ar)
 {
    System.Collections.IEnumerator Ear = ar.GetEnumerator ();
    int i = 0;
    int cols = ar.GetLength (ar.Rank - 1);
    Console.WriteLine("\nМассив:");
    while (Ear.MoveNext ())
    {
        if (i < cols) i++;
        else
        {
            Console.WriteLine ();
            i = 1;
        }
        Console.Write ($"\t{Ear.Current}");
    }
    Console.WriteLine ();
   
 }
 public static void Lght(Array ar)
 {
    Console.WriteLine("\nКоличество элемнтов в Array: {0}",ar.Length);
    
 }
 //public static void 
 
 public static void Menu(Array ar)
 {
    bool ex=true;
    Console.WriteLine();
    Console.WriteLine("\t\tМеню");
    Console.WriteLine("1. Печатать Array ");
    Console.WriteLine("2. Метод Lenght ");
    Console.WriteLine("3. Метод Clear ");
    Console.WriteLine("4. Метод Rank ");
    Console.WriteLine("5. Метод Reverse");
    Console.WriteLine("6. Заполнение");
    Console.WriteLine("7. Поиск по элементу");
    Console.WriteLine("8. Поиск по индексу");
    Console.WriteLine("9. Метод Sort");
    Console.WriteLine("10. Завершить работу.");
    Console.WriteLine("Введите выбранный номер: ");
    int n=Convert.ToInt32(Console.ReadLine());
    switch (n)
    {
        case 1:
            PrintValues(ar);
            break;
        case 2:
            Lght(ar);
            break;
        case 3:
            Array.Clear(ar,0,ar.Length);
            PrintValues(ar);
            
            break;
        case 4:
            Console.WriteLine("\nRank="+ar.Rank);
            
            break;
        case 5:
            Array.Reverse(ar);
            PrintValues(ar);
            
            break;
        case 6:
            Stand(ar);
            PrintValues(ar);
              
            break;
        case 7:
            Console.WriteLine("Введите элемент массива");
            int t=Convert.ToInt32(Console.ReadLine());
            int ind_t=Array.IndexOf(ar,t);
            Console.WriteLine("Элемент имеет индекс "+ind_t);
            break;
        case 8:
            Console.WriteLine("Введите индекс элемента ");
            int ind=Convert.ToInt32(Console.ReadLine());
            var val=ar.GetValue(ind);
            Console.WriteLine("Элемент "+val);
           
            break;
        case 9:
            Array.Sort(ar);
            PrintValues(ar);
            
            break;


        case 10:
            Console.WriteLine("Досвидание.");
            ex=false;
            break;
        default:
            Console.WriteLine("\nВыбранный номер не указан. ");
            break;
    }
    if(ex) Menu(ar);
    
 }


 public static void Stand(Array ar)
 {
    
    
        for(int j=ar.GetLowerBound(0);j<=ar.GetUpperBound(0);j++)
        {
            //Console.WriteLine(i+" "+j);
            ar.SetValue(1+j,j);
        }
 }
 
  static void Main ()
  {
    Console.WriteLine("Введите размер массива");
    int n=Convert.ToInt32(Console.ReadLine());
    Array ar=Array.CreateInstance(typeof(int),n);
    
    for(int i=ar.GetLowerBound(0);i<=ar.GetUpperBound(0);i++)    ar.SetValue(i+1,i);
    
    Menu(ar);
    
  }
}
