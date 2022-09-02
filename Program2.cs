Console.Write("Напишите любое число: ");
string a = Console.ReadLine();
int number = Convert.ToInt32(a);
if(number%2==0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}