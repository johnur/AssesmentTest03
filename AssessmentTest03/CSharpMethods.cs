using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTest03
{
    public class CSharpMethods
    {
        public static int SumEdges(int[] arr, bool add10000)
        {
            var eka = arr.First();
            var vika = arr.Last();
            int tonni = 10000;

            if (add10000)
            {
                return eka + vika + tonni;
            }
           
            return eka + vika;
        }
    }
}
