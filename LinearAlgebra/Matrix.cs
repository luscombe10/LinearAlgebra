using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public class Matrix: ILinearAlgebra<Matrix>
    {
        private double[,] data;
        private int rows;
        private int columns;

        public Matrix(double[,] dataArray)
        {
            data = dataArray;
            rows = dataArray.GetLength(0);
            columns = dataArray.GetLength(1);
        }
        public double this[int iIndex, int jIndex]
        {
            get => data[iIndex, jIndex];
            set => data[iIndex, jIndex] = value;
        }
        public double[,] Data
        {
            get => data;
        }

        public (int, int) Shape()
        {
            return (rows, columns);
        }

        public double MemoryUsage()
        {
            return (rows * columns * 64) / 8.0;
        }

        public Matrix Copy()
        {
            double[,] newData = new double[rows,columns];
            for (int i=0; i<rows; i++)
            {
                for (int j=0; j<columns; j++)
                {
                    newData[i, j] = data[i, j];
                }
            }
            return new Matrix(newData);
        }


        public bool Equals(Matrix other)
        {
            if (rows == other.rows && columns==other.columns)
            {
                for (int i=0; i<rows; i++)
                {
                    for (int j=0; j<rows; j++)
                    {
                        if (this[i,j] != other[i,j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public Matrix Multiply(Matrix other)
        {
            if (columns == other.rows)
            {
                Matrix outputMatrix = new Matrix(new double[rows, other.columns]);
                for (int i=0; i<rows; i++)
                {
                    for (int j=0; j<other.columns; j++)
                    {
                        outputMatrix[i, j] = 0;
                        for (int k=0; k<columns; k++)
                        {
                            outputMatrix[i, j] += data[i, k] * other[k, j];
                        }
                    }
                }
                return outputMatrix;
            }
            else
            {
                throw new MatrixDimensionException(
                    $"Matrix Dimension missmatch, left is {rows}x{columns}, right is {other.rows}x{other.columns}"
                    );
            }
        }
    }
}
