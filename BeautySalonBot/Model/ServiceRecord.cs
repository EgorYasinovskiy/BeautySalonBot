namespace BeautySalonBot.Domain.Model
{
	public class ServiceRecord
	{
		public Guid Id { get; set; }
		public Guid SpecialistId { get; set; }
		public virtual Specialist Specialist { get; set; }
		public Guid ClientId { get; set; }
		public virtual Client Client { get; set; }
		public Guid ServiceId { get; set; }
		public virtual Service Service { get; set; }
		public DateTime RecordTime { get; set; }
		public bool Cancelled { get; set; }
	}
}
