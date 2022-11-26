// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());
// метод с суммой чисел
Console.WriteLine("Сумма " + GetSumNum(num));

int GetSumNum(int input)
{
    // сумма чисел
    int sum =0;
    while(input>0)
    {
        sum+=input%10;
        input=input/10;
    }
    return sum;
}
