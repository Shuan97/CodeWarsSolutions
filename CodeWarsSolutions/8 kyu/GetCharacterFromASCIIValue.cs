using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._8_kyu
{
    static class GetCharacterFromASCIIValue
    {
        public static char GetChar(int charcode) => Convert.ToChar(charcode);


        //simpler solution
        public static char GetChar2(int c) => (char)c;
    }
}
