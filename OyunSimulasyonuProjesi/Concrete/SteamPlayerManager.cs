using OyunSimulasyonuProjesi.Abstract;
using OyunSimulasyonuProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Concrete
{
    public class SteamPlayerManager:BasePlayerManager
    {
        IPlayerCheckService _playerCheckService;

        public SteamPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Not a valid Player");
            }
           
        }

        
    }
}
