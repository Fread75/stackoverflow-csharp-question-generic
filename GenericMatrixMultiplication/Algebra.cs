using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrixMultiplication
{
    internal static class Algebra
    {
        internal static void Multiply<TMatrix>(TMatrix a, TMatrix b, TMatrix result) where TMatrix : IMatrix
        {
            for (int i = 0; i < a.Size; i++)
            {
                for (int j = 0; j < a.Size; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < a.Size; k++)
                    {
                        temp += a[i, k] * b[k, j];
                    }
                    result[i, j] = temp;
                }
            }
        }

        internal static void Multiply(Matrix a, Matrix b, Matrix result)
        {
            for (int i = 0; i < a.Size; i++)
            {
                for (int j = 0; j < a.Size; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < a.Size; k++)
                    {
                        temp += a[i, k] * b[k, j];
                    }
                    result[i, j] = temp;
                }
            }
        }
    }
}
