Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0;

while (number > 999)
{
   number = number / 10;
}

if (number > 99 && number < 1000)
{
    a = number % 10;
    Console.WriteLine(a);
}
else if (number < 100)
{
     Console.WriteLine("третьей цифры нет");
}
