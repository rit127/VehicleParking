//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleParking.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pk_vehicle_out
    {
        public long Id { get; set; }
        public int user_id { get; set; }
        public string ticket_id { get; set; }
        public string plate_number_out { get; set; }
        public System.DateTime date_out { get; set; }
        public string status { get; set; }
    }
}
