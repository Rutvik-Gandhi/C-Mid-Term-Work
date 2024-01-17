// Rutvik Gandhi
// Student Number: 8809972
// Section: 1/3
// Date: 21/10/2022
// Midterm


using System;

namespace Midterm
{
    class program
    {
        public static void Main(String[] args)
        {
            try
            {
                // Menu option where Client select

                int option = 0;

                List<appointment> appointments = new List<appointment>();

                // Car Services

                services serv1 = new services();
                serv1.servicename = "Oil change";
                serv1.price = 59.99;

                services serv2 = new services();
                serv2.servicename = "Tune-up";
                serv2.price = 69.99;

                services serv3 = new services();
                serv3.servicename = "Tire Rotation";
                serv3.price = 26.59;

                services serv4 = new services();
                serv4.servicename = "General Check up";
                serv4.price = 49.99;

                // 3 Given Appointment Data

                appointment appointment1 = new appointment();
                appointment1.FirstName = "Rutvik";
                appointment1.Lastname = "Gandhi";
                appointment1.Email = "Rgandhi9972@conestogac.on.ca";
                appointment1.CarModel = "Ford Mustang";
                appointment1.Services.Add(serv2);
                appointment1.availableSlot.slotId = 0;

                appointments.Add(appointment1);

                appointment appointment2 = new appointment();
                appointment2.FirstName = "Salim";
                appointment2.Lastname = "Sema";
                appointment2.Email = "Salimsema@gmail.com";
                appointment2.CarModel = "Toyota Cruz";
                appointment2.Services.Add(serv4);
                appointment2.availableSlot.slotId = 1;

                appointments.Add(appointment2);

                appointment appointment3 = new appointment();
                appointment3.FirstName = "Ricky";
                appointment3.Lastname = "Patel";
                appointment3.Email = "Rickypatel@gmail.com";
                appointment3.CarModel = "Nissan GTR";
                appointment3.Services.Add(serv1);
                appointment3.availableSlot.slotId = 2;

                appointments.Add(appointment3);

                // Main loop

                do
                {
                    // Ask to the Client that what they would you like to do

                    option = showMenu();

                    // list of all appointments

                    if (option == 1)
                    {
                        listappointments(appointments);
                    }
                    else if (option == 2)
                    {
                        Console.Clear();

                        appointment ap = new appointment();

                        Console.WriteLine("Add Appointment");
                        Console.WriteLine("-*-*-*-*-*-*-*-*-*");

                        Console.WriteLine("FirstName : ");
                        ap.FirstName = Console.ReadLine();
                        Console.WriteLine("LastName : ");
                        ap.Lastname = Console.ReadLine();
                        Console.WriteLine("Email : ");
                        ap.Email = Console.ReadLine();
                        Console.WriteLine("Car Model : ");
                        ap.CarModel = Console.ReadLine();

                        ap.Services = new List<services>();

                        int service = 0;

                        // Add Services to the appointment

                        do
                        {
                            service = showServices();

                            // check which service the client wants
                            // and add Service to the appointment

                            if (service == 1)
                            {
                                ap.Services.Add(serv1);
                            }
                            else if (service == 2)
                            {
                                ap.Services.Add(serv2);
                            }
                            else if (service == 3)
                            {
                                ap.Services.Add(serv3);
                            }
                            else if (service == 4)
                            {
                                ap.Services.Add(serv4);
                            }
                        } while (service != 5);

                        // count remaining appointment slots and provide to new clients and also mention when slots are full
                        if (appointments.Count < 8)
                        {
                            ap.availableSlot.slotId = appointments.Count;
                        }
                        else 
                        {
                            Console.WriteLine("All available slots are full");
                        }

                        // Add the Appointments to the list of the appointments

                        appointments.Add(ap);
                    }
                    // Reset

                    else if (option == 3)
                    {
                        appointments = new List<appointment>();
                    }
                    // Exits when the user press the Number 4
                } while (option != 4);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // List all Appointments in the appointment list

        public static void listappointments(List<appointment> appointments)
        {
            foreach (var ap in appointments)
            {
                Console.WriteLine("Appointment");
                Console.WriteLine("-*-*-*-*-*-*-");
                ap.Output();
            }
            Console.ReadLine();
        }
        public static int showServices()
        {

            // Clear the Console

            Console.Clear();

            Console.WriteLine("Services Offered");
            Console.WriteLine("-*-*-*-*-*-*-*-*-");

            Console.WriteLine("1: Oil Change");
            Console.WriteLine("2: Tune-up");
            Console.WriteLine("3: Tire Rotation");
            Console.WriteLine("4: General Check-Up");
            Console.WriteLine("5: Done");

            // Assume user enters the correct data

            return int.Parse(Console.ReadLine());
        }
        public static int showMenu()
        {
            // Clear the Console

            Console.Clear();

            Console.WriteLine("1: List of All Appointments");
            Console.WriteLine("2: Create an Appointment");
            Console.WriteLine("3: Reset Schedule");
            Console.WriteLine("4: Exit the Program");

            // Assume the user enters the correct data

            return int.Parse(Console.ReadLine());
        }
    }
}
