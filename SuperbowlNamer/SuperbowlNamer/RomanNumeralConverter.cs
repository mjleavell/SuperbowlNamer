using System;
using System.Collections.Generic;
using System.Text;

namespace SuperbowlNamer
{
    public class RomanNumeralConverter
    {
        public string ToRomanNumeral(int numberToConvert)
        {
            if (numberToConvert >= 1000)
            {
                return "M" + ToRomanNumeral(numberToConvert - 1000);
            }

            if (numberToConvert >= 900)
            {
                return "CM" + ToRomanNumeral(numberToConvert - 900);
            }

            if (numberToConvert >= 500)
            {
                return "D" + ToRomanNumeral(numberToConvert - 500);
            }

            if (numberToConvert >= 400)
            {
                return "CD" + ToRomanNumeral(numberToConvert - 400);
            }

            if (numberToConvert >= 100)
            {
                return "C" + ToRomanNumeral(numberToConvert - 100);
            }

            if (numberToConvert >= 90)
            {
                return "XC" + ToRomanNumeral(numberToConvert - 90);
            }

            if (numberToConvert >= 50)
            {
                return "L" + ToRomanNumeral(numberToConvert - 50);
            }

            if (numberToConvert >= 40)
            {
                return "XL" + ToRomanNumeral(numberToConvert - 40);
            }

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
            
            return string.Empty;

        }
    }
}
