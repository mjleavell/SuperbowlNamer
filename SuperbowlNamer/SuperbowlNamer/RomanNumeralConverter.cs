﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperbowlNamer
{
    public class RomanNumeralConverter
    {
        public string ToRomanNumeral(int numberToConvert)
        {
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
