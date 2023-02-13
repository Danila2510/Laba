using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Rabotnik
    {
        private string Polnoe_imya { get; set; }
        private string DenRojdenie { get; set; }
        private string Nomer { get; set; }
        private string Description { get; set; }
        private string Tip { get; set; }
        private int Zarplata { get; set; }

        private static string Email;

        public Rabotnik() { }
        public Rabotnik(string polnoeimya, string den_rojdenie, string nomer, string description, string tip, int zarplata)
        {
            Polnoe_imya = polnoeimya;
            DenRojdenie = den_rojdenie;
            Nomer = nomer;
            Description = description;
            Tip = tip;
            Zarplata = zarplata;
        }
        static Rabotnik()
        {
            Console.WriteLine("Enter you email adress. ");
            Email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($" ФИО {Polnoe_imya}\n День Рождение {DenRojdenie}\n Номер {Nomer}\n Эмеил  {Email}\n Описание {Description}\n Тип {Tip}\n Зарплата  {Zarplata}$");
        }
        public override string ToString()
        {
            return $" ФИО {Polnoe_imya}\n День Рождение  {DenRojdenie}\n Номер {Nomer}\n Эмеил {Email}\n Описание {Description}\n Тип {Tip}\n Зарплата {Zarplata}$";
        }

        public static Rabotnik operator +(Rabotnik a, int b)
        {
            a.Zarplata += b;
            return a;
        }
        public static Rabotnik operator -(Rabotnik a, int b)
        {
            a.Zarplata -= b;
            return a;
        }
        public static bool operator ==(Rabotnik a, Rabotnik b)
        {
            if (a.Zarplata == b.Zarplata)
                return true;
            else
                return false;
        }
        public static bool operator !=(Rabotnik a, Rabotnik b) => !(a == b);

        public static bool operator >(Rabotnik a, Rabotnik b)
        {
            if (a.Zarplata > b.Zarplata)
                return true;
            else
                return false;
        }
        public static bool operator <(Rabotnik a, Rabotnik b) => !(a.Zarplata > b.Zarplata);

    }
}

