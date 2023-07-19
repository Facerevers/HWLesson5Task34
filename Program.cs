// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void ShowResult(int[] mas)
{
    int count = 0;
    for(int i = 0 ; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.Write($"{count}");
}

int[] GetMas(int numbers)
{
    int[] mas = new int[numbers];
    for (int i = 0; i< numbers; i++)
    {
        mas[i] = new Random().Next(100,1000);
    }
    return mas;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numbers = GetInput("Введите количество чисел массива: ");
int[] mas = GetMas(numbers);
Console.WriteLine($"Массив [{String.Join(",", mas)}]");
ShowResult(mas);