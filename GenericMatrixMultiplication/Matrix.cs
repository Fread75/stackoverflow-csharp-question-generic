using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrixMultiplication
{
    public sealed class Matrix : IMatrix
    {
        public readonly double[] array;
        private readonly int size;

        public int Size => size;

        public double this[int i, int j]
        {
            get => array[i * size + j];
            set => array[i * size + j] = value;
        }

        public Matrix(int size) : this(new double[size * size], size) { }

        public Matrix(double[] array, int size)
        {
            this.array = array;
            this.size = size;
        }

        public static Matrix CreateRandomMatrix(Random random, int size)
        {
            var maxValue = Math.Min(500, Math.Sqrt(double.MaxValue / size));

            var array = new double[size * size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * maxValue;
            }
            return new Matrix(array, size);
        }
    }
}
