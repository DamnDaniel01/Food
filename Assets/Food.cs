using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Consumable
{
    public float saturation;

    public bool isYummy;

    public override string UseText()
    {
        return "You ate " + displayName + ". There is now " + (maxUses - Uses) + " uses left";
    }

    public override string ToString()
    {
        return "This is a " + displayName + " and it costs " + GetPricePerWeight() + " kr " + "per " + "kg. " + " it gives the saturation " + saturation + YummyToString();
    }

    public string YummyToString()
    {
       
    }
}
