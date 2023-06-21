// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int MultNumbers(int A, int B)
{
    int multInFunction = A;
    for (int i = 1; i < B; i++)
    {
        A = A * multInFunction;
    }
    return A;
}

// ---------------------------- ОСНОВНАЯ ЧАСТЬ КОДА ----------------------------------------

int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");

int mult = MultNumbers(number1, number2);

System.Console.WriteLine($"Произведение чисел {number1} X {number2} -> {mult}");
