using BeautySalonBot.BL.DTO.Record;
using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Queries
{
    public class GetActualRecordsBySpecialistQuery : IRequest<ServiceRecordCollectionDTO>
	{
		public Guid SpecialistId { get; set; }
	}
}
