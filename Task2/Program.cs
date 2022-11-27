// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.WriteLine("Программа создает массив и выводит сумму его элементов, находящихся на нечетных позициях");
Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] array = new int [length];
int count = 0;
RandomArray(length);

NumberOfEvenPosotions(array);
PrintEvenPosotions(array);
Console.WriteLine($" - {count} сумма элементов, стоящих на нечетных позициях");

int[] RandomArray(int length)                 
{ 
 for (int i = 0; i < array.Length; i++) 
 { 
 array[i] = new Random().Next(0, 100);
 }
 return array;
}

int NumberOfEvenPosotions(int[] array)         
{
for (int i = 0; i < array.Length; i+=2)
    count = count + array [i];
return count;
}

void PrintEvenPosotions(int [] array)          
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}