﻿using BeautySalonBot.BL.DTO.Record;
using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Queries
{
    public class GetAllActualRecordsQuery : IRequest<ServiceRecordCollectionDTO>
	{
	}
}
