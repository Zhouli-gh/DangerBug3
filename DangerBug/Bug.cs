namespace DangerBug;

public class Bug
{
    public string Name { get; set; }
    public bool Bite { get; set; }
    public bool Bein { get; set; }
    public bool Bevege { get; set; }
    public bool KanFly {get; set;}
    

    public Bug(string name, bool bite, bool bein, bool bevege, bool kanFly)
    {
        Name = name;
        Bite = bite;
        Bein = bein;
        Bevege = bevege;
        KanFly = kanFly;
    }
    
    public virtual string Fly()
    {
        return $"{Name} kan fly";
    }

    public virtual void VisInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Biter: {Bite}");
        Console.WriteLine($"Har bein: {Bein}");
        Console.WriteLine($"Kan bevege seg: {Bevege}");
        Console.WriteLine($"Kan fly: {KanFly}");
        Console.WriteLine(Fly());
    }
    
}