int num = int.Parse(Console.ReadLine());
int sum = 0;
Console.Write($"Сумма чисел {num} равна {SUMMA(num)}");

int SUMMA(int num)
{
    int num_a = num;
    int sum = 0;
    while (num_a > 0)
    {
        sum += num_a % 10;
        num_a /= 10;
    }
    return sum;
}