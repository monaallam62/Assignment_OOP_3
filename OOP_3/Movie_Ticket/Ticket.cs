using System;
using OOP_3.Enumm;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Movie_Ticket
{
    #region Question 3 part 2
    //public struct SeatLocation
    //{
    //    public TypeOfTicket Row { get; set; }
    //    public int Number { get; set; }

    //    public SeatLocation(TypeOfTicket _row, int _number)
    //    {
    //        Row = _row;
    //        Number = _number;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{Row}-{Number}";
    //    }
    //}
    //public class Ticket
    //{
    //    public TypeOfTicket Type;
    //    public string MovieName { get; set; }
    //    private decimal price;
    //    public decimal Price
    //    {
    //        get { return price; }
    //        set
    //        {
    //            if (value > 0)
    //                price = value;
    //            else
    //                throw new ArgumentException("Price must be greater than 0");
    //        }
    //    }
    //    public int TicketId { get; }
    //    private static int counter = 0;

    //    public Ticket(string movieName, decimal price)
    //    {
    //        MovieName = movieName;
    //        Price = price;
    //        TicketId = counter++;
    //    }

    //    public decimal PriceAfterTax
    //    {
    //        get { return price * 1.14m; }
    //    }

    //    public override string ToString()
    //    {
    //        return $"Ticket #{TicketId} | {MovieName} | Price: {price} EGP |After Tax: {PriceAfterTax} EGP ";
    //    }

    //    public static int GetTotalTickets()
    //    {
    //        return counter;
    //    }

    //    public class StandardTicket : Ticket
    //    {
    //        public SeatLocation Seat { get; set; }
    //        public StandardTicket(string movieName, decimal price, SeatLocation seat) : base(movieName, price)
    //        {
    //            Seat = seat;
    //        }
    //        public override string ToString()
    //        {
    //            return base.ToString() + $"Seat: {Seat}";
    //        }
    //    }

    //    public class VIPTicket : Ticket
    //    {

    //        public bool LoungeAccess { get; set; }
    //        public decimal ServiceFee { get; } = 50m;

    //        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
    //        {
    //            LoungeAccess = loungeAccess;
    //        }
    //        public override string ToString()
    //        {
    //            return base.ToString() + $"| Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Free: {ServiceFee} EGP";
    //        }

    //    }

    //    public class IMAXTicket : Ticket
    //    {
    //        public bool Is3D { get; set; }
    //        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30 : price)
    //        {
    //            Is3D = is3D;
    //        }
    //        public override string ToString()
    //        {
    //            return base.ToString() + $"IMAX 3D: {(Is3D ? "Yes" : "No")}";
    //        }
    //    }
    //}

       #endregion   
    
}
