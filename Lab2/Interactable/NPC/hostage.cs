using System.Collections.Generic;

public class hostage : NPCBaseController
{
    public hostage(string _name) : base(_name)
    {
        this.Health = 100;
        this.MessagesTied = new List<string> { "Help me!", "I dont wanna die!" };
        this.MessagesFree = new List<string> { "Thank you!", "Thanks God!" };
        this.Name = _name;
        this.Role = "Hostage";
        protected bool Reusable { get; set; } = true;
}

    private void Scream()
    {
        //screams and asks for help
    }

    public override void Release()
    {
        base.Move();
        base.Speak();
    }
}
