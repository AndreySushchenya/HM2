Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 )
{
  Console.WriteLine("да");
}
else if (number == 7 )
{
  Console.WriteLine("да");
}
else if (number < 6 && number > 0)
{
  Console.WriteLine("нет");
}
else if (number > 7)
{
  Console.WriteLine("не день недели");
}
else if (number < 1)
{
  Console.WriteLine("не день недели");
}