using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hjsd.Methods
{
    internal class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessfull { get; set; }
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public virtual void GetPromotion()
        {
            // GetPromotion  burada həyata keçirilir.

            Console.WriteLine("İscilerin yükseldilmesi prosesi.");
            Salary += 100;
           
        }

    }
}
