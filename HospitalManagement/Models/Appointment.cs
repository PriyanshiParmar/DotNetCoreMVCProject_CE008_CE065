using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public DateTime AppointmentTime { get; set; }
        public Patient? Patient { get; set; }
        public int PatientId { get; set; }
        public Doctor? Doctor { get; set; }
        public int DoctorId { get; set; }

        public Appointment() { }
        public Appointment(DateTime date, DateTime appointmentTime, Patient patient, Doctor doctor)
        {
            //this.appointmentId = appointmentId;
            Date = date;
            Status = "Confirmed";
            AppointmentTime = appointmentTime;
            Patient = patient;
            Doctor = doctor;
        }

        public Appointment(DateTime date, Patient patient, Doctor doctor)
        {
            Date = date;
            Patient = patient;
            Doctor= doctor;
            Status = "Pending";
        }
    }
}
