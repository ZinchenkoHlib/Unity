using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiliPepper : itemBaseController
{
    public chiliPepper(string _name)
    {
        this.Description = "Let the fire spread from your mouth!";
        this.Name = _name;
        this.Type = "Booster";
        this.Reusable = false;
    }

    public override void Consume()
    {
        //Gives an opportunity to player to breathe fire and disappear from inventory
    }

    public override void Interact()
    {
        base.Pickup();
    }
}
