using SalaryCalculatorApp;

Salary salary = new Salary();
Tax tax = new Tax();
Insurance insurance = new Insurance();

Console.Write("Please enter number of employee: ");
int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

int[] salaries = new int[numberOfEmployees];

for (int i = 0; i<salaries.Length; i++)
{
    Console.Write($"Please enter employee {i + 1} salary: ");
    salaries[i] = Convert.ToInt32(Console.ReadLine());
}

salary.GetNetSalaries(salaries);
salary.GetAvarageSalaries(salaries);
salary.GetSumOfSalaries(salaries);
tax.GetAllTaxes(salaries);
insurance.GetAllInsurances(salaries);

Salary salaryObj = new Salary();
