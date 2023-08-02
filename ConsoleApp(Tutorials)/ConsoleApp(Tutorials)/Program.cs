// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Welcome\nNumeral convertor (to other bases)");
Console.WriteLine("Would you like to proceed? Y/N");
string ProceedYesNo = Console.ReadLine();

if (ProceedYesNo == null)
{
    Console.WriteLine("Enter a valid input and continue: y/n");

}
else if (ProceedYesNo == "y")
{
    int OptionNum;
    int DecimalNum;
    string BinaryNum;
    Console.WriteLine("What operator do you want to perform? Enter option number to continue.");
    Console.WriteLine("1. Decimal to Binary \n2. Binary to Decimal");
    OptionNum = int.Parse(Console.ReadLine());
    //Coversion Block
    switch (OptionNum)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Enter decimal number:");
            DecimalNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"\'{DecimalNum}\' to binary is \'{Convert.ToString(DecimalNum, 2)}\'.");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Enter binary number:");
            BinaryNum = Console.ReadLine();
            Console.WriteLine($"\'{BinaryNum}\' to decimal is \'{Convert.ToInt32(BinaryNum, 2)}\'.");
            break;

    }
    Console.WriteLine("Conversion successful.");
}
else
    {
        Console.WriteLine("Thank you. You may try another time.");
    }

    Console.ReadLine();

