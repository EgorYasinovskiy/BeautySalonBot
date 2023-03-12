using BeautySalonBot.Domain.Model;
using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Queries
{
	public class GetRecordQuery : IRequest<ServiceRecord>
	{
		public Guid RecordId { get; set; }
	}
}
