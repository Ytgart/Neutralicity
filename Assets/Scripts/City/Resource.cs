using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource
{
    public string Name { get; private set; }
    public int Amount { get; private set; }
    public int Growth { get; private set; }

    public Resource(string name, int amount, int growth)
    {
        Name = name;
        Amount = amount;
        Growth = growth;
    }

    public void AddGrowthValue()
    {
        Amount += Growth;
    }
}
