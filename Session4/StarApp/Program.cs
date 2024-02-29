char repeat = 'y';

while (repeat == 'y') {

    Console.Write("Please enter a number: ");
    int input = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= input; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    Console.Write("Do you want to repeat it? (y / n): ");
    repeat = Convert.ToChar(Console.ReadLine());
}