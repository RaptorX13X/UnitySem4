using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TicketsService : MonoBehaviour, ITicketsService
{
    private ITicketsRepository _repository;

    private void Start()
    {
        _repository = TicketsRepository.Instance;
    }

    public List<string> GetTicketsNames()
    {
        List<string> ticketNames = new();
        foreach (Ticket ticket in GetAllTickets())
        {
            ticketNames.Add(ticket.movieName);
        }

        return ticketNames;
    }

    public List<Ticket> GetAllTickets() => _repository.GetAllTickets();

    public List<Ticket> GetAllTicketsForChildren() => GetAllTickets().Where(ticket => ticket.forChildren).ToList();

    public float GetProfitValue()
    {
        float profit = 0;
        foreach (Ticket ticket in GetAllTickets())
        {
            profit += (ticket.price - ticket.price * ticket.producerTax) * ticket.quantity;
        }

        return profit;
    }
}
