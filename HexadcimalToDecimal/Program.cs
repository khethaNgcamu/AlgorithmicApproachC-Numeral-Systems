namespace HexadcimalToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();

            int decimalNumber = HexadecimalToDecimal(hexadecimalNumber);

            Console.WriteLine($"Decimal representation: {decimalNumber}");
        }

        static int HexadecimalToDecimal(string hexadecimalNumber)
        {
            int decimalNumber = 0;
            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                char digit = hexadecimalNumber[i];
                int digitValue;

                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0'; // Convert digit character to its integer value
                }
                else
                {
                    digit = char.ToUpper(digit); // Convert lowercase letters to uppercase
                    digitValue = digit - 'A' + 10; // Convert hexadecimal letters to their integer values
                }

                decimalNumber = decimalNumber * 16 + digitValue;
            }

            return decimalNumber;
        }
    }
}
