namespace MSschool.Application.Domain.Common;

public partial class Audit
{
    public Audit(Id id)
    {
        Id = id;
    }

    public Id Id { get; set; }
    public Availability? Availability { get; private set; }
    public CreatedDate? CreatedDate { get; private set; }
    public string? CreatedByUser { get; private set; }
    public LastModifiedDate? LastModifiedDate { get; private set; }
    public string? LastModifiedByUser { get; private set; }

    public void SetAvailability(Availability? availability)
    {
        Availability = availability;
    }

    public void SetCreatedDate(CreatedDate createdDate)
    {
        CreatedDate = createdDate;
    }

    public void SetCreatedByUser(string createdByUser)
    {
        CreatedByUser = createdByUser;
    }

    public void SetLastModifiedDate(LastModifiedDate modifiedDate)
    {
        LastModifiedDate = modifiedDate;
    }

    public void SetLastModifiedByUser(string lastModifiedByUser)
    {
        LastModifiedByUser = lastModifiedByUser;
    }
}
