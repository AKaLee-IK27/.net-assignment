namespace Practice1;

public abstract class Cattle
{
    public abstract void Sound();

    public abstract int Milk();

    public int Breed()
    {
        return new Random().Next(10);
    }
}
