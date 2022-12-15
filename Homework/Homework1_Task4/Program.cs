Console.Write("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count < num)
{
    if(num % 2 == 0)
    Console.WriteLine($"{num}");
    num--;
}
