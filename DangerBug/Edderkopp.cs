namespace DangerBug;

public class Edderkopp : Bug
{
    public string Plage {get;set;}
    public string Goodstuff {get;set;}
    public Edderkopp() : base("Edderkopp", true, true, true, false)
    {
       Plage = "kan bite mennesker"; 
       Goodstuff = "spiser fluer og midd";
    }
    public override void VisInfo()
    {
        base.VisInfo();
        Console.WriteLine($"Plage: {Plage}");
        Console.WriteLine($"Goodstuff: {Goodstuff}");
    }
}