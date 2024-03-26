namespace RomanDigitToArabic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Roman numeral: ");
            string romanNumeral = Console.ReadLine().ToUpper();
            int arabicNumeral = RomanToArabic(romanNumeral);
            Console.WriteLine($"The Arabic equivalent of {romanNumeral} is {arabicNumeral}.");

        }

        static int RomanToArabic(string roman)
        {
            Dictionary<char, int> romanNumerals = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int arabic = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int value = romanNumerals[roman[i]];

                // If the value of current numeral is less than the value of next numeral,
                // subtract its value from the total.
                if (i < roman.Length - 1 && romanNumerals[roman[i + 1]] > value)
                    arabic -= value;
                else
                    arabic += value;
            }

            return arabic;
        }
    }
}
