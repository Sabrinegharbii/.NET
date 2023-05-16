﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Capacity { get; set; }
        public PlaneType PlaneType{ get; set; }

        public virtual IList<Flight> Flights { get; set; }


        //Constructeur
        //public Plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    PlaneType = pt;
        //    Capacity = capacity;
        //    ManufactureDate = date;
        //}
    }
}
