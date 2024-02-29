// static [return type] [Method Name] (parameters)
// {
//    ....
// }

int input = -1;

while (input != 0)
{
    Console.Write("0: Exit 1: Add  2: Subtract 3: Multiply 4: Devide  => ");
    input = Convert.ToInt32(Console.ReadLine());

    Console.Write("Pls enter number 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Pls enter number 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
        case 0:               
            break;
        case 1:
            Console.WriteLine($"Result: {Add(num1, num2)}");           
            break;
        case 2:
            Console.WriteLine($"Result: {Subtract(num1, num2)}");            
            break;
        case 3:
            Console.WriteLine($"Result: {Multipe(num1, num2)}");
            break;
        case 4:
            Console.WriteLine($"Result: {Devide(num1, num2)}");
            break;
        default:
            Console.WriteLine("Hey sheep! Pls be a human!");
            break;
    }
}



static int Add(int a, int b)
{
    return a + b;
}

static int Subtract(int a, int b)
{
    return a - b;
}

static int Multipe(int a, int b)
{
    return a * b;
}

static int Devide(int a, int b)
{
    return a / b;
}
