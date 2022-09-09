//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");
if (firstValue == secondValue)
{
    System.Console.WriteLine("-> Числа равны");
} 
else
{
    if (firstValue > secondValue)
    {
     System.Console.WriteLine($" max = {firstValue}, min = {secondValue}");   
    }
   else
   {
     System.Console.WriteLine($" max = {secondValue}, min = {firstValue}");  
   }
}

