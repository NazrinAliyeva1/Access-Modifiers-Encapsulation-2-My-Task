using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hjsd.Methods
{
    internal class Manager : Employee
    {
        // Köməkçidən işçinin maaşının artırılmasını xahiş edir
        public void RequestPromotionFromManager(Assistant assistant, Employee employee)
        {
            // Sorğunu köməkçiyə göndərir və cavabı alır
            bool isApproved = assistant.GetPromotionApprovalFromManager(this, employee);

            // Köməkçinin cavabına uyğun tədbir görülür
            if (isApproved)
            {
                Console.WriteLine($"{Name} meneceri {employee.Name} iscisi ücün yükselisi  tesdiqlyir.");
                employee.GetPromotion();
            }


        }

    }
}
