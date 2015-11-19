using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities.DTO
{
    public class SeatingSummary
    {
        public byte Table { get; set; } // the Taable.TableNumber
        public int Seating { get; set; } // the seating capacity - Tables.Capacity
        public bool Taken { get; set; } // calculated - true if occupied
        public int? BillID { get; set; } // Bills.BillID (nullable)
        public decimal? BillTotal { get; set; } // calcualted - total bill (nullable)
        public string Waiter { get; set; } // Waiters' name
        public string ReservationName { get; set; } // Reservasation.ContactName (nullable)
    }
}
