using System;
using System.Collections.Generic;
using System.Text;
using NeroAndKahveDunyasiCustomerManagement.Entities;

namespace NeroAndKahveDunyasiCustomerManagement.Abstract
{
    /// <summary>
    /// Mernis kontrolünü bugün için Starbucks istiyor olabilir ancak yarın diğer kahve satıcıları da isteyebilir bu nedenle interface üzerinden implemente etmekte fayda var.
    /// </summary>
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
