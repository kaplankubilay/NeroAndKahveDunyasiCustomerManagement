using System;
using NeroAndKahveDunyasiCustomerManagement.Abstract;
using NeroAndKahveDunyasiCustomerManagement.Adoptors;
using NeroAndKahveDunyasiCustomerManagement.Concrete;
using NeroAndKahveDunyasiCustomerManagement.Entities;

namespace NeroAndKahveDunyasiCustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu kısım herhangi bir IOC conteiner ile 
            BaseCustomerManager customerManager= new StarbucksCustomerManager(new MernisServiceAdoptor());
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1985,1,6),FirstName = "Kubilay",LastName = "Kaplan",NationalityId = "123"});
            Console.ReadLine();
        }
    }
}
