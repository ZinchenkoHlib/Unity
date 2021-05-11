using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyborgBossController : EnemyBaseController
{
    public cyborgBossController(string _name) : base(_name)
    {
        this.Name = _name;
        this.Damage = 15;
        this.Health = 1500;
    }

    protected override void Move()
    {
        base.Move();
        //move close to the tower
        base.Flying();
        //fly around the player
    }

    public override void Interact()
    {
        base.Taunt();
        base.Attack();
    }
}