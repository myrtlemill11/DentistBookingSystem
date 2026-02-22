namespace Dentalsystem;
using System.Collections.Generic;
class Program
{
    static List<Dentist> dentists = new List<Dentist>()
    {
        new Dentist("dent1", "1234", "Dr Smith"),
        new Dentist("dent2", "pass", "Dr Brown")
    };

    static List<Appointment> appointments = new List<Appointment>()
    {
        new Appointment("John Doe", "20 Feb"),
        new Appointment("Sarah Ali", "21 Feb")
    };

    static void Main(string[] args)
    {

        Login();

    }
    static void Login()
    {
        Console.WriteLine("=== Dentist Login ===");

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        foreach (Dentist d in dentists)
        {
            if (d.Username == username && d.Password == password)
            {
                Console.WriteLine("Login successful!\n");
                Dashboard(d);
                return;
            }
        }

        Console.WriteLine("Login failed.\n");
        Login();
    }
    static void Dashboard(Dentist dentist)
    {
        while (true)
        {
            Console.WriteLine("=== Dentist Dashboard ===");
            Console.WriteLine("Welcome " + dentist.Name);
            Console.WriteLine("1. View Appointments");
            Console.WriteLine("2. Confirm Appointment");
            Console.WriteLine("3. Logout");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ViewAppointments();
            }
            else if (choice == "2")
            {
                ConfirmAppointment();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Logging out...\n");
                Login();
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice\n");
            }
        }
    }
    static void ViewAppointments()
    {
        Console.WriteLine("\nAppointments:");

        for (int i = 0; i < appointments.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " +
                              appointments[i].PatientName +
                              " | " +
                              appointments[i].Date +
                              " | " +
                              appointments[i].Status);
        }

        Console.WriteLine();
    }
    static void ConfirmAppointment()
    {
        ViewAppointments();

        Console.Write("Enter appointment number: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index >= 0 && index < appointments.Count)
        {
            appointments[index].Status = "Confirmed";
            Console.WriteLine("Appointment confirmed!\n");
        }
        else
        {
            Console.WriteLine("Invalid number.\n");
        }
    }

}