//Console.Write("Pls enter day of week number: ");
//int weekday = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine();

//if (weekday == 0)
//{
//    Console.WriteLine("It is SUNDAY");
//}
//else if(weekday == 1)
//{
//    Console.WriteLine("It is MONDAY");
//}
//else if (weekday == 2)
//{
//    Console.WriteLine("It is TUESDAY");
//}
//else if(weekday == 3)
//{
//    Console.WriteLine("It is WEDNESDAY");
//}
//else if(weekday == 4)
//{
//    Console.WriteLine("It is THURSDAY");
//}
//else if (weekday == 5)
//{
//    Console.WriteLine("It is FRIDAY");
//}
//else if(weekday == 6)
//{
//    Console.WriteLine("It is SATURDAY");
//}
//else
//{
//    Console.WriteLine("Invalid Input");
//}


//int[] numbers = { 15, 32, 12, 25 };

//Console.WriteLine("numbers.Length  =>   " + numbers.Length + "\n");
//Console.WriteLine("numbers[2]  =>   " + numbers[2] + "\n");

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//Add();

//void Add()
//{
//    Console.Write("Pls enter number1: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Pls enter number2: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Result is: " + (num1 + num2));
//}

//Console.WriteLine("Result is: " + Add());

//int Add()
//{
//    Console.Write("Pls enter number1: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Pls enter number2: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    return num1 + num2;
//}

//Console.WriteLine("Result is: " + Add(34, 67));
//Console.WriteLine("Result is: " + Add(32, 2));
//Console.WriteLine("Result is: " + Add(2, 6));

//int Add(int number1, int number2)
//{
//    return number1 + number2;
//}

Introduce(country: "Spain", fullName: "Fateme Elahi");

void Introduce(string fullName = "Mamad", string country = "Iran")
{
    Console.WriteLine($"{fullName} from {country}");
}