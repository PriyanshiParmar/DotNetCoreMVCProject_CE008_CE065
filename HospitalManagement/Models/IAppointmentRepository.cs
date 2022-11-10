namespace HospitalManagementSystem.Models
{
    public interface IAppointmentRepository
    {
        //Methods to be used for Appointment model
        //1.    Get all appointments for given patient
        //2.    Get all appointmnets for given doctor
        //3.    Get all appointmnets for a specific day(date)
        //4.    Get detailed info of an appointment
        //5.    Add an appointment
        //6.    Update appointment 

        public IEnumerable<Appointment> GetAppointmentsOfPatient(Patient patient);
        public IEnumerable<Appointment> GetAppointmentsOfDoctor(Doctor doctor);
        public Appointment GetAppointment(int appointmentId);
        public Appointment AddAppointment(Appointment appointment);
        public Appointment UpdateAppointment(Appointment appointmentUpdate);
    }
}
