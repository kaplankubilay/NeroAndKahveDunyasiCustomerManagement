using System;
using NeroAndKahveDunyasiCustomerManagement.Abstract;

namespace NeroAndKahveDunyasiCustomerManagement.Entities
{
    public class Customer:IEntity
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}