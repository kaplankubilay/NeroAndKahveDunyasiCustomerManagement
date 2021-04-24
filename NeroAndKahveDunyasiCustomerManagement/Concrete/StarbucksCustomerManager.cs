using System;
using System.Collections.Generic;
using System.Text;
using NeroAndKahveDunyasiCustomerManagement.Abstract;
using NeroAndKahveDunyasiCustomerManagement.Entities;

namespace NeroAndKahveDunyasiCustomerManagement.Concrete
{
    /// <summary>
    /// "BaseCustomerManager" alarak Dolaylı olarak interface içerisindeki Save operasyonunuda almış oldu.
    /// </summary>
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }


        /// <summary>
        /// Save metodunu burada override edebiliriz bunun yanısıra mernis doğrulaması isteyen starbncks için bu noktada mernis doğrulaması da yapılabilir.
        /// </summary>
        /// <param name="customer"></param>
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person!");
            }
        }
    }
}
