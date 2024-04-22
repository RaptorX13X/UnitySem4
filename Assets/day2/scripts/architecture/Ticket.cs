using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tools/Ticket", fileName = "New Ticket")]
public class Ticket : ScriptableObject
{
    public string movieName;
    public float price;
    public int quantity;
    [Range(0f, 1f)]public float producerTax;
    public bool forChildren;
}
