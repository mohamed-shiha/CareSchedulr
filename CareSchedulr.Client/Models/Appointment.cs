using System.ComponentModel.DataAnnotations;

namespace CareSchedulr.Client.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [Required]
        public string PPSNumber { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public DateTime? AppointmentDate { get; set; }
        [Required]
        public TimeSpan? AppointmentTime { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
