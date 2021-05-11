using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBaseController : Interactable
{
    protected string Name { get; set; }
    protected string Role { get; set; }
    protected int Health { get; set; }
    protected List<string> MessagesFree { get; set; }
    protected List<string> MessagesTied { get; set; }
    protected bool Tied { get; set; } = false;

    protected virtual void Buy()
    {
        //buying smth from player
    }

    protected virtual void Sell()
    {
        //selling smth to player
    }

    protected override void Move()
    {
        //moving around the location
    }

    protected virtual void Speak()
    {
        //speaks to player after release
    }
}
