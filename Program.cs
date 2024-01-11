using System;
public class BaseConverter
{
    // Ikki qarshilik (2-lik) sonni o'nlik (10-lik) soniga o'tkazish
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

    // O'nlik (10-lik) sonni ikki qarshilik (2-lik) soniga o'tkazish
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

    // Sakkizlik (8-lik) sonni o'nlik (10-lik) soniga o'tkazish
    public static int OctalToDecimal(string octalNumber)
    {
        int decimalNumber = 0;
        int power = 0;

        for (int i = octalNumber.Length - 1; i >= 0; i--)
        {
            int digit = octalNumber[i] - '0';
            decimalNumber += digit * (int)Math.Pow(8, power);
            power++;
        }

        return decimalNumber;
    }

    // O'nlik (10-lik) sonni sakkizlik (8-lik) soniga o'tkazish
    public static string DecimalToOctal(int decimalNumber)
    {
        string octalNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 8;
            octalNumber = remainder + octalNumber;
            decimalNumber /= 8;
        }

        return octalNumber != "" ? octalNumber : "0";
    }

    // O'n oltilik (16-lik) sonni o'nlik (10-lik) soniga o'tkazish
    public static int HexadecimalToDecimal(string hexadecimalNumber)
    {
        int decimalNumber = 0;

        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            int digit = GetHexadecimalValue(hexadecimalNumber[i]);
            decimalNumber += digit * (int)Math.Pow(16, hexadecimalNumber.Length - 1 - i);
        }

        return decimalNumber;
    }

    // O'nlik (10-lik) sonni o'n o'nlik olchamdagi (16-lik) soniga o'tkazish
    public static string DecimalToHexadecimal(int decimalNumber)
    {
        string hexadecimalNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 16;
            hexadecimalNumber = GetHexadecimalDigit(remainder) + hexadecimalNumber;
            decimalNumber /= 16;
        }

        return hexadecimalNumber != "" ? hexadecimalNumber : "0";
    }

    // 16-lik sonning o'nlik miqdorini olish uchun yordamchi metod
    private static int GetHexadecimalValue(char hexDigit)
    {
        if (hexDigit >= '0' && hexDigit <= '9')
            return hexDigit - '0';
        else if (hexDigit >= 'A' && hexDigit <= 'F')
            return hexDigit - 'A' + 10;
        else if (hexDigit >= 'a' && hexDigit <= 'f')
            return hexDigit - 'a' + 10;
        else
            throw new ArgumentException("Noto'g'ri 16-lik son belgisi");
    }

    // 10-lik sonning 16-lik sonning belgisi uchun yordamchi metod
    private static char GetHexadecimalDigit(int value)
    {
        if (value >= 0 && value <= 9)
            return (char)(value + '0');
        else if (value >= 10 && value <= 15)
            return (char)(value - 10 + 'A');
        else
            throw new ArgumentException("16-lik son belgisi uchun noto'g'ri o'nlik qiymat");
    }

    // Test konvertatsiyalarni sinovlash uchun asosiy metod
    public static void Main()
    {
        string binaryNumber = "1010";
        int decimalNumber = BinaryToDecimal(binaryNumber);
        decimalNumber = Convert.ToInt32(binaryNumber, 2);

        Console.WriteLine($"Ikkilik son: {binaryNumber} o`nlikka o`tkazilganda: {decimalNumber}");

        decimalNumber = 12;
        binaryNumber = DecimalToBinary(decimalNumber);
        binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"O`nlikdagi son: {decimalNumber} ikkilikka o`tkazilganda: {binaryNumber}\n");


        string octalNumber = "16";
        decimalNumber = OctalToDecimal(octalNumber);
        decimalNumber = Convert.ToInt32(octalNumber, 8);

        Console.WriteLine($"Sakkizlik son: {octalNumber} o`nlikka o`tkazilganda: {decimalNumber}");

        decimalNumber = 26;
        octalNumber = DecimalToOctal(decimalNumber);
        octalNumber = Convert.ToString(decimalNumber, 8);

        Console.WriteLine($"O`nlikdagi son: {decimalNumber} sakkizlikka o`tkazilganda: {octalNumber}\n");

        string hexadecimalNumber = "1A";
        decimalNumber = HexadecimalToDecimal(hexadecimalNumber);
        decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);

        Console.WriteLine($"O'n olchamdagi son: {hexadecimalNumber} o`nlikka o`tkazilganda: {decimalNumber}");

        decimalNumber = 42;
        hexadecimalNumber = DecimalToHexadecimal(decimalNumber);
        hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper();

        Console.WriteLine($"O`nlikdagi son: {decimalNumber} o'n olchamdagi soniga o`tkazilganda: {hexadecimalNumber}\n");
    }
}