using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands
{
	internal class MoveRecordCommand : IRequest<bool>
	{
		public Guid RecordId { get; set; }
		public DateTime NewTime { get; set; }
	}
}
