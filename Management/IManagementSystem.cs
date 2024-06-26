﻿using CS162_Final_CarnivalManagement.Experiences;
using System.Collections.Generic;

namespace CS162_Final_CarnivalManagement.Management
{
    public interface IManagementSystem
    {
        decimal TicketCost {get; set;}
        int totalSoldTickets { get; }

        void saleTickets(int numberToSell); //Intended to update the total sold tickets.

        void displayTotalTickets(); //Intended to show a message box with the total number of tickets.
    
    }
}
