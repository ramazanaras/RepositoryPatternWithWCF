using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KuzeyYeli.WCFService
{

    using Repository;
    using DTO;
    using Entity;
    using Extensions;

    //UrunRepository,KategoriRepository gibi classları tek başına üstlenen metot yaptık.aslında kodu dahada kısaltmak için yaptık.yoksa her bir Service classı içinde UrunRepository a=new UrunRepostiroy() gibi veya KategoriRepository b=new KategoriRepository() diye tanımlayacaktık
    public class ServiceBase<Rep, Ent, DTO> : IServiceBase<DTO> where Rep : IRepository<Ent> //Rep --> IRepository<Entity>  tipindedir dedik.
    {
        //========Singleton pattern
        private static Rep _repository;

        public static Rep Repository
        {
            get
            {
                if (_repository == null)
                    _repository = Activator.CreateInstance<Rep>();//new'leme yaptık.Tipi belli olmayan tipi new 'leme işi.

                return _repository;

            }
            set { _repository = value; }
        }
        //==========




        public List<DTO> Listele()
        {
            //Not:Repository.Listele gibi  metotların çıkması için yukarıda  where Rep:IRepository<Entity> bunu yazdık

            return Repository.Listele().Select(x=>x.MapTo<DTO>()).ToList(); //Entity listesini DTO listesine dönüştürdük.
        }

        public bool Ekle(DTO entity)
        {
            return Repository.Ekle(entity.MapTo<Ent>());  //DTO 'yu Entity nesnesine çevirip Ekle metoduna verdik.Çünkü Repository bizden Entity ister.Entity'den anlar :)
        }

        public bool Guncelle(DTO entity)
        {
            return Repository.Guncelle(entity.MapTo<Ent>());
        }

        public bool Sil(DTO entity)
        {
            return Repository.Sil(entity.MapTo<Ent>());
        }
    }
}