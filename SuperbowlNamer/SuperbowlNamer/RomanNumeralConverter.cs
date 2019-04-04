using System;
using System.Collections.Generic;
using System.Text;

namespace SuperbowlNamer
{
    public class RomanNumeralConverter
    {
        public string ToRomanNumeral(int numberToConvert)
        {
            //var romanNumeral = "";

            if (numberToConvert >= 10)
            {
                return "X" + ToRomanNumeral(numberToConvert - 10);
            }

            if (numberToConvert >= 9)
            {
                return "IX" + ToRomanNumeral(numberToConvert - 9);
            }

            if (numberToConvert >= 5)
            {
                return "V" + ToRomanNumeral(numberToConvert - 5);
            }

            if (numberToConvert >= 4)
            {
                return "IV" + ToRomanNumeral(numberToConvert - 4);
            }

            if (numberToConvert >= 1)
            {
                return "I" + ToRomanNumeral(numberToConvert - 1);
            }

            //return romanNumeral;
        }
    }
}
