// for (int i = 1; i <= 5; i++){
//     Console.WriteLine(i);
// }

// int n = 1;
// while (n <= 5)
// {
//     Console.WriteLine(n);
//     n++;
// }

// int answer;
// do
// {
//     Console.WriteLine("Введите число больше 0: ");
//     answer = Convert.ToInt32(Console.ReadLine());
// }
// while(answer <= 0);

// Задание 1.1

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

// ===== Решение ====

// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

// Задание 1.2

// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     else
//     {
//         continue;
//     }
// }

// int sum = 0;
// for (int i = 1; i <= 10; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма: {sum}");

// int count = 0;
// for (int i = 1; i <= 20; i++)
// {
//     if (i % 5 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Чисел, кратных 5: {count}");

// Задание 5

// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if ( i % 7 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Сумма числе кратных 3: {sum}, кол-во числе кратных 7: {count}");

// Пример 3

// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;

// while (number != 0)
// {
//     total += number;
//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"Сумма: {total}");

// Пример 3. Решение

// int number = Convert.ToInt32(Console.ReadLine());
// int countPositive = 0;
// int countNegative = 0;

// while (number != 0)
// {
//     if (number > 0)
//     {
//        countPositive++; 
//     }
//     else
//     {
//         countNegative ++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"Кол-во положительных: {countPositive}, отрицательных: {countNegative}");


// Самостоятельные задания

// Задание 5. Таблица умножения.

// Console.WriteLine("🟰 Таблица умножения 🟰");

// Console.Write("Введите число от 1 до 9: ");
// int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }

// Задание 5. Числа без троек.

// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     if ( i % 10 == 0 && i > 20)
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }

// Итоговая задача. «Угадай число»

int secret = 42;
Console.WriteLine("В программе загадано число. У вас есть 5 попыток, чтобы его отгадать. Желаю удачи!");
for (int i = 1; i <= 5; i++)
{
    Console.Write("Введите свое число: ");
    int userSecret = int.Parse(Console.ReadLine());
    if (userSecret > secret)
    {
        Console.WriteLine("Ваше число больше");
    }
    else if (userSecret < secret)
    {
        Console.WriteLine("Ваше число меньше");
    }
    if (userSecret == secret)
    {
        Console.WriteLine($"Вы угадали число за {i} попыток. Мое число было: {secret}");
        break;
    }

    if (i == 5)
    {
        Console.WriteLine($"Вы проиграли. Мое число было: {secret}. Кол-во попыток {i}"); 
        break;   
    }

}

// Дополнительное задание ★★★

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int sum = 0;
// int count = 0;
// while(n > 0)
// {
//     sum += n % 10;
//     count++;
//     n = n / 10;
// }
// Console.WriteLine($"Сумма цифр: {sum}");
// Console.WriteLine($"Количество цифр {count}");
