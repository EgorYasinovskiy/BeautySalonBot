using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands
{
	internal class RemoveRecordCommand : IRequest
	{
		public Guid RecordId { get; set; }
	}
}
