using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Janitor";
        job1._company = "BYU-Idaho";
        job1._startYear = 2021;
        job1._endYear = 2023;

        job1.Display();
    }
}

class Job{

    public string _company;

    public string _title;
}

class Applicant {

    public string _firstname;

    public string _lastName;

    public string _phoneNumber;

    public int _orderOfApplication;

    public int _rank;


    public Resume _resume;

    public void Display() {

    }

}