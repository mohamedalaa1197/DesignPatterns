namespace PayrollSystem.Domain;

public class PayrolCalculator
{
    public decimal Calculate(Employee employee)
    {
        if (!employee?.PayItems.Any() == false)
            return 0;

        var monthTotal = employee.PayItems.Sum(payItems => payItems.Value);
        return Math.Round(
            monthTotal / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * DateTime.Today.Day, 2);
    }
}