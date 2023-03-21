// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int numM, int numN, int sum)
{
    if (numM < numN)
    {
        sum += numM;
        if (numM == numN)
        {
            return sum;
        }
        numM++;
        return Sum(numM, numN, sum);
    }
    else
    {
        sum += numN;
        if (numM == numN)
        {
            return sum;
        }
        numN++;
        return Sum(numM, numN, sum);
    }
}


int m = ReadInt("Введите число M ");
int n = ReadInt("Введите число N ");
System.Console.WriteLine(Sum(m, n, 0));