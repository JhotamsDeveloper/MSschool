namespace MSschool.Application.Domain.Common;

public partial class Audit
{
    public Audit(Id id, Id createdByIdUser)
    {
        Id = id;
        CreatedByIdUser = createdByIdUser;
        Availability = new Availability(true);
        CreatedDate = CreatedDate.CreationDate();
    }

    public Id? Id { get; private set; }
    public Availability? Availability { get; private set; }
    public CreatedDate? CreatedDate { get; private set; }
    public Id? CreatedByIdUser { get; private set; }
    public LastModifiedDate? LastModifiedDate { get; private set; }
    public Id? LastModifiedByIdUser { get; private set; }

    public void Update(Id id, Availability? availability, Id lastModifiedByIdUser)
    {
        Id = id;
        LastModifiedByIdUser = lastModifiedByIdUser;
        Availability = availability;
        LastModifiedDate = LastModifiedDate.CreationDate();
    }
}
