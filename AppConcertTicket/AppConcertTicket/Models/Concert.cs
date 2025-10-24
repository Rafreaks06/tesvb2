using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConcertTicket.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string ConcertName { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public decimal TicketPrice { get; set; }
        public int TicketStock { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
