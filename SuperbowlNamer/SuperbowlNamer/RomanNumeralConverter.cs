using System;
using System.Collections.Generic;
using System.Text;

namespace SuperbowlNamer
{
    public class RomanNumeralConverter
    {
        public string ToRomanNumeral(int numberToConvert)
        {
            var romanNumeral = "";

            if (numberToConvert >= 4)
            {
                romanNumeral = "IV" + ToRomanNumeral(numberToConvert - 4);
            }

            if (numberToConvert >= 5)
            {
                romanNumeral = "V" + ToRomanNumeral(numberToConvert - 5);
            }

            if (numberToConvert < 4)
            {

                for (int i = 0; i < numberToConvert; i++)
                {
                    romanNumeral += "I";
                }

            }

            return romanNumeral;

        }
    }
}
