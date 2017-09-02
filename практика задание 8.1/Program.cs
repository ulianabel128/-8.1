using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_задание_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = -1;
            bool ok = false;

            do
            {
                Console.WriteLine("Введите размер матрицы смежности");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out r);
                if (r < 1) ok = false;
                if (!ok) Console.WriteLine("Неверный ввод");
            }
            while (!ok);

            ok = false;

            int[,] matrix = new int[r, r];
            
            for (int i=0; i<matrix.GetLength(0); i++)
                for (int j= 0; j < matrix.GetLength(0); j++)
                {
                    do
                    {
                        Console.WriteLine("Введите элемент матрицы " + (i + 1) + " " + (j + 1));
                        string user = Console.ReadLine();
                        ok = int.TryParse(user, out matrix[i,j]);
                        if ((matrix[i, j]<0) || (matrix[i,j]>1)) ok = false;
                        if ((i == j) && (r == 1)) ok = false;
                        if (!ok) Console.WriteLine("Неверный ввод");
                    }
                    while (!ok);

                    ok = false;
                }
        }
    }
}
