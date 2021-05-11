using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstAidKit : itemBaseController
{
    public firstAidKit(string _name)
    {
        this.Description = "Heal player";
        this.Name = _name;
        this.Type = "Healer";
        this.Reusable = false;
    }

    public override void Consume()
    {
        //heals player and disappears from inventory
    }

    public override void Interact()
    {
        base.Pickup();
    }
}