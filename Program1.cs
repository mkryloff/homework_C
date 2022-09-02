Console.Write("Введите первое число: ");
string a = Console.ReadLine();
int first = Convert.ToInt32(a);
Console.Write("Введите второе число: ");
string b = Console.ReadLine();
int second = Convert.ToInt32(b);
if(first > second)
{
    Console.WriteLine("max = " + first);
}
else
{
    Console.WriteLine("max = " + second);
}



