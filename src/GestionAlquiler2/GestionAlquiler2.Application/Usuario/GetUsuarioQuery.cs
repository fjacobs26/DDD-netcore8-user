using GestionAlquiler2.Application.Abstracciones.Messaging;

namespace GestionAlquiler2.Application.Usuario;

public sealed record GetUsuarioQuery(Guid usuarioId): IQuery<UsuarioResponse>;
