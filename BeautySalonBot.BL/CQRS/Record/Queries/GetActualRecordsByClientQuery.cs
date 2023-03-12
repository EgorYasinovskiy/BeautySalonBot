using BeautySalonBot.BL.DTO.Record;
using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Queries
{
    public class GetActualRecordsByClientQuery : IRequest<ServiceRecordCollectionDTO>
	{
		public Guid ClientID { get; set; }
	}
}
