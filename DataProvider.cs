using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitCalculator
{
    public class DataProvider : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { Math.PI / 2, 1.0 };
            yield return new object[] { Math.PI / 6, 0.5 };
            yield return new object[] { 0, 0 };
        }
    }
}
