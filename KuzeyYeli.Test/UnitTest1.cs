using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KuzeyYeli.Test
{
    using DTO;
    using Entity;
    using Extensions;
    using KuzeyYeli.Entity.Models;

    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void MapToTest()
        {
            Urunler urn = new Urunler();
            urn.UrunID = 4;
            urn.UrunAdi = "Karpuz";
            urn.Fiyat = 12;
            urn.Stok = 985;
            urn.BirimdekiMiktar = "213213";


            UrunlerDTO dto = urn.MapTo<UrunlerDTO>(); //map ettik.Urunleri UrunlerDTO'ya dönüştürdük.




        }
    }
}
