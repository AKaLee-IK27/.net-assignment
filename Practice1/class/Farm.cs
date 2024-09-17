namespace Practice1;

public class Farm
{
    public List<Cattle> Cattles { get; set; }

    public Farm(int cows, int sheeps, int goats)
    {
        Cattles = new List<Cattle>();
        for (int i = 0; i < cows; i++)
        {
            Cattles.Add(new Cow());
        }
        for (int i = 0; i < sheeps; i++)
        {
            Cattles.Add(new Sheep());
        }
        for (int i = 0; i < goats; i++)
        {
            Cattles.Add(new Goat());
        }
    }

    public void MakeNoise()
    {
        foreach (var cattle in Cattles)
        {
            cattle.Sound();
        }
        Console.WriteLine();
    }

    public void Info()
    {
        int TotalMilk = 0;
        int TotalCows = Cattles.Count(c => c is Cow);
        int TotalSheeps = Cattles.Count(s => s is Sheep);
        int TotalGoats = Cattles.Count(g => g is Goat);
        foreach (var cattle in Cattles)
        {
            int newCattle = cattle.Breed();
            if (cattle is Cow)
            {
                TotalCows += newCattle;
                TotalMilk += cattle.Milk();
            }
            if (cattle is Goat)
            {
                TotalGoats += newCattle;
                TotalMilk += cattle.Milk();
            }
            if (cattle is Sheep)
            {
                TotalSheeps += newCattle;
                TotalMilk += cattle.Milk();
            }
        }

        Console.WriteLine($"Number of cows: {TotalCows}");
        Console.WriteLine($"Number of sheeps: {TotalSheeps}");
        Console.WriteLine($"Number of goats: {TotalGoats}");
        Console.WriteLine($"Total milk produced: {TotalMilk}");
    }
}
