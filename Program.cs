using hjsd.Methods;

namespace hjsd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çalışan oluştur
            Employee employee = new Employee
            {
                Name = "John Doe",
                IsSuccessfull = true,
                Salary = 11
            };

            employee.GetPromotion();
            double newSalary=employee.Salary;
            Console.WriteLine($"İşçinin yeni maaşı:{newSalary}");

            // Yönetici oluştur
            Manager manager = new Manager
            {
                Name = "Alice Smith",
                IsSuccessfull = true
                
            };

            // Asistan oluştur
            Assistant assistant = new Assistant
            {
                Name = "Bob Johnson",
                IsSuccessfull = true
                
            };


            // Asistan, çalışanın performansını değerlendirir ve gerektiğinde maaş artışını gerçekleştirir
            assistant.GetFeedback(employee);



           
        }
    }

   
}
