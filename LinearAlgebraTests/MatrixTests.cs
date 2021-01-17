using NUnit.Framework;
using LinearAlgebra;

namespace LinearAlgebraTests
{
    public class MatrixTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // build some test helper functions to make matrices
        [Test]
        public void TestEquals()
        {
            // Explicitly identical
            Matrix x = new Matrix(new double[3, 3] { { 1, 1, 1 }, { 0, 0, 0 }, { 2, 2, 2 } });
            Matrix y = new Matrix(new double[3, 3] { { 1, 1, 1 }, { 0, 0, 0 }, { 2, 2, 2 } });
            Assert.IsTrue(x.Equals(y));
            // one element different
            y = new Matrix(new double[3, 3] { { 2, 1, 1 }, { 0, 0, 0 }, { 2, 2, 2 } });
            Assert.IsFalse(x.Equals(y));
            // different shape
            y = new Matrix(new double[2, 2] { { 1, 0 }, { 0, 1 } });
            Assert.IsFalse(x.Equals(y));
        }

        [Test]
        public void TestMultiply()
        { 
            Matrix x = new Matrix(
                new double[2, 3]{ 
                    { 10,10,10},
                    { 10,10,10} 
                });
            Matrix y = new Matrix(
                new double[3, 2]{
                    {1,2},
                    {1,3},
                    {2,2}
                });
            Matrix result = x.Multiply(y);
            Assert.IsTrue(result.Equals(new Matrix(new double[2, 2] { { 40, 70 }, { 40, 70 } })));
            // try with Identity
            result = x.Multiply(new Matrix(new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } }));

            Assert.IsTrue(x.Equals(result));
        }

        [Test]
        public void TestAdd()
        {
            Matrix x = new Matrix(new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } });
            Matrix y = new Matrix(new double[3, 3] { { 0, 2, 0 }, { 1, 0, 0 }, { 0, 0, 6 } });
            Matrix result = x.Add(y);
            Assert.IsTrue(result.Equals(new Matrix(new double[3, 3] { { 1, 2, 0 }, { 1, 1, 0 }, { 0, 0, 7 } })));

        }

        [Test]
        public void TestSubtract()
        {
            Matrix x = new Matrix(new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } });
            Matrix y = new Matrix(new double[3, 3] { { 0, 2, 0 }, { 1, 0, 0 }, { 0, 0, 6 } });
            Matrix result = x.Subtract(y);
            Assert.IsTrue(result.Equals(new Matrix(new double[3, 3] { { 1, -2, 0 }, { -1, 1, 0 }, { 0, 0, -5 } })));
        }

        [Test]
        public void TestTranspose()
        {
            Matrix x = new Matrix(new double[3, 2] { { 1, 2 }, { 0, 1 }, { 1, 0 } });
            Assert.IsTrue(x.Transpose().Equals(new Matrix(new double[2, 3] { { 1, 0, 1 }, { 2, 1, 0 } })));
        }
    }
}