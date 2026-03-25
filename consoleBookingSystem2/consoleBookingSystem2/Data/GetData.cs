using System;

public class GetData
{
	public GetData()
	{

	}
	public void RandomiseUserData()
	{
		Random rand = new Random();
		list[] firstNames = { "John", "Jane", "Michael", "Emily", "David" };
		list[] lastNames = { "Smith", "Johnson", "Brown", "Taylor", "Anderson" };
		list[] id = { "12345", "67890", "54321", "98765", "24680" };
		list[] password = { "password1", "password2", "password3", "password4", "password5" };
		list[] phoneNumber = { "555-1234", "555-5678", "555-9012", "555-3456", "555-7890" };
		list[] email = { "user@example.com", "user2@mail.com", "user3@test.com", "user4@demo.com", "user5@sample.com" };
		
	}

    public void RandomisePatientData()
	{
		Random rand = new Random();
		list[] allergies = { "Peanuts", "Shellfish", "Pollen", "Dust", "Latex" };
		list[] medicalConditions= { "Diabetes", "Hypertension", "Asthma", "Heart Disease", "Arthritis" };
		list[] typeOfPatient = { "New Patient", "Returning Patient", "Emergency Patient" };
		list[] DOB = { "01/01/1990", "15/05/1985", "30/09/2000", "20/12/1975", "10/07/1995" };
    }	


	public void RandomiseDentistData()
	{
		Random rand = new Random();
		list[] speciality = { "Orthodontics", "Endodontics", "Periodontics", "Prosthodontics", "Pediatric Dentistry" };

    }

	public void RandomiseAdminData()
	{
		
    }
}
