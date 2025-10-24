using AppConcertTicket.Models;// Use your Models namespace
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;

namespace ConcertTicketAdmin.Helpers // Use your project's namespace
{
    // This class defines HOW the ticket PDF is structured
    public class TicketDocument : IDocument
    {
        private readonly Ticket _ticket;

        public TicketDocument(Ticket ticket)
        {
            _ticket = ticket; // Receive the ticket data to be printed
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        // This method is where we design the PDF
        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50); // Set page margins
                    page.DefaultTextStyle(style => style.FontSize(12));

                    // 1. Header
                    page.Header()
                        .AlignCenter()
                        .Text("OFFICIAL CONCERT TICKET")
                        .SemiBold().FontSize(24).FontColor(Colors.Blue.Medium);

                    // 2. Content (Ticket Details)
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(col =>
                        {
                            col.Spacing(20); // Spacing between items

                            col.Item().Text($"Booking Code: {_ticket.BookingCode}")
                                .SemiBold().FontSize(16);

                            col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);

                            // Customer Details
                            col.Item().Text($"Customer Name: {_ticket.Cust.Name}");
                            col.Item().Text($"Email: {_ticket.Cust.Email}");

                            col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);

                            // Concert Details
                            col.Item().Text($"Concert: {_ticket.Concert.ConcertName}")
                                .Bold().FontSize(14);
                            col.Item().Text($"Artist: {_ticket.Concert.Artist}");
                            col.Item().Text($"Location: {_ticket.Concert.Location}");
                            col.Item().Text($"Date: {_ticket.Concert.Date.ToString("dd MMMM yyyy, HH:mm")}");

                            col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);

                            // Price Details
                            col.Item().AlignRight()
                                .Text($"Quantity: {_ticket.Quantity} x {_ticket.Concert.TicketPrice:C}");

                            col.Item().AlignRight()
                                .Text($"Total Price: {_ticket.TotalPrice:C}")
                                .Bold().FontSize(16);
                        });

                    // 3. Footer
                    page.Footer()
                        .AlignCenter()
                        .Text(text =>
                        {
                            text.Span("This ticket is valid. Printed on: ");
                            text.Span(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        });
                });
        }
    }
}