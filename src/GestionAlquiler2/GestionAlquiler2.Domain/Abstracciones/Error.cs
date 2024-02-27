namespace GestionAlquiler2.Domain.Abstracciones;

public record Error (string Code, string Message)
{
    public static Error None = new("Error Generico", string.Empty);
    public static Error NullValue = new("Error.NullValue", "Error capturado por Nulo");
}
