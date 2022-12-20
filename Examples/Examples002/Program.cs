// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int numberA = Convert.ToInt32(Console.ReadLine());
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