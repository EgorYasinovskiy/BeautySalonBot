namespace BeautySalonBot.Model
{
    public class SpecialistCalendar : Calendar
    {

        public int WorkDaysSchedule { get; set; }
        public int RestDaysSchedule { get; set; }
        public TimeOnly WorkStart { get; set; }

        public SpecialistCalendar()
        {
        }

        public SpecialistCalendar(int workDaysSchedule, int restDaysSchedule, TimeOnly workStart, Guid id, string name, List<DateOnly> additionalHolidays, List<DayOfWeek> workDays, List<DayOfWeek> holidays) 
            : base(id, name, additionalHolidays, workDays, holidays)
        {
            WorkDaysSchedule = workDaysSchedule;
            RestDaysSchedule = restDaysSchedule;
            WorkStart = workStart;
        }
    }
}
