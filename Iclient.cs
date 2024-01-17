using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    // this is the interface for the class client
    interface Iclient
    {
        string FirstName { get; set; }
        string Lastname { get; set; }
        string Email { get; set; }
        string CarModel { get; set; }
        string AppointmentTime { get; set; }
        string Service { get; set; }
    }
}
