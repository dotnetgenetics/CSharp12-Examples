namespace PrimaryConstructors
{
    /// <summary>
    /// Primary constructor (int recordID, string patientName, int age)
    /// </summary>
    public class HospitalRecord(int recordID, string patientName, int age)
    {
        public int RecordID { get; set; } = recordID;
        public int Age { get; set; } = age;
        public string PatientName { get; set; } = patientName;

        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public HospitalRecord() : this(0, string.Empty, 0) { }

        public HospitalRecord(string patientName) : this(10001, patientName, 25)
        {
        }
    }
}
