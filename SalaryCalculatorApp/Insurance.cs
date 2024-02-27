namespace SalaryCalculatorApp;

public class Insurance
{
    public int GetInsurance(int salary)
    {
        if (salary < 10000)
        {
            return 1000;
        }
        else if (salary >= 10000 && salary < 20000)
        {
            return 1000 + (5 * 10000 / 100);
        }
        else if (salary >= 20000)
        {
            return 12 * 10000 / 100;
        }
        else
        {
            return 0;
        }
    }
    public void GetAllInsurances(int[] salaries)
    {
        int allInsurance = 0;

        for (int i = 0; i < salaries.Length; i++)
        {
            allInsurance = allInsurance + GetInsurance(salaries[i]);
        }

        Console.WriteLine($"All insurance must be pay: {allInsurance}");
    }
}
