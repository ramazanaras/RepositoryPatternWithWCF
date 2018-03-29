using KuzeyYeli.DTO;
using KuzeyYeli.Entity.Models;
using KuzeyYeli.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KuzeyYeli.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KategoriService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KategoriService.svc or KategoriService.svc.cs at the Solution Explorer and start debugging.
    public class KategoriService :ServiceBase<KategoriRepository,Kategoriler,KategorilerDTO>, IKategoriService
    {
        //ServiceBase deki metotları burda düşün.




    }
}
