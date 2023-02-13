using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Matriza
    {
        private static int rady;
        private static int stolb;
        private int[,] mat = new int[rady, stolb];
        private int Min { get; set; } = 0;
        private int Max { get; set; } = 0;
        public Matriza()
        {
            Random random = new Random();
            for (int i = 0; i < rady; i++)
                for (int j = 0; j < stolb; j++)
                    mat[i, j] = random.Next(1, 20);
            for (int i = 0; i < rady; i++)
                for (int j = 0; j < stolb; j++)
                {
                    if (Min > mat[i, j])
                        Min = mat[i, j];
                    if (Max < mat[i, j])
                        Max = mat[i, j];
                }
        }

        static Matriza()
        {
            Console.WriteLine("Enter number of lines");
            rady = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            stolb = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < rady; i++)
            {
                for (int j = 0; j < stolb; j++)
                    Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            Print();
            return "";
        }

        public static Matriza operator +(Matriza a, int b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] += b;
            return a;
        }
        public static Matriza operator -(Matriza a, int b)
        {
            int buf = b * -1;
            return a + buf;
        }
        public static Matriza operator +(Matriza a, Matriza b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] += b.mat[i, j];
            return a;
        }
        public static Matriza operator -(Matriza a, Matriza b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] -= b.mat[i, j];
            return a;
        }
        public static Matriza operator *(Matriza a, int b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] *= b;
            return a;
        }
        public static Matriza operator *(Matriza a, Matriza b)
        {
            Matriza buf = new Matriza();
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    for (int k = 0; k < a.mat.GetLength(0); k++)
                        buf.mat[i, j] += a.mat[i, k] * b.mat[k, j];
            return buf;
        }
        public static bool operator ==(Matriza a, Matriza b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                {
                    if (a.mat[i, j] != b.mat[i, j])
                        return false;
                }
            return true;
        }
        public static bool operator !=(Matriza a, Matriza b)
        {   
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                {
                    if (a.mat[i, j] == b.mat[i, j])
                        return false;
                }
            return true;
        }

        public int this[int r, int c]
        {
            get
            {
                if (r >= mat.GetLength(0) || r < 0 || c >= mat.GetLength(1) || c < 0)
                    throw new Exception("Erorr");
                else
                    return mat[r, c];
            }
            set
            {
                if (r >= mat.GetLength(0) || r < 0 || c >= mat.GetLength(1) || c < 0)
                    throw new Exception("Erorr");
                else
                    mat[r, c] = value;
            }
        }

    }
}
