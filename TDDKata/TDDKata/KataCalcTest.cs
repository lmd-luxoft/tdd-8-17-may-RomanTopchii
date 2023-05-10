using FirstTDDSample;

namespace TDDKata
{
    public class KataCalcTest
    {
        [Fact]
        public void EmptyString()
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
        public void AddSingleNumber()
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
        public void AddTwoNumbers()
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
        public void AddLetterReturnMinusOne()
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
        public void AddNumberAndLetterReturnMinusOne()
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
        public void AddLeterAndNumberReturnMinusOne()
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
        public void AddNumbersSplitedWithNewLine()
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
        public void AddNumbersSplitedWithNewLineAndComma()
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
        public void AddNumbersSplitedWithNewLineAndCommaReturnMinusOne()
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
    }
}


/*
Create a simple String calculator with a method int Add(string numbers)
The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1, 2”

Start with the simplest test case of an empty string and move to 1 and 2 numbers
Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
Remember to refactor after each passing test
*/

/*
Allow the Add method to handle new lines between numbers(instead of commas)
the following input is ok:  “1\n2,3”  (will equal 6)
the following input is NOT ok:  “1,\n”
*/