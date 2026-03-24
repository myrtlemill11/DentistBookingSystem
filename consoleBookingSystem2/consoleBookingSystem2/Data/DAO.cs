using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleBookingSystem.Buisness;


namespace consoleBookingSystem.Data
{
    public interface DAO
    {
        List<Booking> viewAppointments();

        int InsertAppointment(Booking booking);
        int UpdateAppointment(Booking booking);
        int DeleteAppointment(int bookingId);

        int InsertPatient(Patient patient);
        int DeletePatient(int id);

        int assignPatient(Patient patient, Dentist dentist);


    }
}