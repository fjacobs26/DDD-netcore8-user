using GestionAlquiler2.Domain.Abstracciones;
using GestionAlquiler2.Domain.Usuario.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlquiler2.Domain.Usuario;

public sealed class UsuarioEntity : Entity
{
    private UsuarioEntity(
        Guid id,
        Nombre nombre,
        Apellido apellido,
        Email email
    ): base(id)
    {
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
    }
    public Nombre Nombre { get; private set; }
    public Apellido Apellido { get; private set; }
    public Email Email { get; private set; }

    public static UsuarioEntity create(
        Nombre nombre,
        Apellido apellido,
        Email email
    )
    {
        var user = new UsuarioEntity(Guid.NewGuid(), nombre, apellido, email);
        user.RaiseDomainEvent(new EventoUsuarioCreado(email));
        return user;
    }
}
