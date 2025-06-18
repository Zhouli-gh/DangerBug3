namespace DangerBug;

public class Veps : Bug
{
    public string Plage{get;set;}
    public Veps() : base("Veps", true, true, true, true)
    {
        Plage = "giftig, kan gi alvorlig sykdom/død ved allergi";
    }

    public override void VisInfo()
    {
        base.VisInfo();
        Console.WriteLine($"Plage: {Plage}");
    }
    
}