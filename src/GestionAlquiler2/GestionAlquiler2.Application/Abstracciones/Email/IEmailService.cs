
namespace GestionAlquiler2.Application.Abstracciones.Email;

public interface IEmailService
{
    Task SendAsyncEmail(Domain.Usuario.Email email,string subject, string body);
}
