public class Card
{
    public string Name { get; set; }
    public int Num { get; set; }

    public Card(string name, int num)
    {
        Name = name;
        Num = num;
    }

    public int SelectCard()
    {
        return Num;
    }
}
