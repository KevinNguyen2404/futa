//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusTicketManagementApplication.src.dbConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_AVAILABLETRIP
    {
        public string Trip_ID { get; set; }
        public string Registration_number_of_bus { get; set; }
        public string Start_point { get; set; }
        public string End_point { get; set; }
        public System.DateTime Departure_time { get; set; }
        public int Duration { get; set; }
        public Nullable<byte> Remain_seat { get; set; }
        public string Status { get; set; }
    }
}
