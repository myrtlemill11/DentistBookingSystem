namespace Dentalsystem;

public class Appointment
{
    public string PatientName;
    public string Date;
    public string Status;

    public Appointment(string patientName, string date)
        {
        PatientName = patientName;
        Date = date;
        Status = "Pending";
        }

}