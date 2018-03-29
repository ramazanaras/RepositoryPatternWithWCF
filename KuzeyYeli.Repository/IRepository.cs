using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    public interface IRepository<T>
    {
        List<T> Listele();
        bool Ekle(T entity);
        bool Guncelle(T entity);
        bool Sil(T entity);

    }
}
