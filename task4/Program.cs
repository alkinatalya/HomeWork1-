// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число >");
if (value == 0)
{
     System.Console.Write($" Нет четных чисел в этом диапазоне 0,");
}
else
{
    if (value > 0)
{
    if (value == 1)
    {
        System.Console.Write($" Нет четных чисел в этом диапазоне 1,");
    }
    else
    {
       for (int index = 2; index < value + 1; index = index + 2)
        {
            System.Console.Write($" {index},");
        } 
    }
}
else
{
   if (value == -1)
    {
        System.Console.Write($" Нет четных чисел в этом диапазоне -1,");
    }
    else
    {
        for (int index = -2; index > value - 1; index = index - 2)
        {
            System.Console.Write($" {index},");
        }
    }
}
}
