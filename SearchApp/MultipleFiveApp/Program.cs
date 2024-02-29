int[] numbers = { 1, 6, 15, 4, 20, 17, 27, 300};
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 5 == 0)
    {
        sum = sum + numbers[i];
    }
}

Console.WriteLine("Sum is: " + sum);
