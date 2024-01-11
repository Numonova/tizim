using System;

public class BaseConverter
{
    public static void Main()
    {
        string binaryNumber = "1010";
        int decimalNumber = Convert.ToInt32(binaryNumber, 2);

        Console.WriteLine($"Ikkilik son: {binaryNumber} o`nlikka o`tkazilganda: {decimalNumber}");

        decimalNumber = 12;
        binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"O`nlikdagi son: {decimalNumber} ikkilikka o`tkazilganda: {binaryNumber}\n");

        string octalNumber = "16";
        decimalNumber = Convert.ToInt32(octalNumber, 8);

        Console.WriteLine($"Sakkizlik son: {octalNumber} o`nlikka o`tkazilganda: {decimalNumber}");

        decimalNumber = 26;
        octalNumber = Convert.ToString(decimalNumber, 8);

        Console.WriteLine($"O`nlikdagi son: {decimalNumber} sakkizlikka o`tkazilganda: {octalNumber}\n");

        string hexadecimalNumber = "1A";
        decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);

        Console.WriteLine($"O'n olchamdagi son: {hexadecimalNumber} o`nlikka o`tkazilganda: {decimalNumber}");

        decimalNumber = 42;
        hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper();

        Console.WriteLine($"O`nlikdagi son: {decimalNumber} o'n olchamdagi soniga o`tkazilganda: {hexadecimalNumber}\n");
    }
}




