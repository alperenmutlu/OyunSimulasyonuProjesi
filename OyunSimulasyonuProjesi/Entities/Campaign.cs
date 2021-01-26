using OyunSimulasyonuProjesi.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSimulasyonuProjesi.Entities
{
    public class Campaign:IEntity
    {
        public string CampaignName { get; set; }
        public double Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
