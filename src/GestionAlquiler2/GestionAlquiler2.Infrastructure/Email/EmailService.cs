using GestionAlquiler2.Application.Abstracciones.Email;

namespace GestionAlquiler2.Infrastructure.Email;

internal sealed class EmailService : IEmailService
{
    public Task SendAsyncEmail(Domain.Usuario.Email email, string subject, string body)
    {
        return Task.CompletedTask;
    }
}
