Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

for(int i=0; i<=b;i++)
{
    Console.WriteLine($"Число   {Math.Pow(a,i)}");
}


