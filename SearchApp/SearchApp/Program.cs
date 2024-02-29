Console.Write("Please write a number for array size? ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Please enter number " + i + " : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Please enter a number for searching in array? ");
int searchItem = Convert.ToInt32(Console.ReadLine());

IndexOf(array, searchItem);

Console.ReadKey();








static void IndexOf(int[] arr, int searchItem)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == searchItem)
        {
            Console.WriteLine("I found it in index: " + i);
            break;
        }
    }
}


//string name = "Ghasem";
//SayHi(name);

//static void SayHi(string name) 
//{
//    Console.WriteLine("Hi " + name + " :))");
//}


//Console.WriteLine(Add(14, 7));
//Console.WriteLine(Add(13, 5));

//static int Add(int x, int y)
//{
//    return x + y;
//}
