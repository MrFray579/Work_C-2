/*Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int sum = numberA * numberA;
Console.WriteLine(sum);*/

Console.WriteLine("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB * numberB)
{
    Console.WriteLine("a является квадратом b");
}
else
{
    Console.WriteLine("a не является квадратом b");
}