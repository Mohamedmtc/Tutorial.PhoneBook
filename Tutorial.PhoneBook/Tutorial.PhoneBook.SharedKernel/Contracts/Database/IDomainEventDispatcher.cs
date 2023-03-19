using Tutorial.PhoneBook.SharedKernel.DataBase;

namespace Tutorial.PhoneBook.SharedKernel.Contracts.Database;

public interface IDomainEventDispatcher
{
    Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);
}
