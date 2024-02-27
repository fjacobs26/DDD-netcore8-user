using GestionAlquiler2.Domain.Abstracciones;
namespace GestionAlquiler2.Domain.Usuario.Events;

public sealed record EventoUsuarioCreado(Email email): IDomainEvent;