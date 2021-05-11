using System.Collections.Generic;

public class villager : NPCBaseController
{
    private List<ItemBaseController> Items { get; set; }

    public villager(string _name) : base(_name)
    {
        this.Health = 100;
        this.MessagesFree = new List<string> { "Hello, dear hero", "What do you want from me?" };
        this.Name = _name;
        this.Role = "Trader";
        this.Tied = false;
    }

    protected override void Move()
    {
        //move around the village
    }

    public override void Trade()
    {
        base.Buy();
        base.Sell();
    }
}
