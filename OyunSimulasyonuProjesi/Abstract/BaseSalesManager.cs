using OyunSimulasyonuProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Abstract
{
    public abstract class BaseSalesManager : ISalesService
    {
        public void Add(Sales sale)
        {
            Console.WriteLine(sale.GameName + " Oyunu Şimdi Satışta!");
        }

        public void Delete(Sales sale)
        {
            Console.WriteLine(sale.GameName + " Oyunu Satıştan Kaldırıldı");
        }

        public void Update(Sales sale)
        {
            Console.WriteLine(sale.GameName + " Oyunu satış güncelledi!");
        }
    }
}
