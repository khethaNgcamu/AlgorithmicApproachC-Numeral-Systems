
namespace DecimalToHexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string hexadecimal = ConvertToHexadecimal(decimalNumber);
            Console.WriteLine(hexadecimal);
        }

        private static string ConvertToHexadecimal(int deciNum)
        {
            if(deciNum == 0)
            {
                return "0"; 
            }

            string hexa = "";
            while(deciNum > 0)
            {
                int remainder = deciNum % 16;
                hexa = GetHexadecimalDigit(remainder) + hexa;
                deciNum /= 16;
            }
            return hexa;
        }

        static char GetHexadecimalDigit(int value)
        {
            if (value >= 0 && value <= 9)
                return (char)(value + '0');
            else
                return (char)(value - 10 + 'A');
        }
    }
}
