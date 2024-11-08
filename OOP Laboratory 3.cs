// For Loop Example

int total = 0;
for (int i=1; i<=10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Even number: {i}");
    }
    
    total = total + i;
}
Console.WriteLine($"Total sum of numbers from 1 to 10 is: {total}"); 

// While Loop Example

int sum = 0;
Console.WriteLine("Enter numbers (enter a negative number to stop)");
while (true){

    int number = int.Parse(Console.ReadLine());
    

    if (number >= 0)
    {
        sum = sum + number; 
    }
    else
    {
        break;
    }
}
Console.WriteLine($"The sum of entered numbers is: {sum}"); 

// Do-While Loop Example

string password = "pass123", attempt;
do
{
    Console.Write("Please enter the password: ");
    attempt = Console.ReadLine();
    if (attempt == password)
    {
        Console.WriteLine("Access granted!");
        break;
    }
}
while (true); 

// Foreach Loop Example

int[] numbers = {10, 20, 30, 40, 50};
Console.WriteLine("Original Array: ");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("Updated Array: ");
numbers[2] = 35;

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// List Operations Example

List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
Console.WriteLine("Original Array: ");
foreach (string fru in fruits)
{
    Console.WriteLine(fru);
}
Console.WriteLine("\nUpdated Array: ");
fruits.Remove("Cherry");
fruits.Insert(1, "Grapes");

foreach (string fru in fruits)
{
    Console.WriteLine(fru);
}
