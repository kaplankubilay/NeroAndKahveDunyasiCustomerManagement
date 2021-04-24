using System;
using System.Collections.Generic;
using System.Text;
using NeroAndKahveDunyasiCustomerManagement.Abstract;
using NeroAndKahveDunyasiCustomerManagement.Entities;

namespace NeroAndKahveDunyasiCustomerManagement.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
