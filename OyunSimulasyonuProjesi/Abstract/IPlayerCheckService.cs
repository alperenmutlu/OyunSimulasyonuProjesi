using OyunSimulasyonuProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
