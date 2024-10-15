// ***** first example of objected oriented programming laboratory 1 *****

/* Console.Write("Enter the radius of the circle: ");
float radius = float.Parse(Console.ReadLine());

float area = 3.14 * radius * radius;
Console.WriteLine($"The area of the circle is: {area}"); */

// ***** second example of objected oriented programming laboratory 1 *****

/* Console.Write("Enter a temperature in Celsius: ");
float Celsius = float.Parse(Console.ReadLine());

float Fahrenheit = (Celsius * 9 / 5) + 32;
Console.WriteLine($"The temperature in Fahrenheit is {Fahrenheit}"); */

// ***** third example of objected oriented programming laboratory 1 *****

/* Console.Write("Enter a number to check if it is even or odd: ");
int number = int.Parse(Console.ReadLine()); 

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even.");
}
else
{
    Console.WriteLine($"{number} is odd.");
} */

// ***** fourth example of objected oriented programming laboratory 1 *****

/* Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 + num2;  
int difference = num1 - num2;
int product = num1 * num2;
double quotient = (double)num1 / num2;

Console.WriteLine($"Sum is {sum}.");
Console.WriteLine($"Difference is {difference}.");
Console.WriteLine($"Product is {product}.");
Console.WriteLine($"Quotient is {quotient}."); */

// ***** fifth example of objected oriented programming laboratory 1 *****

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}

Console.Write($"Maximum of the three numbers is {max}");
