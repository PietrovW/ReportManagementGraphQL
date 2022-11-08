using System;
using System.ComponentModel.DataAnnotations;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace ReportManagementGraphQL.Data.Entity
{ 
    public class ReportItem
	{
        public Guid Id { get; init; }
        public string? Title { get; init; }
        public bool IsCompleted { get; init; }
        public User User { get; init; }
        public int UserId { get; init; }
        public DateTime CreatedOn { get; init; }
        public byte[] RowVersion { get; init; }
    }
}

