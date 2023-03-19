using Ardalis.Specification;
using Tutorial.PhoneBook.SharedKernel.Contracts.Database;

namespace Tutorial.PhoneBook.SharedKernel.Contracts.DataAccess;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
