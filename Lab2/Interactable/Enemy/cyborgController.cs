using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyborgController : EnemyBaseController
{
    public cyborgController(string _name) : base(_name)
    {
        this.Name = _name;
        this.Damage = 3;
        this.Health = 100;
    }

    protected override void Move()
    {
        base.Move();
        //move around his location
    }

    public override void Interact()
    {
        base.Attack();
    }
}
