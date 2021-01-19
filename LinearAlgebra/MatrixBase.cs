using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public abstract class MatrixBase<T>: ILinearAlgebra<T>
    {
        private double[,] data;
        public abstract bool Equals(T other);
        public abstract double MemoryUsage();


        public void SwapRowsInPlace(int row1, int row2)
        {
            data = swapArrayRowsInPlace(data, (row1, row2));
        }

        private double[,] swapArrayRowsInPlace(double[,] inputArray, (int, int) RowsToSwap)
        {

            int numberOfColumns = inputArray.GetLength(1);
            double[] rowBuffer = new double[numberOfColumns];
            for (int i = 0; i < numberOfColumns; i++)
            {
                rowBuffer[i] = inputArray[RowsToSwap.Item1, i];
                inputArray[RowsToSwap.Item1, i] = inputArray[RowsToSwap.Item2, i];
                inputArray[RowsToSwap.Item2, i] = rowBuffer[i];
            }
            return inputArray;
        }

    }
}
