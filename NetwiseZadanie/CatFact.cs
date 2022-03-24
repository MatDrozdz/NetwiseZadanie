


public class CatFact
{
    public string? Fact { get; set; }
    public int Length { get; set; }

    public override string ToString()
    {
        return $"Fact: {Fact} \nLength: {Length}";
    }
}
