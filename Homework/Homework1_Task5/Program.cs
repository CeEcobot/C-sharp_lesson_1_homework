Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num != 0)
{
    Console.WriteLine(num % 10);
    num /= 10;                
    }

// Решил как разбить на разряды, но не могу понять как вывести нужный третий разряд слева