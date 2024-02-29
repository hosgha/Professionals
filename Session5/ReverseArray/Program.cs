// {78, 16, 14, 23} => {23, 14, 16, 78}

// (1)
//int[] arr = { 78, 16, 14, 23 };

//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(arr[i]);
//}

int[] arr = { 78, 16, 14, 23 };
int[] tempArray = new int[arr.Length];
int counter = 0;

for (int i = arr.Length - 1; i >= 0; i--)
{
    tempArray[counter] = arr[i];
    counter++;
}

for (int i = 0; i < tempArray.Length; i++)
{
    Console.Write(tempArray[i]);

    if (i != arr.Length - 1)
        Console.Write(", ");
}