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
    }
}