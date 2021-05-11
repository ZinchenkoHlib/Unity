using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiliPepper : itemBaseController
{
    public chiliPepper(string _name)
    {
        this.Description = "Let your sword and instincts do the job!";
        this.Name = _name;
        this.Type = "Booster";
        this.Reusable = false;
    }

    public override void Consume()
    {
        //Power ups player's armor and damage and disappear from inventory
    }

    public override void Interact()
    {
        base.Pickup();
    }
}
