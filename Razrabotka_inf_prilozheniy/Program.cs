//Перечень заданий
System.Console.WriteLine("    ПЕРЕЧЕНЬ ЗАДАНИЙ:");
System.Console.WriteLine("    -----------------");
System.Console.WriteLine(" Домашнее задание 1");
System.Console.WriteLine(" 1. Задача 1");
System.Console.WriteLine(" 2. Задача 2");
System.Console.WriteLine(" 3. Задача 3");
System.Console.WriteLine(" 4. Задача 4");
System.Console.WriteLine(" 5. Задача 5");
System.Console.WriteLine(" 6. Задача 6");
System.Console.WriteLine(" 7. Задача 7");
System.Console.WriteLine(" 8. Задача 8");
System.Console.WriteLine(" Домашнее задание 2");
System.Console.WriteLine(" 9. Задача 1");
System.Console.WriteLine("10. Задача 2");
System.Console.WriteLine("11. Задача 3");
System.Console.WriteLine("12. Задача 4");
System.Console.WriteLine(" Домашнее задание 3");
System.Console.WriteLine("13. Задача");
System.Console.WriteLine("    -----------------");
System.Console.WriteLine("Выберите номер практического задания:");
int zad = Convert.ToInt32(Console.ReadLine());

//1. Задача 1
//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
if (zad == 1)
{
   Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber > secondNumber)
    {
        Console.WriteLine($"Большее число: {firstNumber}");
        Console.WriteLine($"Меньшее число: {secondNumber}");
    }
    else if (firstNumber < secondNumber)
    {
        Console.WriteLine($"Большее число: {secondNumber}");
        Console.WriteLine($"Меньшее число: {firstNumber}");
    }
    else
    {
        Console.WriteLine("Оба числа равны.");
    }
}

//2. Задача 2
//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
if (zad == 2)
{
   Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());

    int maxNumber = firstNumber;

    if (secondNumber > maxNumber)
    {
        maxNumber = secondNumber;
    }

    if (thirdNumber > maxNumber)
    {
        maxNumber = thirdNumber;
    }

    Console.WriteLine($"Максимальное число: {maxNumber}");
}

//3. Задача 3
//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
if (zad == 3)
{
   Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // Проверяем, является ли число четным
    if (number % 2 == 0)
    {
        Console.WriteLine("Число является четным.");
    }
     else
    {
        Console.WriteLine("Число является нечетным.");
    }
}

//4. Задача 4
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
if (zad == 4)
{
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Четные числа от 1 до " + N + ":");
    // Выводим четные числа от 1 до N
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
             Console.WriteLine(i);
        }
     }
}

//5. Задача 5
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
if (zad == 5)
{
   Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // Проверка кратности
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число " + number + " кратно одновременно 7 и 23.");
    }
    else
    {
        Console.WriteLine("Число " + number + " НЕ кратно одновременно 7 и 23.");
    }
}

//6. Задача 6
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
if (zad == 6)
{
   Console.Write("Введите координату X (X ≠ 0): ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Y (Y ≠ 0): ");
    double y = Convert.ToDouble(Console.ReadLine());
    // Проверяем, что X и Y не равны 0
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Координаты должны быть ненулевыми.");
        return;
    }
    // Определяем номер координатной четверти
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в первой четверти.");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка находится во второй четверти.");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в третьей четверти.");
    }
    else // x > 0 && y < 0
    {
        Console.WriteLine("Точка находится в четвертой четверти.");
    }
}

//7. Задача 7
//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
if (zad == 7)
{
   Console.Write("Введите целое число от 10 до 99: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // Проверяем, что число находится в заданном диапазоне
    if (number < 10 || number > 99)
    {
        Console.WriteLine("Число должно быть в диапазоне от 10 до 99.");
        return;
    }
    // Извлекаем цифры
    int tens = number / 10; // десятки
    int units = number % 10; // единицы
    // Определяем наибольшую цифру
    int maxDigit = Math.Max(tens, units);
    // Выводим результат
    Console.WriteLine($"Наибольшая цифра числа {number} равна {maxDigit}.");
}

//8. Задача 8
//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
if (zad == 8)
{
   Console.Write("Введите натуральное число: ");
    string input = Console.ReadLine();
    // Проверяем, что введенная строка является натуральным числом
    if (ulong.TryParse(input, out ulong number) && number > 0)
    {
        // Преобразуем число в строку
        string numberStr = number.ToString();
        // Выводим цифры через запятую
        Console.WriteLine(string.Join(", ", numberStr.ToCharArray()));
    }
    else
    {
        Console.WriteLine("Введите корректное натуральное число.");
    }
}

//9. Задача 1
//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
if (zad == 9)
{
   int[] numbers = new int[10];
    // Заполняем массив
    Console.WriteLine("Введите 10 целых чисел:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    // Подсчет количества элементов, значение которых находится в отрезке [20, 90]
    int count = 0;
    foreach (int number in numbers)
    {
        if (number >= 20 && number <= 90)
        {
            count++;
        }
    }
    // Вывод результата
    Console.WriteLine("Количество элементов в отрезке [20, 90]: " + count);
}

//10. Задача 2
//Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.
if (zad == 10)
{
   int[] numbers = new int[10];
    // Заполняем массив
    Console.WriteLine("Введите 10 целых чисел:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    // Подсчет количества четных чисел
    int evenCount = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0) // Проверка на четность
        {
            evenCount++;
        }
    }
    // Вывод результата
    Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
}

//11. Задача 3
//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
if (zad == 11)
{
   double[] numbers = new double[10];
    // Заполняем массив
    Console.WriteLine("Введите 10 вещественных чисел с ненулевой дробной частью:");
    for (int i = 0; i < numbers.Length; i++)
    {
        while (true)
        {
            Console.Write($"Введите число {i + 1}: ");
            double input = Convert.ToDouble(Console.ReadLine());
            // Проверка на ненулевую дробную часть
            if (input % 1 != 0)
            {
            numbers[i] = input;
            break;
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число с ненулевой дробной частью.");
            }
        }
    }
    // Нахождение максимального и минимального значения
    double max = numbers[0];
    double min = numbers[0];
    foreach (double number in numbers)
    {
        if (number > max)
            max = number;

        if (number < min)
            min = number;
    }
    // Вычисление разницы
    double difference = max - min;
    // Вывод результата
    Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
}

//12. Задача 4
//Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
//Размер массива должен быть равен количеству цифр.
if (zad == 12)
{
   Console.Write("Введите натуральное число от 1 до 100000: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // Проверка на диапазон
    if (number < 1 || number > 100000)
    {
        Console.WriteLine("Число должно быть в диапазоне от 1 до 100000.");
        return;
    }
    // Преобразование числа в строку для извлечения цифр
    string numberStr = number.ToString();
    int length = numberStr.Length;
    // Создаем массив для хранения цифр
    int[] digits = new int[length];
    // Заполняем массив цифрами числа
    for (int i = 0; i < length; i++)
    {
        digits[i] = numberStr[i] - '0'; // Преобразуем символ в цифру
    }
    // Вывод массива
    Console.Write("Массив из цифр числа: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(digits[i] + " ");
    }
    Console.WriteLine();
}

//13. Задача
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
if (zad == 13)
{
   int size = 20; // Например, 20 элементов
    int[] numbers = new int[size];
    Random rand = new Random();
    // Заполнение массива случайными трехзначными числами
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(100, 1000); // Генерация случайного числа от 100 до 999
    }
    // Подсчет четных чисел в массиве
    int evenCount = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    // Вывод результата
    Console.WriteLine("Сгенерированные числа: " + string.Join(", ", numbers));
    Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
}
System.Console.WriteLine("Чтобы проверить выполнение другой задачи, заново запустите программу");