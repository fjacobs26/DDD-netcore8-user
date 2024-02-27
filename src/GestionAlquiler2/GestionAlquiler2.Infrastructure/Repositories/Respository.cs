using GestionAlquiler2.Domain.Abstracciones;
namespace GestionAlquiler2.Infrastructure.Repositories;

internal abstract class Respository<T> where T : Entity
{
    protected readonly ApplicationDbContext DbContext;
}
