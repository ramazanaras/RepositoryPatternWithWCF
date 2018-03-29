using KuzeyYeli.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    public class RepositoryBase<T>:IRepository<T> where T:class  // T bir classtır diyoruz.(references tiplidir diyoruz.)
    {
        //SINGLETON PATTERN (TEKIL NESNE KULLANIMI) Tek context üretme işlemi.Herkeste aynı context var.Tek context üzerinden işlemler yapılır.

        //propfull tab tab 'a bas(kısayol)
        private static KuzeyYeliContext _context;

        public static KuzeyYeliContext Context
        {
            get
            {
                if (_context == null)
                    _context = new KuzeyYeliContext();

                return _context;
            }
            set { _context = value; }
        }




        //NOT:Repository katmanına manage nugettan entityframeworkü yüklüyoruz  .(Context.Set<>() metodunun çıkması için)

        /*Hata
         Error	1	The type 'T' must be a reference type in order to use it as parameter 'TEntity' in the generic type or method 'System.Data.Entity.DbContext.Set<TEntity>()'	C:\Users\RAMAZAN\Desktop\KuzeyYeli\KuzeyYeli.Repository\RepositoryBase.cs	36	20	KuzeyYeli.Repository
bizden T 'nin references tipli olduğunu belirtmemizi istiyor.bu yüzden yukarıda bunu where T:class   diyerek belirtiyoruz.
         
         */


        public List<T> Listele()
        {
            return Context.Set<T>().ToList();//Set metodu hangi tip geliyorsa o tabloyu çekmek için kullanılıyor.
        }


        public bool Ekle(T entity)
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
                return false;

            }
            catch (Exception ex)
            {
             
                return false;
            }
        }



        public bool Guncelle(T entity)
        {
            try
            {
               
                Context.SaveChanges();//değişiklikleri kaydetmemiz yeterli
                return false;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Sil(T entity)
        {
            try
            {
                Context.Set<T>().Remove(entity);
                Context.SaveChanges();
                return false;

            }
            catch (Exception ex)
            {

                return false;
            }
        }



    }
}
