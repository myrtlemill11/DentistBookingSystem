using System;

public class Patient{
		string firstName;
		string lastName;
		bool isOngoing;
		List <string> allergies = new List<string>();
        List <string> medicalConditions = new List<string>();
		List <string> patientType = new List<string>() {"Child","Adult"};
		string extraInfo;
	//no args constructor for patient class
	public Patient(){
	}

    //args constructor for patient class 
    public Patient(string fname, string lname, bool status, List<string> allergies, List<string> medicalConditions,string type,string extra info){
		this.firstName = fname;
		this.lastName = lname;
		this.isOngoing = status;
		this.allergies = allergies;
		this.medicalConditions = medicalConditions;
		this.patientType = patientType[patientType.IndexOf(type)];
		this.extraInfo = extraInfo;
    }

    //setter methods for patients 
    private void setFirstName(string fname){
		this.firstName = fname;
    }
	private void setLastName(string lname){
		this.lastName = lname;
    }

	private void setOngoingStatus(bool status){
		this.isOngoing = status;
    }
	private void addAllergy(string allergy){
		this.allergies.Add(allergy);
    }
	private void addMedicalCondition(string condition){
		this.medicalConditions.Add(condition);
    }
    //getter methods for patients
	private string getFirstName(){
		return this.firstName;
    }
	private string getLastName(){
		return this.lastName;
    }
	private bool getOngoingStatus(){
		return this.isOngoing;
    }
	private List<string> getAllergies(){
		return this.allergies;
    }
	private List<string> getMedicalConditions(){
		return this.medicalConditions;
    }
	private string getPatientType(){
	return this.patientType[0];
	}
	private string getExtraInfo(){
	return this.extraInfo;
	}
}



