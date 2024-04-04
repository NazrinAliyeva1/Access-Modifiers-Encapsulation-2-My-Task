using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hjsd.Methods
{
    internal class Derived : Employee
    {
        protected void GetPromotion(Employee employee)
        {
            // Burada terfi prosesləri həyata keçirilir 
            Console.WriteLine($"{employee.Name} işçisi yüksəldilir.");
        }
    }
}
