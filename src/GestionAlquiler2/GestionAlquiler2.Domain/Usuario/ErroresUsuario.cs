using GestionAlquiler2.Domain.Abstracciones;
namespace GestionAlquiler2.Domain.Usuario;

public static class ErroresUsuario
{
    public static Error NotFound = new(
        "User.Found",
        "No existe el usuario buscado"
    );

}
