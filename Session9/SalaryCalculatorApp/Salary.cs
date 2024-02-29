namespace SalaryCalculatorApp;

public class Salary
{
    public void GetNetSalaries(int[] salaries)
    {
        Tax tax = new Tax();
        Insurance insurance = new Insurance();
        for (int i = 0; i < salaries.Length; i++)
        {
            int net = salaries[i] - tax.GetTax(salaries[i]) - insurance.GetInsurance(salaries[i]);
            Console.WriteLine($"Employee {i + 1} net salary is: {net}");
        }
    }    
    public void GetAvarageSalaries(int[] salaries)
    {
        Tax tax = new Tax();
        Insurance insurance = new Insurance();

        int sum = 0;

        for (int i = 0; i < salaries.Length; i++)
        {
            sum = sum + salaries[i] - tax.GetTax(salaries[i]) - insurance.GetInsurance(salaries[i]);
        }
        
        Console.WriteLine($"Avarage of salaries after reducing tax and insurance: {sum / salaries.Length}");
    }
    public void GetSumOfSalaries(int[] salaries)
    {
        Tax tax = new Tax();
        Insurance insurance = new Insurance();
        int sum = 0;

        for (int i = 0; i < salaries.Length; i++)
        {
            sum = sum + salaries[i] - tax.GetTax(salaries[i]) - insurance.GetInsurance(salaries[i]);
        }

        Console.WriteLine($"Sum of salaries after reducing tax and insurance: {sum}");
    }

}
