using System;
using SolidApp.Domain;
using SolidApp.Domain.Services;
using SolidApp.Implementation;
using SolidApp.Infrastructure;
using SolidApp.Infrastructure.Data;
using SolidApp.Tasks;

namespace SolidApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Model1Container())
            {
                IDataContext dataContext = new EFDataContext(context);
                IEmployeeRepository employeeRepo = new EmployeeRepository(dataContext);
                IEmailService emailService = new EmailService();

                string ceoEmail = "ceo@thecompany.com";

                var task = new EmployeeBirthdayMailerTask(employeeRepo, emailService, ceoEmail);

                task.SendBirthdayGreetings(DateTime.Now.AddDays(1));
            }
        }
    }
}
