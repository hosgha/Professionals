Console.Write("Please enter number of employee: ");
int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

int[] salaries = new int[numberOfEmployees];

for (int i = 0; i < salaries.Length; i++)
{
    Console.Write($"Please enter employee {i + 1} salary: ");
    salaries[i] = Convert.ToInt32(Console.ReadLine());
}

GetNetSalaries(salaries);
GetAvarageSalaries(salaries);
GetSumOfSalaries(salaries);
GetAllTaxes(salaries);
GetAllInsurances(salaries);

static void GetNetSalaries(int[] salaries)
{
    for (int i = 0; i < salaries.Length; i++)
    {
        int net = salaries[i] - GetTax(salaries[i]) - GetInsurance(salaries[i]);
        Console.WriteLine($"Employee {i + 1} net salary is: {net}");
    }
}
static int GetTax(int salary)
{
    if (salary < 10000)
    {
        return 5 * 10000 / 100;
    }
    else if (salary >= 10000 && salary < 20000)
    {
        return 10 * 10000 / 100;
    }
    else if (salary >= 20000)
    {
        return 25 * 10000 / 100;
    }
    else
    {
        return 0;
    }
}
static int GetInsurance(int salary)
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
static void GetAvarageSalaries(int[] salaries)
{
    int sum = 0;

    for (int i = 0; i < salaries.Length; i++)
    {
        sum = sum + salaries[i] - GetTax(salaries[i]) - GetInsurance(salaries[i]);
    }

    Console.WriteLine($"Avarage of salaries after reducing tax and insurance: {sum / salaries.Length}");
}
static void GetSumOfSalaries(int[] salaries)
{
    int sum = 0;

    for (int i = 0; i < salaries.Length; i++)
    {
        sum = sum + salaries[i] - GetTax(salaries[i]) - GetInsurance(salaries[i]);
    }

    Console.WriteLine($"Sum of salaries after reducing tax and insurance: {sum}");
}
static void GetAllTaxes(int[] salaries)
{
    int allTax = 0;

    for (int i = 0; i < salaries.Length; i++)
    {
        allTax = allTax + GetTax(salaries[i]);
    }

    Console.WriteLine($"All tax that must be pay: {allTax}");
}
static void GetAllInsurances(int[] salaries)
{
    int allInsurance = 0;

    for (int i = 0; i < salaries.Length; i++)
    {
        allInsurance = allInsurance + GetInsurance(salaries[i]);
    }

    Console.WriteLine($"All insurance must be pay: {allInsurance}");
}