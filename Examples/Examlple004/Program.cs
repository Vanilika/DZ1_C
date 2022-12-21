// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if(max < numberB)
{ 
    max = numberB;
}
if(max < numberC);
{
    max = numberC;
}

Console.Write("Макисмальное число = ");
Console.WriteLine(max);