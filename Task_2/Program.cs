//                                       Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




int InputNum(string message) // Метод для ввода числа пользователем.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int SumNumbers(int M, int N) // Метод, который рекурсивно суммирует числа от M до N.
{
    if (M > N)
    {
        return 0; // если M > N, то возвращаем 0.
    }
    else
    {
        return M + SumNumbers(M + 1, N); // Рекурсивный вызов метода SumNumbers с аргументом M + 1.
    }
}

int M = InputNum("Введите целое число M: ");
int N = InputNum("Введите целое число N: ");

int sum = SumNumbers(M, N);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {sum}.");
