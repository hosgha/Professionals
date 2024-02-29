// Write to Console => Console.WriteLine(...);
int englishScore = 10;
Console.WriteLine("My English number is " + englishScore + " and My Math number is " + 12);

// Read from Console => type name = Convert.ToType(Console.ReadLine());
double salary = Convert.ToDouble(Console.ReadLine());

// Define variable => type name; || type name = value; 
double number;
int sum = 0;
string name = "";

// if(conditions)
// {
//     ...
// }
// else if(conditions)
// {
//     ...
// }
// else
// {
//    ...
// }

if (sum < 100)
{
    sum = 100;
}
else if(sum > 100)
{
    sum = sum + 10;
}
else
{
    sum = 0;
}

// for(define loop counter and initialize; break condition of loop; steep)
// {
//      ...
// }

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// type[] name = new type[lenght];
// type[] name = {value1, value2, ....};
int[] numbers = new int[10];
int[] scores = { 20, 19, 16, 20, 18 };

Console.WriteLine(scores[2]);

for(int index = 0; index < numbers.Length; index++)
{
    Console.WriteLine(scores[index]);
}

//switch, while, foreach, Math, String, Break/Continue

