namespace DangerBug;

public class Flått: Bug
{
    public string Plage { get; set; }
    public Flått() : base("Flått", true, true, true, false)
    {
        Plage = "kan gi alvorlig sykdom";
    }
    public override void VisInfo()
    {
        base.VisInfo();
        Console.WriteLine($"Plage: {Plage}");
    }
}