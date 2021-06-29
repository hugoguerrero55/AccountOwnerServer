using System;

namespace Entities.DataTransferObjects
{
    public class AccountDto
    {
        public Guid IdAccount { get; set; }
        public DateTime DateCreated { get; set; }
        public string AccountType { get; set; }
    }
}
