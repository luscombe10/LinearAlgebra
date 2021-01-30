using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public class LUPDecomposition : MatrixBase<LUPDecomposition>
    {
        private Matrix luMatrix;
        private int[] PermutationArray;
        public LUPDecomposition(Matrix A)
        {
            int shape = A.Shape.Item1;
            double[,] luArray = new double[shape, shape];
            double[] swapArray = new double[shape];
            int[] permutationArray = new int[shape];
            luMatrix = new Matrix(luArray);
            PermutationArray = permutationArray;
        }

        public override double MemoryUsage()
        {
            return ((double)PermutationArray.Length * 32) + luMatrix.MemoryUsage();
        }

        public Matrix LUMatrix
        {
            get => luMatrix;
        }

        public override bool Equals(LUPDecomposition other)
        {
            return false;
        }
    }
}

