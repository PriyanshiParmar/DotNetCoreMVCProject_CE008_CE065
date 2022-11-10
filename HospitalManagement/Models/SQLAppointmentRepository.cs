using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class SQLAppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext context;
        public SQLAppointmentRepository(AppDbContext context)
        {
            this.context = context;
        }

        Appointment IAppointmentRepository.AddAppointment(Appointment appointment)
        {
            context.Appointments.Add(appointment);
            context.SaveChanges();
            return appointment;
        }

        Appointment IAppointmentRepository.GetAppointment(int appointmentId)
        {
            Appointment appointment = context.Appointments.Find(appointmentId);
            return appointment;
        }

        IEnumerable<Appointment> IAppointmentRepository.GetAppointmentsOfDoctor(Doctor doctor)
        {
            IList<Appointment> appointments = context.Appointments.Where(a => a.DoctorId == doctor.Id).ToList();
            return appointments;
        }

        IEnumerable<Appointment> IAppointmentRepository.GetAppointmentsOfPatient(Patient patient)
        {
            IList<Appointment> appointments = context.Appointments.Where(a => a.PatientId == patient.Id).ToList();
            return appointments;
        }

        Appointment IAppointmentRepository.UpdateAppointment(Appointment appointmentUpdate)
        {
            var appointment = context.Appointments.Attach(appointmentUpdate);
            appointment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return appointmentUpdate;
        }
    }
}
