using OyunSimulasyonuProjesi.Abstract;
using OyunSimulasyonuProjesi.Concrete;

namespace OyunSimulasyonuProjesi
{
    internal class PlayerManager : BasePlayerManager
    {
        private PlayerCheckManager playerCheckManager;

        public PlayerManager(PlayerCheckManager playerCheckManager)
        {
            this.playerCheckManager = playerCheckManager;
        }
    }
}