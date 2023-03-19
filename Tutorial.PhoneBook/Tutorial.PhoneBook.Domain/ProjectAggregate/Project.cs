
using Tutorial.PhoneBook.SharedKernel.Contracts.Database;
using Tutorial.PhoneBook.SharedKernel.DataBase;

namespace Tutorial.PhoneBook.Domain.ProjectAggregate;

public class Project : EntityBase, IAggregateRoot
{
    public string Name { get; private set; }

    private readonly List<ToDoItem> _items = new();
    public IEnumerable<ToDoItem> Items => _items.AsReadOnly();
    public ProjectStatus Status => _items.All(i => i.IsDone) ? ProjectStatus.Complete : ProjectStatus.InProgress;

    public int Priority { get; private set; }

    public Project(string name, int priority)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException(nameof(name));
        Name = name;

        Priority = priority;
    }

    public void AddItem(ToDoItem newItem)
    {

        if (newItem == null)
            throw new ArgumentNullException(nameof(newItem));
        _items.Add(newItem);
    }

    public void UpdateName(string newName)
    {
        if (string.IsNullOrEmpty(newName))
            throw new ArgumentNullException(nameof(newName));
        Name = newName;
    }
}
