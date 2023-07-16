using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_design_pattern.employee.model
{
    public interface IEmployeeData
    {
        void CalculatePay();

        void ReportHours();

        void Save();
    }
}
