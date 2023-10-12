using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listbox.Models
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }

        public Car()
        {
            Make = "NULL";
            Model = "NULL";
            ProductionDate = DateTime.Today;
        }

        public Car(string make, string model, DateTime productionDate)
        {
            Make = make;
            Model = model;
            ProductionDate = productionDate;
        }

        public override string ToString()
            => $"{Make} {Model} {ProductionDate.ToShortDateString()}";
    }
}
