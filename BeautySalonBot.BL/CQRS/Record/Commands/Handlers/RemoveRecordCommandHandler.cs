using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands.Handlers
{
    internal class RemoveRecordCommandHandler : IRequestHandler<RemoveRecordCommand>
    {
        public Task Handle(RemoveRecordCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
