using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class StringExtensions
    {
        // neste caso, como é uma extensão que precisa receber uma entrada int, devemos não apenas receber o próprio objeto this, 
        // quanto também receber este inteiro.
        public static string Cut(this string thisObj, int count)
        {
            if(thisObj.Length <= count)
            {
                return thisObj;
            }
            return thisObj.Substring(0,count)+"...";

        }

    }
}
