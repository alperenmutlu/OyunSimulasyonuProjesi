using OyunSimulasyonuProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Entities
{
    public class Player:IEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay{ get; set; }

    }
}
