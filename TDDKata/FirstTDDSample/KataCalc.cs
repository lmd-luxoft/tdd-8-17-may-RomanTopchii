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

            var splitedStringNumbers = numbers.Split(new string[2] {"\n", ","}, StringSplitOptions.None);
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
    }
}