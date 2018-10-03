using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{
    public float Uses;

    public float maxUses;

    public void OnMouseUpAsButton()
    {
        if (Uses != maxUses)
        {
            Use();
            print(UseText());
        }
        else
            print(NoUsesRemainingText());
    }

    public virtual void Use()
    {
        Uses++;
    }


    public virtual string UseText()
    {
        return "You ate " + displayName + ". There is now " + (maxUses - Uses) + " uses left";
    }

    public virtual string NoUsesRemainingText()
    {
        return "You have no uses remaining, please try another item.";
    }

    public override string ToString()
    {
        return "This is a " + displayName + " and it costs " + GetPricePerWeight() + " kr " + "per " + "kg. ";
    }

}
