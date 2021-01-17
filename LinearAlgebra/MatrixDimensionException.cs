using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    class MatrixDimensionException: Exception
    {
        public MatrixDimensionException()
        {
        }
        public MatrixDimensionException(string message): base(message)
        {
        }
        public MatrixDimensionException(string message, Exception inner)
            : base(message, inner)
        { 
        }
    }
}
