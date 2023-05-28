using MSschool.Application.Domain.Helpers;

namespace MSschool.Application.Domain.Common
{
    public partial class Audit
    {
        public Audit(Id id, Id createdByIdUser)
        {
            Id = id;
            Availability = true;
            CreatedDate = new CreatedDate(DateTimeHelper.GetDateAndTime().DateTime);
            CreatedByIdUser = createdByIdUser;
        }

        public Id Id { get; private set; }
        public bool Availability { get; private set; }
        public CreatedDate? CreatedDate { get; private set; }
        public Id CreatedByIdUser { get; private set; }
        public LastModifiedDate? LastModifiedDate { get; private set; }
        public Id? LastModifiedByIdUser { get; private set; }
    }
}
