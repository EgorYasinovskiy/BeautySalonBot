using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands
{
	public class CancelRecordCommand : IRequest<bool>
	{
		public Guid RecordId { get; set; }
	}
}
