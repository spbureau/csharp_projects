// See https://aka.ms/new-console-template for more information

// TUTORIALS, CRUD

int AccountBenchmark = 100;

Console.WriteLine("Who is here? Enter your name:");
string username = Console.ReadLine();

// Account Operations
Console.WriteLine("How much?");

int MichaelsAccount = Convert.ToInt32(Console.ReadLine());
int BlaysAccount = 200;

if (MichaelsAccount <= AccountBenchmark )
{
     BlaysAccount = BlaysAccount + 20;
     MichaelsAccount -= 20;
     Console.WriteLine($"Blay's account balance is now GHS {BlaysAccount}. \nMike's new account balance is {MichaelsAccount}.");
}
else
{
    MichaelsAccount += 20;
    Console.WriteLine("Michael's account balance is more than GHS100.");
}
Console.WriteLine($"{username}, operation complete.");

// Next Porgram is below...
// Database Account Details
//[0] is Account Number, [1] is Account Balance, [2] is Password

int[] Ern_001 = { 001, 159, 165 }; //Ernest's Account
int[] Sam_002 = { 002, 5000, 166 }; //Sammy's Account
int[] Bla_033 = { 033, 108, 167 }; //Blay's Account
int[] Pet_022 = { 022, 338, 168 }; //Peter's Account
int[] Jam_051 = { 051, 969, 169 }; //James Account

Console.WriteLine("Enter your account number:");
int accNum = Convert.ToInt32(Console.ReadLine());

switch (accNum) // Ern_001, Sam_002, Bla_033, Pet_022, Jam_051)
{
    case 001:
        Console.WriteLine("Hello Ernest! Enter your password to proceed.");
            int pwd = Convert.ToInt32(Console.ReadLine());
        if (pwd == Ern_001[2])
        {
            Console.WriteLine("Your Account balcance is GHS" + Ern_001[1]);
        }
        else
        {
            Console.WriteLine("Incorrect password. Restart program to try again.");
        }
        break;

    case 033:
            Console.WriteLine("Hello Blay, enter your password to proceed.");
            int pwd2 = Convert.ToInt32(Console.ReadLine());
            if (pwd2 == Bla_033[2])
            {
                Console.WriteLine("Your Account balcance is GHS" + Bla_033[1]);
            }
            else
            {
                Console.WriteLine("Incorrect password. Restart program to try again.");
            }
        break;

    case 002:
        Console.WriteLine("Hello Sammy, enter your password to proceed.");
        int pwd3 = Convert.ToInt32(Console.ReadLine());
        if (pwd3 == Sam_002[2])
        {
            Console.WriteLine("Your Account balcance is GHS" + Sam_002[1]);
        }
        else
        {
            Console.WriteLine("Incorrect password. Restart program to try again.");
        }
        break;

    default:
        Console.WriteLine("Sorry. Such Account doesn't exist. Check Account Number and try again.");
        break;
}

// KNUST AND JOHN BULL STORY
string school = "KNUST";
string student = "John Bull";
int minAge = 20;

Console.WriteLine("Enter your year of birth.");
int yearOfBirth = Convert.ToInt32(Console.ReadLine());

int studentAge = 2023 - yearOfBirth;

if (studentAge >= minAge)
{
    Console.WriteLine($"Hello {student}, you're qualified to be enrolled into {school}.\nPROCEED WITH THE APPLICATION");
}
else
{
    Console.WriteLine($"You are just {studentAge} years old. Try again in {minAge - studentAge} years." );
}

// WHILE LOOP

int num = 21;
while (num >= 30)
{
    Console.WriteLine($"N0. {num}: The next number is...");
    num++;
    Console.WriteLine("End of Code");
}
































