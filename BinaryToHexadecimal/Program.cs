namespace BinaryToHexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();

            string hexadecimalNumber = BinaryToHexadecimal(binaryNumber);

            Console.WriteLine("Hexadecimal equivalent: " + hexadecimalNumber);
        }

        static string BinaryToHexadecimal(string binary)
        {
            // Convert binary to decimal
            int decimalNumber = Convert.ToInt32(binary, 2);

            // Convert decimal to hexadecimal
            string hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper();

            return hexadecimalNumber;
        }
    }
}
