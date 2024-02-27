using GestionAlquiler2.Domain.Usuario;

namespace GestionAlquiler2.Application.Usuario;

public sealed class UsuarioResponse
{
    public Guid Id { get; init; }
    public string Nombre { get; init; }
    public string Apellido { get; init; }
    public string Email {  get; init; }
}
