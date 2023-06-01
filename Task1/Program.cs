Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10;
int b = a % 10;
if (number > 99 && number < 1000)
{
   Console.WriteLine(b);
}
else {
   Console.WriteLine("Введено не трехзначное число");
}