using facade_design_pattern.employee.model;

internal class Program
{ 
    private static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("D:\\mycode\\csharp\\design-patterns\\facade-design-pattern\\facade-design-pattern\\resources\\employee.txt");
        IEmployeeData employeeData = new EmployeeData(sr.ReadLine());
        sr.Close();
        employeeData.CalculatePay();
        employeeData.ReportHours();
        employeeData.Save();
    }
}