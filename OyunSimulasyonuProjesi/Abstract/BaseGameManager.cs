using OyunSimulasyonuProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Abstract
{
    public abstract class BaseGameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Güncellendi");
        }
    }
}
