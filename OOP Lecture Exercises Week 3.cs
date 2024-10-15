// OOP LECTURE EXERCISES WEEK 3 

// EXERCISE 1

/* Write a program that takes a user's input for a grade (A, B, C, D, F) and prints out the corresponding GPA
using the following logic:
A = 4
B = 3
C = 2
D = 1
F = 0  */

Console.Write("Enter a grade (A,B,C,D,F): ");
string grade = Console.ReadLine().ToUpper();
int gpa;

switch (grade)
{
    case "A":
        gpa = 4;
        break;

    case "B": 
        gpa = 3; 
        break;

    case "C": 
        gpa = 2;
        break;

    case "D":
        gpa = 1;
        break;

    case "F":
        gpa = 0;
        break;

    default:
        Console.WriteLine("You entered invalid grade!");
        return;
}

Console.WriteLine($"Your gpa is {gpa}"); 

// EXERCISE 2

/* Write a program that asks the user to input their age and checks the following conditions:
 If they are under 18, print "You are a minor."
 If they are between 18 and 65, print "You are an adult."
 If they are over 65, print "You are a senior citizen." */

Console.Write("Please enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age > 0 && age < 18)
{
    Console.WriteLine("You are a minor.");
}
else if (age >= 18 && age <= 65)
{
    Console.WriteLine("You are an adult.");
}
else if (age > 65)
{
    Console.WriteLine("You are a senior citizen.");
}
else
{
    Console.WriteLine("You entered invalid age.");
}

// EXERCISE 3

/* Write a program that asks for a number from the user and checks:
 If the number is positive.
 If the number is divisible by 2 or 3.
 If the number is divisible by both 2 and 3. */

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if(number > 0)
{
    Console.WriteLine("The number is positive.");
}
else
{
    Console.WriteLine("The number is not positive.");
}

if (number % 2 == 0 || number % 3 == 0)
{
    Console.WriteLine("The number is divisible by 2 or 3.");
}
else
{
    Console.WriteLine("The number is not divisible by 2 or 3.");
}

if (number % 2 == 0 && number % 3 == 0)
{
    Console.WriteLine("The number is divisible by both 2 and 3.");
}
else
{
    Console.WriteLine("The number is not divisible by both 2 and 3.");
} 

// EXERCISE 4

/* Write a program that takes a number from the user and uses a switch statement to print:
 "Small number" for numbers between 1 and 10.
 "Medium number" for numbers between 11 and 20.
 "Large number" for numbers above 20.
 Use the default case to handle any numbers below 1. */

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case int n when (n >= 1 && n <= 10):
        Console.WriteLine("The number you entered is Small Number.");
        break;

    case int n when (n >= 11 && n <= 20):
        Console.WriteLine("The number you entered is Medium Number.");
        break;

    case int n when (n > 20):
        Console.WriteLine("The number you entered is Large Number.");
        break;

    default:
        Console.WriteLine("The number you entered is invalid!");
        return;
} 

// EXERCISE 5

/* Write a C# program that checks the type of a variable using a switch statement with the when keyword.
The program should classify the variable based on its type and specific conditions. For example, if the
variable is an int and is positive, print "Positive Integer". If it's a string and has more than 5 characters,
print "Long String". */

object obj = ;

switch (obj)
{
    case int n when n > 0:
        Console.WriteLine("Positive Integer");
        break;

    case int n when n < 0:
        Console.WriteLine("Negative Integer");
        break;

    case int n when n == 0:
        Console.WriteLine("Zero");
        break;

    case string s when s.Length > 5:
        Console.WriteLine("Long String");
        break;

    case string s when s.Length <= 5:
        Console.WriteLine("Short String");
        break;

    case null:
        Console.WriteLine("Null");
        break;

    default:
        Console.WriteLine("Unknown Type");
        return;

}
