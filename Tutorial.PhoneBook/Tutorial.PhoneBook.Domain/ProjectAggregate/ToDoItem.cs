
using Tutorial.PhoneBook.SharedKernel.DataBase;

namespace Tutorial.PhoneBook.Domain.ProjectAggregate;

public class ToDoItem : EntityBase
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int? ContributorId { get; private set; }
    public bool IsDone { get; private set; }

    public void MarkComplete()
    {
        if (!IsDone)
        {
            IsDone = true;
        }
    }

    public void AddContributor(int contributorId)
    {
        if (contributorId <= 0)
            throw new ArgumentNullException(nameof(contributorId));
        ContributorId = contributorId;
    }

    public void RemoveContributor()
    {
        ContributorId = null;
    }

    public override string ToString()
    {
        string status = IsDone ? "Done!" : "Not done.";
        return $"{Id}: Status: {status} - {Title} - {Description}";
    }
}
