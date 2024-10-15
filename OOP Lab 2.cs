// Lab 2 Exercises

// LAB 2 EXERCISE 1

Console.WriteLine("Enter your grade (A,B,C,D,F): ");
string grade = Console.ReadLine();
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
        Console.WriteLine("Enter a valid grade!");
        return;
}

Console.WriteLine("Your GPA is {0}", gpa);
Console.WriteLine($"Your GPA is {gpa}");

// LAB 2 EXERCISE 2

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even.");
}
else
{
    Console.WriteLine($"{number} is odd.");
}

// LAB 2 EXERCISE 3

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine($"{number} is positive");
}
else if (number < 0)
{
    Console.WriteLine($"{number} is negative");
}
else
{
    Console.WriteLine($"{number} is zero");
} 

// LAB 2 EXERCISE 4

Console.Write("Enter a day number: ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid Day Of The Number");
        return;

}

// LAB 2 EXERCISE 5

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Number 1 is greater than number 2.");
}
else if (num1 < num2)
{
    Console.WriteLine("Number 2 is greater than number 3.");
}
else
{
    Console.WriteLine("Number 1 is equal to number 2.");
}
