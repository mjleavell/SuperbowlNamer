using System;
using Xunit;

namespace SuperbowlNamer.Tests
{
    public class convert_number_to_roman_numeral
    {
        [Fact]
        public void convert_number_less_than_4_to_roman_numeral()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 1;
            var expectedResult = "I";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_5_to_v()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 5;
            var expectedResult = "V";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_9_to_ix()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 9;
            var expectedResult = "IX";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_12_to_xii()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 12;
            var expectedResult = "XII";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_16_to_xvi()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 16;
            var expectedResult = "XVI";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_29_to_xxix()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 29;
            var expectedResult = "XXIX";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_44_to_xliv()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 44;
            var expectedResult = "XLIV";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_45_to_xlv()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 45;
            var expectedResult = "XLV";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_68_to_lxviii()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 68;
            var expectedResult = "LXVIII";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_83_to_lxxxiii()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 83;
            var expectedResult = "LXXXIII";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_97_to_xcvii()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 97;
            var expectedResult = "XCVII";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_99_to_xcix()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 99;
            var expectedResult = "XCIX";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_498_to_cdxcviii()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 498;
            var expectedResult = "CDXCVIII";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_500_to_d()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 500;
            var expectedResult = "D";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_501_to_di()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 501;
            var expectedResult = "DI";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_649_to_dcxlix()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 649;
            var expectedResult = "DCXLIX";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_798_to_dccxcviii()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 798;
            var expectedResult = "DCCXCVIII";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_891_to_dcccxci()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 891;
            var expectedResult = "DCCCXCI";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void convert_999_to_dcccxci()
        {
            // Arrange
            var converter = new RomanNumeralConverter();
            var input = 999;
            var expectedResult = "CMXCIX";

            // Act
            var actualResult = converter.ToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        //[Fact]
        //public void convert_1000_to_M()
        //{
        //    // Arrange
        //    var converter = new RomanNumeralConverter();
        //    var input = 1000;
        //    var expectedResult = "M";

        //    // Act
        //    var actualResult = converter.ToRomanNumeral(input);

        //    // Assert
        //    Assert.Equal(expectedResult, actualResult);
        //}
    }
}
