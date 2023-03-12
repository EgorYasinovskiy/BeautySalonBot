using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands
{
	public class CreateRecordCommand : IRequest<Guid>
	{
		public Guid SpecialistId { get; set; }
		public Guid ClientId { get; set; }
		public Guid ServiceId { get; set; }
		public DateTime ServiceTime { get; set; }
	}
}