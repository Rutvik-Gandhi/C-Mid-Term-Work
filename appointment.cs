using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class appointment : client
    {
        public appointment()
        {
            Services = new List<services>();
            availableSlot = new slot();
        }
        public List<services> Services { get; set; }
        public slot availableSlot { get; set; }

        // Display the Appointment Data

        public void Output()
        {
            double subtotal = 0.0;

            Console.WriteLine(this.FirstName + " " + this.Lastname + " " + this.Email);

            // The Service's Client want

            foreach(var serv in Services)
            {
                Console.WriteLine(serv.servicename + " " + serv.price);

                subtotal += serv.price;
            }

            // showing avaiaableslots and also mention slots are book details
            if (this.availableSlot.slotId == 0)
                Console.WriteLine("Your slot is 8 AM to 9 AM");
            else if (this.availableSlot.slotId == 1)
                Console.WriteLine("Your slot is 9 AM to 10 AM");
            else if (this.availableSlot.slotId == 2)
                Console.WriteLine("Your slot is 10 AM to 11 AM");
            else if (this.availableSlot.slotId == 3)
                Console.WriteLine("Your slot is 11 AM to 12 PM");
            else if (this.availableSlot.slotId == 4)
                Console.WriteLine("Your slot is 12 PM to 1 PM");
            else if (this.availableSlot.slotId == 5)
                Console.WriteLine("Your slot is 1 PM to 2 PM");
            else if (this.availableSlot.slotId == 6)
                Console.WriteLine("Your slot is 2 PM to 3 PM");
            else if (this.availableSlot.slotId == 7)
                Console.WriteLine("Your slot is 3 PM to 4 PM");
            else
                Console.WriteLine("All slots are booked. Please try booking an appointment tomorrow.");
            
            // generate subtotal and Total for client

            Console.WriteLine("sub Total: " + subtotal);

            Console.WriteLine("Total: " + Convert.ToDouble(subtotal + (subtotal * 0.13)));

        }
    }
}
