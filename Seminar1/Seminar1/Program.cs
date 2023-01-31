// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Enter number: ");

string strNumber = Console.ReadLine();

int number = Convert.ToInt32(strNumber);

int sqr = number * number;

Console.WriteLine(sqr);

// конец

Console.WriteLine("Enter number one: ");
string strNumber1 = Console.ReadLine();
int numberA = Convert.ToInt32(strNumber1);

Console.WriteLine("Enter number two: ");
string strNumber2 = Console.ReadLine();
int numberB = Convert.ToInt32(strNumber2);

if (numberA / numberB == numberB)
{
    Console.WriteLine("Является квадратом");
}
else
{
    Console.WriteLine("Не вляется квадратом");
} 

// конец

