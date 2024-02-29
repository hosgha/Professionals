class Program
{
    static void Main(string[] args)
    {
        Produce(firstName: "Ehsan");
        Produce(firstName: "Ehsan", lastName: "Salek");

        double myNum1 = Divide(8, 5);
        double myNum2 = Divide(14.3, 6.26);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }

    static void Produce(string firstName)
    {
        Console.WriteLine($"My first name is {firstName}");
    }

    static void Produce(string firstName, string lastName)
    {
        Console.WriteLine($"My name is {firstName} {lastName}");
    }

    static double Divide(int x, int y)
    {
        return x / y;
    }

    static double Divide(double x, double y)
    {
        return x / y;
    }

}