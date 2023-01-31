Console.Write("Enter number: ");
string strNumber = Console.ReadLine();
int Number1 = Convert.ToInt32(strNumber);
if (Number1 == 1)
{
    Console.WriteLine("Понедельник");
}
else if (Number1 == 2)
{
    Console.WriteLine("Вторник");
}
else if (Number1 == 3)
{
    Console.WriteLine("Среда");
}
else if (Number1 == 4)
{
    Console.WriteLine("Четверг");
}
else if (Number1 == 5)
{
    Console.WriteLine("Пятница");
}
else if (Number1 == 6)
{
    Console.WriteLine("Суббота");
}
else if (Number1 == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}
