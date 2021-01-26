using OyunSimulasyonuProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public DateTime Release { get; set; }
        public string GameType { get; set; }
    }
}
