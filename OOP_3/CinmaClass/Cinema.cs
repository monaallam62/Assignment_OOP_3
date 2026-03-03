using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_3.Movie_Ticket;

namespace OOP_3.CinmaClass
{
    #region Question 3 part 2
    //public sealed class  Projector
    //{
    //    public void Start()
    //    {
    //        Console.WriteLine("Projector Started.");
    //    }
    //    public void Stop()
    //    {
    //        Console.WriteLine("Projector Stopped.");
    //    }
    //}
    //public class Cinema
    //{
    //    public string CinemaName { get; set; }

    //    private Projector projector;
    //    private Ticket[] tickets = new Ticket[20];
    //    public Cinema(string name)
    //    {
    //        CinemaName = name;
    //        projector= new Projector();
    //    }
    //    public void AddTicket(Ticket t)
    //    {
    //        for (int i = 0; i < tickets.Length; i++)
    //        {
    //            if (tickets[i] == null)
    //            {
    //                tickets[i] = t;
    //                return;
    //            }
    //        }

    //        Console.WriteLine("Cinema is full!");
    //    }

    //    public void PrintStatistics()
    //    {
    //        Console.WriteLine("\n====================== Statistics =======================");

    //        int count = 0;

    //        foreach (var t in tickets)
    //        {
    //            if (t != null)
    //                count++;
    //        }

    //        Console.Write($"Total Tickets Created: {Ticket.GetTotalTickets()} \n");
    //        Console.WriteLine();

    //        for (int i = 1; i <= 2; i++)
    //        {
    //            Console.WriteLine($"Booking Ref {i}: BK-{i}");
    //        }

    //        Console.WriteLine();

    //        int numberOfPeople = 5;
    //        decimal ticketPrice = 100m;
    //        decimal total = numberOfPeople * ticketPrice;
    //        decimal discount = total * 0.10m;
    //        decimal finalAmount = total - discount;

    //        Console.WriteLine($"Group Discount ({numberOfPeople} x {ticketPrice} EGP): {finalAmount} EGP (10% off)");
    //    }
    //    public void PrintAllTickets()
    //    {
    //        foreach (var t in tickets)
    //        {
    //            if (t != null)
    //                Console.WriteLine(t);
    //        }
    //    }
    //    public void OpenCinema()
    //    {
    //        Console.WriteLine("===================== Cinema Opened =====================");
    //        projector.Start();
    //    }

    //    public void CloseCinema()
    //    {
    //        Console.WriteLine("\n===================== Cinema Closed =====================");
    //        projector.Stop();
    //    }
    //} 
    #endregion

}
