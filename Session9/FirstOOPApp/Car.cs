namespace FirstOOPApp;

public class Car
{    
    // Attribute => Fields and Properties
    public string Brand { get; set; }
    public string Color { get; set; }
    public int Weight { get; set; }
    public int MaxSpeed { get; set; }
    public int Speed { get; set; } = 0;


    // Behavior => Methods
    public void IncreaseSpeed() 
    {
        Speed = Speed + 5;
        Console.WriteLine($"Speed: {Speed}");
    }

    public void DecreaseSpeed()
    {
        Speed = Speed - 5;
        Console.WriteLine($"Speed: {Speed}");
    }
}
