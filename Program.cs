public class BaseConverter
{
    public static int BinaryToDecimal(string binaryNumber)
    {
        int decimalNumber = 0;
        int power = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            int digit = binaryNumber[i] - '0';
            decimalNumber += digit * (int)Math.Pow(2, power);
            power++;
        }

        return decimalNumber;
    }

    public static string DecimalToBinary(int decimalNumber)
    {
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber != "" ? binaryNumber : "0";
    }


    public static void Main()
    {
        string binaryNumber = "1010";
        int decimalNumber = BinaryToDecimal(binaryNumber);

        Console.WriteLine($"Ikkilik son : {binaryNumber} o`nlikka o`tkazilganda : {decimalNumber}");

        decimalNumber = 12;
        binaryNumber = DecimalToBinary(decimalNumber);

        Console.WriteLine($"O`nlikdagi son : {decimalNumber} ikkilikka o`tkazilganda : {binaryNumber}");
    }
}
