using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOM
{
    public static class StringExtensions
    {
        public static string ToUpperCase(this string TextToConvert)
        {
            return TextToConvert.Trim().ToUpper();
        }


    }
}
