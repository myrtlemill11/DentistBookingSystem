using System;
using System.Collections.Generic;

namespace consoleBookingSystem2.Business
{
    public class BookingValidator
    {
        public bool IsValidId(int id)
        {
            return id > 0;
        }

        public bool IsValidDate(DateTime date)
        {
            return date >= DateTime.Today;
        }

        public bool IsValidDentist(int dentistId, List<int> dentistIds)
        {
            return dentistIds.Contains(dentistId);
        }

        public bool IsValidPatient(int patientId, List<int> patientIds)
        {
            return patientIds.Contains(patientId);
        }
    }
}
