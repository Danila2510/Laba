using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee("Nikita", "10.02.2004", "+380631140207", "CEO", "Main Proger", 2300);
            //Employee employee2 = new Employee("Dima", "22.07.2004", "+380955053116", "CO-CEO", "Proger", 2000);
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee1 == employee2);
            //Console.WriteLine("\n\n");
            Matriza matriza1 = new Matriza();
            Console.WriteLine(matriza1 + "\n\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    try
                    {
                        matriza1[i, j] = i + j;
                        Console.Write(matriza1[i, j] + "\t");
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
                Console.WriteLine("\n");

            }
        }
    }
}

