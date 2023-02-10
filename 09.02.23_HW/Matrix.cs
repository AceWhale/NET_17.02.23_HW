using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._02._23_HW
{
    class Matrix
    {
        private static int rows;
        private static int cols;
        private int[,] mat = new int[rows, cols];
        private int Min { get; set; } = 0;
        private int Max { get; set; } = 0;
        public Matrix()
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    mat[i, j] = random.Next(1, 20);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    if (Min > mat[i, j])
                        Min = mat[i, j];
                    if (Max < mat[i, j])
                        Max = mat[i, j];
                }
        }

        static Matrix()
        {
            Console.WriteLine("Введите кол-во строк: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов: ");
            cols = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            Print();
            return "";
        }

        public static Matrix operator+(Matrix a, int b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] += b;
            return a;
        }
        public static Matrix operator-(Matrix a, int b)
        {
            int buf = b * -1;
            return a + buf;
        }
        public static Matrix operator+(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] += b.mat[i,j];
            return a;
        }
        public static Matrix operator-(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] -= b.mat[i, j];
            return a;
        }
        public static Matrix operator*(Matrix a, int b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    a.mat[i, j] *= b;
            return a;
        }
        public static Matrix operator*(Matrix a, Matrix b)
        {
            Matrix buf = new Matrix();
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                    for (int k = 0; k < a.mat.GetLength(0); k++)
                        buf.mat[i, j] += a.mat[i, k] * b.mat[k, j];
            return buf;
        }
        public static bool operator==(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.mat.GetLength(0); i++)
                for (int j = 0; j < a.mat.GetLength(1); j++)
                {
                    if (a.mat[i,j] != b.mat[i,j])
                        return false;
                }
            return true;
        }
        public static bool operator!=(Matrix a, Matrix b)
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
                    throw new Exception("Некорректный индекс");
                else
                    return mat[r, c];
            }
            set
            {
                if (r >= mat.GetLength(0) || r < 0 || c >= mat.GetLength(1) || c < 0)
                    throw new Exception("Некорректный индекс");
                else
                    mat[r, c] = value;
            }
        }

    }
}
