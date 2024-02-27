namespace GestionAlquiler2.Domain.Usuario;

public interface IUsuarioRepository
{
    Task<UsuarioEntity> GetById(Guid id, CancellationToken cancellationToken = default);

    void Add(UsuarioEntity entity);
}
