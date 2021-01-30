using NUnit.Framework;
using LinearAlgebra;

namespace LinearAlgebraTests
{
    class TestLUPDecompositionTests
    {
        [Test]
        public void TestLUPDecompose()
        {
            Matrix input = new Matrix(new double[,] { { 5, 3, 3 }, { 10, 6, 3 }, { 5, 6, 3 } });
            LUPDecomposition output = new LUPDecomposition(input);
            Assert.True(output.LUMatrix.Equals(new Matrix(new double[,] { { 10, 6, 3 }, { 0, 3, 1.5 }, { 0, 0, 1.5 } })));

        }
    }
}

