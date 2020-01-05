using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrixMultiplication
{
    [DisassemblyDiagnoser(printIL: true, recursiveDepth: 3)]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 5, warmupCount: 0, targetCount: 10)]
    public class TestDevirtualization
    {

        private const int MATRIX_SIZE = 400;
        private readonly Random random = new Random(0);
        private readonly IMatrix matrixA;
        private readonly IMatrix matrixB;
        private readonly IMatrix matrixRes;

        public TestDevirtualization()
        {
            matrixA = Matrix.CreateRandomMatrix(random, MATRIX_SIZE);
            matrixB = Matrix.CreateRandomMatrix(random, MATRIX_SIZE);
            matrixRes = new Matrix(MATRIX_SIZE);
        }

        [Benchmark, System.STAThread]
        public void TestWithGeneric() => Algebra.Multiply<Matrix>((Matrix)matrixA, (Matrix)matrixB, (Matrix)matrixRes);

        [Benchmark, System.STAThread]
        public void TestWithReal() => Algebra.Multiply((Matrix)matrixA, (Matrix)matrixB, (Matrix)matrixRes);
    }
}
