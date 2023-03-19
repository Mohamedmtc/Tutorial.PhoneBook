using MediatR;

namespace Tutorial.PhoneBook.SharedKernel.DataBase;

public abstract class DomainEventBase : INotification
{
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
