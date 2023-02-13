using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Gorod
    {
        private string Imya;
        private string Strana;
        private int podchet;
        private string Keye;
        private string Rajon;

        public Gorod() { }
        public Gorod(string ine, string st, int po, string key, string ra)
        {
            Imya = ine;
            Strana = st;
            podchet = po;
            Keye = key;
            Rajon = ra;
        }
        public string imya { get { return Imya; } set { Imya = value; } }
        public string strana { get { return Strana; } set { Strana = value; } }
        public int Podchet { get { return podchet; } set { podchet = value; } }
        public string keye { get { return keye; } set { keye = value; } }
        public string rajon { get { return Rajon; } set { Rajon = value; } }

        public void Print()
        {
            Console.WriteLine($" ФИО  {Imya} \n Номер карты  {Strana} \n Дата  {podchet} \n CVV  {keye} \n Деньги {Rajon}");
        }
        public override string ToString()
        {
            return $" ФИО  {Imya} \n Номер карты  {Strana} \n Дата  {podchet} \n CVV  {keye} \n Деньги {Rajon}";
        }
        public static Gorod operator +(Gorod a, int b)
        {
            a.podchet += b;
            return a;
        }
        public static Gorod operator -(Gorod a, int b)
        {
            b *= -1;
            return a + b;
        }
        public static bool operator ==(Gorod a, int b)
        {
            if (a.podchet == b)
                return true;
            else
                return false;
        }
        public static bool operator !=(Gorod a, int b) => !(a == b);
        public static bool operator >(Gorod a, int b)
        {
            if (a.podchet > b)
                return true;
            else
                return false;
        }
        public static bool operator <(Gorod a, int b) => !(a > b);
    }
}
