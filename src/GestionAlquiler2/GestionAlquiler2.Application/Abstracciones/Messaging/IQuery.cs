using GestionAlquiler2.Domain.Abstracciones;
using MediatR;
namespace GestionAlquiler2.Application.Abstracciones.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
