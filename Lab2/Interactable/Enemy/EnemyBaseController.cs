using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseController : Interactable
{
    protected string Name { get; set; }
    protected int Health { get; set; }
    protected int Damage { get; set; }

    public EnemyBaseController(string _name)
    {
        Name = _name;
    }

    protected virtual void Move() 
    { 
        //Move around his location
    }

    protected virtual void Flying()
    {
        //Flying around his location
    }

    public virtual void Attack()
    {
        //attack player within a range
    }

    protected virtual void Taunt() 
    { 
        //Boss taunts player before fight
    }
}
