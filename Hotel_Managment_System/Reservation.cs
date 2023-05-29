//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Managment_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int ReservationID { get; set; }
        public Nullable<System.DateTime> CheckInDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> RoomID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
    }
}
