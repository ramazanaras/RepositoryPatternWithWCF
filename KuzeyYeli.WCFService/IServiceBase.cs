using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;//eklendi.
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.WCFService
{

    [ServiceContract] //dışarıya açılması için.
    public interface IServiceBase<DTO>  
    {
        [OperationContract]
        List<DTO> Listele();

        [OperationContract]
        bool Ekle(DTO entity);


        [OperationContract]
        bool Guncelle(DTO entity);


        [OperationContract]
        bool Sil(DTO entity);


    }
}


