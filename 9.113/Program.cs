using System;
using System.Text;

namespace _9._113
{
    class Program
    {
        static string Metod (string Name)
        {
            Console.WriteLine($"Введите {Name}:");
            string a = "";
            while (a.Length < 1)     
                a = Console.ReadLine();
            return a;
        }
        static void Main(string[] args)
        {
            StringBuilder b = new StringBuilder(Metod("предложение"));
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == 'с')
                {
                    b = b.Remove(i, 1);
                    b = b.Append('_');
                }
            }
            Console.WriteLine(b);
       
        }
    }
}
