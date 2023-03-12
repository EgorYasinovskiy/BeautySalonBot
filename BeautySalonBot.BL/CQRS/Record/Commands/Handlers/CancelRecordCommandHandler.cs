using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands.Handlers
{
    public class CancelRecordCommandHanler : IRequestHandler<CancelRecordCommand, bool>
    {
        public Task<bool> Handle(CancelRecordCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
