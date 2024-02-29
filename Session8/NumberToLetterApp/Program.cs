string[] zeroToNineteen = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
    "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

string[] tens = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

RepeatWheneverUserWant();

string ConvertNumberToWords(int number)
{
    if (number == 0)
        return "Zero";

    if (number < 0)
        return "Minus " + ConvertNumberToWords(Math.Abs(number));

    string words = string.Empty;

    if ((number / 1000000) > 0)
    {
        words += ConvertNumberToWords(number / 1000000) + " Million ";
        number %= 1000000;
    }

    if ((number / 1000) > 0)
    {
        words += ConvertNumberToWords(number / 1000) + " Thousand ";
        number %= 1000;
    }

    if ((number / 100) > 0)
    {
        words += ConvertNumberToWords(number / 100) + " Hundred ";
        number %= 100;
    }

    if (number > 0)
    {
        if (!string.IsNullOrWhiteSpace(words))
            words += "and ";

        if (number < 20)
            words += zeroToNineteen[number];
        else
        {
            words += tens[number / 10];
            if ((number % 10) > 0)
                words += "-" + zeroToNineteen[number % 10];
        }
    }

    return words;
}

void RepeatWheneverUserWant()
{
    var input = "y";

    while (input != null && input.ToLower() == "y")
    {
        try
        {
            Console.Write("Pls enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConvertNumberToWords(num));
        }
        catch
        {
            Console.WriteLine("Number is undefined!");
        }


        Console.Write("\nDo you want to continue? Press y or Y if you want or press another key to exit: ");
        input = Console.ReadLine();
    }
}
