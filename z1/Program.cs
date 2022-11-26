// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Write number1: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write number2: ");
int B = Convert.ToInt32(Console.ReadLine());

// возводим в степень(число, степень)
int Power(int num1, int num2)
{
    int result = 1;

    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}
// решение до сюда

double res = Power (A, B);
Console.WriteLine(res);
