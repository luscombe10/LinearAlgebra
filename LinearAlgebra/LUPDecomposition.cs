using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public class LUPDecomposition
    {
        public Matrix LUMatrix;
        private int[] PermutationArray;
        public LUPDecomposition(Matrix A)
        {
            double[,] luArray = new double[A.Shape.Item1, A.Shape.Item2];
            double[] swapArray = new double[A.Shape.Item2]; 
            int[] permutationArray = new int[A.Shape.Item1];
            for (int i = 1; i < A.Shape.Item1; i++)
            {
                
            }
            LUMatrix = new Matrix(luArray);
            PermutationArray = permutationArray;
        }
    }
}
