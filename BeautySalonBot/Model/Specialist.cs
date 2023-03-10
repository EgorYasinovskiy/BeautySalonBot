using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonBot.Domain.Model
{
    public class Specialist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CalendarId { get; set; }
        public virtual SpecialistCalendar Calendar { get; set; }
        public Guid SalonId { get; set; }
        public virtual Salon Salon { get; set; }

        public Specialist() { }

        public Specialist(Guid id, string name, Guid calendarId, SpecialistCalendar calendar, Guid salonId, Salon salon)
        {
            Id = id;
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
            CalendarId = calendarId;
            Calendar = calendar ?? throw new ArgumentNullException(nameof(calendar));
            SalonId = salonId;
            Salon = salon ?? throw new ArgumentNullException(nameof(salon));
        }
    }
}
