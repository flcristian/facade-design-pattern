using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_design_pattern.employee.logic
{
    public class PayCalculator : IPayCalculator
    {
        public int CalculatePay(int currentPay, ref int totalHours)
        {
            int pay = currentPay + totalHours * 10;
            Console.WriteLine($"Payment calculated! Employee must be payed ${pay}.");
            totalHours = 0;
            return pay;
        }
    }
}
