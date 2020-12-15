using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MesUI
{
    public class MesRegEx
    {
        enum MesDataType
        {
            MES_NUMBER_ONLY = 0,
            MES_STRING_ONLY = 1
        };
        public static bool IsNumber(string data)
        {
            Regex rex = new Regex(@"\d{1}?");  // d1 숫자 1자리 형식

            // Find matches.
            MatchCollection matches = rex.Matches(data);

            // Report the number of matches found.
            if (matches.Count != data.Length )
                return false; // 데이터가 형식에 맞지 않음
            else
                return true;
        }

        public static bool HasNumber(string data)
        {
            Regex rex = new Regex(@"\d{1}?");  // d1 숫자 1자리 형식

            // Find matches.
            MatchCollection matches = rex.Matches(data);

            // Report the number of matches found.
            if (matches.Count > 0)
                return true; // 데이터가 형식에 맞지 않음
            else
                return false;
        }
    }
}
