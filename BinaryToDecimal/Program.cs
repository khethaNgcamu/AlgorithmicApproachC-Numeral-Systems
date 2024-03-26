
//string binary = "11001";

//int result = Convert.ToInt32(binary, 2);
//Console.WriteLine(result);


Console.Write("Enter a binary number: ");
string binaryString = Console.ReadLine();

// Convert binary to decimal
int decimalNumber = ConvertBinaryToDecimal(binaryString);

// Display the result
Console.WriteLine($"Decimal equivalent: {decimalNumber}");

static int ConvertBinaryToDecimal(string binaryString)
{
    int decimalNumber = 0;
    int power = 0;

    // Start from the rightmost bit
    for (int i = binaryString.Length - 1; i >= 0; i--)
    {
        // Convert char to int
        int bit = binaryString[i] - '0';

        // Add to decimal after multiplying by appropriate power of 2
        decimalNumber += bit * (int)Math.Pow(2, power);
        power++;
    }

    return decimalNumber;
}

