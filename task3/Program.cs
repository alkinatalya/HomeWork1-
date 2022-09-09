// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число >");
if (value > 0)
{
    if(value % 2 == 1)
{
        System.Console.WriteLine($"{value} = нет");
    }
else
    {
        System.Console.WriteLine($"{value} = да");
    }
}
else
{
    if (value % 2 == -1)
    {
        System.Console.WriteLine($"{value} = нет");
    }
    else
    {
        System.Console.WriteLine($"{value} = да");
    }
}

