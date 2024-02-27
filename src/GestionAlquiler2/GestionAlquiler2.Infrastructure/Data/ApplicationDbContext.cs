using GestionAlquiler2.Domain.Abstracciones;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlquiler2.Infrastructure.Data;

public sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    private readonly IPublisher _publisher;

    public ApplicationDbContext(DbContextOptions options, IPublisher publisher): base(options)
    {
        _publisher = publisher;
    }

    public override async Task<int> IUnitOfWork.SaveChangesAsync(CancellationToken cancellation)
    {
        try
        {
            var result = await base.SaveChangesAsync(cancellation);
            await PublishDomainEventAsync();
            return result;
        }
        catch(DbUpdateConcurrencyException ex)
        {
            throw new DbUpdateConcurrencyException("Error en insercion");
        }
        
    }
    private async Task PublishDomainEventAsync()
    {
        var domainEvents = ChangeTracker.Entries<Entity>().Select(e => e.Entity).SelectMany(entity =>
        {
            var de = entity.GetDomainEvents();
            /**/
            entity.CleanDomainEvents();
            return de;
        }).ToList();
        foreach(var domainEvent in domainEvents)
        {
            await _publisher.Publish(domainEvent);
        }
    }
}
