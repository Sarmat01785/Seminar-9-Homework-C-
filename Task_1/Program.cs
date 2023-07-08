//                                      Задача 64:
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNum(string message) // Метод для ввода числа пользователем.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
void PrintNumbers(int N) // Метод, который рекурсивно выводит числа от N до 1.
{
    if (N > 0)
    {
        if (N == 1)
        {
            Console.Write("1");
        }
        else
        {
            Console.Write($"{N}, ");
            PrintNumbers(N - 1); // Рекурсивный вызов метода PrintNumbers с аргументом N - 1.
        }
    }
}

int N = InputNum("Введите целое число N: ");
PrintNumbers(N);
Console.WriteLine(".");

/*
int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void PrintNumbers(int start, int end)
{
    if (start > end)
        return;
    PrintNumbers(start + 1, end);
    Console.Write(start + " ");
}
int num = InputNum("Введите целое число: ");
PrintNumbers(1, num);
Эта задача была решена на семинаре. Выше свое решение.
*/




