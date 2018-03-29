using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


using KuzeyYeli.Extensions;
using KuzeyYeli.Entity.Models;
using KuzeyYeli.Repository;
using KuzeyYeli.DTO;//ekledik.
namespace KuzeyYeli.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UrunService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UrunService.svc or UrunService.svc.cs at the Solution Explorer and start debugging.
    public class UrunService : ServiceBase<UrunRepository,Urunler,UrunlerDTO>,IUrunService
    {

    //  ServiceBase metotları burda düşün.Listele,Ekle,Güncelle,Sil metotları falan 

       //Not:ServisBase i yazmadaki amaç burda sürekli Ekle Güncelle Sil metotları yazmaya gerek duymadan direk miras vererek işi halletmek
    }
}
