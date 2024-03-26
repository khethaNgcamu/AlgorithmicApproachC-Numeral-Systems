
namespace HexadecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();

            string binaryNumber = HexadecimalToBinary(hexadecimalNumber);
            Console.WriteLine(binaryNumber);
        }

        private static string HexadecimalToBinary(string? hexadecimalNumber)
        {
            string binaryNumber = "";

            foreach (char digit in hexadecimalNumber)
            {
                int digitValue;

                if (char.IsDigit(digit))
                {
                    digitValue = digit - '0'; // Convert digit character to its integer value
                }
                else
                {
                    char upperCaseDigit = char.ToUpper(digit); // Convert lowercase letters to uppercase
                    digitValue = upperCaseDigit - 'A' + 10; // Convert hexadecimal letters to their integer values
                }

                // Convert the digit to 4-bit binary representation
                string binaryDigit = Convert.ToString(digitValue, 2).PadLeft(4, '0');
                binaryNumber += binaryDigit;
            }

            return binaryNumber;
        }
    }
}
