﻿namespace MSschool.Application.Domain.Common
{
    public class Audit
    {
        public Guid Id { get; set; }
        public bool Availability { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
