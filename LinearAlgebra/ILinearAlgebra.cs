using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    interface ILinearAlgebra<T>
    {
        bool Equals(T other);
        (int, int) Shape();
        double MemoryUsage();
    }
}
