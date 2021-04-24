using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using NeroAndKahveDunyasiCustomerManagement.Abstract;
using NeroAndKahveDunyasiCustomerManagement.Entities;

namespace NeroAndKahveDunyasiCustomerManagement.Adoptors
{
    public class MernisServiceAdoptor:ICustomerCheckService
    {
        /// <summary>
        /// Mernis e ait servise bağlanılarak kullanılan gerçek kişi kontrolü yapan service.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client
                .TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
                    customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
