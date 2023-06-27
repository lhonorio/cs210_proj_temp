using System;

class Program
{
    static void Main(string[] args)
    {

        Reservation resv = new Reservation("John", 3, "room 203", "6/21/2023");

        resv.DisplayRSVP();

    }
}
