// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Определение входных чисел
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int maxNumber = numberA;
// Оперделяем большее число
if (maxNumber > numberB)
{
    maxNumber = numberA;    
}
else
{
    maxNumber = numberB;
}
Console.WriteLine($"Максимальное число: {maxNumber}");