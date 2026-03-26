using System;

public class Booking
{
    private DateTime whenIsAppt;
    private Patient patient;
    private Dentist dentist;
    private string reasonForAppt;
    private int priorityLevel;

    public Booking()
    {
    }

    public DateTime getDate()
    {
        return whenIsAppt;
    }

    public string getReason()
    {
        return reasonForAppt;
    }

    public int getPriorityLevel()
    {
        return priorityLevel;
    }

    public Dentist getDentist()
    {
        return dentist;
    }

    public Patient getPatient()
    {
        return patient;
    }

    public void setDate(DateTime d)
    {
        whenIsAppt = d;
    }

    public void setReason(string r)
    {
        reasonForAppt = r;
    }

    public void setPriorityLevel(int p)
    {
        priorityLevel = p;
    }

    public void setDentist(Dentist d)
    {
        dentist = d;
    }

    public void setPatient(Patient p)
    {
        patient = p;
    }
}
