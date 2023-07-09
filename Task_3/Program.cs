//                                  Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message) // Метод для ввода числа пользователем.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
// Метод Ackermann вычисляет значение функции Аккермана для заданных аргументов m и n
int Ackermann(int m, int n)
{
    // Если m равно 0, возвращаем n + 1
    if (m == 0)
    {
        return n + 1;
    }
    // Если m больше 0 и n равно 0, вызываем функцию Ackermann с аргументами (m - 1, 1)
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    // Если m и n больше 0, вызываем функцию Ackermann с аргументами (m - 1, Ackermann(m, n - 1))
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    // В случае некорректных аргументов возвращаем -1
        else
    {
        return -1;
    }
    
}

// Запрос у пользователя ввода числа m
int m = InputNum("Введите неотрицательное число m: ");

// Запрос у пользователя ввода числа n
int n = InputNum("Введите неотрицательное число n: ");

// Вычисление значения функции Аккермана с помощью метода Ackermann
int result = Ackermann(m, n);

// Вывод результата на экран
Console.WriteLine($"A({m}, {n}) = {result}");