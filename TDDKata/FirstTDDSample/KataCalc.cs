using System.Text.RegularExpressions;

namespace FirstTDDSample
{
    public class KataCalc
    {
        public int Add(string numbers)
        {
            var separators = new string[2] { "\n", "," };
            var a = numbers.Count();
            if (numbers.Length > 4 && numbers.StartsWith("//") && numbers[3].ToString() == "\n")
            {
                separators = new string[1] { numbers[2].ToString() };
                numbers = numbers.Substring(4, numbers.Length - 4);
            }

            if (numbers == string.Empty)
            {
                return 0;
            }

            var splitedStringNumbers = numbers.Split(separators, StringSplitOptions.None);
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