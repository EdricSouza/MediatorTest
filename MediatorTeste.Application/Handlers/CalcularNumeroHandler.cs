using MediatR;

namespace MediatorTeste.Application.Handlers;

public sealed class CalcularNumeroHandler : IRequestHandler<CalcularNumeroQuery, int>
{
    public Task<int> Handle(CalcularNumeroQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(request.numeroA + request.numeroB);
    }
}