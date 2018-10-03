using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string displayName;

    public float weight;

    public float cost;

    public float GetPricePerWeight()
    {
        return cost / weight;
    }

    public override string ToString()
    {
        return "This is a " + displayName + " and it costs " + GetPricePerWeight() + " kr " + "per " + "kg. ";
    }

    public virtual void OnMouseEnter()
    {
        Debug.Log(ToString());
    }

}
