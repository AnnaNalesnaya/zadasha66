// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumFor(int min, int max)
{
    int result = 0;
    for (int i = min; i <= max; i++)
    {
     result += i;
    }
    return result;
}


int min = Prompt("введите число min-> ");
int max = Prompt("введите число max-> ");
System.Console.WriteLine();
System.Console.WriteLine(SumFor(min, max));
