using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hjsd.Methods
{
    internal class Assistant : Employee
    {
  
        // İşçinin yüksəliş tələbi ilə bağlı rəhbərdən razılıq alır
        public bool GetPromotionApprovalFromManager(Manager manager, Employee employee)
        {
            Console.WriteLine($"Assistent {manager.Name} menecerinden {employee.Name} iscisi ucun yukselisin tesdiqini teleb edir.");
            // Administratordan təsdiq alır
            // Burada sadə bir nümunə təsadüfi təsdiq yaradır
            Random rnd = new Random();
            bool isApproved = rnd.Next(2) == 0; // 0: Tesdiq, 1: Red
            return isApproved;
        }
        // İşçinin fəaliyyətini qiymətləndirir və lazım gəldikdə yüksəlişlər edir
        public void GetFeedback(Employee employee)
        {
            Manager manager = new Manager(); // Admin yaradın
            bool isApproved = GetPromotionApprovalFromManager(manager, employee);

            if (isApproved)
            {
                // Müvəffəqiyyətli təsdiq edildikdə, maaş artımı aparılır

                    Console.WriteLine($"{Name} tarafından {employee.Name} işçisi için yükseltme talebi alındı.");
                    employee.GetPromotion();
                    Console.WriteLine($"İşçinin güncellenmiş maaşı: {employee.Salary}");
            }
      
             else
            {
                Console.WriteLine($"{Salary} müveffeqiyyətli deyil, buna göre də təşviq yoxdur.");
            }
        }
    }
}
