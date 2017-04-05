using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrix10
{
    class Program
    {
        static void SetRandom(MyLibrary.Matrix<int> m)
        {
            Random random = new Random();
            for (int i = 0; i < m.Height; i++)
            {
                for (int j = 0; j < m.Width; j++)
                {
                    m[i, j] = random.Next(10) + 1;
                    m[i, j] = random.Next(10) + 1;
                }
            }
        }

        delegate void MatrixSetter(MyLibrary.Matrix<int> n);

        static void Main(string[] args)
        {
            MatrixSetter randomSetter = new MatrixSetter(SetRandom);

            Console.WriteLine("Enter height matrix");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter wight matrix");
            int w = int.Parse(Console.ReadLine());

            MyLibrary.Matrix<int> a = new MyLibrary.Matrix<int>(w, h);
            MyLibrary.Matrix<int> b = new MyLibrary.Matrix<int>(w, h);
            randomSetter(a);
            randomSetter(b);

            Console.WriteLine("Matrix a");
            a.Print();
            Console.WriteLine("Matrix b");
            b.Print();

            MyLibrary.Matrix<int> s = a + b;
            Console.WriteLine("Matrix a+b");
            s.Print();
            Console.ReadKey();
            



            /*
            Matrix<int> a = Matrix<int>.FromArray(new int[,] { { 4, 8, 5 }, { 2, 1, 3 }, { 7, 4, 6 } });
            Matrix<int> b = Matrix<int>.FromArray(new int[,] { { 2, 4, 5 }, { 1, 1, 3 }, { 7, 2, 3 } });
            Matrix<int> s = a + b;
            Matrix<int> v = a - b;
            Matrix<int> u = a * b; 
            Matrix<int> d = a / b;
 
            
            Random random = new Random();
            Matrix<int> matrix1 = Matrix<int>.FromArray(new int[h, w]);
            Console.WriteLine("Matrix1:");
            /*for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    matrix1[i, j] = random.Next(10);
                    Console.Write("{0,5}", matrix1[i, j]);
                }
                Console.WriteLine();
            }*/
            

        }
    }
}
