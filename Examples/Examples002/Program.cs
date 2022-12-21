// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if(numberA > numberB)
{ 
    max = numberA;
    min = numberB;
    }
else
{
    max = numberB;
    min = numberA;
}

Console.Write("число большее = ");
Console.WriteLine(max);
Console.Write("число меньшее = ");
Console.WriteLine(min);