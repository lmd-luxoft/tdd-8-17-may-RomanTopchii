using FirstTDDSample;

namespace TDDKata
{
    public class KataCalcTest
    {
        [Fact]
        public void When_AddEmptyString_Expect_Zero()
        {
            // Arrange
            string numbers = string.Empty;
            var expected = 0;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddSingleNumber_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "1";
            var expected = 1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersSplitedWithComma_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "1,2";
            var expected = 3;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddSingleLetter_Expect_MinusOne()
        {
            // Arrange
            string numbers = "w";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumberAndLetterSplitedWithComma_Expect_MinusOne()
        {
            // Arrange
            string numbers = "1,w";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddLetterAndNumberSplitedWithComma_Expect_MinusOne()
        {
            // Arrange
            string numbers = "q,1";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersSplitedWithNewLine_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "1\n1";
            var expected = 2;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersSplitedWithCommaAndNewLine_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "1\n2,3";
            var expected = 6;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumberAndLetterWithoutSpecifiedDelimeter_Expect_MinusOne()
        {
            // Arrange
            string numbers = "2,\n";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersWithSpecifiedDelimeterSemicolon_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "//;\n1;2";
            var expected = 3;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersAndLetterWithSpecifiedDelimeterSemicolon_Expect_MinusOne()
        {
            // Arrange
            string numbers = "//;\n1;A";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddLetterWithSpecifiedDelimeterSemicolon_Expect_MinusOne()
        {
            // Arrange
            string numbers = "//;\nA";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersAndLetterWithSpecifiedDelimeterAsteriskDollarPersent_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "//[*$%]\n1*$%2*$%3";
            var expected = 6;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersAndLetterWithSpecifiedDelimeterAsteriskDollarPersent_Expect_MinusOne()
        {
            // Arrange
            string numbers = "//[*$%]\n1*$%A";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddLetterWithSpecifiedDelimeterMultipleAsterisks_Expect_MinusOne()
        {
            // Arrange
            string numbers = "//[***]\nA";
            var expected = -1;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersWithSpecifiedDelimeterMultipleSquareBrackets_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "//[]]]]\n1]]]2]]]3";
            var expected = 6;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersWithSpecifiedDelimeterNewLines_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "//[\n\n\n]\n1\n\n\n2\n\n\n3";
            var expected = 6;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNumbersWithSpecifiedDelimeterSquareBracketAndNewLine_Expect_CorrectCalc()
        {
            // Arrange
            string numbers = "//[]\n]\n1]\n2]\n3";
            var expected = 6;

            var kataCalc = new KataCalc();

            // Act
            var actual = kataCalc.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}


/*
Create a simple String calculator with a method�int Add(string numbers)
The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example��� or �1� or �1, 2�

Start with the simplest test case of an empty string and move to 1 and 2 numbers
Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
Remember to refactor after each passing test
*/

/*
Allow the Add method to handle new lines between numbers(instead of commas)
the following input is ok:� �1\n2,3�� (will equal 6)
the following input is NOT�ok:� �1,\n�
*/

/*Support different delimiters
to change a delimiter, the beginning of the string will contain a separate line that looks like this:�� �//[delimiter]\n[numbers�]� for example �//;\n1;2� should return three where the default delimiter is �;��
the first line is optional � all existing scenarios should still be supported
*/

/*Delimiters can be of any length with the following format:� �//[delimiter]\n� for example: �//[***]\n1***2***3��
should return 6
*/