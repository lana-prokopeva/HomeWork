// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Определение входных данных
Console.Write("Введите число от 1 до N: ");
int number = int.Parse(Console.ReadLine());
int startNumber = 1;
// Определяем является ли число четным
while (startNumber <= number)
{
    if ((startNumber%2) == 0)
    {
        Console.WriteLine($"{startNumber}");
    }
    startNumber ++;
}    
