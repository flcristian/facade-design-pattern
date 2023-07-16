using facade_design_pattern.employee.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_design_pattern.employee.model
{
    public class EmployeeData : IEmployeeData
    {
        private IPayCalculator _payCalculator;
        private IHourReporter _hourReporter;
        private IEmployeeSaver _employeeSaver;
        private int _pay;
        private int _totalHours;

        // Constructors

        public EmployeeData(string text)
        {
            _payCalculator = new PayCalculator();
            _hourReporter = new HourReporter();
            _employeeSaver = new EmployeeSaver();

            string[] data = text.Split("/");
            _pay = Int32.Parse(data[0]);
            _totalHours = Int32.Parse(data[1]);
        }

        // Methods

        public void CalculatePay()
        {
            _pay = _payCalculator.CalculatePay(_pay, ref _totalHours);
        }

        public void ReportHours()
        {
            Console.WriteLine("Enter the ammount of hours you want to report:");
            int hours = Int32.Parse(Console.ReadLine());
            _totalHours = _hourReporter.ReportHours(_totalHours, hours);
        }

        public void Save()
        {
            _employeeSaver.Save(_pay, _totalHours);
        }
    }
}
