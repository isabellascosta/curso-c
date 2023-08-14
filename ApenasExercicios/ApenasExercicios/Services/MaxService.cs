using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApenasExercicios.Services
{
    internal class MaxService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            T max = list[0];
            for (int i =1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) == 1)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
