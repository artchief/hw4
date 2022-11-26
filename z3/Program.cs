// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int size)
{
    // создали массив
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next(1,50);
    }
    return array;
}
// вызвали метод на 17 строчке и он заработал на 7 строчке
int[] array = GetArray(8);
// выводим массив
Console.Write(String.Join(" ", array));