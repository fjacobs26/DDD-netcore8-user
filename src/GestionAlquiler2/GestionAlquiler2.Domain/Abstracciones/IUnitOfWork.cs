using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlquiler2.Domain.Abstracciones;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellation = default);
}
