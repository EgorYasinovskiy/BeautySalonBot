namespace BeautySalonBot.Domain.Model
{
    public class Calendar
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<DateOnly> AdditionalHolidays { get; set; }
        public List<DayOfWeek> WorkDays { get; set; }
        public List<DayOfWeek> Holidays { get; set; }
        public Calendar()
        {
        }

        public Calendar(Guid id, string name, List<DateOnly> additionalHolidays, List<DayOfWeek> workDays, List<DayOfWeek> holidays)
        {
            Id = id;
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
            AdditionalHolidays = additionalHolidays ?? throw new ArgumentNullException(nameof(additionalHolidays));
            WorkDays = workDays ?? throw new ArgumentNullException(nameof(workDays));
            Holidays = holidays ?? throw new ArgumentNullException(nameof(holidays));
        }
    }
}
