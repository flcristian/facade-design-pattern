using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_design_pattern.employee.logic
{
    public class EmployeeSaver : IEmployeeSaver
    {
        public void Save(int pay, int totalHours)
        {
            StreamWriter sw = new StreamWriter("D:\\mycode\\csharp\\design-patterns\\facade-design-pattern\\facade-design-pattern\\resources\\employee.txt");
            sw.WriteLine($"{pay}/{totalHours}");
            sw.Close();
            Console.WriteLine("Employee saved!");
        }
    }
}
