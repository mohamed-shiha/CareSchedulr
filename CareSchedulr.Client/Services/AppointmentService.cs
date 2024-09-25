using CareSchedulr.Client.Models;

namespace CareSchedulr.Client.Services
{
    public class AppointmentService
    {
        private List<Appointment> _appointments = new List<Appointment>();
        private int _nextId = 1;

        public void AddAppointment(Appointment appointment)
        {
            appointment.Id = _nextId++;
            _appointments.Add(appointment);
        }

        public List<Appointment> GetAppointments()
        {
            return _appointments.OrderBy(a => a.AppointmentDate).ThenBy(a => a.AppointmentTime).ToList();
        }
    }
}
