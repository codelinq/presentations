using System;
using SolidApp.Domain;
using SolidApp.Domain.Services;

namespace SolidApp.Tasks
{
    public class EmployeeBirthdayMailerTask
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly IEmailService _emailService;
        private readonly string _ceoEmail;

        public EmployeeBirthdayMailerTask(IEmployeeRepository employeeRepo, IEmailService emailService, string ceoEmail)
        {
            _employeeRepo = employeeRepo;
            _emailService = emailService;
            _ceoEmail = ceoEmail;
        }

        public void SendBirthdayGreetings(DateTime birthday)
        {
            var employees = _employeeRepo.EmployeesBornOn(birthday);

            foreach (var employee in employees)
            {
                _emailService.Send(_ceoEmail, employee.EmailAddress, string.Format("Dear {0},\n I wanted to take the time to wish you a Happy Birthday!\n Sincerely The CEO.", employee.Name));
            }
        }
    }
}
