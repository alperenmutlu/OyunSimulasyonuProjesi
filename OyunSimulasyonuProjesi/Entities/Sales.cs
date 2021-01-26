using OyunSimulasyonuProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Entities
{
    public class Sales:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
    }
}
