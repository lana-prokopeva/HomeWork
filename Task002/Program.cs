// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Определение входных чисел
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());
int maxNumber = numberA;
// Опрeделяем большее число
if (numberB > maxNumber)
{
    maxNumber = numberB;
}
if (numberC > maxNumber)
{
    maxNumber = numberC;
}
Console.WriteLine($"Максимальное число: {maxNumber}");
