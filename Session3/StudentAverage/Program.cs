// گرفتن 10 عدد از ورودی
Console.Write("Please enter math score: ");
double mathScore = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter physic score: ");
double physicScore = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter lan score: ");
double lanScore = Convert.ToDouble(Console.ReadLine());


//محاسبه معدل
double average = (mathScore + physicScore + lanScore) / 3;

//چاپ معدل در خروجی
Console.WriteLine(average);

