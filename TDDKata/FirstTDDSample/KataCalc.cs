namespace FirstTDDSample
{
    public class KataCalc
    {
        public int Add(string numbers)
        {
            if (numbers == string.Empty)
            {
                return 0;
            }

            var splitedStringNumbers = numbers.Split(',');
            var numberList = new List<int>();
            foreach (var stringNumber in splitedStringNumbers)
            {
                var number = -1;
                if (!Int32.TryParse(stringNumber, out number))
                {
                    return -1;
                }
                numberList.Add(number);
            }

            return numberList.Sum(x => x);
        }

        //public int Add(string numbers)
        //{
        //    if (numbers == string.Empty)
        //    {
        //        return 0;
        //    }

        //    if (!numbers.Contains(","))
        //    {
        //        var number = -1;
        //        if (!Int32.TryParse(numbers, out number))
        //        {
        //            return -1;
        //        }

        //        return number;
        //    }
        //    else
        //    {
        //        var splitedNumbers = numbers.Split(',');

        //        var firstNumber = -1;
        //        if (!Int32.TryParse(splitedNumbers.First(), out firstNumber))
        //        {
        //            return -1;
        //        }

        //        var secondNumber = -1;
        //        if (!Int32.TryParse(splitedNumbers.Last(), out secondNumber))
        //        {
        //            return -1;
        //        }

        //        return firstNumber + secondNumber;
        //    }
        //}
    }
}