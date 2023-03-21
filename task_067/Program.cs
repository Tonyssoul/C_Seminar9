// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int num, int sum)
{
    sum += num % 10;
    if (num / 10 == 0)
    {
        return sum;
    }
    return Sum(num / 10, sum);
}


int m = ReadInt("Введите число ");
System.Console.WriteLine(Sum(m, 0));