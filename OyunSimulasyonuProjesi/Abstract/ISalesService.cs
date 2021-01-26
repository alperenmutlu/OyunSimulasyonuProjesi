using OyunSimulasyonuProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Abstract
{
    public interface ISalesService
    {
        void Add(Sales sale);
        void Update(Sales sale);
        void Delete(Sales sale);
    }
}
