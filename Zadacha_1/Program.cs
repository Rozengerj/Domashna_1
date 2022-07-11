



int Budget = int.Parse(Console.ReadLine());
if (Budget<1 || Budget >8000)
{
    throw new ArgumentException("pod 8000 i nad 1");
}
string Sezon = Console.ReadLine();
if(Sezon != "Autumn"&&Sezon!= "Summer"&&Sezon!="Winter"&&Sezon!="Spring")
{
    throw new ArgumentException("Prolet, Lqto, Esen ili Zima");

}
int Ribari = int.Parse(Console.ReadLine());
if (Ribari < 4 || Ribari > 18)
{
    throw new ArgumentException("pod 18 i nad 4");
}
double Cena=0;
switch(Sezon){
    case "Summer":
        {
            Cena = 4200;
            break;
        }
    case "Winter":
        {
            Cena = 2600;
            break;
        }
    case "Autumn":
        {
            Cena = 4200;
            break;
        }
    case "Spring":
        {
            Cena = 3000;
            break;
        }
        
}

if (Ribari <7)
{
    Cena = Cena - Cena*0.10;
}
else if (Ribari>6&&Ribari < 13)
{
    Cena = Cena - Cena * 0.15;
}
else
{
    Cena = Cena - Cena * 0.25;
}
if (Ribari % 2 == 0)
{
    if (Sezon != "Autumn")
    {
        Cena = Cena - Cena * 0.05;
    }
}
Console.WriteLine(Cena);
if (Cena <= Budget)
{
    Console.WriteLine("Yes, you have " + (Budget - Cena) + " left!");
}
else
{
    Console.WriteLine("beden, ne ti sigat " + (Cena - Budget) + " leva!");
}
