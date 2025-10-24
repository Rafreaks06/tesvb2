using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConcertTicket.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string BookingCode { get; set; }
        public DateTime BookingDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice{ get; set; }
        public int CustId { get; set; }
        public virtual Account Cust { get; set; }
        public int ConcertId { get; set; }
        public virtual Concert Concert { get; set; }
    }
}
