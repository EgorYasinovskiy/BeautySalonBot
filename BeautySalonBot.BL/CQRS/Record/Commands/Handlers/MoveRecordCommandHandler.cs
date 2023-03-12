using MediatR;

namespace BeautySalonBot.BL.CQRS.Record.Commands.Handlers
{
    internal class MoveRecordCommandHandler : IRequestHandler<MoveRecordCommand, bool>
    {
        public Task<bool> Handle(MoveRecordCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
