using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinterest.Models
{
    public class Event : BaseEntity
    {
        public int EventId {get; set;}
        public Boolean Confirmed {get;set;}
        public int ListingId {get; set;}
        public Listing Listing {get;set;}
        public int BrokerId {get; set;}
        public Broker Broker {get; set;}
        public List<Area> AreaOfHouse {get; set;}

        public DateTime OpenHouseDateTime {get; set;}
        public virtual List<VendorToEvent> EventVendors {get;set;}
    }
}