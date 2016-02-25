using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MobilePost_Service.Models
{
    public class ParcelContext:DbContext

    {

        public ParcelContext():base("MobilePostService")
        {

        }
        public DbSet<Parcel> Parcels { set; get; }
    }
}