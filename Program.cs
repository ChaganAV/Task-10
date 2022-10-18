// На вход 3х значное число и на выходе показывает вторую цифру числа
Console.Write("Введите 3х значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int first = num/100*10;
int second = num/10-first;

Console.WriteLine($"Вторая цифра числа: {second}");
