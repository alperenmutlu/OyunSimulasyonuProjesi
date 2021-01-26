using OyunSimulasyonuProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game  sale);
        void Delete(Game game);
    }
}
