using Ardalis.Specification;
using Tutorial.PhoneBook.SharedKernel.Contracts.Database;

namespace Tutorial.PhoneBook.SharedKernel.Contracts.DataAccess;

// from Ardalis.Specification
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
