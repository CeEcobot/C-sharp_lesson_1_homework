Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (max > num2)
{
    Console.Write("max = ");
    Console.WriteLine($"{max}");
}
else
{
  Console.Write("max = ");
  Console.WriteLine($"{num2}");  
}