namespace DangerBug;

public class Mygg : Bug
{
    public bool SugerBlod {get; set;}
    public string Plage {get; set;}
    
    public Mygg() : base("Mygg", true ,true, true, true)
    {
        SugerBlod = true;
        Plage = "Gir kløe";
    }
    public override string Fly()
    {
        return $"{Name} kan fly";
    }

    public override void VisInfo()
    {
        base.VisInfo();
        Console.WriteLine($"SugerBlod: {SugerBlod}");
        Console.WriteLine($"Plage: {Plage}");
        
    }
}