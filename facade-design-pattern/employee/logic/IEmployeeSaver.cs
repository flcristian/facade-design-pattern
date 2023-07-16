using facade_design_pattern.employee.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_design_pattern.employee.logic
{
    public interface IEmployeeSaver
    {
        void Save(int pay, int totalHours);
    }
}
