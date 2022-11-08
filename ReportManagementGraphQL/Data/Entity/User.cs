using System;
using System.ComponentModel.DataAnnotations;

namespace ReportManagementGraphQL.Data.Entity
{
	public class User
	{
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Email { get; set; }
        public ICollection<ReportItem> Reports { get; set; }
       // public byte[] RowVersion { get; set; }
    }
}

