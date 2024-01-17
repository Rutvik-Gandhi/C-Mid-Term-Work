using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    // this is client class which will implement Iclient interface
    public class client : Iclient
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string CarModel { get; set; }
        public string AppointmentTime { get; set; }
        public string Service { get; set; }
    }
}
