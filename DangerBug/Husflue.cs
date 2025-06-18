namespace DangerBug;

public class Husflue :Bug
{
    public string Spre {get;set;}
    public Husflue() : base("Husflue", false, true, true, true)
    {
        Spre = "kan spre sykdommer";
    }
    public override string Fly()
    {
        return $"{Name} kan fly";
    }
    public override void VisInfo()
    {
        base.VisInfo();
        Console.WriteLine($"Spre: {Spre}");
    }
}