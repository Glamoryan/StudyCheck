using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudyCheck.Utilities
{
    public class Utility
    {
        public readonly static Regex regex = new Regex("^[a-zA-Z0-9]*$");//harfler ve rakamlar
        public readonly static Regex regexOnlyLetters = new Regex("^[a-zA-Z]*$");//harfler
        public readonly static Regex regexOnlyNumbers = new Regex("^[0-9]*$");//sayılar
        public readonly static Regex regexAll = new Regex("^[a-zA-Z0-9_]*$");//harfler , rakamlar ve altçizgi
    }
}
