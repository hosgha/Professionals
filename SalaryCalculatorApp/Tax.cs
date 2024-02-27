namespace SalaryCalculatorApp;

public class Tax
{
    public int GetTax(int salary)
    {
        if (salary < 10000)
        {
            return 5 * salary / 100;
        }
        else if (salary >= 10000 && salary < 20000)
        {
            return 10 * salary / 100;
        }
        else if (salary >= 20000)
        {
            return 25 * salary / 100;
        }
        else
        {
            return 0;
        }
    }
    public void GetAllTaxes(int[] salaries)
    {
        int allTax = 0;

        for (int i = 0; i < salaries.Length; i++)
        {
            allTax = allTax + GetTax(salaries[i]);
        }

        Console.WriteLine($"All tax that must be pay: {allTax}");
    }

}
