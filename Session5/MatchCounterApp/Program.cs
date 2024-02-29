string[] names = { "Ali", "Mamad", "Esi", "Ali", "Mamad", "Ali"};

Console.Write("Please enter a name: ");
string name = Console.ReadLine();

int matchCounter = 0;
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == name)
    {
        matchCounter++;
    }
}

Console.WriteLine(matchCounter);