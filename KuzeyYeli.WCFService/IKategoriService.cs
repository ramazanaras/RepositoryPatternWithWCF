using KuzeyYeli.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KuzeyYeli.WCFService
{
   
    [ServiceContract]
    public interface IKategoriService : IServiceBase<KategorilerDTO>  //implemente ediyoruz
    {
      
    }
}
