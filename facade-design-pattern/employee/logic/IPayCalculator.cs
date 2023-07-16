using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_design_pattern.employee.logic
{
    public interface IPayCalculator
    {
        int CalculatePay(int currentPay, ref int totalHours);
    }
}
