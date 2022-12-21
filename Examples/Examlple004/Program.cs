// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(max < numberA) max = numberA;

if(max < numberB) max = numberB;
if(max < numberC) max = numberC;

Console.Write("Макисмальное число = ");
Console.WriteLine(max);