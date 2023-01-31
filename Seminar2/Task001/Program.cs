// // int.TryParse(strNumber, out number1); // пытаемся парсить, если возможно

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10, 100);
// int number1 = number/10;
// int number2 = number%10;

// System.Console.WriteLine($"number = {number}");

// if (number1 > number2)
// {
// System.Console.WriteLine("number1 больше number2");
// }
// else if (number2 > number1)
// {
// System.Console.WriteLine("number2 больше number1");
// }
// else
// System.Console.WriteLine("number2 равно number1");

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100, 1000);
// int number1 = number/100;
// int number3 = number%10;

// int sum = number1*10+number3;

// System.Console.WriteLine(sum);

// System.Console.WriteLine(number);
// System.Console.WriteLine(number1);
// System.Console.WriteLine(number2);
// System.Console.WriteLine(number3);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     int ost = num1 % num2;
//     Console.WriteLine($"не кратно, остаток {ost}");
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB*numberB || numberB == numberA*numberA )
{
    Console.WriteLine("Ура, это квадрат!");
}
else
{
    Console.Write("Не квадрат ");
}