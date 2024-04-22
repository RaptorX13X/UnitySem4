using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    private ITicketsService _ticketsService;

    private void Start()
    {
        // !!!!!!!!!!!!!!!!!!!!!! simulation of dependency injection
        _ticketsService = FindObjectOfType<TicketsService>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // foreach (Ticket ticket in _ticketsService.GetAllTickets())
            // {
            //     Debug.Log($"Name : {ticket.movieName} \n Price : {ticket.price} \n Amount {ticket.quantity}"  );
            // }
            Debug.Log($"Profit : {_ticketsService.GetProfitValue()}");
        }
    }
}
