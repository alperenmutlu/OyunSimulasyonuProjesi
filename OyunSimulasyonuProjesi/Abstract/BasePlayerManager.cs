using OyunSimulasyonuProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Oyuncu Eklendi : " + player.FirstName);
        }

        public void Delete(Player player)
        {
            
            Console.WriteLine("Oyuncu Silindi : " + player.FirstName);
        }

        public void Update(Player player)
        {
            
            Console.WriteLine("Oyuncu Güncellendi : " + player.FirstName);
        }
    }
}
