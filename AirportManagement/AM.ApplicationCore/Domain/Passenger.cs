using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        private const string V = "msg";

        public int Id { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Le prénom doit comporter entre 3 et 25 caractères.")]
       // public string FirstName { get; set; }
       // public string LastName { get; set; }
        public FullName FullName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid Phone Number!")]
        public int TelNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public virtual IList<Flight> Flights { get; set; }

        public virtual IList<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return BirthDate + " " + EmailAddress + " " + TelNumber + " ";
        }
        //10-a-b-c
        //public bool CheckProfile(string fName, string lName)
        //{
        //    return fName == FirstName && lName == LastName;
        //}

        //public bool CheckProfile(string firstName, string lastName, string email)
        //{
        //    return FirstName == firstName && LastName == lastName && EmailAddress == email;
        //}

        //public bool CheckProfile(string firstName, string lastName, string email = null)
        //{
        //    if (email != null)
        //        return FirstName == firstName && LastName == lastName &&
        //        EmailAddress == email;
        //    else
        //        return FirstName == firstName && LastName == lastName;
        //}
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }
    }
}
