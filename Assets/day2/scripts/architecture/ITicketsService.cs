using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITicketsService
{
    public List<string> GetTicketsNames();
    public List<Ticket> GetAllTickets();
    public List<Ticket> GetAllTicketsForChildren();

    public float GetProfitValue();
}
