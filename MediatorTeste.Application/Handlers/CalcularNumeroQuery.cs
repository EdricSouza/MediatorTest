using MediatR;

namespace MediatorTeste.Application.Handlers;
public sealed record CalcularNumeroQuery(int numeroA, int numeroB) : IRequest<int> {};