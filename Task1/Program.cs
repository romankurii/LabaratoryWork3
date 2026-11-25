//Task1
Console.Write("Введіть число: ");
string input = Console.ReadLine();
bool success = int.TryParse(input, out int number);

int sum = 0;
if (success)
{

}
else
{
    Console.WriteLine("not good");
}



while (number > 0)
{
    int digit = number % 10;
    sum += digit;
    number /= 10;
}
Console.WriteLine(sum);
