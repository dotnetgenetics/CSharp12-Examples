namespace PrimaryConstructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            HospitalRecord recordOne = new HospitalRecord();
            recordOne.RecordID = 10001;
            recordOne.PatientName = "Greg Esguerra";
            recordOne.Age = 35;
            Console.WriteLine($"Record One: {recordOne.RecordID}, {recordOne.PatientName},{recordOne.Age}");

            HospitalRecord recordTwo = new HospitalRecord("Michelle Esguerra");
            recordTwo.RecordID = 10002;
            recordTwo.Age = 30;
            Console.WriteLine($"Record Two: {recordTwo.RecordID}, {recordTwo.PatientName},{recordTwo.Age}");

            HospitalRecord recordThree = new HospitalRecord(10004, "John Doe", 48);
            Console.WriteLine($"Record Three: {recordThree.RecordID}, {recordThree.PatientName},{recordThree.Age}");

            Console.ReadLine();
        }
    }
}
