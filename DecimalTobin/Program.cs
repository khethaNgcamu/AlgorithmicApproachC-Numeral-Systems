namespace DecimalTobin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = DecimalToBinary(decimalNumber);

            Console.WriteLine($"Binary representation: {binaryNumber}");
        }

        static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }

            return binary;
        }
    }
}
