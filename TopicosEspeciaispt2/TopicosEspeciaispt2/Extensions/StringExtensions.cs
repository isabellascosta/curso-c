using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisobj,int count)
        {
            if(thisobj.Length <= count)
            {
                return thisobj;
            }
            else
            {
                return thisobj.Substring(0, count)+"...";
            }
        }
    }
}
