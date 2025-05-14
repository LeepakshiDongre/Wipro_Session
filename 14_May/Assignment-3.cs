using System;

abstract class TicketBooking
{
    public abstract void BookTicket(int seats);

    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking tickets");
    }
}
class BusBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine("Booking" + seats + "bus tickets");

    }
}
class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine("Booking" + seats + "flight tickets");

    }
}

class BookingProgram
{
    static void Main()
    {
        TicketBooking bus = new BusBooking();
        TicketBooking flight = new FlightBooking();

        bus.ShowBookingInfo();
        bus.BookTicket(3);

        flight.ShowBookingInfo();
        flight.BookTicket(2);
    }
}

