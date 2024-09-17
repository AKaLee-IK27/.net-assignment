namespace Practice1;

public class Sheep : Cattle
{
    public override int Milk()
    {
        return new Random().Next(5);
    }

    public override void Sound()
    {
        Console.Write("Baaaa");
    }
}
