using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MobilePost_Service.Models
{
    public class Parcel
    { 
        [ScaffoldColumn(false)]
        public long Id{get;set;}
        public DateTime RegistationDate { get; set; }
        public string Name{get;set;}
        public string City{get;set;}
        public string Street{get;set;}
        public string PostalCode{get;set;}
        public string Email{get;set;}
    }
}