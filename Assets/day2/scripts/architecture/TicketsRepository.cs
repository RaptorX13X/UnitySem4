using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TicketsRepository : MonoBehaviour, ITicketsRepository
{
    public static ITicketsRepository Instance;
    private List<Ticket> _tickets;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        _tickets = new List<Ticket>();
        foreach (Ticket ticket in Resources.LoadAll<Ticket>("Tickets"))
        {
            _tickets.Add(Instantiate(ticket));
        }
    }

    public List<Ticket> GetAllTickets() => _tickets;

    public bool SaveDatabase() => true;
}
