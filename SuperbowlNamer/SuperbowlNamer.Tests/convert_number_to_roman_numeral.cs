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
            var input = 3;
            var expectedResult = "III";
            // Act
            var actualResult = converter.ConvertToRomanNumeral(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
