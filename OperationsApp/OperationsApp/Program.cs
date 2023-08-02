// See https://aka.ms/new-console-template for more information
// BASIC MATH OPERATIONS USING CONDITIONALS

Console.WriteLine("BASIC MATH CALCULATOR (USING SWITCH, IF ELSE)\nThis program performs basic math operations (addition, subtraction, multiplication and division) on two numbers only and displays the result.");
Console.WriteLine("Shall we proceed? y/n");
string yesNo = Console.ReadLine();

switch (yesNo)
{
    case "y":
    Console.WriteLine("What operation do you want to perform?\nEnter operator/symbol (+, -, *, or /) for addition, subtruction, multiplication or division.");
    string opera = Console.ReadLine();

    Console.WriteLine("Enter first number:"); // First Number Reader
    int num1 = Convert.ToInt32(Console.ReadLine()); // Number 1
    Console.WriteLine("Enter second number:"); // Second Number Reader
    int num2 = Convert.ToInt32(Console.ReadLine()); // Number 2

    if (opera == "+") // Plus Condition
    { // Addition Block
        Console.WriteLine($"{num1} + {num2} is {num1 + num2}.\nAddition complete. Thank you.");

    }
    else if (opera == "-") // Minus Condition
    {
        Console.WriteLine($"{num1} - {num2} is {num1 - num2}.\nSubstraction done. Thank you.");

    }
    else if (opera == "*") // Times Condition
    {
        Console.WriteLine($"{num1} * {num2} is {num1 * num2}.\nMultiplaction done. Thank you.");

    }
    else if (opera == "/")
    {
        Console.WriteLine($"{num1} / {num2} is {num1 / num2}.\nDivison complete. Thank you.");

    }
    else
    {
        Console.WriteLine("Unrecognised operation.\n: )");
    }
    break;
// NO CASE        
    case "n":
    Console.WriteLine("Thank you. You may perform operation later.");
    break;
// RESULT, WHEN WRONG INPUT FOR Y/N IS ENTERED 
    default:
    Console.WriteLine("Enter y or n. Try again.");
       break;
}
// End Remarks
Console.WriteLine("Program succesful. Run again for multiple operations.");


// OPERATIONS WITH IF ELSE (NESTED CONDITIONALS)
// OPERATIONS WITH IF ELSE (NESTED CONDITIONALS)
// OPERATIONS WITH IF ELSE (NESTED CONDITIONALS)
/*
Console.WriteLine("BASIC MATH CALCULATOR (USING IF ESLE)\nThis program performs basic math operations (addition, subtraction, multiplication and division) on two numbers only and displays the result.");
Console.WriteLine("Shall we proceed? y/n");
string yesN = Console.ReadLine();

if (yesN == "y")
{
    Console.WriteLine("What operation do you want to perform?\nEnter operator/symbol (+, -, *, or /) for addition, subtruction, multiplication or division.");
    string opera = Console.ReadLine();

    Console.WriteLine("Enter first number:"); // First Number Reader
    int num1 = Convert.ToInt32(Console.ReadLine()); // Number 1
    Console.WriteLine("Enter second number:"); // Second Number Reader
    int num2 = Convert.ToInt32(Console.ReadLine()); // Number 2

    if (opera == "+") // Plus Condition
    { // Addition Block
        Console.WriteLine($"{num1} + {num2} is {num1 + num2}.\nAddition complete. Thank you.");

    }
    else if (opera == "-") // Minus Condition
    {
        Console.WriteLine($"{num1} - {num2} is {num1 - num2}.\nSubstraction done. Thank you.");

    }
    else if (opera == "*") // Times Condition
    {
        Console.WriteLine($"{num1} * {num2} is {num1 * num2}.\nMultiplaction done. Thank you.");

    }
    else if (opera == "/")
    {
        Console.WriteLine($"{num1} / {num2} is {num1 / num2}.\nDivison complete. Thank you.");

    }
    else
    {
        Console.WriteLine("Unrecognised operation.\n: )");
    }
}
else if (yesN == "n")
{
    Console.WriteLine("Thank you. You may perform operation later.");
}
else
{
    Console.WriteLine("Enter y or n. Try again.");
}
// End Remarks
Console.WriteLine("Program succesful. Run again for multiple operations.");
*/
