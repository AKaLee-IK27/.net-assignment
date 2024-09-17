namespace Practice1;

public class Cow : Cattle
{
    public override int Milk()
    {
        return new Random().Next(20);
    }

    public override void Sound()
    {
        Console.Write("Moooo");
    }
}
