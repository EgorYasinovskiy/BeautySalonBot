using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands.Handlers
{
    public class CreateRecordCommandHandler : IRequestHandler<CreateRecordCommand, Guid>
    {
        public Task<Guid> Handle(CreateRecordCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}