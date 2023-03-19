using System.Xml.Linq;
using Tutorial.PhoneBook.SharedKernel.Contracts.Database;
using Tutorial.PhoneBook.SharedKernel.DataBase;

namespace Tutorial.PhoneBook.Domain.ContributorAggregate;

public class Contributor : EntityBase, IAggregateRoot
{
    public string Name { get; private set; }

    public Contributor(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException(nameof(name));
        Name = name;
    }

    public void UpdateName(string newName)
    {
        if (string.IsNullOrEmpty(newName))
            throw new ArgumentNullException(nameof(newName));
        Name = newName;
    }
}
