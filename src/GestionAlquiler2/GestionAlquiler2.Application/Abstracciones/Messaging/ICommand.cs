using GestionAlquiler2.Domain.Abstracciones;
using MediatR;

namespace GestionAlquiler2.Application.Abstracciones.Messaging;

public interface ICommand: IRequest<Result>, IBaseCommand
{

}
public interface IBaseCommand {}