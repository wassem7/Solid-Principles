class DependencyInversion
{

    static void main()
    {
        SalaryCalculator salarycalculator2022 = new SalaryCalculator();
        Employee E1 = new Employee(salarycalculator2022, "Kwame Darkwa",hours:3.12,rate:23.23);
        E1.GetSalary();

    }
}

class Employee
{
    private string _fullname;
    private double _hours;
    private double _rate;
    private readonly ISalaryCalculator _salarycalculator;


    public Employee(ISalaryCalculator salaryCalculator, string fullname,double hours,double rate)
    {
        this._salarycalculator = salaryCalculator;
        this._fullname = fullname;
        this._hours = hours;
        this._rate = rate;
    }



    public void GetSalary()
    {
        Console.WriteLine(_salarycalculator.CalculateSalary(this._hours, this._rate));
    }


}

interface ISalaryCalculator
{
    double CalculateSalary(double hours, double rate);
}

class SalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(double hours, double rate)
    {
        return hours * rate;
    }
}


