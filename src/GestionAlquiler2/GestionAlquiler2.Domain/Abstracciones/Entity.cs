namespace GestionAlquiler2.Domain.Abstracciones;

public abstract class Entity
{
    protected Entity(Guid id)
    {
        Id = id;
    }
    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public Guid Id { get; set; }

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }
    public void CleanDomainEvents()
    {
        _domainEvents.Clear();
    }
    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}
