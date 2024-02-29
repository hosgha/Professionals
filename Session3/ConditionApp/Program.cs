Console.Write("Please enter a score: ");
double score = Convert.ToDouble(Console.ReadLine());

if (score >= 10 && score < 15)
{
    Console.WriteLine("Your grade is C");
}
else if (score >= 15 && score < 17)
{
    Console.WriteLine("Your grade is B");
}
else if (score >= 17 && score <= 20)
{
    Console.WriteLine("Your grade is A");
}
else if (score < 10)
{
    Console.WriteLine("Your grade is D");
}
else
{
    Console.WriteLine("You enter incorrect score!");
}

Console.WriteLine("good bye");
