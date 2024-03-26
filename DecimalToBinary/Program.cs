int toBinary = 148;
string result = "";

while(toBinary > 0)
{
   int temp = toBinary % 2;
    result = temp + result;
    toBinary = toBinary / 2;
   //Console.WriteLine(result);
}

Console.WriteLine(result);