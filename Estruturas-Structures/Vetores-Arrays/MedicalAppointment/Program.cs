using System;

var medicalAppointment = new MedicalAppointment("John Smith", 14);




//simple appointment
medicalAppointment.Reschedule(new DateTime(2024, 4, 4));

//overwrite month and day
//medicalAppointment.OverwritheMonthAndDay(5, 1);

//add a given number of months and days
//medicalAppointment.MoveByMonthsAndDays(1, 2);

Console.ReadKey();

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
    }
}
class MedicalAppointment
{
    private string patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        this.patientName = patientName;
        _date = date;
    }
    
    public DateTime GetDate() => _date;

    //public MedicalAppointment(string patientName) : this (patientName, 7)
    //{
    //}

    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        this.patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void OverwritheMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
}
