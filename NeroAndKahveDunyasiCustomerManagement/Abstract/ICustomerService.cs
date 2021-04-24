using System;
using System.Collections.Generic;
using System.Text;
using NeroAndKahveDunyasiCustomerManagement.Entities;

namespace NeroAndKahveDunyasiCustomerManagement.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
