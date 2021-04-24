using System;
using System.Collections.Generic;
using System.Text;
using NeroAndKahveDunyasiCustomerManagement.Entities;

namespace NeroAndKahveDunyasiCustomerManagement.Abstract
{
    /// <summary>
    /// Müşteri kaydetme operasyonu ortaktır bu nedenle abstract bir class içerisine tanımlanabilir.
    /// </summary>
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db :"+ customer.FirstName);
        }
    }
}
