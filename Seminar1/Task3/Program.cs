System.Console.WriteLine("Задача 8. Решение 2");
System.Console.Write("Введите число: ");
string strNumber4_1 = Console.ReadLine();
int Number4_1 = Convert.ToInt32(strNumber4_1);


int count = 2;
int res = 0;

if (Number4_1 <= 0)
{
    count *= -1;
    System.Console.Write("0, ");
}

while (Math.Abs(res) <= Math.Abs(Number4_1))
{
    res += count;
    System.Console.Write(res + ", ");
}
