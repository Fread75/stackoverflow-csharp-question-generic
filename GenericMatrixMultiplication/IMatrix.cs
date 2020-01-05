using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrixMultiplication
{
    internal interface IMatrix
    {
        double this[int i, int j] { get; set; }
        int Size { get; }
    }
}
