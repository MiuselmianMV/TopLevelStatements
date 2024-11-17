using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLevelStatements
{
    public class Employee
    {
        public string FullName { get; set; }
        public string BirthDate {  get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }

        


        public Employee(string fullName, string birthDate, string contactNumber, string email, string position, string description)
        {
            FullName = fullName;
            BirthDate = birthDate;
            ContactNumber = contactNumber;
            Email = email;
            Position = position;
            Description = description;
        }

        public void Show()
        {
            Console.WriteLine("FullName: {0}", FullName);
            Console.WriteLine("BirthDate: {0}", BirthDate);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Contact number: {0}", ContactNumber);
            Console.WriteLine("Position: {0}", Position);
            Console.WriteLine("Description: {0}", Description);

        }

    }
}
