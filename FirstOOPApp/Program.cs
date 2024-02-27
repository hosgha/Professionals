using FirstOOPApp;

Car benz = new Car();
benz.Brand = "Benz";
benz.MaxSpeed = 300;
benz.Color = "Black";

Car bmw = new Car();
bmw.Brand = "Bmw";
bmw.MaxSpeed = 380;
bmw.Color = "White";

bmw.IncreaseSpeed();

Car volvo = new Car();
volvo.Brand = "Volvo";
volvo.MaxSpeed = 280;
volvo.Color = "Red";

volvo.IncreaseSpeed();
volvo.IncreaseSpeed();


Console.WriteLine($"Car brand is {benz.Brand}, Current Speed is {benz.Speed}");
Console.WriteLine($"Car brand is {bmw.Brand}, Current Speed is { bmw.Speed }");
Console.WriteLine($"Car brand is {volvo.Brand}, Current Speed is {volvo.Speed}");