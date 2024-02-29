int maxNumber = 0;
int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

Console.Write("Plaese enter number1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number2: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number3: ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number4: ");
num4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number5: ");
num5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number6: ");
num6 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number7: ");
num7 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number8: ");
num8 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number9: ");
num9 = Convert.ToInt32(Console.ReadLine());

Console.Write("Plaese enter number10: ");
num10 = Convert.ToInt32(Console.ReadLine());

if(maxNumber < num1)
{
    maxNumber = num1;
}

if (maxNumber < num2)
{
    maxNumber = num2;
}

if (maxNumber < num3)
{
    maxNumber = num3;
}

if (maxNumber < num4)
{
    maxNumber = num4;
}

if (maxNumber < num5)
{
    maxNumber = num5;
}

if (maxNumber < num6)
{
    maxNumber = num6;
}

if (maxNumber < num7)
{
    maxNumber = num7;
}

if (maxNumber < num8)
{
    maxNumber = num8;
}

if (maxNumber < num9)
{
    maxNumber = num9;
}

if (maxNumber < num10)
{
    maxNumber = num10;
}

Console.WriteLine("\nMax number is: " + maxNumber);