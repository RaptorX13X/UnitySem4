using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITicketsRepository
{
    public List<Ticket> GetAllTickets();
    
    public bool SaveDatabase();
}
