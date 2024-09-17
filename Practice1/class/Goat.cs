namespace Practice1;

public class Goat : Cattle
{
    public override int Milk()
    {
        return new Random().Next(10);
    }

    public override void Sound()
    {
        Console.Write("Beeee");
    }
}
