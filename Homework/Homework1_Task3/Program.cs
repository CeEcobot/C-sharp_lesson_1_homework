Console.Write("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());


if(num % 2 == 0)
Console.WriteLine($"{num} - четное число");
else
Console.WriteLine($"{num} - нечетное число");
