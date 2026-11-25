// Task2
int[] numbers = { 8, 12, 3, 17, 2, 9 };


int min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];

    }
}
Console.WriteLine(min);
