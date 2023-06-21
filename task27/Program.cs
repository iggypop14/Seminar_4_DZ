// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
string ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToString(Console.ReadLine());
}

int SumFunc(string numx)
{
    int sum = 0;
    for(int i = 0; i < numx.Length; i++)
    {
        sum = sum + Convert.ToInt32(Convert.ToString(numx[i]));
    }
    return sum;
}

string num = ReadInt("Введите число: ");
int summa = SumFunc(num);
System.Console.WriteLine($"Сумма цифр числа {num} равна -> {summa}");