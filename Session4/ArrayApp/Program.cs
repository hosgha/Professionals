string[] daysOfWeek = {"Sun", "Mon", "Tus", "Wen", "Thr", "Fri", "Sat"};

for (int i = 0; i < daysOfWeek.Length; i++)
{
    Console.WriteLine((i+1) + " => " + daysOfWeek[i]);
}


//Console.Write("Please enter a number: ");
//int input = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//int[] numbers = new int[input];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write("Please enter number" + (i + 1) + ": ");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//int max = numbers[0];
//int min = numbers[0];

//for (int i = 0; i < numbers.Length; i++)
//{
//    if(max < numbers[i])
//    {
//        max = numbers[i];
//    }
    
//    if(min > numbers[i])
//    {
//        min = numbers[i];
//    }
//}

//Console.WriteLine("Max:" + max);
//Console.WriteLine("Min:" + min);