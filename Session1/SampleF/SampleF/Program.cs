Console.Write("Please enter grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

if(grade>17 &&  grade<20)
{
    Console.WriteLine("A");
}
if (grade > 10 && grade < 15)
{    
        Console.WriteLine("C");
}
else
{
    Console.WriteLine("B");
}
