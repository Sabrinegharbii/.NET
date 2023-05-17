﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff: Passenger
    {
        public string Function { get; set; }
        public DateTime EmployementDate { get; set; }

        [DataType(DataType.Currency)]
        public float Salary { get; set; }

        public virtual IList<Ticket> Tickets { get; set; }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a staff member");
        }
    }
}
